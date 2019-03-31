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
    class Find_Repair
    {
        public static List<String> Find_Repair_Query(string Repair_Number)
        {
            //connection to database
            var client = new MongoClient("mongodb+srv://Damir:Bea27yee1989.@cluster0-szzlz.mongodb.net/test?retryWrites=true");
            var database = client.GetDatabase("OneC_JRM");
            var collection = database.GetCollection<JSON.Repair_JSON>("Repairs");

            //this is a list to hold the values from the database to be validated against user input.
            var myresultDoc = collection.Find(new BsonDocument()).ToList();
            //foreach loop checking the values in the database and passing them to variables further down.
            foreach (var myitem in myresultDoc)
            {
                string Repair = myitem.Repair_Number.ToString();
                List<String> res = new List<string>();
                             

                if (Repair == Repair_Number)
                {
                    res.Add("Repair Number: " + myitem.Repair_Number);
                    res.Add("Category: " + myitem.Category);
                    res.Add("Condition: " + myitem.Condition);
                    res.Add("Work Required: " + myitem.Work_Required);
                    res.Add("Notes: " + myitem.Notes);
                    //returns the object corresponding to search query.
                    return res;
                }
            }
            //produces a message box with error if repair was not found.
            MessageBox.Show("There has been an error Finding Your Repair!");
            return null;
        }
    }
}
