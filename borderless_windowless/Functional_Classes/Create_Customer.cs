using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;

namespace Jewellery_Repair_Window_2019.Functional_Classes
{
    class Create_Customer
    {
        public static bool Create_Customer_Func(string First_Name, string Last_Name, string Address1, string Addres2, string Postcode, string Phone, string Mobile, string Email, string Contact_Pref)
        {
            //connection to database
            var client = new MongoClient("mongodb+srv://Damir:Bea27yee1989.@cluster0-szzlz.mongodb.net/test?retryWrites=true");
            var database = client.GetDatabase("OneC_JRM");
            var collection = database.GetCollection<BsonDocument>("Customers");

            var CreateD = new BsonDocument
            {

                {"First_Name",First_Name},
                {"Last_Name",Last_Name},
                {"Address1",Address1},
                {"Addres2",Addres2},
                {"Postcode",Postcode},
                {"Phone",Phone},
                {"Mobile",Mobile},
                {"Email",Email},
                {"Contact_Pref",Contact_Pref}

            };
            collection.InsertOneAsync(CreateD);
            // collection.InsertOneAsync(CreateD);




            return true;
        }
    }
}
