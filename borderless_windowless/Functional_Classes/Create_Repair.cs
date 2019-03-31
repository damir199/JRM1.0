using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;

namespace Jewellery_Repair_Window_2019.Functional_Classes
{
    class Create_Repair
    {
        public static bool Create_Repair_Func(string Category, string Condition, string Work_Required, string Notes) {
            //connection to database
            var client = new MongoClient("mongodb+srv://Damir:Bea27yee1989.@cluster0-szzlz.mongodb.net/test?retryWrites=true");
            var database = client.GetDatabase("OneC_JRM");
            var collection = database.GetCollection<BsonDocument>("Repairs");

            var CreateD = new BsonDocument
            {
               
                {"Category",Category},
                {"Condition",Condition},
                {"Work_Required",Work_Required},
                {"Notes",Notes}

            };
            collection.InsertOneAsync(CreateD);
           // collection.InsertOneAsync(CreateD);
           

            
           
            return true;
         }       
        }
    }

