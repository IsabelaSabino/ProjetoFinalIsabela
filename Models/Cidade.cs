using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace ProjetoFinalIsabela.Models
{
    public class Cidade
    {
        [Column("Id")]
        [Display(Name = "Código da Cidade ")]
        public int Id { get; set; }

        [Column("CidadeNome")]
        [Display(Name = "Cidade")]
        public string CidadeNome { get; set; } = string.Empty;


        [ForeignKey("EstadoId")]
        [Display(Name = "Estado")]

        public int EstadoId { get; set; }

        public Estado? Estado { get; set; }


    }
}
