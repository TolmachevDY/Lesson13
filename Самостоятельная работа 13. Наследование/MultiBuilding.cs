using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Самостоятельная_работа_13.Наследование
{
    //Создаем наследуемый класс, котрый в свою очередь не может быть унаследован
    sealed class MultiBuilding: Building
    {
        //добавляем поле
        int floors;
        //добавляем свойство
        int Floors
        {
            get
            {
                return floors;
            }
            set
            {
                if (value < 1)
                    floors = 1;
                else
                    floors = value;
            }
        }
        //создаем конструктор, который вызывает базовый конструктор
        public MultiBuilding(string building_address, int building_length, int building_width, int building_height, int floors)
            :base(building_address, building_length, building_width, building_height)
        {
            this.Floors = floors;
        }
        //создаем метод, который обращается к методу базового класса
        public string Print()
        {
            string result = base.Print();
            result += $"\nЭтажность здания - {floors}";
            return result;
        }
    }
}
