using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RogueLikeSharp
{
    /// <summary>
    /// The Player is a Human that is controlled by the user.
    /// </summary>
    public sealed class Player : Human
    {
       
        #region Constructor
        /// <summary>
        /// Instantiates an instance of the player. (Only use once)
        /// </summary>
        /// <param name="name">The player name.</param>
        public Player(string name) : base(name)
        {
            PropertyChanged += Player_PropertyChanged;
            OnKilled += Player_OnKilled;
        }
        #endregion

        #region Events
        /// <summary>
        /// The event handler for the OnKilled event.
        /// </summary>
        public event KilledEventHandler OnKilled;

        /// <summary>
        /// What to do when each property changes.
        /// Health and IsDead are "pseudo-binded"
        /// </summary>
        /// <param name="sender">Sender.</param>
        /// <param name="e">The Event args.</param>
        private void Player_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            switch(e.PropertyName)
            {
                case "Health":
                    Console.WriteLine("Ouch");
                    if (Health <= 0)
                        IsDead = true;
                    break;
                case "IsDead":
                    if (IsDead)
                        OnKilled.Invoke(this, new KilledEventArgs("You died."));
                    break;
                case "Location":
                    //Draw.DisplayInformation(Location.ToString());
                    break;
                default:
                    break;
            }

            Draw.DisplayInformation("\t\t\t\n\t\t");
            Draw.DisplayPlayerInfo(this);
            
        }


        private void Player_OnKilled(object source, KilledEventArgs e)
        {
            // TODO: End Game
            Console.WriteLine(e.GetInfo());
            //throw new NotImplementedException();
        }
        #endregion

        #region Methods
        /// <summary>
        /// Remove health from player.
        /// </summary>
        /// <param name="damage">Health to remove.</param>
        public void InflictDamage(int damage)
        {
            Health -= damage;
        }

        /// <summary>
        /// Give health to player.
        /// </summary>
        /// <param name="healthGained">Health gained.</param>
        public void Heal(int healthGained)
        {
            Health += healthGained;
        }

        
        #endregion
    }
}