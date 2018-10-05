﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID
{
      class Program
        {
            static void Main(string[] args)
            {
                Apple apple = new Orange();
                Console.WriteLine(apple.GetColor());
            }
        }

        public class Apple
        {
            public virtual string GetColor()
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
