﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LuckySpin
{
    public class Lucky7
    {
        public string Output(int numLucky) {
                Random random = new Random();
                int a = random.Next(1, 10);
                int b = random.Next(1, 10);
                int c = random.Next(1, 10);

                string output = 
                    "<button onclick='history.go(0)'>Spin</button>" +
                    "<div>" + a + "</div><div>" + b + "</div><div>" + c + "</div>" +
                    "<h1> Lucky "+ numLucky +" </h1>";
                if (a == numLucky|| b == numLucky || c == numLucky)
                    output = output + 
                        "<img src='http://faculty.cascadia.edu/brianb/images/LuckySevenExercise.jpg'/>";


                return output;
        }
    }
}
