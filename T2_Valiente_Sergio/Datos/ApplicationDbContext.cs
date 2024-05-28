using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Diagnostics.Contracts;

using T2_Valiente_Sergio.Models;
namespace T2_Valiente_Sergio.Datos
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options) : base(options) 
        { 
        
        }
        public DbSet<Distribuidor> distribuidor { get; set; }
    }
}
