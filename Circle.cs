using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB5_OOP_SamiHarun_NET24
{
    public class Circle
    {
        
            private double _radius;

            // Konstruktor som tar radien som parameter
            public Circle(double radius)
            {
                _radius = radius;
            }

            // Metod som beräknar arean av cirkeln
            public double GetArea()
            {
                return _radius * _radius * Math.PI; // Beräknar arean (π * radie^2)
            }
        }

    }

