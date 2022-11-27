using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Самостоятельная_работа_13.Наследование
{
    class Program
    {
        static void Main(string[] args)
        {
            //создаем экземпляр наследуемого класа и вводим данные
            MultiBuilding multiBuilding = new MultiBuilding("ул.Строителей,15", 20, 15, 10, 0);
            Console.WriteLine(multiBuilding.Print());
            Console.ReadKey();
        }
    }
}
