using System;
using System.Runtime.InteropServices;

namespace RtkApp
{
    class Program
    {
        
        [DllImport("C:\\Users\\Cliente\\Desktop\\RTKPOST\\Fonte\\src\\postpos.dll", CallingConvention = CallingConvention.Cdecl)]
        static extern int postpos(gtime_t ts);

        static void Main(string[] args)
        {
            Console.WriteLine("===  INICIANDO APLICAÇÃO  ===");

            var time = new gtime_t();
            time.time = 12;
            time.sec = 345;

            int retorno = postpos(time);

            Console.WriteLine("Retorno : " + retorno);

            Console.WriteLine("=== FINALIZANDO APLICAÇÃO ===");
            Console.ReadKey();
        }

        struct gtime_t
        {
            public long time { get; set; }
            public double sec { get; set; }
        }
    }
}
