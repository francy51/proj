using UnityEngine;
using System.Collections;

namespace Project.PlayerStatSystem
{
	public class PSBasePlayerStat :  IPSBasePlayerStat
	{
		int _health;

		int _dodges;

		int _mana;

		int _strength;

		string _name;

		string _surname;

		int _age;

	//	int _level;



		#region IPSBasePlayerStat implementation
		public int Health {
			get {
				return _health;
			}
			set {
				_health = value;
			}
		}
		public int Dodges {
			get {
				return _dodges;
			}
			set {
				_dodges = value;
			}
		}
		public int Mana {
			get {
				return _mana;
			}
			set {
				_mana = value;
			}
		}
		public int Strength {
			get {
				return _strength;
			}
			set {
				_strength = value;
			}
		}
		public string Name {
			get {
				return _name;
			}
			set {
				_name = value;
			}
		}
		public string Surname {
			get {
				return _surname;
			}
			set {
				_surname = value;
			}
		}
		public int Age {
			get {
				return _age;
			}
			set {
				_age = value;
			}
		}
		#endregion
	}
}