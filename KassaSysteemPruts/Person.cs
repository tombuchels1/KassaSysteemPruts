﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KassaSysteemPruts
{
    public abstract class Person
    {
        public string Name { get; set; }
        public int Phonenumber { get; set; }

        public Person(string name, int phonenumber)
        {
           Name = name;
           Phonenumber = phonenumber;
        }
    }
}
