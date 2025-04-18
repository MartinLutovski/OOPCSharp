﻿using Qinshift.Inheritance.models;

namespace Qinshift.Inheritance.Models
{
    public class Cat : Animal
    {
        public Cat(string name, string type, string color, bool isLazy) : base(name, type, color)
        {
            Console.WriteLine("Cat constructor is called");
            IsLazy = isLazy;

        }

        public bool IsLazy { get; set; }

        public override void Speak()
        {
            Console.WriteLine($"{Name} the {Color} {Type} says meow!");
        }
    }
}
