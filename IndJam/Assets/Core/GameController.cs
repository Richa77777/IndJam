using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AIApp;
using Browser;
using TMPro;

public class GameController : MonoBehaviour
{
    #region Singleton
    public static GameController Instance;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }

        else
        {
            Destroy(gameObject);
        }
    }
    #endregion

    [SerializeField] private int _moneyAmount = 0;
    [SerializeField] private int _dayNumber = 1;
    [SerializeField] private int _generalSalary = 3500;
    [SerializeField] private int _maxError = 150;
    [SerializeField] private int _targetMoneyValue = 200000;
    [SerializeField] private int _maxAIDays = 7;
    [SerializeField] private TextMeshProUGUI _daysText;

    private AI _currentAI;
    private List<AI> _allAIs = new List<AI>();

    private MoneyBalanceApp _moneyBalanceApp;
    private ValuesController _valuesController;

    public int MoneyAmountGet => _moneyAmount;
    public int DayNumberGet => _dayNumber;
    public int GeneralSalaryGet => _generalSalary;
    public int TargetMoneyValueGet => _targetMoneyValue;
    public AI CurrentAI { get => _currentAI; set => _currentAI = value; }
    public List<AI> AllAisListGet { get => _allAIs;}

    private void Start()
    {
        _moneyBalanceApp = FindObjectOfType<MoneyBalanceApp>(true);
        _valuesController = GetComponent<ValuesController>();
        _daysText = GameObject.FindGameObjectWithTag("Days").GetComponent<TextMeshProUGUI>();

        _generalSalary = _valuesController.DayValuesGet[_dayNumber].SalaryGet;
        _maxError = _valuesController.DayValuesGet[_dayNumber].ErrorGet;
    }

    public void NextDay()
    {
        _dayNumber += 1;

        if (_dayNumber < _valuesController.DayValuesGet.Count)
        {
            _generalSalary = _valuesController.DayValuesGet[_dayNumber].SalaryGet;
            _maxError = _valuesController.DayValuesGet[_dayNumber].ErrorGet;
        }

        List<int> removeIndexes = new List<int>();

        for (int i = 0; i < _allAIs.Count; i++)
        {
            _allAIs[i].NextDay();

            if (_allAIs[i].DaysGet > _maxAIDays)
            {
                removeIndexes.Add(i);
            }
        }

        for (int i = 0; i < removeIndexes.Count; i++)
        {
            _allAIs.RemoveAt(removeIndexes[i]);
        }

        _daysText.text = $"Δενό {_dayNumber}";
    }

    public void AddMoney(int value)
    {
        _moneyAmount += value;
        _moneyBalanceApp.UpdateBalanceValue();
    }

    public void SetDayNumber(int value)
    {
        _dayNumber = value;
    }

    public void SetGeneralSalary(int value)
    {
        _generalSalary = value;
    }

    public void SetMaxError(int value)
    {
        _maxError = value;
    }
}
