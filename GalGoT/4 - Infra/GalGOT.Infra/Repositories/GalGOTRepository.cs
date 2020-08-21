using GalGOT.Domain.Interface;
using GalGOT.Domain.Entites;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace GalGOT.Infra
{
    public class GalGOTRepository<TEntity> : IGalGOTRepository<TEntity> where TEntity : Casa
    {
        protected readonly Context _contexto;

        public GalGOTRepository(Context context )
        {
            _contexto = context;
        }

        public virtual void Alterar(TEntity entity)
        {
            try
            {
                entity.DataCadastro = DateTime.Now;
                _contexto.Set<TEntity>().Update(entity);
                _contexto.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception(e.InnerException.Message);
            }
        }

        public void Dispose()
        {
            _contexto.Dispose();
        }

        public async Task Excluir(int id)
        {
            try
            {
                var entity = SelecionarPorId(id);
                _contexto.Set<TEntity>().Remove(entity);

                await _contexto.SaveChangesAsync();
            }
            catch (Exception e)
            {
                throw new Exception(e.InnerException.Message);
            }
        }

        public void Incluir(TEntity entity)
        {
            try
            {
                entity.DataCadastro = DateTime.Now;
                _contexto.Set<TEntity>().Add(entity);
                _contexto.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception(e.InnerException.Message);
            }
        }

        public virtual TEntity SelecionarPorId(int id)
        {
            try
            {
                return _contexto.Set<TEntity>()
                .AsNoTracking()
                .FirstOrDefault(e => e.CasaId == id);

            }
            catch (Exception e)
            {
                throw new Exception(e.InnerException.Message);
            }
        }

        public List<TEntity> SelecionarTudo()
        {
            return _contexto.Set<TEntity>()
                    .ToList();                    
        }
    }
}
