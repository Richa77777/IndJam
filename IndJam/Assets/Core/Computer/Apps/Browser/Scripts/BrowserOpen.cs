using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Browser;

public class BrowserOpen : MonoBehaviour
{
    [SerializeField] private int _lastDay = 0;

    private VacanciesGenerator _generator;

    private void Start()
    {
        _generator = FindObjectOfType<VacanciesGenerator>();
    }

    public void Open()
    {
        if (_lastDay != GameController.Instance.DayNumberGet)
        {
            _lastDay = GameController.Instance.DayNumberGet;
            _generator.GenerateNewVacancies();
        }
    }
}
