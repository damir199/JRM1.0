using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace borderless_windowless.JSON
{
    class Employee_Login
    {
        //this is needed for deserealization
        [BsonRepresentation(BsonType.ObjectId)]
        public string _id { get; set; }
        public string Employee_ID { get; set; }
        public string Employee_Name { get; set; }
        public string Employee_Password { get; set; }

    }
}
