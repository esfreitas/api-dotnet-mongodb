using System;
using MongoDB.Driver.GeoJsonObjectModel;

namespace Api.Data.Collection
{
    public class Infectado
    {
         string id;
        public Infectado( DateTime dataNascimento, DateTime dataSintomas, string sexo, double latitude, double longitude)
        {
           
            this.DataNascimento = dataNascimento;
            this.DataSintomas = dataSintomas; 
            this.Sexo = sexo;
            this.Localizacao = new GeoJson2DGeographicCoordinates(longitude, latitude);
        }

        public DateTime DataNascimento { get; set; }

        public DateTime DataSintomas { get; set; }

        public string Sexo { get; set; }

        public GeoJson2DGeographicCoordinates Localizacao{ get; set;}
        
    }
}