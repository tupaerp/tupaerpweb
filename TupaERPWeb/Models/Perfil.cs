using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TupaERPWeb.Models
{
    [Table("PERFIL")]
    public class Perfil
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ID")]
        public int Id { get; set; }

        [Column("STATUS")]
        public sbyte Status { get; set; }

        [Required(ErrorMessage = "O campo DESCRIÇÁO é obrigatório.")]
        [Column("DESCRICAO")]
        public required string Descricao { get; set; }

        [DisplayFormat(DataFormatString = "{MM/dd/yyyy}")]
        [Column("DATA_CAD")]
        public DateTime? Data_Cad { get; set; }

        public string? DataCad
        {
            get { return Data_Cad?.ToShortDateString(); }
        }

        [DisplayFormat(DataFormatString = "{MM/dd/yyyy}")]
        [Column("DATA_ALT")]
        public DateTime? Data_Alt { get; set; }

        public string? DataAlt
        {
            get { return Data_Alt?.ToShortDateString(); }
        }
    }
}
