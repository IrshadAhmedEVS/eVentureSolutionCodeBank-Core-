﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PolymorphismDemo
{
    class Manager:Employee
    {


        private string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public override double TellMeYourSalary()
        {
            return Salary;
        }


    }
}
