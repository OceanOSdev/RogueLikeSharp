using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RogueLikeSharp
{
    /// <summary>
    /// Enumaration of the possible guilds that a chacter can be in.
    /// </summary>
    public enum Guild
    {
        /// <summary>
        /// The mage faction, should give an increase in user's efficiency of magic.
        /// </summary>
        Mage = 1,
        /// <summary>
        /// The thieve faction, should give an increase in user's stealth.
        /// </summary>
        /// <remarks>Theif guild sounds stupid, plan on renaming it</remarks>
        Thief = 2,
        /// <summary>
        /// The warrior faction, should give an increase in user's weaponry efficiency.
        /// </summary>
        Warrior = 3,
        /// <summary>
        /// Technically a lack of a faction, should be used as the default
        /// </summary>
        Neutral = 4
    }
}