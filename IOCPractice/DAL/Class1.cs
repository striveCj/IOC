﻿using IDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class People : IPeople
    {
        public string Run()
        {
            return "成功";
        }

        public People()
        {
            name = "cj";
        }
        public string name { get; set; }
    }
}
