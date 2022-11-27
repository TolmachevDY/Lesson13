using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Самостоятельная_работа_13.Наследование
{
    class Building
    {//Задаем поля
        string building_address;
        int building_length;
        int building_width;
        int building_height;
        //Задаем свойства
        string Building_address
        {
            get
            {
                return building_address;
            }
            set
                //Здесь не знаю как задать проверку строки чтобы она соответствовала формату адреса
            {
                if (value == "")
                    Console.WriteLine("Поле адреса не может быть пустым");
                else
                    building_address = value;
            }
        }
        int Building_length
        {
            get
            {
                return building_length;
            }
            set
            {
                if (value < 10)
                    building_length = 10;
                else
                    building_length = value;
            }
        }
        int Building_width
        {
            get
            {
                return building_width;
            }
            set
            {
                if (value < 10)
                    building_width = 10;
                else
                    building_width = value;
            }
        }
        int Building_height
        {
            get
            {
                return building_height;
            }
            set
            {
                if (value < 3)
                    building_height = 3;
                else
                    building_height = value;
            }
        }
        //Создаем конструктор
        public Building(string building_address, int building_length, int building_width, int building_height)
        {
            this.Building_address = building_address;
            this.Building_length = building_length;
            this.Building_width = building_width;
            this.Building_height = building_height;
        }
        //Создаем метод
        public string Print()
        {
            return $"Адресс здания - {building_address}\nДлина здания - {building_length} м\nШирина здания - {building_width} м\nВысота здания - {building_height} м";
        }
    }
}
