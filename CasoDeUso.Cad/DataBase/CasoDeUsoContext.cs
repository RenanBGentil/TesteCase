using CasoDeUso.Cad.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CasoDeUso.Cad.DataBase
{
    public class CasoDeUsoContext : DbContext
    {
        public CasoDeUsoContext(DbContextOptions<CasoDeUsoContext> options) : base (options) { }

        public DbSet<Usuario> Usuario { get; set; }

    }
}
