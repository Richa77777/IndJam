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

        private Vacancy _currentVacancy;

        public TextMeshProUGUI JobTitleTextGet => _jobTitleText;
        public TextMeshProUGUI CharacteristicsTextGet => _characteristicsText;
        public TextMeshProUGUI SalaryTextGet => _salaryText;
        public Vacancy CurrentVacancy { get => _currentVacancy; set => _currentVacancy = value; }

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
