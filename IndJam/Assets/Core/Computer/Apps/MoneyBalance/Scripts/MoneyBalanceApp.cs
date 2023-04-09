using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MoneyBalanceApp : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _balance;
    [SerializeField] private TextMeshProUGUI _targetValue;

    private void Start()
    {
        _targetValue.text = $"{GameController.Instance.TargetMoneyValueGet}$";
    }

    public void UpdateBalanceValue()
    {
        _balance.text = $"{GameController.Instance.MoneyAmountGet}$";
    }
}
