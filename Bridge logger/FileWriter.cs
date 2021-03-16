using System.IO;

namespace Bridge_logger
{
    public class FileWriter : IWriter
    {
        public void Write(string text)
        {
            StreamWriter sr = new StreamWriter("FileWriter.txt");
            sr.WriteLine(text);
            sr.Close();
        }
    }
}
