using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace алтер.classes
{
    class Boat : Transport
    {
        public override int Id { get { return 3; } }
        public override string Motor
        {
            get => "BDFLB";
            set { }
        }

        public override string Print()
        {
            return $"Лодка модель:{Model}, Цвет:{Color}, Категория прав:{Category}, Мотор:{Motor}, Скорость{Speed}";
        }
        public Boat(string speed, string color, string model)
        {
            Model = model;
            Color = color;
            Speed = speed;
        }
    }
}
