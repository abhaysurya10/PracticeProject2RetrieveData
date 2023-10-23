using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetrieveStudData
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                FileStream fs = new FileStream(@"C:\Users\ADMIN\source\repos\RetrieveStudData\StudData\StudDataFile.txt", FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                try
                {
                    string file_data = sr.ReadToEnd();
                    Console.WriteLine(file_data);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    sr.Close();
                    fs.Close();
                    sr.Dispose();
                    fs.Dispose();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}
