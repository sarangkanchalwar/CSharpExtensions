using System;
using System.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SK.CSharpExtensions;

namespace SK.ExtensionsTest
{
    [TestClass]
    public class DataRowExtensionsUnitTests
    {
        static DataTable GetTable()
        {
            // Here we create a DataTable with four columns.
            DataTable table = new DataTable();
            table.Columns.Add("Weight", typeof(int));
            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("IsActive", typeof(bool));
            table.Columns.Add("Date", typeof(DateTime));

            // Here we add five DataRows.
            table.Rows.Add(57, "Koko", true, DateTime.Now);
            table.Rows.Add(130, "Fido", false, DateTime.Now);
            table.Rows.Add(92, "Alex", true, DateTime.Now);
            table.Rows.Add(25, "Charles", true, DateTime.Now);
            table.Rows.Add(7, "Candy", false, DateTime.Now);

            return table;
        }

        [TestMethod]
        public void GetIntTest1()
        {
            var row = GetTable().Rows[0];
            var weight = row.GetInt("Weight");
            Assert.AreEqual(57, weight);
        }

        [TestMethod]
        public void GetIntTest2()
        {
            var row = GetTable().Rows[0];
            var weight = row.GetInt(0);
            Assert.AreEqual(57, weight);
        }

        [TestMethod]
        public void GetIntTest3()
        {
            try
            {
                var row = GetTable().Rows[0];
                var weight = row.GetInt("Name"); // column name targetting non-parsable data
                Assert.Fail();
            }
            catch (Exception exception)
            {
                Assert.AreEqual(typeof(FormatException), exception.GetType());
            }
        }

        [TestMethod]
        public void GetIntTest4()
        {
            try
            {
                var row = GetTable().Rows[0];
                var weight = row.GetInt(1); // column index targetting non-parsable data
                Assert.Fail();
            }
            catch (Exception exception)
            {
                Assert.AreEqual(typeof(FormatException), exception.GetType());
            }
        }

        [TestMethod]
        public void GetIntTest5()
        {
            try
            {
                var row = GetTable().Rows[0];
                var weight = row.GetInt("InvalidParameter"); // invalid parameter name
                Assert.Fail();
            }
            catch (Exception exception)
            {
                Assert.AreEqual(typeof(ArgumentException), exception.GetType());
            }
        }

        [TestMethod]
        public void GetIntTest6()
        {
            try
            {
                var row = GetTable().Rows[0];
                var weight = row.GetInt(4); // Invalid column index
                Assert.Fail();
            }
            catch (Exception exception)
            {
                Assert.AreEqual(typeof(IndexOutOfRangeException), exception.GetType());
            }
        }

        [TestMethod]
        public void GetStringTest1()
        {
            var row = GetTable().Rows[0];
            var result = row.GetString("Name");
            Assert.AreEqual("Koko", result);
        }

        [TestMethod]
        public void GetStringTest2()
        {
            var row = GetTable().Rows[0];
            var result = row.GetString(1);
            Assert.AreEqual("Koko", result);
        }

        [TestMethod]
        public void GetStringTest3()
        {
            try
            {
                var row = GetTable().Rows[0];
                var result = row.GetString("InvalidParameter"); // Invalid column index
                Assert.AreEqual("Koko", result);
            }
            catch (Exception exception)
            {
                Assert.AreEqual(typeof(ArgumentException), exception.GetType());
            }
        }

        [TestMethod]
        public void GetStringTest4()
        {
            try
            {
                var row = GetTable().Rows[0];
                var result = row.GetString(4); // Invalid column index
                Assert.AreEqual("Koko", result);
            }
            catch (Exception exception)
            {
                Assert.AreEqual(typeof(IndexOutOfRangeException), exception.GetType());
            }
        }

        [TestMethod]
        public void GetBoolTest1()
        {
            var row = GetTable().Rows[0];
            var result = row.GetBool("IsActive");
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void GetBoolTest2()
        {
            var row = GetTable().Rows[1];
            var result = row.GetBool(2);
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void GetBoolTest3()
        {
            try
            {
                var row = GetTable().Rows[0];
                var result = row.GetBool("InvalidParameter");
                Assert.Fail();
            }
            catch (Exception exception)
            {
                Assert.AreEqual(typeof(ArgumentException), exception.GetType());
            }
        }

        [TestMethod]
        public void GetBoolTest4()
        {
            try
            {
                var row = GetTable().Rows[0];
                var result = row.GetBool(4);
                Assert.Fail();
            }
            catch (Exception exception)
            {
                Assert.AreEqual(typeof(IndexOutOfRangeException), exception.GetType());
            }
        }
    }
}
