using Browser;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VacancyBeri : MonoBehaviour
{
    [SerializeField] private VacancyCard _currentCard;

    private VacanciesGenerator _generator;

    private void Start()
    {
        _currentCard = GetComponent<VacancyCard>();
        _generator = FindObjectOfType<VacanciesGenerator>();
    }

    public void SetCurrentCard(VacancyCard card)
    {
        _currentCard = card;
    }

    public void Vzal()
    {
        GameController.Instance.AddMoney(GameController.Instance.GeneralSalaryGet);
        GameController.Instance.NextDay();
    }
}
