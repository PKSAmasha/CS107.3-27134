﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lab06_Q1
{
    internal class Employee
    {
        private int empID;
        private string empName;
        private string empDesignation;

      //setter
        public void  setempID(int input)
        {
            empID = input;
        }

        public void setempName(string input)
        {
            empName = input;
        }
        public void setempDesignation(string input)
        {
            empDesignation = input;
        }
        //getter(read variable)
        public int getempID()
        {
            return empID;
        }
        public string getempName()
        {
            return empName;
        }
        public string getempDesignation()
        {
            return empDesignation;
        }
    }
}

