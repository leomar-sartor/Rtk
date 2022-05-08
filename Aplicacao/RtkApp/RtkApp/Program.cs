using System;
using System.Runtime.InteropServices;

namespace RtkApp
{
    class Program
    {
        
        [DllImport("C:\\Users\\Cliente\\Desktop\\RTKPOST\\Fonte\\src\\postpos.dll", CallingConvention = CallingConvention.Cdecl)]
        static extern int postpos(gtime_t ts, gtime_t te, double ti, double tu);

        static void Main(string[] args)
        {
            Console.WriteLine("===  INICIANDO APLICAÇÃO  ===");

            var ts = new gtime_t();
            ts.time = 12;
            ts.sec = 345;

            var te = new gtime_t();
            te.time = 13;
            te.sec = 346;

            int retorno = postpos(ts, te, 347, 348);

            Console.WriteLine("\n\n Retorno : " + retorno);

            Console.WriteLine("\n=== FINALIZANDO APLICAÇÃO ===");
            Console.ReadKey();
        }

        struct gtime_t
        {
            public long time { get; set; }
            public double sec { get; set; }
        }
    }
}
