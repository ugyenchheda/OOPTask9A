using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTask9A
{
    internal class Client
    {
        public Client(int id, string clientName, Countries country)
        {
            Id = id;
            ClientName = clientName;
            Country = country;
        }

        public int Id { get; set; }
        public string ClientName { get; set; }
        public Countries Country { get; set; }
    }
}
