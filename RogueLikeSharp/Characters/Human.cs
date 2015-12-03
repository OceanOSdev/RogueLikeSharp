using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace RogueLikeSharp
{
    /// <summary>
    /// There really is never a reason to instantiate a Human Object
    /// so it's recommended only treat this as a base class.
    /// The reason that Human isn't an abstract class though is because all of
    /// the classes that inherit from Human should be constructed in a similar way.
    /// 
    /// Uses INotifyPropertyChanged to allow binding between properties if so desired.
    /// </summary>
    public class Human : INotifyPropertyChanged
    {
        #region Members
        private int health;
        private string name;
        private string id;
        private Point location;
        private Guild faction;
        private bool isDead;
        #endregion

        #region Constructor
        /// <summary>
        /// Instantiates an instance of the Human.
        /// </summary>
        /// <param name="name"></param>
        public Human(string name)
        {
            this.name = name;
            health = 100;
            id = string.Format("000000");   // doesn't really "need" to be formatted, but meh
            location = new Point(0, 0);
            faction = Guild.Neutral;
            isDead = false;
        }
        #endregion

        #region Events
        /// <summary>
        /// Property Event Changed Handler
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Raises flag when any property gets changed
        /// </summary>
        /// <param name="propertyName">Not needed, but the name of the property being changed.  The method infers it.</param>
        private void NotifyPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            
        }

        #endregion

        #region Methods
        /// <summary>
        /// Moves the character one unit to the right.
        /// </summary>
        public void MoveRight() => this.Location = this.Location.X + 1 < Draw.Width ? new Point(this.Location.X + 1, this.Location.Y) : this.Location;

        /// <summary>
        /// Moves the character one unit to the left.
        /// </summary>
        public void MoveLeft() => this.Location = this.Location.X - 1 > -1 ? new Point(this.Location.X - 1, this.Location.Y) : this.Location;

        /// <summary>
        /// Moves the character one unit up.
        /// </summary>
        public void MoveUp() => this.Location = this.Location.Y - 1 > -1 ? new Point(this.Location.X, this.Location.Y - 1) : this.Location;

        /// <summary>
        /// Moves the character one unit down.
        /// </summary>
        public void MoveDown() => this.Location = this.Location.Y + 1 < Draw.Height? new Point(this.Location.X, this.Location.Y + 1) : this.Location;
        #endregion

        #region Properties
        /// <summary>
        /// Gets or Sets the health of the character.
        /// </summary>
        public virtual int Health
        {
            get
            {
                return health;
            }
            set
            {
                if (value != health)
                {
                    health = value;
                    NotifyPropertyChanged();
                }
            }
        }

        /// <summary>
        /// Gets or sets the name of the character.
        /// </summary>
        public virtual string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (value != name)
                {
                    name = value;
                    NotifyPropertyChanged();
                }
                
            }
        }

        /// <summary>
        /// ID property
        /// </summary>
        /// <remarks>Useless property</remarks>
        [Obsolete("No real purpose, just compare hashcodes instead", false)]
        public virtual string ID
        {
            get
            {
                return id;
            }
            set
            {
                if (value != id)
                {
                    id = value;
                    NotifyPropertyChanged();
                }
            }
        }

        /// <summary>
        /// Gets or Sets the location of the character.
        /// </summary>
        public virtual Point Location
        {
            get
            {
                return location;
            }
            set
            {
                if (value != location)
                {
                    location = value;
                    NotifyPropertyChanged();
                }
            }
        }

        /// <summary>
        /// Gets or Sets what guild/faction the character belongs to.
        /// </summary>
        public virtual Guild Faction
        {
            get
            {
                return faction;
            }
            set
            {
                if (value != faction)
                {
                    faction = value;
                    NotifyPropertyChanged();
                }
            }
        }

        /// <summary>
        /// A boolean representation of whether or not the character is dead.
        /// </summary>
        public bool IsDead
        {
            get
            {
                return isDead;
            }
            set
            {
                if (value != isDead)
                {
                    isDead = value;
                    NotifyPropertyChanged();
                }
            }
        }
        #endregion
    }
}