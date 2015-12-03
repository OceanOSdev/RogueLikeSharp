using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RogueLikeSharp
{
    /// <summary>
    /// An NPC
    /// </summary>
    public class Villager : Human
    {

        #region Constructor
        /// <summary>
        /// An NPC
        /// </summary>
        /// <param name="name">The name of the villager</param>
        public Villager(string name) : base(name)
        {
            PropertyChanged += Villager_PropertyChanged;
            OnKilled += Villager_OnKilled;
            
        }
        #endregion

        #region Events
        private event KilledEventHandler OnKilled;
        private void Villager_OnKilled(object source, KilledEventArgs e)
        {
            // TODO: Dispose of the body
            Console.WriteLine(e.GetInfo());
            //throw new NotImplementedException();
        }
        private void Villager_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            switch (e.PropertyName)
            {
                case "Health":
                    Console.WriteLine("Ouch");
                    if (Health <= 0)
                        IsDead = true;
                    break;
                case "IsDead":
                    if (IsDead)
                        OnKilled.Invoke(this, new KilledEventArgs($"{Name} died."));
                    break;
                default:
                    break;
            }
        }
        #endregion
    }
}