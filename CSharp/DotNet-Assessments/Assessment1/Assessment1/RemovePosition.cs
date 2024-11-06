using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment1
{
    class RemovePosition
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CharacterPosition("Python", 1));
            Console.WriteLine(CharacterPosition("Python", 0));
            Console.WriteLine(CharacterPosition("Python", 4));
            Console.Read();
        }
           static  string CharacterPosition(string str , int position)
            {
            if (position < 0 || position >= str.Length)
             {
                return str;
             }
            return str.Remove(position, 1);
            }
        
    }
}
