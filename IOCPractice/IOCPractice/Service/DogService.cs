﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using IOCPractice.Core;

namespace IOCPractice.Service
{
    public class DogService:IAnimal,IRun
    {
        public void Run()
        {
            Console.WriteLine("小狗在跑");
        }

        public void Shout()
        {
            Console.WriteLine("汪汪汪");
        }
    }
}