﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID
{    
        class Program
        {
            static void Main(string[] args)
            {
                Fruit fruit = new Orange();
                Console.WriteLine(fruit.GetColor());
                fruit = new Apple();
                Console.WriteLine(fruit.GetColor());
            }
        }

        public abstract class Fruit
        {
            public abstract string GetColor();
        }

        public class Apple : Fruit
        {
            public override string GetColor()
            {
                return "Red";
            }
        }

        public class Orange : Apple
        {
            public override string GetColor()
            {
                return "Orange";
            }
        }
 }
