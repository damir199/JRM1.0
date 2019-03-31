using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Jewellery_Repair_Window_2019.JSON
{
    class Create_Customer_JSON
    {
        [BsonRepresentation(BsonType.ObjectId)]
        public string _id { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Postcode { get; set; }
        public string Phone { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string Contact_Pref { get; set; }
    }
}
