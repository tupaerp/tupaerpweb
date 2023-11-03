using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using TupaERPWeb.Data;
using TupaERPWeb.Interfaces;
using TupaERPWeb.Models;

namespace TupaERPWeb.Repository
{
    public class PerfilRepository : PerfilInterface
    {
        //contexto do banco de dados
        private readonly TupaERPDbContext db;

        public PerfilRepository(TupaERPDbContext context)
        {
            db = context;
        }
        public bool Add(Perfil perfil)
        {
            db.Add(perfil);
            return Save();
        }

        public bool Delete(Perfil perfil)
        {
            db.Remove(perfil);
            return Save();
        }

        public async Task<IEnumerable<Perfil>> GetAll()
        {
            return await db.Perfis.ToListAsync();
        }

        public async Task<Perfil> GetByIdAsync(int id)
        {
            return await db.Perfis.FirstOrDefaultAsync(i => i.Id == id);
        }

        public async Task<IEnumerable<Perfil>> GetRaceByDesc(string desc)
        {
            return await db.Perfis.Where(c => c.Descricao.Contains(desc)).ToListAsync();

        }

        public bool Save()
        {
            var saved = db.SaveChanges();
            return saved > 0 ? true : false;
        }

        public bool Update(Perfil perfil)
        {
            throw new NotImplementedException();
        }
    }
}
