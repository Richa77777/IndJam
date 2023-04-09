using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AIApp
{
    public class ApplyAIButton : MonoBehaviour
    {
        [SerializeField] private SliderPercent[] _allPercents = new SliderPercent[3];

        public void SetNewAI()
        {
            AI ai = GameController.Instance.CurrentAI = new AI(_allPercents[0].CurrentPercentGet, _allPercents[1].CurrentPercentGet, _allPercents[2].CurrentPercentGet, GameController.Instance.GeneralSalaryGet);
            GameController.Instance.AllAisListGet.Add(ai);
        }
    }
}
