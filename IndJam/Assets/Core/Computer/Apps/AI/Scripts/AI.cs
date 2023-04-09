using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AIApp
{
    public class AI
    {
        private int _humanitarian = 0;
        private int _techie = 0;
        private int _manager = 0;
        private int _days = 0;
        private int _salary = 0;

        public int HumanitarianValueGet { get => _humanitarian; }
        public int TechieValueGet { get => _techie; }
        public int ManagerValueGet { get => _manager; }
        public int DaysGet { get => _manager; }
        public int SalaryGet { get => _salary;  }

        public AI(int h, int t, int m, int salary)
        {
            _humanitarian = h;
            _techie = t;
            _manager = m;

            _salary = salary;
        }

        public void NextDay()
        {
            _days += 1;
        }
    }
}
