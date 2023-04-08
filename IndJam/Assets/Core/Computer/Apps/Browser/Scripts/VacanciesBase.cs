using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VacanciesBase : MonoBehaviour
{
    [SerializeField] private List<Vacancy> _vacanciesBase;

    public List<Vacancy> VacanciesBaseGet => _vacanciesBase;
}

[System.Serializable]
public class Vacancy
{
    [SerializeField] private string _name;
    [SerializeField] private string _characteristicsText;

    [Header("Need Characteristics")]
    [SerializeField] private int _humanitarian;
    [SerializeField] private int _techie;
    [SerializeField] private int _manager;

    public string NameGet => _name;
    public string CharacteristicsGet => _characteristicsText;

    public int HumanitarianValueGet => _humanitarian;
    public int TechieValueGet => _techie;
    public int ManagerValueGet => _manager;
}
