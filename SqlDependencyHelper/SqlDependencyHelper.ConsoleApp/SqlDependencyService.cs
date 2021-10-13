using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SqlDependencyHelper.ConsoleApp
{
    public class SqlDependencyService
    {
        public string _connectionString { get; set; }

        public SqlDependencyService(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void CreateObjects()
        {
            List<DependentObject> objects;
            using (var context = new DatabaseContext(_connectionString))
            {
                objects = context.DependentObject.ToList();

                foreach (DependentObject sqlObject in objects)
                {
                    var result = context.Database.ExecuteSqlRaw(sqlObject.ObjectDefinition);
                }
            }            
        }
    }
}
