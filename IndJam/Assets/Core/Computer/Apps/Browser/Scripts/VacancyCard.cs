using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace Browser
{
    public class VacancyCard : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI _jobTitleText;
        [SerializeField] private TextMeshProUGUI _characteristicsText;
        [SerializeField] private TextMeshProUGUI _salaryText;

        public void SetJobTitle(string jobTitle)
        {
            _jobTitleText.text = jobTitle;
        }

        public void SetCharacteristics(string characteristics)
        {
            _characteristicsText.text = characteristics;
        }

        public void SetSalary(int value)
        {
            _salaryText.text = $"Зарплата:\n {value}$ в день";
        }
    }
}
