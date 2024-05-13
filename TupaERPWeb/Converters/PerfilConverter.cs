using Microsoft.CodeAnalysis.Elfie.Diagnostics;
using TupaERPWeb.Models;
using TupaERPWeb.Models.ViewModels;

namespace TupaERPWeb.Converters
{
    public static class PerfilConverter
    {
        public static PerfilViewModel ToViewModel(Perfil perfil)
        {
            return new PerfilViewModel
            {
                Id = perfil.Id,
                Descricao = perfil.Descricao,
                Status = perfil.Status,
                Data_Cad = perfil.Data_Cad,
                Data_Alt = perfil.Data_Alt

            };
        }
        public static Perfil ToModel(PerfilViewModel perfil)
        {
            return new Perfil
            {
                Id = perfil.Id,
                Descricao = perfil.Descricao ?? string.Empty,
                Status = perfil.Status,
                Data_Cad = perfil.Data_Cad,
                Data_Alt = perfil.Data_Alt
            };
        }
        public static List<PerfilViewModel> ToViewModel(List<Perfil>? perfis)
        {
            List<PerfilViewModel> lista = new();
            if (perfis != null)
            {
                foreach (var perfil in perfis)
                {
                    lista.Add(ToViewModel(perfil));
                }
            }
            return lista;
        }
    }
}
