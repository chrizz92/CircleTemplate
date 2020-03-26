using Geometry;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestProjectCircle
{
    /// <summary>
    ///This is a test class for CircleTest and is intended
    ///to contain all CircleTest Unit Tests
    ///</summary>
    [TestClass()]
    public class CircleTest
    {
        /// <summary>
        ///A test for Circle Constructor
        ///</summary>
        [TestMethod()]
        public void Constructor_Default_ShouldReturnDefaultValues()
        {
            Circle unitCircle = new Circle();
            Assert.AreEqual(unitCircle.X, 1, 0.01, "Default Kreis hat falsches X");
            Assert.AreEqual(unitCircle.Y, 1, 0.01, "Default Kreis hat falsches Y");
            Assert.AreEqual(unitCircle.Radius, 1, 0.01, "Default Kreis hat falschen Radius");
        }

        [TestMethod()]
        public void Constructor_ParamsXYRadius_ShouldReturnSettedValues()
        {
            double x;
            double y;
            double radius;
            x = 5;
            y = 10;
            radius = 20;
            Circle target = new Circle(x, y, radius);
            Assert.AreEqual(target.X, x, 0.01, "PosX ist falsch zugewiesen");
            Assert.AreEqual(target.Y, y, 0.01, "PosY ist falsch zugewiesen");
            Assert.AreEqual(target.Radius, radius, 0.01, "Radius ist falsch zugewiesen");
        }

        [TestMethod()]
        public void Set_CorrectValue_ShouldReturnSettedX()
        {
            double x;
            double y;
            double radius;
            x = 5;
            y = 10;
            radius = 20;
            Circle target = new Circle(x, y, radius);
            x = 6;
            target.X = x;
            Assert.AreEqual(target.X, x, 0.01, "Ändern von X liefert falsches Ergebnis");
        }

        [TestMethod()]
        public void Constructor_ParameterVisibleFalse_ShouldGetVisibleFalse()
        {
            double x;
            double y;
            double radius;

            Circle unitCircle = new Circle();
            Assert.AreEqual(unitCircle.X, 1, 0.01, "Default Kreis hat falsches X");
            Assert.AreEqual(unitCircle.Y, 1, 0.01, "Default Kreis hat falsches Y");
            Assert.AreEqual(unitCircle.Radius, 1, 0.01, "Default Kreis hat falschen Radius");

            x = 5;
            y = 10;
            radius = 20;
            Circle circleIsInvisible = new Circle(x, y, radius, "gelb", false);
            Assert.IsFalse(circleIsInvisible.Visible, "Kreis ist sichtbar");
        }

        [TestMethod()]
        public void SetVisible_ParameterVisibleFalseThenSettedTrue_ShouldGetVisibleTrue()
        {
            double x;
            double y;
            double radius;

            x = 5;
            y = 10;
            radius = 20;
            Circle circleIsInvisible = new Circle(x, y, radius, "gelb", false);
            Assert.IsFalse(circleIsInvisible.Visible, "Kreis ist sichtbar");
            circleIsInvisible.Visible = true;
            Assert.IsTrue(circleIsInvisible.Visible, "Kreis ist unsichtbar");
        }

        [TestMethod()]
        public void Constructor_ParameterColorYellow_ShouldGetColorYellow()
        {
            double x;
            double y;
            double radius;

            x = 5;
            y = 10;
            radius = 20;
            Circle circle = new Circle(x, y, radius, "gelb", false);
            Assert.AreEqual("gelb", circle.Color);
        }

        /// <summary>
        ///A test for Radius
        ///</summary>
        [TestMethod()]
        public void SetRadius_NegativeValue_GetterShouldReturnZero()
        {
            double x = 5;
            double y = 10;
            double radius = -1;
            Circle target = new Circle(x, y, radius);
            Assert.AreEqual(0, target.Radius, 0.01, "Negativer Radius soll Radius 0 ergeben");
        }

        /// <summary>
        ///A test for Circumference
        ///</summary>
        [TestMethod()]
        public void GetCircumference_ValidValues_ShouldReturnCorrectResult()
        {
            double x = 5;
            double y = 10;
            double radius = 20;
            Circle target = new Circle(x, y, radius);
            Assert.AreEqual(40 * Math.PI, target.Circumference, 0.01, "Umfang stimmt nicht");
        }

        /// <summary>
        ///A test for Circumference
        ///</summary>
        [TestMethod()]
        public void GetCircumference_RadiusZero_ShouldReturnZero()
        {
            double x = 5;
            double y = 10;
            double radius = 0;
            Circle target = new Circle(x, y, radius);
            Assert.AreEqual(0, target.Circumference, 0.01, "Umfang bei Radius 0 ist 0");
        }

        /// <summary>
        ///A test for Circumference
        ///</summary>
        [TestMethod()]
        public void GetCircumference_RadiusNegative_ShouldReturnZero()
        {
            double x = 5;
            double y = 10;
            double radius = 20;
            Circle target = new Circle(x, y, radius);
            target.Radius = -10;
            Assert.AreEqual(0, target.Circumference, 0.01, "Umfang bei negativem Radius 0");
        }

        /// <summary>
        ///A test for Area
        ///</summary>
        [TestMethod()]
        public void Area_CorrectValues_ShouldReturnCorrectArea()
        {
            double x = 5;
            double y = 10;
            double radius = 20;
            Circle target = new Circle(x, y, radius);
            Assert.AreEqual(400 * Math.PI, target.Area, 0.01, "Fläche stimmt nicht");
        }

        [TestMethod()]
        public void Area_RadiusZero_ShouldReturnAreaZero()
        {
            double x = 5;
            double y = 10;
            double radius = 20;
            Circle target = new Circle(x, y, radius);
            target.Radius = 0;
            Assert.AreEqual(0, target.Area, 0.01, "Fläche bei Radius 0 ist 0");
        }

        [TestMethod()]
        public void Area_RadiusNegative_ShouldReturnAreaZero()
        {
            double x = 5;
            double y = 10;
            double radius = 20;
            Circle target = new Circle(x, y, radius);
            target.Radius = -1;
            Assert.AreEqual(0, target.Area, 0.01, "Fläche bei Radius 0 ist 0");
        }

        /// <summary>
        ///A test for GetGap
        ///</summary>
        [TestMethod()]
        public void GetGapTo_TwoCirclesDistance_ShouldReturn5()
        {
            Circle circle = new Circle(0, 0, 10);
            Circle otherCircle = new Circle(20, 0, 5);
            Assert.AreEqual(5, circle.GetGapTo(otherCircle), 0.01, "Einfacher Abstand stimmt nicht");
        }

        [TestMethod()]
        public void GetGapTo_TwoCirclesDistance_ShouldReturn0()
        {
            Circle circle = new Circle(0, 0, 10);
            Circle otherCircle = new Circle(20, 0, 10);
            Assert.AreEqual(0, circle.GetGapTo(otherCircle), 0.01, "Berührung stimmt nicht");
        }

        [TestMethod()]
        public void GetGapTo_TwoCircles_ShouldOverlap()
        {
            Circle circle = new Circle(0, 0, 10);
            Circle otherCircle = new Circle(20, 0, 15);  // einfache Überlappung
            Assert.AreEqual(0, circle.GetGapTo(otherCircle), 0.01, "einfache Überlappung stimmt nicht");
        }

        [TestMethod()]
        public void GetGapTo_TwoCircles_ShouldOverlapCompletely()
        {
            Circle circle = new Circle(0, 0, 10);
            Circle otherCircle = new Circle(0, 0, 10);  // // totale Überlagerung
            Assert.AreEqual(0, circle.GetGapTo(otherCircle), 0.01, "Totale Überlagerung stimmt nicht");
        }

        [TestMethod()]
        public void GetGapTo_TwoCircles45Degrees_ShouldReturnSQRT2()
        {
            Circle circle = new Circle(0, 0, 10 * Math.Sqrt(2));
            Circle otherCircle = new Circle(15, 15, 4 * Math.Sqrt(2));  // 45 Grad
            Assert.AreEqual(Math.Sqrt(2), circle.GetGapTo(otherCircle), 0.01, "Abstand bei 45 Grad stimmt nicht");
        }

        [TestMethod()]
        public void GetGapTo_TwoCircles45DegreesOverlap_ShouldReturn0()
        {
            Circle circle = new Circle(0, 0, 10 * Math.Sqrt(2));
            Circle otherCircle = new Circle(15, 15, 5 * Math.Sqrt(2));  // 45 Grad
            Assert.AreEqual(0, circle.GetGapTo(otherCircle), 0.01, "Berührung bei 45 Grad stimmt nicht");
        }

        [TestMethod()]
        public void GetGapTo_TwoCircles45DegreesOverlapCompletely_ShouldReturn0()
        {
            Circle circle = new Circle(0, 0, 10 * Math.Sqrt(2));
            Circle otherCircle = new Circle(15, 15, 6 * Math.Sqrt(2));  // 45 Grad
            Assert.AreEqual(0, circle.GetGapTo(otherCircle), 0.01, "Überlagerung bei 45 Grad stimmt nicht");
        }

        /// <summary>
        /// tests for size comparing based on radius
        /// </summary>
        [TestMethod()]
        public void IsBigger_CircleBiggerThanReference_ShouldReturnFalse()
        {
            Circle circle = new Circle(0, 0, 10);
            Circle otherCircle = new Circle(5, 7, 10.0000001);
            Assert.IsFalse(circle.IsBigger(otherCircle), "Radius ist größer");
        }

        [TestMethod()]
        public void IsBigger_CircleEqualToReference_ShouldReturnFalse()
        {
            Circle circle = new Circle(0, 0, 10);
            Circle otherCircle = new Circle(5, 7, 10);
            Assert.IsFalse(circle.IsBigger(otherCircle), "Radius ist ungleich");
        }

        [TestMethod()]
        public void IsBigger_CircleBiggerThanReference_ShouldReturnTrue()
        {
            Circle circle = new Circle(0, 0, 10);
            Circle otherCircle = new Circle(5, 7, 9.9999999999);
            Assert.IsTrue(circle.IsBigger(otherCircle), "Radius ist kleiner");
        }

        /// <summary>
        /// tests for staying in a predefined area
        /// </summary>
        [TestMethod()]
        public void MoveTo_CircleTouchBorderLimits_ShouldReturnTrue()
        {
            Circle circle = new Circle(0, 0, 9.5);
            Assert.IsTrue(circle.MoveTo(80.5, 110.5), "Kreis liegt ausserhalb der Grenzen");
        }

        [TestMethod()]
        public void MoveTo_CircleWithinBorderLimits_ShouldReturnTrue()
        {
            Circle circle = new Circle(0, 0, 9.5);
            Assert.IsTrue(circle.MoveTo(0, 0), "Kreis liegt ausserhalb der Grenzen");
        }

        [TestMethod()]
        public void MoveTo_CircleWithNegXNegY_ShouldReturnTrue()
        {
            Circle circle = new Circle(0, 0, 9.5);
            Assert.IsTrue(circle.MoveTo(-5, -10), "Kreis liegt ausserhalb der Grenzen");
        }

        [TestMethod()]
        public void MoveTo_CircleOutOfXBorderLimits_ShouldReturnFalse()
        {
            Circle circle = new Circle(0, 0, 9.5);
            Assert.IsFalse(circle.MoveTo(80.6, 110.5), "Kreis liegt innerhalb der X-Grenze");
        }

        [TestMethod()]
        public void MoveTo_CircleOutOfYBorderLimits_ShouldReturnFalse()
        {
            Circle circle = new Circle(0, 0, 9.5);
            Assert.IsFalse(circle.MoveTo(80.5, 110.6), "Kreis liegt innerhalb der Y-Grenze");
        }
    }
}