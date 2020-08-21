using System;
using System.Collections.Generic;
using System.Text;
using GalGOT.Aplication.Interface;
using GalGOT.Domain.Entites;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using Xunit;
using Assert = NUnit.Framework.Assert;

namespace GalGOT.UnitTest
{
    [TestClass]
    public class GalGOTUnitTest
    {
        private readonly IGalGOTAppService _galGOTAppService;        
        private Casa _casa;
        private Lord _lord;
        private Temporada _temporada;

        public GalGOTUnitTest (IGalGOTAppService galGOTAppService)
        {
            _galGOTAppService = galGOTAppService;
            _casa = new Casa();


            _casa.CasaId = 1;
            _casa.DataCadastro = DateTime.Now;
            _casa.AnoFundacao = 2020;
            _casa.Nome = "Teste Casa";
            _casa.Regiao = "Teste Regiao";
            _casa.AtualLord = _lord;

            _lord.id = 1;
            _lord.NomeLord = "Teste Lord";
            _lord.Temporadas.Add(_temporada);

            _temporada.IdTemporada = 1;
            _temporada.NomeTemporada = "Teste Tomparada";            
        }

        [NUnit.Framework.Theory]
        [InlineData(0)]
        public void Incluir_Casa_Com_id_zerado(int id)
        {
            Casa request = new Casa()
            {
                CasaId = id,
                AnoFundacao = _casa.AnoFundacao,
                DataCadastro = _casa.DataCadastro,
                Nome = _casa.Nome,
                Regiao = _casa.Regiao,
                AtualLord = _casa.AtualLord
            };

            _galGOTAppService.Incluir(request);

            Assert.Inconclusive();
        }

        [NUnit.Framework.Theory]
        [InlineData("")]
        [InlineData(null)]
        public void Incluir_Casa_Com_nome_vazio_e_nulo(string nome)
        {
            Casa request = new Casa()
            {
                CasaId = _casa.CasaId,
                AnoFundacao = _casa.AnoFundacao,
                DataCadastro = _casa.DataCadastro,
                Nome = nome,
                Regiao = _casa.Regiao,
                AtualLord = _casa.AtualLord
            };

            _galGOTAppService.Incluir(request);

            Assert.Inconclusive();
        }

        [TestMethod]
        public void ConsultarPersonagens(string lord)
        {
            var response = _galGOTAppService.GetLord(lord);
        }
    }
}
