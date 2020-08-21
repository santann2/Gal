using GalGOT.Domain.Entites;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GalGOT.Domain.Interface
{
    public interface IAPIOficeFireGalGOT
    {
        List<Personagem> GetLord(string idlord);
    }
}
