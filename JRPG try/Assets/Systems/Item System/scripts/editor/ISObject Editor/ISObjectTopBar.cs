using UnityEditor;
using UnityEngine;
using System.Collections;

namespace Project.ItemSystem
{
    public partial class ISObjectEditor
    {

        void TopBar()
        {

            GUILayout.BeginHorizontal("Box", GUILayout.ExpandWidth(true));
            WeaponTab();
            ArmorTab();
            GUILayout.Button("Potions");
            AboutTab();
            GUILayout.EndHorizontal();

        }

        void WeaponTab()
        {
            if (GUILayout.Button("Weapons"))
            {
                EditingWeapons = true;
                EditingArmor = false;
                About = false;
                showDetails = false;
            }

        }

        void ArmorTab()
        {
            if (GUILayout.Button("Armor"))
            {
                EditingWeapons = false;
                EditingArmor = true;
                About = false;
                showDetails = false;
            }
        }

        void AboutTab()
        {
            if (GUILayout.Button("About"))
            {
                EditingWeapons = false;
                EditingArmor = false;
                showDetails = false;
                About = true;
            } 
        }

    }
}