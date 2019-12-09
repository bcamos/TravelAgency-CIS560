using DataAccess;
using DataModeling.Model;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DataModeling
{
    /// <summary>
    /// Provides functionality for connecting to SQL procedure to create a new agent
    /// </summary>
    public class AgencyCreateAgentDelegate : NonQueryDataDelegate<Agent>
    {
        public readonly string name;
        public readonly double salary;        

        public AgencyCreateAgentDelegate(string name, double salary)
            : base("Agency.CreateAgent")
        {
            this.name = name;
            this.salary = salary;            
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("Name", name);
            command.Parameters.AddWithValue("Salary", salary);            

            var p = command.Parameters.Add("AgentID", SqlDbType.Int);
            p.Direction = ParameterDirection.Output;
        }

        public override Agent Translate(SqlCommand command)
        {
            return new Agent((int)command.Parameters["AgentID"].Value, name, salary);
        }
    }

    
}
