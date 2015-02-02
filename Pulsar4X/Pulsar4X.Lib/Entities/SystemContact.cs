using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using Pulsar4X.Entities.Components;

/// <summary>
/// I am concerned that the distances here are going to get too massive without some bounds checking, that will have to be added in at some point.
/// </summary>

namespace Pulsar4X.Entities
{
    public class SystemContact : GameEntity
    {
        /// <summary>
        /// To which faction does this contact belong?
        /// </summary>
        public Faction faction { get; set; }


        /// <summary>
        /// Bascking entity of this contact.
        /// </summary>
        public StarSystemEntity Entity { get; set; }

        /// <summary>
        /// Creates a new system contact.
        /// </summary>
        /// <param name="Fact">Faction of contact.</param>
        /// <param name="entity">Backing entity of the contact.</param>
        public SystemContact(Faction Fact, StarSystemEntity entity)
        {
            faction = Fact;

            Entity = entity;
        }
    }
}
