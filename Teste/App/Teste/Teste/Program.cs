using System;
using System.Runtime.InteropServices;

namespace Teste
{
    //Ponteiro em C# e C++
    //https://www.youtube.com/watch?v=xkfQFYUuE4o

    //https://gist.github.com/erichschroeter/df895f2855af0fc89dd5
    //https://www.c-sharpcorner.com/uploadfile/GemingLeader/marshaling-with-C-Sharp-chapter-2-marshaling-simple-types/
    //https://www.mathworks.com/help/mps/dotnet/marshal-matlab-structures-structs-in-c.html
    //https://www.youtube.com/c/SingletonSean/search?query=MArshal
    //Ler
    //https://pt.stackoverflow.com/questions/161846/como-uma-classe-%C3%A9-organizada-na-mem%C3%B3ria

    class Program
    {
        [DllImport("C:\\Users\\Cliente\\Desktop\\RTKPOST\\Teste\\shared_lib_rtk.dll", CallingConvention = CallingConvention.Cdecl)]
        static extern int Somar(int num1, int num2);

        [DllImport("C:\\Users\\Cliente\\Desktop\\RTKPOST\\Teste\\shared_lib_rtk.dll", CallingConvention = CallingConvention.Cdecl)]
        static extern void MostrarEstrutura(estrutura_t est);

        [DllImport("C:\\Users\\Cliente\\Desktop\\RTKPOST\\Teste\\shared_lib_rtk.dll", CallingConvention = CallingConvention.Cdecl)]
        static extern int MostrarEstruturaComArray(snrmask_t snrmask);

        [DllImport("C:\\Users\\Cliente\\Desktop\\RTKPOST\\Teste\\shared_lib_rtk.dll", CallingConvention = CallingConvention.Cdecl)]
        static extern int MostrarEstruturaDentroDeEstruturaPorPonteiro(ref prcopt_t popt);



        static void Main(string[] args)
        {
            Console.WriteLine("===  INICIANDO APLICAÇÃO  ===");

            //Processar();

            //Arrays();

            EstruturaComPonteiros();


            Console.WriteLine("=== FINALIZANDO APLICAÇÃO ===");
            Console.ReadKey();
        }

        static void Arrays()
        {
            Console.WriteLine("");
            Console.WriteLine($" Arrays");


            snrmask_t snr = new snrmask_t()
            {
                ena = new int[] { 13, 10 },
                mask = new double[,]
                {
                    { 1, 2, 3, 4, 5, 6, 7, 8, 9 },
                    { 10, 11, 12, 13, 14, 15, 16, 17, 18 },
                    { 19, 20, 21, 22, 23, 24, 25, 26, 27 }
                }
            };

            //var registro2 = new snrmask_t();
            //registro2.ena = new int[2] { 9, 9 }; //new int[2];
            //registro2.ena[0] = 9;
            //registro2.ena[1] = 9;

            var retorno = MostrarEstruturaComArray(snr);

            Console.WriteLine($"=> RETORNO: {retorno}");
        }
        static void Processar()
        {
            var retorno = Somar(9, 15);

            Console.WriteLine("");
            Console.WriteLine($" Soma: {retorno}");

            var registro = new estrutura_t();
            registro.codigo = 1;
            registro.nome = "TESTE";
            registro.time = 12;
            registro.sec = 345;

            MostrarEstrutura(registro);
        }

        static void EstruturaComPonteiros()
        {
            var registro = new prcopt_t();
            registro.mode = 19;

            snrmask_t snr = new snrmask_t()
            {
                ena = new int[] { 10, 13 },
                mask = new double[,]
                {
                    { 10, 20, 30, 40, 50, 60, 70, 80, 90 },
                    { 15, 25, 35, 45, 55, 65, 75, 85, 95 },
                    { 17, 27, 37, 47, 57, 67, 77, 87, 100 }
                }
            };

            registro.snrmask = snr;

            var retorno = MostrarEstruturaDentroDeEstruturaPorPonteiro(ref registro);

            Console.WriteLine($"=> RETORNO: {retorno}");
        }
    }


    [StructLayout(LayoutKind.Sequential)]
    struct prcopt_t
    {
        public int mode { get; set; }

        public snrmask_t snrmask { get; set; }
    }

    [StructLayout(LayoutKind.Sequential, Size = 224)]
    struct snrmask_t
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, IidParameterIndex = 0)]
        public int[] ena;

        //3X9=27
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 27, IidParameterIndex = 0)]
        public double[,] mask;
    }

    struct estrutura_t
    {
        public int codigo { get; set; }
        public string nome { get; set; }

        public UInt32 time { get; set; }
        public double sec { get; set; }
    }
}