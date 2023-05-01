﻿using FoodShortage.Models.Interfaces;

namespace FoodShortage.Models
{
    public class Pet : IBirthable, INameable
    {
        public Pet(string name, string birthdate)
        {
            Name = name;
            Birthdate = birthdate;
        }

        public string Name { get; private set; }
        public string Birthdate { get; private set; }

    }
}
