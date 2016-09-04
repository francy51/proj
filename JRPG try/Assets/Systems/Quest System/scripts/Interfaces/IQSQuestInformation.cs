using UnityEngine;
using System.Collections;

namespace Project.QuestSystem
{
    public interface IQSQuestInformation 
    {
        string Name { get; }
        string DescriptionSummary { get; }
        string Hint { get; }
        string Dialog { get; }
        int SourceID { get; }
        int chainQuestID { get; }
        int QuestID { get; }

    }
}

