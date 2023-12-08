using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace ProjetoFinalIsabela.Models
{
    [Table("Procedimento")]
    public class Procedimento
    {
        [Column("Id")]
        [Display(Name = "Código do Procedimento")]
        public int Id { get; set; }

        [Column("ProcedimentoNome")]
        [Display(Name = "Procedimento")]
        public string ProcedimentoNome { get; set; } = string.Empty;

        [Column("ProcedimentoObservacao")]
        [Display(Name = "Observação do Procedimento")]
        public string ProcedimentoObservacao { get; set; } = string.Empty;


        [ForeignKey("TipoProcedimentoId")]
        [Display(Name = "Tipo do Procedimento")]

        public int TipoProcedimentoId { get; set; }
        [Display(Name = "Tipo Procedimento")]
        public TipoProcedimento? Tipoprocedimento { get; set; }




    }
}
