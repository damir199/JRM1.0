using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Jewellery_Repair_Window_2019.JSON
{
    class Outworker_JSON
    {
        [BsonRepresentation(BsonType.ObjectId)]
        public string _id { get; set; }
        public string Outworker_Name { get; set; }
        public string Outworker_Company { get; set; }
        public string Add_Line_1 { get; set; }
        public string Add_Line_2 { get; set; }
        public string Postcode { get; set; }
        public string Phone { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string Status { get; set; }
    }
}
