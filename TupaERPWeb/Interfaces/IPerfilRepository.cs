using System.Diagnostics;
using TupaERPWeb.Models;

namespace TupaERPWeb.Interfaces
{
    public interface IPerfilRepository
    {
        bool Adicionar(Perfil perfil);

        bool Atualizar(Perfil perfil);

        bool Remover(Perfil perfil);
        bool Salvar();
        Task<Perfil?> ObterPorId(long id);

        Task<(List<Perfil>? Perfis, int QtdTotalItens)> ObterPerfis(string descricao, string ordenarPor, string tipoOrdenacao, int paginaAtual, int qtdItensPagina);
    }
}
