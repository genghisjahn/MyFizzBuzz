using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public class FizzBuzzProcessor
    {
        List<FizzBuzzItem> fbitems;

        public FizzBuzzProcessor(List<FizzBuzzItem> fzbzitems)
        {
            fbitems = fzbzitems;
        }

        public string ItemMessage(int number)
        {
            string result = "";
            foreach (var i in fbitems.OrderBy(c => c.OrderCheck))
            {
                bool setMessage = true;
                foreach (var m in i.Multiples)
                {
                    if (number % m != 0)
                    {
                        setMessage = false;
                        break;
                    }
                }
                if (setMessage)
                {
                    result = i.Message;
                    break;
                }
                else
                {
                    result = number.ToString();
                }
            }
            return result;
        }
    }
}
