using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace omsMongoConsole
{
    public class ordenRequest
    {
        public IMongoCollection<orden>? coleccionDB { get; set; }
        public string? commercial_id { get; set; }
        public string? order_state { get; set; }
        public string? new_order_state { get; set; }

        public orden myOrder { get; set; }

        public ordenRequest(IMongoCollection<orden> _coleccionDB)
        {
            coleccionDB = _coleccionDB;
        }
        public ordenRequest() { }

    }
}
