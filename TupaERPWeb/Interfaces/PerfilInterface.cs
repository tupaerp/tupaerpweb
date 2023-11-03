using System.Diagnostics;
using TupaERPWeb.Models;

namespace TupaERPWeb.Interfaces
{
    public interface PerfilInterface
    {
        Task<IEnumerable<Perfil>> GetAll();

        Task<Perfil> GetByIdAsync(int id);
        Task<IEnumerable<Perfil>> GetRaceByDesc(string desc);
        bool Add(Perfil perfil);
        bool Update(Perfil perfil);

        bool Delete(Perfil perfil);
        bool Save();
    }
}
