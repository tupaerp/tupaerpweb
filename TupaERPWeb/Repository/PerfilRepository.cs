using Microsoft.EntityFrameworkCore;
using System;
using System.Diagnostics;
using TupaERPWeb.Data;
using TupaERPWeb.Interfaces;
using TupaERPWeb.Models;

namespace TupaERPWeb.Repository
{
    public class PerfilRepository : IPerfilRepository
    {
        //contexto do banco de dados
        private readonly TupaERPDbContext _db;

        public PerfilRepository(TupaERPDbContext db)
        {
            _db = db;
        }

        public bool Adicionar(Perfil perfil)
        {
            _db.Add(perfil);
            return Salvar();
        }

        public bool Atualizar(Perfil perfil)
        {
            perfil.Data_Alt = DateTime.Now;
            _db.Update(perfil);
            return Salvar();

        }

        public async Task<(List<Perfil>? Perfis, int QtdTotalItens)> ObterPerfis(string descricao, string ordenarPor, string tipoOrdenacao, int paginaAtual, int qtdItensPagina)
        {
            IQueryable<Perfil> query = _db.Perfis.AsNoTracking();

            if (!string.IsNullOrEmpty(descricao)) 
            { 
               query = query.Where(p => p.Descricao.Contains(descricao));
            }
            int qtdTotalItens = await query.CountAsync();

            var lista = await query.OrderBy(p => p.Descricao).Skip(paginaAtual * qtdItensPagina).Take(qtdItensPagina).ToListAsync();

            return (lista, qtdTotalItens);

        }

        public async Task<Perfil?> ObterPorId(long id)
        {
            return await _db.Perfis.FirstOrDefaultAsync(i => i.Id == id);
        }

        public bool Remover(Perfil perfil)
        {
            _db.Remove(perfil);
            return Salvar();
        }

        public bool Salvar()
        {
            var salvo = _db.SaveChanges();
            return salvo > 0;
        }
    }
}
