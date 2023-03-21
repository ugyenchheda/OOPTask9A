using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTask9A
{
    internal class PlacedOrder
    {
        public PlacedOrder(int id, int clientId)
        {
            Id = id;
            ClientId = clientId;
        }

        public int Id { get; set; }
        public int ClientId { get; set; }
    }
}
