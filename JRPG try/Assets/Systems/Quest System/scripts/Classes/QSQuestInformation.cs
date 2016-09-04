using UnityEngine;
using System.Collections;
using System;

namespace Project.QuestSystem
{
    public class QSQuestInformation : IQSQuestInformation
    {

        private string name;
        private string descriptionSummary;
        private string dialog;
        private string hint;
        private int questID;
        private int chainquestID;
        private int sourceID;

        public string Name
        {
            get
            {
                return name;
            }
        }

        public string DescriptionSummary
        {
            get
            {
                return descriptionSummary;
            }
        }

        public string Hint
        {
            get
            {
                return hint;
            }
        }

        public string Dialog
        {
            get
            {
                return hint;
            }
        }

        public int SourceID
        {
            get
            {
                return sourceID;
            }
        }

        public int chainQuestID
        {
            get
            {
                return chainquestID;
            }
        }

        public int QuestID
        {
            get
            {
                return questID;
            }
        }
    }
}