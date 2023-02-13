using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson.Serialization.Attributes;

namespace BookStore.Core
{
    public class Book
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string Id {get; set;}

        public string Name {get;set;}

        public double Price {get;set;}

        public string Category {get;set;}

        public string Author {get;set;}
    }
}