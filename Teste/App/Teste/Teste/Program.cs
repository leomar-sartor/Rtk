using System;
using System.Runtime.InteropServices;

namespace Teste
{
    class Program
    {
        [DllImport("C:\\Users\\Cliente\\Desktop\\RTKPOST\\Teste\\shared_lib_rtk.dll", CallingConvention = CallingConvention.Cdecl)]
        static extern int Somar(int num1, int num2);

        [DllImport("C:\\Users\\Cliente\\Desktop\\RTKPOST\\Teste\\shared_lib_rtk.dll", CallingConvention = CallingConvention.Cdecl)]
        static extern void MostrarEstrutura(estrutura_t est);

        static void Main(string[] args)
        {
            Console.WriteLine("===  INICIANDO APLICAÇÃO  ===");

            Processar();

            Console.WriteLine("=== FINALIZANDO APLICAÇÃO ===");
            Console.ReadKey();
        }

        static void Processar()
        {
            var retorno = Somar(9, 15);

            Console.WriteLine("");
            Console.WriteLine($" Soma: {retorno}");

            Console.WriteLine("");
            var registro = new estrutura_t();
            registro.codigo = 1;
            registro.nome = "TESTE";
            registro.time = 12;
            registro.sec = 345;

            MostrarEstrutura(registro);
        }
    }

    struct estrutura_t
    {
        public int codigo { get; set; }
        public string nome { get; set; }

        public UInt32 time { get; set; }
        public double sec { get; set; }
    }
}
