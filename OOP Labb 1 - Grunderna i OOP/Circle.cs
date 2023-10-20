using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Labb_1___Grunderna_i_OOP
{
    internal class Circle
    {
        const float _pi = 3.141f;
        int _Radius;

        public Circle(int Radius)
        {
            _Radius = Radius;
        }

        public float getArea() 
        {
           float area =  _Radius * _Radius *_pi;

            return area;
        }

        public float getCircumference() 
        {
            float circumference = _Radius * 2 * _pi;
            return circumference;
        }

        public float getVolume() 
        {
            float volume = (_Radius * _Radius * _Radius * _pi * 4)/3;
            return volume;
        }



    }
}
