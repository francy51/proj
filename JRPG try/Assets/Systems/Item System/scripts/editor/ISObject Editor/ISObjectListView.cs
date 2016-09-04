using UnityEditor;
using UnityEngine;
using System.Collections;

namespace Project.ItemSystem
{
    public partial class ISObjectEditor
    {

        Vector2 _scrollPos = Vector2.zero;
        int _listViewWidth = 200;
        ScriptableObject Database;
        bool EditingWeapons;
        bool EditingArmor;
        bool About;

        void ListView()
        {

            _scrollPos = EditorGUILayout.BeginScrollView(_scrollPos, "Box", GUILayout.ExpandHeight(true), GUILayout.Width(_listViewWidth));
          //  GUILayout.Label("TEST");
            if (EditingWeapons)
            {
                if (WeaponDB.Count > 0)
                {
                    for (int i = 0; i < WeaponDB.Count; i++)
                    {
                        GUILayout.BeginHorizontal();
                        if (GUILayout.Button(WeaponDB.Get(i).ISName))
                        {
                            TempWeapon = WeaponDB.Get(i);
                            showDetails = true;
                        }
                        if (GUILayout.Button("X"))
                        {
                            WeaponDB.RemoveAt(i);
                        }
                        GUILayout.EndHorizontal();
                    }
                }
                else
                {
                    if (GUILayout.Button("No Items in the database add one now"))
                    {

                        TempWeapon = new ISWeapon();
                        showDetails = true;
                    }
                }
            }
            if (EditingArmor)
            {
                GUILayout.Label("Not Created Yet");
            }
            if (About)
            {
                GUILayout.Label("This is the list view. All the items in the Database will apear here. To view the items stats click it. To delete it you can click hte cross.");
            }
            GUILayout.EndScrollView();

        }

    }
}