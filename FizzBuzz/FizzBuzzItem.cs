using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public class FizzBuzzItem
    {
        public List<int> Multiples { get; set; }
        public string Message { get; set; }
        public int OrderCheck { get; set; }

        public FizzBuzzItem(){}
        public FizzBuzzItem(List<int> multiple, string message, int ordercheck)
        {
            this.Multiples = multiple;
            this.Message = message;
            this.OrderCheck = ordercheck;
        }
    }
}
