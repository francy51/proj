
using UnityEngine;
using System.Collections;

namespace Project.ItemSystem
{
    public partial class ISObjectEditor
    {

        ISWeapon TempWeapon;
        bool showDetails = false;

        ISQualityDatabase QDB;
        const string QUALITY_DATABASE_PATH = @"Systems/Item System/scripts/database/Actual Database";
        const string QUALITY_DATABASE_NAME = @"ISQUALITYDATABASE.asset";


        void ObjectDetails()
        {

            GUILayout.BeginVertical("Box", GUILayout.ExpandWidth(true), GUILayout.ExpandHeight(true));
            GUILayout.BeginHorizontal("Box", GUILayout.ExpandWidth(true), GUILayout.ExpandHeight(true));


            if (showDetails)
            {
                DisplayNewWeapon();
            }   

            if (About)
            {
                GUILayout.Label("This is where you stats will apear when editing an existing weapon or creating a new one.");   
            }

            GUILayout.EndHorizontal();

            GUILayout.BeginHorizontal("Box", GUILayout.ExpandWidth(true));

            DisplayButtons();
            GUILayout.EndHorizontal();
            GUILayout.EndVertical();

        }

        void DisplayNewWeapon()
        {

            TempWeapon.OnGUI();

        }


        void DisplayButtons()
        {

            if (!showDetails)
            {
                if (GUILayout.Button("Add Object"))
                {
                    if (EditingWeapons)
                    {
                        TempWeapon = new ISWeapon();
                    }
                    if (About)
                    {
                        Debug.Log("This creates a temporary item press teh save button to permanently add it to you database.");
                    }
                    showDetails = true;
                }
            }
            else
            {

                if (GUILayout.Button("Save"))
                {
                    if (EditingWeapons)
                    {
                        for (int i = 0; i < WeaponDB.Count; i++)
                        {
                            if (TempWeapon.ISName == WeaponDB.Get(i).ISName)
                            {
                                QDB = ISQualityDatabase.GetDatabase<ISQualityDatabase>(QUALITY_DATABASE_PATH, QUALITY_DATABASE_NAME);
                                TempWeapon.ISQuality = QDB.Get(TempWeapon.qualitySelectedID);
                                WeaponDB.Replace(i, TempWeapon);
                                showDetails = false;
                                TempWeapon = null;
                            }
                        }
                        Debug.Log("weapon saved");

                        QDB = ISQualityDatabase.GetDatabase<ISQualityDatabase>(QUALITY_DATABASE_PATH, QUALITY_DATABASE_NAME);
                        TempWeapon.ISQuality = QDB.Get(TempWeapon.qualitySelectedID);
                        WeaponDB.Add(TempWeapon);
                        showDetails = false;
                        TempWeapon = null;
                    }
              
                }

                if (GUILayout.Button("Cancel"))
                {
                    Debug.Log("weapon canceled");
                    showDetails = false;
                    TempWeapon = null;
                }

            }

        }

    }
}