using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TupaERPWeb.Models.ViewModels
{

	public class PerfilListViewModel : BaseListViewModel
	{
		public PerfilListViewModel(List<PerfilViewModel>? perfis, int totalItens, int paginaAtual, int qtdItensPagina) : base(totalItens, paginaAtual, qtdItensPagina)
		{
			Perfis = perfis;

		}
		public string? Descricao { get; set; }
		public sbyte Status { get; set; }
		public List<PerfilViewModel>? Perfis { get; set; }
	}

	public class PerfilViewModel
	{
		
		public int Id { get; set; }

		public sbyte Status { get; set; }

				
		[Required(ErrorMessage = "O campo DESCRIÇÁO é obrigatório.")]
		public required string Descricao { get; set; }

		[DisplayFormat(DataFormatString = "{MM/dd/yyyy}")]
		public DateTime? Data_Cad { get; set; }

		[Display(Name = "Cadastro")]
		public string? DataCad
		{
			get { return Data_Cad?.ToShortDateString(); }
		}

		[DisplayFormat(DataFormatString = "{MM/dd/yyyy}")]
		public DateTime? Data_Alt { get; set; }

		[Display(Name = "Alteração")]
		public string? DataAlt
		{
			get { return Data_Alt?.ToShortDateString(); }
		}
	}
}
