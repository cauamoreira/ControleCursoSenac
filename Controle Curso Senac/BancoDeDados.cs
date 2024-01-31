using Microsoft.EntityFrameworkCore;

namespace Controle_Curso_Senac
{
    public class BancoDeDados : DbContext
    {
        public DbSet<Agenda> Agendas { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder opt)
        {
            opt.UseSqlite("Data Source = Banco.db");
        }
    }


}
