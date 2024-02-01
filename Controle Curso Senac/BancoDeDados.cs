using Microsoft.EntityFrameworkCore;

namespace Controle_Curso_Senac
{
    public class BancoDeDados : DbContext
    {
        public DbSet<Agenda> Agendas{ get; set; }

        public DbSet<Usuario> Usuarios { get; set; }

        public DbSet <Curso> Cursos { get; set; }

        public DbSet<Historico> Historicos { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder opt)
        {
            opt.UseSqlite("Data Source = Banco.db");
        }
    }


}
