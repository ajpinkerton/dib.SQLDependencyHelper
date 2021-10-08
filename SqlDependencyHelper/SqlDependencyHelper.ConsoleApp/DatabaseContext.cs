using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SqlDependencyHelper.ConsoleApp
{
    public class DatabaseContext : DbContext
    {
        private readonly string _connectionString;
        public DbSet<DependentObject> DependentObjects { get; set; }

        public DatabaseContext(string connectionString)
        {
            _connectionString = connectionString;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
        }
    }

    public class DependentObject
    {
        public int DependentObjectID { get; set; }
        public string DatabaseName { get; set; }
        public string SchemaName { get; set; }
        public string ObjectName { get; set; }
        public string ObjectType { get; set; }        

    }

}
