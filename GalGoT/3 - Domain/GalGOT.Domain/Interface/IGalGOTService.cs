using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using GalGOT.Domain.Entites;

namespace GalGOT.Domain.Interface
{
    public interface IGalGOTService
    {
        List<Casa> SelecionarTudo();
        Casa SelecionarPorId(int id);
        void Incluir(Casa request);        
        void Alterar(Casa request);
        Task Excluir(int id);
        
    }
}
