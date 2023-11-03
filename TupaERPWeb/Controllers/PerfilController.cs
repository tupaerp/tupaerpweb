using Microsoft.AspNetCore.Mvc;
using TupaERPWeb.Interfaces;
using TupaERPWeb.Models;

namespace TupaERPWeb.Controllers
{
    public class PerfilController : Controller
    {
        //contexto do banco de dados
        private readonly PerfilInterface _perfilRepository;

        Perfil perfil; //objeto

        IEnumerable<Perfil> listaPerfis; //Lista enumerada

        public PerfilController(PerfilInterface perfilRepository)
        {
            _perfilRepository = perfilRepository;
        }

      
        public async Task<IActionResult> Index()
        {
            this.listaPerfis = await _perfilRepository.GetAll(); //............Esse representa o Model ou o "M" da sigla

            return View(listaPerfis); //........................Esse representa a View ou o "V" da Sigla
        }

    }
}
