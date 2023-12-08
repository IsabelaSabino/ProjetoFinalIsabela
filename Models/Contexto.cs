using Microsoft.EntityFrameworkCore;
using ProjetoFinalIsabela.Models;

namespace ProjetoFinalIsabela.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {

        }
        public DbSet<ProjetoFinalIsabela.Models.Cidade>? Cidade { get; set; }
        public DbSet<ProjetoFinalIsabela.Models.Cliente>? Cliente { get; set; }
        public DbSet<ProjetoFinalIsabela.Models.Colaborador>? Colaborador { get; set; }
        public DbSet<ProjetoFinalIsabela.Models.Estado>? Estado { get; set; }
        public DbSet<ProjetoFinalIsabela.Models.LocalRealizacao>? LocalRealizacao { get; set; }
        public DbSet<ProjetoFinalIsabela.Models.Procedimento>? Procedimento { get; set; }
        public DbSet<ProjetoFinalIsabela.Models.ProcedimentoRealizado>? ProcedimentoRealizado { get; set; }
        public DbSet<ProjetoFinalIsabela.Models.TipoColaborador>? TipoColaborador { get; set; }
        public DbSet<ProjetoFinalIsabela.Models.TipoProcedimento>? TipoProcedimento { get; set; }
        public DbSet<ProjetoFinalIsabela.Models.Usuario>? Usuario { get; set; }
       /* public DbSet<Cidade> Cidade{ get; set; }*/
       




    }
}
