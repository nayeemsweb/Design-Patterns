using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Factory.Car;

namespace Factory
{
    public class CarFactory
    {
        public static Car CreateCar(Presets preset)
        {
            if (preset == Presets.Preset1)
            {
                return new Toyota()
                {
                    Color = "Red",
                    Wheels = "Large"
                };
            }
            else if (preset == Presets.Preset2)
            {
                return new BMW()
                {
                    Color = "Blue",
                    Wheels = "Small"
                };
            }
            else
                return null;
        }
    }
}
