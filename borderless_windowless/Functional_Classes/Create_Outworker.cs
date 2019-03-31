using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;

namespace Jewellery_Repair_Window_2019.Functional_Classes
{
    class Create_Outworker
    {
        public static bool Create_Outworker_Func(string Outworker_Name, string Outworker_Company, string Outworker_Add1, string Outworker_Add2, string Outworker_Postcode, string Outworker_Phone, string Outworker_Mobile, string Outworker_Email, string Outworker_Status)
        {
            //connection to database
            var client = new MongoClient("mongodb+srv://Damir:Bea27yee1989.@cluster0-szzlz.mongodb.net/test?retryWrites=true");
            var database = client.GetDatabase("OneC_JRM");
            var collection = database.GetCollection<BsonDocument>("Outworkers");

            var CreateD = new BsonDocument
            {

                {"Outworker_Name",Outworker_Name},
                {"Outworker_Company",Outworker_Company},
                {"Outworker_Add1",Outworker_Add1},
                {"Outworker_Add2",Outworker_Add2},
                {"Outworker_Postcode",Outworker_Postcode},
                {"Outworker_Phone",Outworker_Phone},
                {"Outworker_Mobile",Outworker_Mobile},
                {"Outworker_Email",Outworker_Email},
                {"Outworker_Status",Outworker_Status}

            };
            collection.InsertOneAsync(CreateD);
            




            return true;
        }
    }
}
