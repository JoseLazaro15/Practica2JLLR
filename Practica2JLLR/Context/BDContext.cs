using Microsoft.EntityFrameworkCore;
using Practica2JLLR.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practica2JLLR.Context
{
    public class BDContext : DbContext
    {
        public BDContext
            (DbContextOptions<BDContext> options):base
                (options)
        {

        }
        public DbSet<Ruta> Rutas { get; set; }
        public DbSet<Menu> Menus { get; set; }

    }
}
