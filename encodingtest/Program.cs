using System;
using System.Text;

namespace encodingtest
{
    using static Console;
    class Program
    {
        static void Main(string[] args)
        {
            //var xx = Encoding.GetEncoding(1252);
            //WriteLine(xx.BodyName);
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            var xx = Encoding.GetEncoding("Windows-1252");
            WriteLine(xx.BodyName);
            ReadKey();
        }
    }
}
