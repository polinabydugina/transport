using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace алтер.classes
{
     class Motocycle : Transport
    {
        public override int Id { get { return 2; } }
        public override int Numberofwheels
        {
            get { return 2; }
            set { }
        }
        public override string Category { get { return "A"; } }
        public override string Motor
        {
            get => "JKGB";
            set { }
        }

        public override string Print()
        {
            return $"Мотоцикл модель:{Model}, Цвет:{Color}, Категория прав:{Category}, Мотор:{Motor}, Скорость{Speed}";
        }
        public Motocycle(string speed, string color, string model)
        {
            Model = model;
            Color = color;
            Speed = speed;
        }
    }
}
