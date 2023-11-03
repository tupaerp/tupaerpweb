using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TupaERPWeb.Models
{
    public class Acesso
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "ID")]
        [Column("ID")]
        public int Id { get; set; }


        [Display(Name = "Tabela")]
        [Required(ErrorMessage = "O campo TABELA é obrigatório.")]
        [ForeignKey("Tabela")]
        [Column("TABELA_ID")]
        public required int TabelaId { get; set; }

        [Display(Name = "Perfil")]
        [Required(ErrorMessage = "O campo PERFIL é obrigatório.")]
        [ForeignKey("Perfil")]
        [Column("PERFIL_ID")]
        public required int PerfilId { get; set; }


        [Display(Name = "Inserir")]
        [Column("TABELA_I")]
        public sbyte Inserir { get; set; }

        [Display(Name = "Alterar")]
        [Column("TABELA_A")]
        public sbyte Alterar { get; set; }

        [Display(Name = "Excluir")]
        [Column("TABELA_E")]
        public sbyte Excluir { get; set; }


        [Display(Name = "Visualizar")]
        [Column("TABELA_V")]
        public sbyte Visualizar { get; set; }



        [Display(Name = "Status")]
        [Column("STATUS")]
        public sbyte Status { get; set; }



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

        //Chaves Estrangeiras
        public Tabela? Tabela { get; set; }

        public Perfil? Perfil { get; set; }
    }
}
