using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace алтер.classes
{
    class Car : Transport
    {
        public override int Id { get { return 0; } }
        public override int Numberofwheels
        {
            get { return 4 ; }
            set { }
        }
        public override string Category { get { return "B"; } }
        public override string Motor
        {
            get => "JKBVFJK";
            set { }
        }

        public override string Print()
        {
            return $"Машина модель:{Model}, Цвет:{Color}, Категория прав:{Category}, Мотор:{Motor}, Скорость{Speed}";
        }
        public Car(string speed, string color, string model)
        {
            Model = model;
            Color = color;
            Speed = speed;
        }
    }
}
