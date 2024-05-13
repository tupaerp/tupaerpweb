using Microsoft.AspNetCore.Mvc;
using TupaERPWeb.Converters;
using TupaERPWeb.Interfaces;
using TupaERPWeb.Models;
using TupaERPWeb.Models.ViewModels;

namespace TupaERPWeb.Controllers
{
    public class PerfilController : Controller
    {
        //contexto do banco de dados
        private readonly IPerfilRepository _perfilRepository;

       

        public PerfilController(IPerfilRepository perfilRepository)
        {
            _perfilRepository = perfilRepository;
        }

      
        public async Task<IActionResult> Index(string descricao, int paginaAtual = 1, int qtdItensPagina = 5)
        {
            var (Perfis, QtdTotalItens) = await _perfilRepository.ObterPerfis(descricao, string.Empty, string.Empty, paginaAtual - 1, qtdItensPagina);

            var lista = PerfilConverter.ToViewModel(Perfis);

            return View(new PerfilListViewModel(lista, QtdTotalItens, paginaAtual, qtdItensPagina));
        }

    }
}
