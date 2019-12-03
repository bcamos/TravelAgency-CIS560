﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModeling.Model
{
    public class Agents
    {
        public int AgentID { get; }

        public string Name { get; }

        public float Salary { get; }

        public bool IsDeleted { get; }

        public Agents(int aID, string name, float salary, bool isDeleted)
        {
            AgentID = aID;
            Name = name;
            Salary = salary;
            IsDeleted = isDeleted;
        }
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append("AgentID: " + AgentID);
            result.Append(", ");
            result.Append("Name: " + Name);
            result.Append(", ");
            result.Append("Salary: " + Salary);
            result.Append(", ");

            if (IsDeleted)
            {
                result.Append("Deleted");
            }
            else
            {
                result.Append("Not Deleted");
            }
            return result.ToString();

        }

    }
}