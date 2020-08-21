using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using GalGOT.Domain.Util;


namespace GalGOT.Domain.Entites
{
    public class GalGOTEntite
    {
    }
    public class Casa
    {
        public int CasaId { get; set; }
        [Required]
        [MaxLength(100)]
        public string Nome { get; set; }
        [MaxLength(150)]
        public string Regiao { get; set; }
        public int AnoFundacao { get; set; }
        public DateTime DataCadastro { get; set; }
        public Lord AtualLord { get; set; }
    }

    public class Lord
    {
        public int id { get; set; }
        public string NomeLord { get; set; }
        public List<Temporada> Temporadas { get; set; }
    }

    public class Temporada
    {
        public int IdTemporada { get; set; }

        public string NomeTemporada { get; set; }
    }

    public class Personagem
    {
        public string Url { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Culture { get; set; }
        public string Born { get; set; }
        public string Died { get; set; }
        public string[] Titles { get; set; }
        public string[] Aliases { get; set; }
        public string Father { get; set; }
        public string Mother { get; set; }
        public string Spouse { get; set; }
        public object[] Allegiances { get; set; }
        public object[] Books { get; set; }
        public object[] PovBooks { get; set; }
        public string[] TvSeries { get; set; }
        public string[] PlayedBy { get; set; }

        public string TitleText { get { return GalGoTUtil.GetArrayInString(Titles); } }
        public string AliasText { get { return GalGoTUtil.GetArrayInString(Aliases); } }
        public string TvSeriesText { get { return GalGoTUtil.GetArrayInString(TvSeries); } }
        public string PlayedByText { get { return GalGoTUtil.GetArrayInString(PlayedBy); } }
    }
}
