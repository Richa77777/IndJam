using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class JobCard : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _jobTitleText;
    [SerializeField] private TextMeshProUGUI _characteristicsText;
    [SerializeField] private TextMeshProUGUI _wageText;

    public void SetJobTitle(string jobTitle)
    {
        _jobTitleText.text = jobTitle;
    }

    public void SetCharacteristics(string characteristics)
    {
        _characteristicsText.text = characteristics;
    }

    public void SetWage(int value)
    {
        _wageText.text = value.ToString();
    }
}