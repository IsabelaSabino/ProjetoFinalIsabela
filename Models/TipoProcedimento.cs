using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace ProjetoFinalIsabela.Models
{
    [Table("TipoProcedimento")]
    public class TipoProcedimento
    {
        [Column("Id")]
        [Display(Name = "Código do Procedimento")]
        public int Id { get; set; }

        [Column("TipoProcedimentoNome")]
        [Display(Name = "Tipo de Procedimento")]
        public string TipoProcedimentoNome { get; set; } = string.Empty;



    }
}
