using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using GalGOT.Domain.Entites;

namespace GalGOT.Aplication.Interface
{
    public interface IGalGOTAppService
    {
        List<Casa> SelecionarTudo();
        Casa SelecionarPorId(int id);
        void Incluir(Casa request);
        void Alterar(Casa request);
        Task Excluir(int id);
        List<Personagem> GetLord(string id);
    }
}
