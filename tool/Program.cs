using System;

namespace tool
{
    class Program
    {
        static void Main(string[] args)
        {
            var curr = System.Environment.CurrentDirectory;
            var path = System.IO.Directory.GetParent(curr).FullName;
            var ss = $"{path}/data/mca/";
            var dd = $"{path}/src/GB2260/data/";
            var cf = "_mca.gz";
            GZip.Compress(ss, dd, cf);
            ss = $"{path}/data/stats/";
            dd = $"{path}/src/GB2260/data/";
            cf = "_stats.gz";
            GZip.Compress(ss, dd, cf);
            Console.WriteLine("everything is OK.");
            Console.WriteLine("Press Any Key To Exit...");
            Console.ReadKey();
        }
    }
}
