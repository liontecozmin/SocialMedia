using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SC.Core;
namespace SC.Infrastructure
{  
    public class UserContext : DbContext
    {
        public DbSet<User> User { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=Users;Trusted_Connection=True;");
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("In UserContext");
            Console.ReadKey();
        }


} 
  
}
