using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Pulsar4X.Entities;
using Pulsar4X.Entities.Components;
using log4net;
using System.ComponentModel;

/// <summary>
/// This is a duplicate of the Aurora armor system: Ships are basically spheres with a volume of HullSize.
/// Armor is coated around these spheres in ever increasing amounts per armor depth. likewise armor has to cover itself, as well as the ship sphere.
/// ShipOnDamage(or its equivilant) will touch on this, though I have yet to figure that out.
/// This is certainly up for updating/revision. - NathanH.
/// </summary>

namespace Pulsar4X.Entities.Components
{
    /// <summary>
    /// Ship Class armor definition. each copy of a ship will point to their shipclass, which points to this for important and hopefully static data.
    /// </summary>
	public class ArmorDef
	{
        /// <summary>
        /// Armor coverage of surface area of the ship per HullSpace(50.0 ton increment). This will vary with techlevel and can be updated. CalcArmor requires this.
        /// </summary>
        public ushort ArmorPerHS { get; set; }		

        /// <summary>
        /// Number of armor layers, CalcArmor needs to know this as well.
        /// </summary>
        public ushort Depth { get; set; }		

        /// <summary>
        /// Overall size of the armor, this is added to the ship proper. CalcArmor calculates this.
        /// </summary>
        public double Size { get; set; }
        
        /// <summary>
        /// Area coverage of the armor, Cost and column # both require this.
        /// </summary>
        public double Area { get; set; }

        /// <summary>
        /// Cost of the Armor. Ship costs, repair cost, and material resource costs will depend on this. It is naively equal to area in terms of per numbers, but resources required
        /// will vary with tech level. In Aurora costs shift from duranium to neutronium for example.
        /// </summary>
        public double Cost { get; set; }

        /// <summary>
        /// Column number counts how many columns of armor this ship can have, and hence how well protected it is from normal damage.
        /// This is determined by taking the overall strength requirement divided by the depth of the armor.
        /// </summary>
        public ushort CNum { get; set; }

        /// <summary>
        /// Just an empty constructor. I don't really need this, the main show is in CalcArmor.
        /// </summary>
	    public ArmorDef()
	    {
		    Size = 0.0;
		    Cost = 0.0;
		    Area = 0.0;
	    }

        /// <summary>
        /// CalcArmor takes the size of the craft, as well as armor tech level and requested depth, and calculates how big the armor must be to cover the ship.
        /// this is an iterative process, each layer of armor has to be placed on top of the old layer. Aurora updates this every time a change is made to the ship,
        /// and I have written this function to work in the same manner.
        /// </summary>
        /// <param name="armorPerHS"> armor Per Unit of Hull Space </param>
        /// <param name="sizeOfCraft"> In HullSpace increments </param>
        /// <param name="armorDepth"> Armor Layers </param>
	    public void CalcArmor(ushort armorPerHS, double sizeOfCraft, ushort armorDepth)
	    {
            /// <summary>
            /// Bounds checking as armorDepth is a short
            if (armorDepth < 1)
                armorDepth = 1;
            if (armorDepth > 65535)
                armorDepth = 65535;

		    ArmorPerHS = armorPerHS;
		    Depth = armorDepth;

            /// <summary>
            /// Armor calculation is as follows:
            /// First Volume of a sphere: V = 4/3 * pi * r^3 r^3 = 3V/4pi. Hullsize is the value for volume. radius is what needs to be determined
            /// From radius the armor area can be derived: A = 4 * pi * r^2
            /// Area / 4.0 is the required strength area that needs to be covered.
            /// </summary>

            bool done;
		    int loop;
		    double volume,radius3,radius2,radius,area=0.0, strengthReq=0.0,lastPro;
		    double areaF;
		    double temp1 = 1.0 / 3.0;	
		    double pi = 3.14159654;		

            /// <summary>
            /// Size must be initialized to 0.0 for this
            /// Armor is being totally recalculated every time this is run, the previous result is thrown out.
            /// </summary>
		    Size = 0.0; 

            /// <summary>
            /// For each layer of Depth.
            /// </summary>
		    for( loop = 0; loop < Depth; loop++) 
		    {
			    done = false;
			    lastPro = -1;
	    		    volume = Math.Ceiling( sizeOfCraft + Size );
		
                /// <summary>
                /// While Armor does not yet fully cover the ship and itself.
                /// </summary>
			    while( done == false ) 
			    {
				    radius3 = ( 3.0 * volume ) / ( 4.0 * pi ) ;
				    radius = Math.Pow( radius3, temp1 );
				    radius2 = Math.Pow( radius, 2.0 );
				    area = ( 4.0 * pi ) * radius2;

				    areaF = Math.Floor( area * 10.0 ) / 10.0;
				    area = ( Math.Round(area * 10.0) ) / 10.0;
				    area *= (double)( loop + 1 );
				    strengthReq = area / 4.0 ;

				    Size = Math.Ceiling( ( strengthReq / (double) ArmorPerHS ) * 10.0 ) / 10.0;
				    volume = Math.Ceiling(sizeOfCraft + Size);

				    if( Size == lastPro )
					    done = true;

				    lastPro = Size;
			    }
		    }

		    Area = ( area * Depth ) / 4.0;
		    Cost = Area;
		    CNum = (ushort)Math.Floor( strengthReq / (double)Depth );
	    }
        /// <summary>
        /// End of Function CalcArmor
        /// </summary>
    }
    /// <summary>
    /// End of Class ArmorDef
    /// </summary>
    
    /// <summary>
    /// Armor contains ship data itself. each ship will have its own copy of this.
    /// </summary>
    public class Armor
    {
        /// <summary>
        /// isDamaged controls whether or not armorColumns has been populated yet. 
        /// </summary>
        public bool isDamaged { get; set; }

        /// <summary>
        /// armorColumns contains the actual data that will need to be looked up
        /// </summary>
        public BindingList<ushort> armorColumns { get; set; }

        /// <summary>
        /// armorDamage is an easily stored listing of the damage that the ship has taken
        /// Column # is the key, and value is how much damage has been done to that column( DepthValue to Zero ).
        /// </summary>
        public Dictionary<ushort, ushort> armorDamage { get; set; }

        /// <summary>
        /// the actual ship armor constructor does nothing with armorColumns or armorDamage yet.
        /// </summary>
        public Armor()
        {
            isDamaged = false;
            armorColumns = new BindingList<ushort>();
            armorDamage = new Dictionary<ushort, ushort>();
        }

        /// <summary>
        /// SetDamage puts (CurrentDepth-DamageValue) damage into a specific column.
        /// </summary>
        /// <param name="ColumnCount">Total Columns, ship will have access to ship class which has armorDef.</param>
        /// <param name="Depth">Full and pristine armor Depth.</param>
        /// <param name="Column">The specific column to be damaged.</param>
        /// <param name="DamageValue">How much damage has been done.</param>
        public void SetDamage(ushort ColumnCount, ushort Depth, ushort Column, ushort DamageValue)
        {
            ushort newDepth;
            if (isDamaged == false)
            {
                for (ushort loop = 0; loop < ColumnCount; loop++)
                {
                    if (loop != Column)
                    {
                        armorColumns.Add(Depth);
                    }
                    else
                    {
                        /// <summary>
                        /// I have to type cast this subtraction of a short from a short into a short with a short.
                        /// </summary>
                        newDepth = (ushort)(Depth - DamageValue);
                        if (newDepth < 0)
                            newDepth = 0;

                        armorColumns.Add(newDepth);
                        armorDamage.Add(Column, newDepth);
                    }
                }
                /// <summary>
                /// end for ColumnCount
                /// </summary>
                isDamaged = true;
            }
            /// <summary>
            /// end if isDamaged = false
            /// </summary>
            else
            {
                newDepth = (ushort)(armorColumns[Column] - DamageValue);
                armorColumns[Column] = newDepth;

                if (armorDamage.ContainsKey(Column) == true)
                {
                    armorDamage[Column] = newDepth;
                }
                else
                {
                    armorDamage.Add(Column, newDepth);
                }
            }
            /// <summary>
            /// end else if isDamaged = true
            /// </summary>

        }

        /// <summary>
        /// RepairSingleBlock undoes one point of damage from the worst damaged column.
        /// If this totally fixes the column all damage to that column is repaired and it is removed from the list.
        /// If all damage overall is repaired isDamaged is set to false, and the armorColumn is depopulated.
        /// </summary>
        /// <param name="Depth">Armor Depth, this will be called from ship which will have access to ship class and therefore this number</param>
        public void RepairSingleBlock(ushort Depth)
        {
            ushort mostDamaged = armorDamage.Min().Key;

            ushort repair = (ushort)(armorDamage.Min().Value + 1);
            armorDamage[mostDamaged] = repair;
            armorColumns[mostDamaged] = repair;

            if (armorDamage[mostDamaged] == Depth)
            {
                armorDamage.Remove(mostDamaged);

                if (armorDamage.Count == 0)
                {
                    RepairAllArmor();
                }
            }
        }

        /// <summary>
        /// When the armor of a ship is repaired at a shipyard all damage is cleared.
        /// Also convienently called from RepairSingleBlock if a hangar manages to complete all repairs.
        /// </summary>
        public void RepairAllArmor()
        {
            isDamaged = false;
            armorDamage.Clear();
            armorColumns.Clear();
        }
    }
    /// <summary>
    /// End of Class Armor
    /// </summary>
}
/// <summary>
/// End of Namespace Pulsar4X.Entites.Components
/// </summary>