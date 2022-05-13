using System.IO;
using System.Linq;
using System.Text;

namespace doagain_class
{
    public class Program
    {
        static void Main()
        {

            var data = filestream.GetFilestreams();


          // filestream Write 

            string path = @"C:\Users\H0me1\Videos\Data.txt";
            FileStream fs = File.Open(path, FileMode.OpenOrCreate);
            Encoding u8 = Encoding.UTF8;
            
            
            {
                byte[] bytlist = data.SelectMany(x => u8.GetBytes(x.)).ToArray();
                fs.Write(bytlist, 0, bytlist.Length);
                fs.Position = 0;
                

            }
            System.Console.Read();



            //filestream Read 

            //byte[] filelist = new byte[bytlist.Length];
            //for (int i = 0; i < bytlist.Length; i++)
            //{
            //    filelist[i] = (byte)fs.ReadByte();
            //}
            //Console.WriteLine(Encoding.Default.GetString(filelist));
            //fs.Close();
        }
    }
}
