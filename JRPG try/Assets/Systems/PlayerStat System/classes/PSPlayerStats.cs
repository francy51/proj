using UnityEngine;
using System.Collections;
using System.Linq;
using System.Collections.Generic;
namespace Project.PlayerStatSystem
{
    public class PSPlayerStats : MonoBehaviour
	{
		int health;

		public int Health {
			get {
				return health;
			}
			set {
				health = value;
			}
		}

		int dodges;

		public int Dodges {
			get {
				return dodges;
			}
			set {
				dodges = value;
			}
		}

		int mana;

		public int Mana {
			get {
				return mana;
			}
			set {
				mana = value;
			}
		}

		int strength;

		public int Strength {
			get {
				return strength;
			}
			set {
				strength = value;
			}
		}

#pragma warning disable CS0108 // Member hides inherited member; missing new keyword
        string name;
#pragma warning restore CS0108 // Member hides inherited member; missing new keyword

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        string surname;

		public string Surname {
			get {
				return surname;
			}
			set {
				surname = value;
			}
		}

		int age;

		public int Age {
			get {
				return age;
			}
			set {
				age = value;
			}
		}



     
    }
}

