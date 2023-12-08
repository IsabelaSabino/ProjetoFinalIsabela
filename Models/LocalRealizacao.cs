using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace ProjetoFinalIsabela.Models
{
    [Table("LocalRealizacao")]
    public class LocalRealizacao
    {
        [Column("Id")]
        [Display(Name = "Código Local Realizado")]
        public int Id { get; set; }

        [Column("LocalNome")]
        [Display(Name = "Local")]
        public string LocalNome { get; set; } = string.Empty;


        [ForeignKey("CidadeId")]
        [Display(Name = "Cidade")]

        public int CidadeId { get; set; }

        public Cidade? Cidade { get; set; }
    }
}
