using System.Collections.Generic;

namespace CasoDeUso.Cad.Models.Contracts
{
    public interface IUsuario<TEntity> 
    {
        public void Add(TEntity obj);
        public void Update(TEntity obj);
        public void Remover(TEntity obj);
        IEnumerable<TEntity> GetAll();
        TEntity GetById(int id);
    }
}
