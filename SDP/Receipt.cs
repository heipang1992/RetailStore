using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDP
{

    public class Receipt
    {
        public int ID { get; set; }
        public string name { get; set; }
        public string model { get; set; }
        public double price { get; set; }
        public int qty { get; set; }
        public string total { get { return string.Format("${0}", price * qty); } }
    }
}
