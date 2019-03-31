using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using System.Windows.Forms;
using MongoDB.Driver;

namespace Jewellery_Repair_System.Functional_Classes
{
    class Employee_Login_Val
    {
        public static bool Employee_Login_Auth(string name, string password)
        {
            //connection to database
            var client = new MongoClient("mongodb+srv://Damir:Bea27yee1989.@cluster0-szzlz.mongodb.net/test?retryWrites=true");
            var database = client.GetDatabase("OneC_JRM");
            var collection = database.GetCollection<JSON.Employee_Login>("Users");

            //this is a list to hold the values from the database to be validated against user input.
            var myresultDoc = collection.Find(new BsonDocument()).ToList();
            //foreach loop checking the values in the database and passing them to variables further down.
            foreach (var myitem in myresultDoc)
            {
                string userVal = myitem.Employee_Name.ToString();
                string passVal = myitem.Employee_Password.ToString();
                if (userVal == name && passVal == password)
                {
                    //returns true if validation is passed.
                    return true;
                }
                else
                {
                    //produces a message box with error if validation failed.
                    MessageBox.Show("There has been an error!");
                }
            }
            return false;
        }
    }
}
