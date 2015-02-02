using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pulsar4X.Entities
{
    public enum StarSystemEntityType
    {
        Body,
        Waypoint,
        JumpPoint,
        TaskGroup,
        Population,
        Missile,
        TypeCount
    }

    public struct SystemPosition
    {
        /// <summary>
        /// System currently in.
        /// </summary>
        public StarSystem System { get; set; }

        /// <summary>
        /// System X coordinante in AU
        /// </summary>
        public double X { get; set; }

        /// <summary>
        /// System Y coordinante in AU
        /// </summary>
        public double Y { get; set; }

        /// <summary>
        /// Initilized constructor.
        /// </summary>
        /// <param name="system">StarSystem value.</param>
        /// <param name="x">X value.</param>
        /// <param name="y">Y value.</param>
        public SystemPosition(StarSystem system, double x, double y) : this()
        {
            System = system;
            X = x;
            Y = y;
        }

        /// <summary>
        /// Static function to find the distance between two positions.
        /// </summary>
        /// <param name="posA"></param>
        /// <param name="posB"></param>
        /// <returns>distance between posA and posB</returns>
        public static float GetDistanceBetween(SystemPosition posA, SystemPosition posB)
        {
            if (posA.System != posB.System)
            {
                throw new InvalidOperationException("Cannont compare distances between positions in different systems.");
            }
            float distX = (float)(posA.X - posB.X);
            float distY = (float)(posA.Y - posB.Y);

            return (float)Math.Sqrt((distX * distX) + (distY * distY));
        }

        /// <summary>
        /// Instance function for those who don't like static functions.
        /// </summary>
        /// <param name="otherPos"></param>
        /// <returns></returns>
        public float GetDistanceTo(SystemPosition otherPos)
        {
            return GetDistanceBetween(this, otherPos);
        }

        /// <summary>
        /// Adds two SystemPositions together.
        /// </summary>
        /// <param name="posA"></param>
        /// <param name="posB"></param>
        /// <returns></returns>
        public static SystemPosition operator +(SystemPosition posA, SystemPosition posB)
        {
            if (posA.System != posB.System)
            {
                throw new InvalidOperationException("Cannot add positions in different systems.");
            }

            posA.X += posB.X;
            posA.Y += posB.Y;
            return posA;
        }
    }

    public class DistanceTable
    {
        /// <summary>
        /// Parent contact of this table.
        /// </summary>
        private StarSystemEntity m_parent;

        /// <summary>
        /// Lookup referances for this table.
        /// </summary>
        private Dictionary<StarSystemEntity, float> m_distances;
        private Dictionary<StarSystemEntity, int> m_lastUpdateSecond;
        private Dictionary<StarSystemEntity, int> m_lastUpdateYear;

        /// <summary>
        /// Calculates distance between the parent and the specified contact.
        /// distance parameter is garenteed to be populated.
        /// </summary>
        /// <param name="contact"></param>
        /// <param name="distance"></param>
        /// <returns>true if distance was already in table. False if it distance was calculated.</returns>
        public bool GetDistance(StarSystemEntity entity, out float distance)
        {
            if (m_distances.TryGetValue(entity, out distance))
            {
                if (m_lastUpdateSecond[entity] == GameState.Instance.CurrentSecond && m_lastUpdateYear[entity] == GameState.Instance.CurrentYear)
                {
                    return true;
                }
            }
            distance = m_parent.Position.GetDistanceTo(entity.Position);
            UpdateDistance(entity, distance);
            entity.DistTable.UpdateDistance(m_parent, distance);
            return false;
        }

        /// <summary>
        /// Public constructor.
        /// </summary>
        /// <param name="parent"></param>
        public DistanceTable(StarSystemEntity parent)
        {
            m_distances = new Dictionary<StarSystemEntity, float>();
            m_lastUpdateSecond = new Dictionary<StarSystemEntity, int>();
            m_lastUpdateYear = new Dictionary<StarSystemEntity, int>();
            m_parent = parent;
        }

        /// <summary>
        /// Updates/Adds the contact in the distance table with the correct distance/timestamp.
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="distance"></param>
        private void UpdateDistance(StarSystemEntity entity, float distance)
        {
            m_distances[entity] = distance;
            m_lastUpdateSecond[entity] = GameState.Instance.CurrentSecond;
            m_lastUpdateYear[entity] = GameState.Instance.CurrentYear;
        }

        /// <summary>
        /// Clears the distance table.
        /// </summary>
        public void Clear()
        {
            m_distances.Clear();
            m_lastUpdateSecond.Clear();
            m_lastUpdateYear.Clear();
        }

        /// <summary>
        /// Moves the specified contact from the distance table.
        /// </summary>
        /// <param name="entity"></param>
        public void Remove(StarSystemEntity entity)
        {
            m_distances.Remove(entity);
            m_lastUpdateSecond.Remove(entity);
            m_lastUpdateYear.Remove(entity);
        }
    }

    public abstract class StarSystemEntity : GameEntity
    {
        /// <summary>
        /// Current System and Position of the entity.
        /// </summary>
        public SystemPosition Position;

        /// <summary>
        /// where the entity was on the last tick.
        /// </summary>
        public SystemPosition LastPosition;

        /// <summary>
        /// distance between this entity and the other entities in the system in AU.
        /// </summary>
        public DistanceTable DistTable { get; set; }

        /// <summary>
        /// Type of entity that is represented here.
        /// </summary>
        public StarSystemEntityType SSEntity { get; set; }

        public StarSystemEntity()
            : base()
        {
            DistTable = new DistanceTable(this);
        }
    }
}
