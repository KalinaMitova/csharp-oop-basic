﻿using System;

namespace _09Google
{
    public class Parent
    {
        private string mainName;
        private string name;
        private string dateOfBirth;

        public string MainName => this.mainName;

        public Parent(string mainName, string name, string dateOfBirth)
        {
            this.mainName = mainName;
            this.name = name;
            this.dateOfBirth = dateOfBirth;
        }

        public override string ToString()
        {
            return $"{name} {dateOfBirth}";
        }
    }
}
