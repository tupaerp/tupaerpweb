using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TupaERPWeb.Models
{
    [Table("TABELA")]
    public class Tabela
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Id")]
        [Column("ID")]
        public int Id { get; set; }

        [Display(Name = "Status")]
        [Column("STATUS")]
        public sbyte Status { get; set; }

        [Display(Name = "Id Tabela")]
        [Required(ErrorMessage = "O campo TABELA é obrigatório.")]
        [Column("TABELA")]
        public required string DescTabela { get; set; }


        [Display(Name = "Obs.")]
        [Column("OBSERVACAO")]
        public string? Observacao { get; set; }

        [DisplayFormat(DataFormatString = "{MM/dd/yyyy}")]
        [Column("DATA_CAD")]
        public DateTime? Data_Cad { get; set; }

        [Display(Name = "Cadastro")]
        public string? DataCad
        {
            get { return Data_Cad?.ToShortDateString(); }
        }

        [DisplayFormat(DataFormatString = "{MM/dd/yyyy}")]
        [Column("DATA_ALT")]
        public DateTime? Data_Alt { get; set; }

        [Display(Name = "Alteração")]
        public string? DataAlt
        {
            get { return Data_Alt?.ToShortDateString(); }
        }


    }
}
