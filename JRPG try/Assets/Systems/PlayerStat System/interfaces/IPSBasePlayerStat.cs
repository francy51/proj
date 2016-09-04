using UnityEngine;
using System.Collections;

namespace Project.PlayerStatSystem {
	public interface IPSBasePlayerStat
	{

		int Health { get; set; }

		int Dodges { get; set; }

		int Mana { get; set; }

		int Strength { get; set; }

		string Name { get; set; }

		string Surname { get; set; }

		int Age { get; set; }

		//int level { get; set; }

 	}
}