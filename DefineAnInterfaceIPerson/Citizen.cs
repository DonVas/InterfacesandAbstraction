﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PersonInfo
{
    public class Citizen : IPerson
    {
        private string name;
        private int age;

        public Citizen(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
        public int Age
        {
            get => age;
            set => age = value;
        }


        public string Name
        {
            get => name;
            set => name = value;
        }
    }
}
