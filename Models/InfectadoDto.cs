using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Api.Models
{
    public class InfectadoDto
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public String Id { get; set; }
        public DateTime DataNascimento { get; set; }

        public DateTime DataSintomas { get; set; }

        public string Sexo { get; set; }

        public double Latitude { get; set; }

        public double Longitude { get; set; } 
        
    }
}