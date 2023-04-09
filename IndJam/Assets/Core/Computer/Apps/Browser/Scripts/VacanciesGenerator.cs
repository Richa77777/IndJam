using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Browser
{
    public class VacanciesGenerator : MonoBehaviour
    {
        [SerializeField] private VacancyCard[] _vacancyCards = new VacancyCard[3];

        private VacanciesBase _vacanciesBase;

        private void Start()
        {
            _vacanciesBase = GetComponent<VacanciesBase>();
        }

        [ContextMenu("Generate")]
        public void GenerateNewVacancies()
        {
            Vacancy randomVacancy = null;
            int randomVacancyIndex = 0;

            for (int i = 0; i < _vacancyCards.Length; i++)
            {
                randomVacancyIndex = Random.Range(0, _vacanciesBase.VacanciesBaseGet.Count);
                randomVacancy = _vacanciesBase.VacanciesBaseGet[randomVacancyIndex];

                _vacancyCards[i].SetJobTitle(randomVacancy.NameGet);
                _vacancyCards[i].SetCharacteristics(randomVacancy.CharacteristicsGet);
                _vacancyCards[i].SetSalary(GameController.Instance.GeneralSalaryGet);

                _vacancyCards[i].CurrentVacancy = randomVacancy;
            }
        }
    }
}