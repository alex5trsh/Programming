using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    class Ring
    {
        private double _innerRadius; 

        private double _outerRadius; 

        public Point2D CenterOfRing { get; set; }

        public double InnerRadius  
        {
            get => _innerRadius;
            set
            {
                Validator.AssertValueInRange(value, OuterRadius, double.MaxValue, "InnerRadius");

                _innerRadius = value;
            }
        }

        public double OuterRadius 
        {
            get => _outerRadius;
            set
            {
                Validator.AssertValueInRange(value, 1, InnerRadius, "OuterRadius" );

                _outerRadius = value;

            }
        }

        private double Area(Ring ring)
        { 
            // Math.PI
            return Math.PI * (ring.OuterRadius * ring.OuterRadius
                - ring.InnerRadius * ring.InnerRadius);
        }

        public Ring(Point2D centerOfRing, int innerRadius, int outerRadius)
        {
            CenterOfRing = centerOfRing;
            InnerRadius = innerRadius;
            OuterRadius = outerRadius;
        }


    }
}
