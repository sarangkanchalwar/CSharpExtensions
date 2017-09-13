using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using SK.CSharpExtensions;

namespace SK.ExtensionsTest
{
    [TestClass]
    public class StreamExtensionsUnitTests
    {
        [TestMethod]
        public void WriteToFileTest1()
        {

            var sourceFile = @"D:\test.txt";
            var destinationFile = $@"D:\{Guid.NewGuid()}.txt";
            try
            {
                if (File.Exists(destinationFile)) File.Delete(destinationFile);
                using (Stream stream = File.OpenRead(sourceFile))
                {
                    stream.WriteToFile(destinationFile);
                }
                Assert.IsTrue(File.Exists(destinationFile));
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
            finally
            {
                File.Delete(destinationFile);
            }
        }

        [TestMethod]
        public void WriteToFileTest2()
        {
            var sourceFile = @"D:\test.txt";
            var destinationFile = $@"D:\destination.txt";
            try
            {
                using (Stream stream = File.OpenRead(sourceFile))
                {
                    stream.WriteToFile(destinationFile, true);
                }
                Assert.IsTrue(File.Exists(destinationFile));
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
            finally
            {
                File.Delete(destinationFile);
            }
        }
    }
}
