using GalGOT.Aplication.Interface;
using GalGOT.Domain.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using GalGOT.Domain.Entites;

namespace GalGOT.Aplication.AppService
{
    public class GalGOTAppService : IGalGOTAppService
    {
        private readonly IGalGOTService _repo;
        private readonly IAPIOficeFireGalGOT _got;

        public GalGOTAppService(IGalGOTService repo, IAPIOficeFireGalGOT got)
        {
            _repo = repo;
            _got = got;
        }

        public virtual void Alterar(Casa request)
        {
            _repo.Alterar(request);
        }

        public async Task Excluir(int id)
        {
            await _repo.Excluir(id);
        }

        public virtual void Incluir(Casa request)
        {
            _repo.Incluir(request);
        }

        public Casa SelecionarPorId(int id)
        {
            return _repo.SelecionarPorId(id);
        }

        public List<Casa> SelecionarTudo()
        {
            return _repo.SelecionarTudo();
        }

        public List<Personagem> GetLord(string id)
        {
            var response = _got.GetLord(id);
            return response;
        }
    }
}
