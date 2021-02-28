using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Data.Entity;

namespace StudentDatabase
{
    public class StudentContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
    }
}
