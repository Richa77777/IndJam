using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    #region Singleton
    public static GameController Instance;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }

        else if (Instance == this)
        {
            Destroy(gameObject);
        }

        DontDestroyOnLoad(gameObject);
    }
    #endregion

    [SerializeField] private int _moneyAmount = 0;
    [SerializeField] private int _dayNumber = 1;
    [SerializeField] private int _generalSalary = 3500;
    [SerializeField] private int _maxError = 150;

    public int MoneyAmountGet => _moneyAmount;
    public int DayNumberGet => _dayNumber;
    public int GeneralWageGet => _generalSalary;

    public void AddMoney(int value)
    {
        _moneyAmount += value;
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
