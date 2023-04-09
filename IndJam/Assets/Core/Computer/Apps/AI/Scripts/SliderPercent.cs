using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

namespace AIApp
{
    public class SliderPercent : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI _percentText;
        [SerializeField] private int _currentPercent;

        public int CurrentPercentGet => _currentPercent;

        public void UpdatePercent(float percent)
        {
            _currentPercent = Mathf.RoundToInt(percent * 100);

            _percentText.text = $"{_currentPercent}%";
        }
    }
}
