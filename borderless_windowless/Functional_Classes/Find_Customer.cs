using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Driver;
using MongoDB.Bson;

namespace Jewellery_Repair_Window_2019.Functional_Classes
{
    class Find_Customer
    {
        public static List<String> Find_Customer_Query(string Customer_Number)
        {
            //connection to database
            var client = new MongoClient("mongodb+srv://Damir:Bea27yee1989.@cluster0-szzlz.mongodb.net/test?retryWrites=true");
            var database = client.GetDatabase("OneC_JRM");
            var collection = database.GetCollection<JSON.Customer_JSON>("Customers");

            //this is a list to hold the values from the database to be validated against user input.
            var myresultDoc = collection.Find(new BsonDocument()).ToList();
            //foreach loop checking the values in the database and passing them to variables further down.
            foreach (var myitem in myresultDoc)
            {
                string Customer = myitem.Customer_Number.ToString();
                List<String> res = new List<string>();
                             

                if (Customer == Customer_Number)
                {
                    res.Add(myitem.Customer_Number);
                    res.Add(myitem.First_Name);
                    res.Add(myitem.Last_Name);
                    res.Add(myitem.Address1);
                    res.Add(myitem.Address2);
                    res.Add(myitem.Postcode);
                    res.Add(myitem.Phone);
                    res.Add(myitem.Mobile);
                    res.Add(myitem.Email);
                    res.Add(myitem.Contact_Pref);
                    //returns the object corresponding to search query.
                    return res;
                }
            }
            //produces a message box with error if repair was not found.
            MessageBox.Show("There has been an error Finding Your Customer!");
            return null;
        }
    }
}
