using Module7.Final.Server.Abstract.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module7.Final.Server.Delivers.Couriers
{
    internal class CarCourier : abstractCarCurier<int>
    {

        internal CarCourier(string name, string number, int Id)
        {
            _carName = name;
            _numberCar = number;
            _id = Id;
            colorCar = new ColorCar();
        }



        internal class ColorCar
        {
            Random rnd = new Random();
            private string colorcar;
            internal ColorCar()
            {
                int colorIndex = rnd.Next(1, 4);
                if (colorIndex == 1)
                    colorcar = "Красный";
                else if (colorIndex == 2)
                    colorcar = "Синий";
                else if (colorIndex == 3)
                    colorcar = "Зеленый";
            }

            internal string GetColorCar() => colorcar;

        }
    }



}
