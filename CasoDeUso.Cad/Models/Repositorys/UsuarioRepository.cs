
using System.Collections.Generic;
using System.Linq;
using CasoDeUso.Cad.DataBase;
using CasoDeUso.Cad.Models.Contracts;
using Microsoft.EntityFrameworkCore;

namespace CasoDeUso.Cad.Models.Repositorys
{
    public class UsuarioRepository<TEntity> : IUsuario<TEntity> where TEntity : class, new()
    {
        private readonly CasoDeUsoContext _banco;
        private readonly DbSet<TEntity> _DbSet;
        public UsuarioRepository(CasoDeUsoContext banco)
        {
            _banco = banco;
            _DbSet = _banco.Set<TEntity>();
        }

        public void Add(TEntity obj)
        {
            _DbSet.Add(obj);
            _banco.SaveChanges();
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _DbSet.AsNoTracking().ToList();
        }

        public TEntity GetById(int id)
        {
            return _DbSet.Find(id);
        }

        public void Remover(TEntity obj)
        {
            _DbSet.Remove(obj);
            _banco.SaveChanges();
        }

        public void Update(TEntity obj)
        {
            _DbSet.Update(obj);
            _banco.SaveChanges();
        }
    }
}
