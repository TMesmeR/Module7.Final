using Module7.Final.Server.Delivers.Couriers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module7.Final.Server.Abstract.Classes
{
    internal abstract class abstractCarCurier<T>
    {
        private protected string _carName;
        private protected string _numberCar;
        private protected T _id;
        private protected CarCourier.ColorCar colorCar;
        internal string GetCarName() => _carName;
        internal string GetNumberCar() => _numberCar;

        internal T GetId() => _id;

        internal string CourierCar() => colorCar.GetColorCar();

    }
}
