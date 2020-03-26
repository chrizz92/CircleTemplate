/*--------------------------------------------------------------
 *				HTBLA-Leonding / Class: <xxxx/xxxx>
 *--------------------------------------------------------------
 *              Name:
 *--------------------------------------------------------------
 * Description:
 *
 *--------------------------------------------------------------
*/

using System;

namespace Geometry
{
    /// <summary>
    /// modeling a simple geometric shape -> circle
    /// </summary>
    public class Circle
    {
        private const double BORDER_LIMIT_X = 90; // fixed border limits - not changeable
        private const double BORDER_LIMIT_Y = 120; // fixed border limits - not changeable

        #region Fields

        private double _x;
        private double _y;
        private double _radius;
        private string _color;
        private bool _visible;

        #endregion Fields

        #region Properties

        // implement properties
        public double Area
        {
            get
            {
                if (_radius <= 0)
                {
                    return 0.0;
                }
                return _radius * _radius * Math.PI;
            }
        }

        public double Circumference
        {
            get
            {
                if (_radius <= 0)
                {
                    return 0.0;
                }
                return 2 * _radius * Math.PI;
            }
        }

        public string Color
        {
            set { _color = value; }
            get { return _color; }
        }

        public double Radius
        {
            set { _radius = value; }
            get
            {
                if (_radius < 0)
                {
                    return 0;
                }
                return _radius;
            }
        }

        public bool Visible
        {
            set { _visible = value; }
            get { return _visible; }
        }

        public double X
        {
            set { _x = value; }
            get { return _x; }
        }

        public double Y
        {
            set { _y = value; }
            get { return _y; }
        }

        #endregion Properties

        #region Constructor

        public Circle()
        {
            _x = 1;
            _y = 1;
            _radius = 1;
        }

        public Circle(double x, double y, double radius)
        {
            _x = x;
            _y = y;
            _radius = radius;
        }

        public Circle(double x, double y, double radius, string color, bool visible)
        {
            _x = x;
            _y = y;
            _radius = radius;
            _color = color;
            _visible = visible;
        }

        #endregion Constructor

        #region Methods

        /// <summary>
        /// calculates distances of the current circle object to the reference circle
        /// </summary>
        /// <param name="otherCircle"></param>
        /// <returns>distance of two circles</returns>
        public double GetGapTo(Circle otherCircle)
        {
            double catheteOne = this.X - otherCircle.X;
            double catheteTwo = this.Y - otherCircle.Y;
            double hypotenuse = Math.Sqrt((catheteOne * catheteOne) + (catheteTwo * catheteTwo));
            double gap = hypotenuse - this.Radius - otherCircle.Radius;

            if (gap < 0)
            {
                gap = 0;
            }

            return gap;
        }

        /// <summary>
        /// tests whether two circles overlapping
        /// </summary>
        /// <param name="otherCircle"></param>
        /// <returns>true if circles overlap</returns>
        public bool IsOverlappingWith(Circle otherCircle)
        {
            double catheteOne = this.X - otherCircle.X;
            double catheteTwo = this.Y - otherCircle.Y;
            double hypotenuse = Math.Sqrt((catheteOne * catheteOne) + (catheteTwo * catheteTwo));
            double gap = hypotenuse - this.Radius - otherCircle.Radius;

            if (gap < 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// compares size of current object to a reference circle
        /// </summary>
        /// <param name="other"></param>
        /// <returns>true if current object is bigger</returns>
        public bool IsBigger(Circle other)
        {
            if (this.Radius <= other.Radius)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// moves circle to a new position, if the borderlines
        /// are not violated. the borderlines may be touched.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public bool MoveTo(double x, double y)
        {
            //private const double BORDER_LIMIT_X = 90; // fixed border limits - not changeable
            //private const double BORDER_LIMIT_Y = 120; // fixed border limits - not changeable
            if ((x + _radius) <= 90 && (y + _radius) <= 120)
            {
                this.X = x;
                this.Y = y;
                return true;
            }
            else
            {
                return false;
            }
        }

        #endregion Methods
    }
}