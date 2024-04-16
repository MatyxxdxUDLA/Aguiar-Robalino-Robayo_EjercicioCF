using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Aguiar_Robalino_Robayo_EjercicioCF.Models;

namespace Aguiar_Robalino_Robayo_EjercicioCF.Data
{
    public class Aguiar_Robalino_Robayo_EjercicioCFContext : DbContext
    {
        public Aguiar_Robalino_Robayo_EjercicioCFContext (DbContextOptions<Aguiar_Robalino_Robayo_EjercicioCFContext> options)
            : base(options)
        {
        }

        public DbSet<Aguiar_Robalino_Robayo_EjercicioCF.Models.Estudiante> Estudiante { get; set; } = default!;
    }
}
