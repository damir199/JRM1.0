using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Jewellery_Repair_Window_2019.JSON
{
    class Create_Repair_JSON
    {
        //this is needed for deserealization
        [BsonRepresentation(BsonType.ObjectId)]
        public string _id { get; set; }
        public string Category { get; set; }
        public string Condition { get; set; }
        public string Work_Required { get; set; }
        public string Notes { get; set; }
    }
}
