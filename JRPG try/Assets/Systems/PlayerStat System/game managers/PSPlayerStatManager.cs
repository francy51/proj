using UnityEngine;
using System.Collections;
using UnityEngine.UI;

namespace Project.PlayerStatSystem.Managers
{
    public class PSPlayerStatManager : MonoBehaviour
	{
        PSBasePlayerStat baseStats;

        public PSPlayerStats playerStats;

		bool baseplayerstatsChosen;

        void Start() 
        {
            playerStats = GetComponent<PSPlayerStats>();
        }

		void OnGUI()
		{
			if (baseplayerstatsChosen == false) 
			{
                SurnameQuestion();
			}
		}

        void SurnameQuestion()
        {
            print(playerStats);
            GUI.Label(new Rect(0, 0, 10, 5), "What is your Surname?");
           // playerStats.Surname = GUI.TextField(new Rect(10, 10, 10, 5), playerStats.Surname);
           
        }
	}
}