using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TupaERPWeb.Models
{
    public class Empresa
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Id")]
        [Column("ID")]
        public int Id { get; set; }

        [StringLength(100, MinimumLength = 8, ErrorMessage = "Fantasia deve ter entre 8 e 100 caracteres.")]
        [Display(Name = "Fantasia")]
        [Required(ErrorMessage = "O campo FANTASIA é obrigatório.")]
        [Column("FANTASIA")]
        public required string Fantasia { get; set; }


        [StringLength(100, MinimumLength = 8, ErrorMessage = "Razão Social deve ter entre 8 e 100 caracteres.")]
        [Display(Name = "Razão Social")]
        [Required(ErrorMessage = "O campo RAZAO SOCIAL é obrigatório.")]
        [Column("RAZAO_SOCIAL")]
        public required string RazaoSocial { get; set; }
      

        [Display(Name = "CEP")]
        [RegularExpression(@"^[0-9-]+$", ErrorMessage = "O CEP deve conter apenas números e hífens.")]
        [StringLength(10, ErrorMessage = "O CEP deve ter no máximo 10 caracteres.")]
        [Column("CEP")]
        public string? Cep { get; set; }


        [Display(Name = "Logradouro")]
        [Column("LOGRADOURO")]
        public  string? Logradouro { get; set; }

        [Display(Name = "Número")]
        [Column("NUMERO")]
        public string? Numero { get; set; }

        [Display(Name = "Bairro")]
        [Column("BAIRRO")]
        public string? Bairro { get; set; }

        [Display(Name = "Cidade")]
        [Column("CIDADE")]
        public string? Cidade { get; set; }

        [Display(Name = "UF")]
        [Column("UF")]
        public string? Uf { get; set; }

        [RegularExpression(@"^\(\d{2}\)\d{4}-\d{4}$", ErrorMessage = "O TELEFONE deve estar no formato (99)9999-9999.")]
        [StringLength(13, ErrorMessage = "O telefone deve ter no máximo 13 caracteres.")]
        [Display(Name = "Telefone(fixo)")]
        [Column("TELEFONE")]
        public string? Telefone { get; set; }


        [RegularExpression(@"^\(\d{2}\)\d{5}-\d{4}$", ErrorMessage = "O CELULAR PRINCIPAL deve estar no formato (99)99999-9999.")]
        [StringLength(14, ErrorMessage = "O CELULAR deve ter no máximo 14 caracteres.")]
        [Display(Name = "Celular(principal)")]
        [Column("CELULAR")]
        public string? Celular { get; set; }

        [RegularExpression(@"^\(\d{2}\)\d{5}-\d{4}$", ErrorMessage = "O CELULAR SECUNDÁRIO deve estar no formato (99)99999-9999.")]
        [StringLength(14, ErrorMessage = "O CELULAR deve ter no máximo 14 caracteres.")]
        [Display(Name = "Celular(secundário)")]
        [Column("CELULAR_2")]
        public string? Celular2 { get; set; }

        [RegularExpression(@"^\d{2}\.\d{3}\.\d{3}\/\d{4}-\d{2}$", ErrorMessage = "O CNPJ deve estar no formato 99.999.999/9999-99.")]
        [Display(Name = "CNPJ")]
        [Column("CNPJ")]
        public string? Cnpj { get; set; }

        [RegularExpression(@"^\d{3}\.\d{3}\.\d{3}-\d{2}$", ErrorMessage = "O CPF deve estar no formato 999.999.999-00.")]
        [Display(Name = "CPF")]
        [Column("CPF")]
        public string? Cpf { get; set; }


        [Display(Name = "IE")]
        [Column("INSC_ESTADUAL")]
        public string? Ie { get; set; }


        [Display(Name = "CRT")]
        [Required(ErrorMessage = "O campo CRT é obrigatório.")]
        [ForeignKey("Crt")]
        [Column("CRT_ID")]
        public required int CRT { get; set; }

        [Display(Name = "Sit. Tributária")]
        [Required(ErrorMessage = "O campo SITUAÇÃO é obrigatório.")]
        [ForeignKey("Situacao")]
        [Column("SITUACAO_ID")]
        public required int SitTrib { get; set; }


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


        [Display(Name = "Grupo Empresa")]
        [Required(ErrorMessage = "O campo GRUPO EMPRESA é obrigatório.")]
        [ForeignKey("GrupoEmp")]
        [Column("GRUPO_ID")]
        public required int GrupoEmpresa { get; set; }

        [Display(Name = "Condição")]
        [Required(ErrorMessage = "O campo CONDIÇÃO é obrigatório.")]
        [ForeignKey("Condicao")]
        [Column("CONDICAO_ID")]
        public required int CondicaoEmp5 { get; set; }



        //Chaves Estrangeiras
        public Crt? Crt { get; set; }
        public SituacaoTributaria? Situacao { get; set; }

        public GrupoEmpresa? GrupoEmp { get; set; }

        public Condicao? Condicao { get; set; }
    }
}
