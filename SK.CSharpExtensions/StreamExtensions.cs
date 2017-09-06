using System.IO;
using System.Reflection;

namespace SK.CSharpExtensions
{
    public static class StreamExtensions
    {
        /// <summary>
        /// Writes stream to file & save to specified path or root directory.
        /// </summary>
        /// <param name="inputStream">The input stream.</param>
        /// <param name="fileNameOrFilePath">Name of the file or complete file path.</param>
        /// <param name="overwrightExistingFile">if set to <c>true</c> [overwright existing file].</param>
        /// <exception cref="IOException">File already exists.;-2147024816</exception>
        public static void WriteToFile(this Stream inputStream, string fileNameOrFilePath, bool overwrightExistingFile = false)
        {
            string filePath;
            if (string.IsNullOrEmpty(Path.GetDirectoryName(fileNameOrFilePath)))
            {
                var path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
                if (!path.EndsWith(@"\")) path += @"\";
                filePath = Path.Combine(path, fileNameOrFilePath);
            }
            else
            {
                filePath = fileNameOrFilePath;
            }
            
            if (File.Exists(filePath) && overwrightExistingFile == false)
                throw new IOException("File already exists.", -2147024816); // -2147024816 is HResult value for file already exists

            if (File.Exists(filePath))
                File.Delete(filePath);

            using (FileStream fs = new FileStream(filePath, FileMode.CreateNew, FileAccess.Write))
            {
                inputStream.CopyTo(fs);
            }

            inputStream.Close();
            inputStream.Flush();
        }        
    }
}
