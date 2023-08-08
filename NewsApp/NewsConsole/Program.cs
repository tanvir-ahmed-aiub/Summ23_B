using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cat = CategoryService.Get(1);
            Console.WriteLine(cat.Name);
        }
    }
}
