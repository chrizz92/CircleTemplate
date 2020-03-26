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
        const double BORDER_LIMIT_X = 90; // fixed border limits - not changeable
        const double BORDER_LIMIT_Y = 120; // fixed border limits - not changeable

        #region Fields
        private double _x;
        private double _y;
        private double _radius;

        #endregion

        #region Properties
        // implement properties
        #endregion Properties

        #region Constructor
        // implement constructors
        #endregion Constructor

        #region Methods
        /// <summary>
        /// calculates distances of the current circle object to the reference circle
        /// </summary>
        /// <param name="otherCircle"></param>
        /// <returns>distance of two circles</returns>
        public double GetGapTo(Circle otherCircle)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// tests whether two circles overlapping
        /// </summary>
        /// <param name="otherCircle"></param>
        /// <returns>true if circles overlap</returns>
        public bool IsOverlappingWith(Circle otherCircle)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// compares size of current object to a reference circle
        /// </summary>
        /// <param name="other"></param>
        /// <returns>true if current object is bigger</returns>
        public bool IsBigger(Circle other)
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }
        #endregion Methods
    }
}
