using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RogueLikeSharp
{
    /// <summary>
    /// Represents the method that will handle the RogueLikeSharp.KilledEvent
    /// event raised when a character's health is depleted. 
    /// </summary>
    /// <param name="source">The source of the event.</param>
    /// <param name="e">A KilledEventArgs that contains the event data</param>
    public delegate void KilledEventHandler(object source, KilledEventArgs e);

    /// <summary>
    /// Provides data for the KilledEvent event
    /// </summary>
    public class KilledEventArgs : EventArgs
    {
        private string EventInfo;

        /// <summary>
        /// Initializes a new instance of the KilledEventArgs class
        /// </summary>
        /// <param name="text">The message to be displayed</param>
        public KilledEventArgs(string text)
        {
            EventInfo = text;
        }

        /// <summary>
        /// Returns event info.
        /// </summary>
        /// <returns>The Event Info.</returns>
        public string GetInfo()
        {
            return EventInfo;
        }
    }
}
