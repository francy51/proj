using UnityEngine;
using System.Collections;

namespace Project.ItemSystem {
	public partial class ISObjectEditor  {

		void BotBar(){
			GUILayout.BeginHorizontal ("Box", GUILayout.ExpandWidth (true));
            //GUILayout.Label ("TEST");
            if (EditingWeapons)
            {
                GUILayout.Label(WeaponDB.name);
                GUILayout.Label("# of objects in Database - " + WeaponDB.Count);    
            }
            if (About)
            {
                GUILayout.Label("General stats relavent t the database as a whole apear here");
            }
			GUILayout.EndHorizontal ();
		}
	}
}