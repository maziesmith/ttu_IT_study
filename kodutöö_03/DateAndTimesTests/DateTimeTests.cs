using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DateAndTimesTests {
    [TestClass]
    public class DateTimeTests {
        private DateTime date = DateTime.Now;
        private DateTime customDate = new DateTime(2016, 9, 25, 20, 50, 0, 0, DateTimeKind.Local);

        [TestCategory("Type"), TestMethod]
        public void DateTimeTypeTest() {
            Assert.IsTrue(date.GetType() == typeof(DateTime));
        }

        [TestCategory("Method"), TestMethod]
        public void DateTimeToStringTest() {
            string value = date.ToString();

            Assert.IsTrue(value.GetType() == typeof(string));
        }

        [TestCategory("Method"), TestMethod]
        public void DateTimeToShortDateStringTest() {
            string value = customDate.ToShortDateString();

            Assert.AreEqual("25.09.2016", value);
        }

        [TestCategory("Method"), TestMethod]
        public void DateTimeToShortTimeStringTest() {
            string value = customDate.ToShortTimeString();

            Assert.AreEqual("20:50", value);
        }

        [TestCategory("Method"), TestMethod]
        public void DateTimeToLongDateStringTest() {
            string value = customDate.ToLongDateString();

            Assert.AreEqual("25. september 2016", value);
        }

        [TestCategory("Method"), TestMethod]
        public void DateTimeAddMethodsTest() {
            Assert.AreEqual(2017, customDate.AddYears(1).Year);
            Assert.AreEqual(26, customDate.AddDays(1).Day);
            Assert.AreEqual(10, customDate.AddMonths(1).Month);
        }

        [TestCategory("Get"), TestMethod]
        public void DateTimeGetValuesTest() {
            Assert.AreEqual(2016, customDate.Year);
            Assert.AreEqual(9, customDate.Month);
            Assert.AreEqual(25, customDate.Day);
            Assert.AreEqual(20, customDate.Hour);
            Assert.AreEqual(50, customDate.Minute);
        }
    }

    [TestClass]
    public class TimeSpanTests {
        static private DateTime date1 = new DateTime(2015, 9, 25, 21, 0, 0, 0, DateTimeKind.Local);
        static private DateTime date2 = new DateTime(2016, 9, 25, 21, 0, 0, 0, DateTimeKind.Local);
        private TimeSpan timeDifference = date2 - date1;

        [TestCategory("Type"), TestMethod]
        public void TimeSpanTypeTest () {
            Assert.IsTrue(timeDifference.GetType() == typeof(TimeSpan));
        }

        [TestCategory("Method"), TestMethod]
        public void TimeSpanMethodsTest () {
            bool isLeapYear = true; 
            int days = isLeapYear ? 366 : 365; // 2016 was leap year, otherwise 365 for "normal" years.

            Assert.AreEqual(days, timeDifference.TotalDays); 
            Assert.AreEqual(days * 24, timeDifference.TotalHours);
            Assert.AreEqual(days * 24 * 60, timeDifference.TotalMinutes);
        }
    }
}
