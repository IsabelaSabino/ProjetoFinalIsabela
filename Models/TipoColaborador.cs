using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace ProjetoFinalIsabela.Models
{
    public class TipoColaborador
    {
        [Column("Id")]
        [Display(Name = "Código do Tipo de Colaborador")]
        public int Id { get; set; }

        [Column("TipoColaboradorNome")]
        [Display(Name = "Colaborador")]
        public string TipoColaboradorNome { get; set; } = string.Empty;
    }
}
