using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSort
{
     class ClosingPrice
    {
        static void Main(string[] args)
        {
            Create();
        }
        static public void Create()
        {
            using (var sw = new StreamWriter("ClosingPrice.txt"))
            {
                using (StreamReader sr = new StreamReader("ticker.txt"))
                {
                    string CurrentLinestring = string.Empty;
                    string PrevLineString = string.Empty;
                    string line = string.Empty;

                    while ((line = sr.ReadLine()) != null)
                    {
                        if (line != PrevLineString && !line.All(char.IsNumber))
                        {
                            sw.WriteAsync(PrevLineString);
                            sw.WriteLine(line);
                        }
                        PrevLineString = line;
                    }
                       
                   
                }


            }
        }
    }
}
