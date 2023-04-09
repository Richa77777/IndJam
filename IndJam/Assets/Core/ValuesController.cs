using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ValuesController : MonoBehaviour
{
    [SerializeField] private List<DayValues> _dayValues = new List<DayValues>();

    public List<DayValues> DayValuesGet => _dayValues;
}

[System.Serializable]
public class DayValues
{
    [SerializeField] private int _salary;
    [SerializeField] private int _error;

    public int SalaryGet => _salary;
    public int ErrorGet => _error;
}