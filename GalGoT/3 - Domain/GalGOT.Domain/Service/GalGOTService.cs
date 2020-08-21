using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using GalGOT.Domain.Entites;
using GalGOT.Domain.Interface;

namespace GalGOT.Domain.Service
{
    public class GalGOTService: IGalGOTService
    {
        private readonly IGalGOTRepository<Casa> _repo;

        public GalGOTService(IGalGOTRepository<Casa> repo)
        {
            _repo = repo;
        }

        public virtual void Alterar(Casa request)
        {
            _repo.Alterar(request);
        }

        public async Task Excluir(int id)
        {
            await _repo.Excluir(id);
        }

        public virtual void Incluir(Casa entity)
        {
            _repo.Incluir(entity);
        }

        public Casa SelecionarPorId(int id)
        {
            return _repo.SelecionarPorId(id);
        }

        public List<Casa> SelecionarTudo()
        {
            return _repo.SelecionarTudo();
        }
    }
}
