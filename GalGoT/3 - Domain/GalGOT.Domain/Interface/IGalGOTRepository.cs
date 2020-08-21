using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GalGOT.Domain.Interface
{
    public interface IGalGOTRepository<TEntity> : IDisposable where TEntity : class
    {
        List<TEntity> SelecionarTudo();
        TEntity SelecionarPorId(int id);
        void Incluir(TEntity entity);
        void Alterar(TEntity entity);
        Task Excluir(int id);        
    }
}
