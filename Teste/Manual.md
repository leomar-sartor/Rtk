Links Úteis
    1. https://forum.scriptbrasil.com.br/topic/100232-criarrodar-dll-dev-c/
    2. https://www.clubedohardware.com.br/topic/1345237-criando-e-utilizando-dll/
    3. https://www.youtube.com/watch?v=ktbIIvXzypU
    4. https://terminaldeinformacao.com/2015/10/08/como-instalar-e-configurar-o-gcc-no-windows-mingw/
    5. https://social.msdn.microsoft.com/Forums/pt-BR/216a765f-3082-4fd0-bdd7-b90707daa393/erro-dll-daruma

BIBLIOTECA C

    Passo 1: Criar Shared LIB (.h)
    Passo 2: Consumir LIB no C (.cpp)
    Passo 3: Criar o Build (.bat)
        - Vai gerar 3 arquivos
            1. shared_lib_rtk.dll (Arquivo usado no C#)
            2. shared_lib_rtk.o
            3. libshared_lib_rtk.a
    Passo 4: Acessar Prompt De Comando do Windows no Diretório
        -Executar build.bat
            1. build.bat (cria os arquivos descritos anteriormente)

APLICAÇÃO C#

    Passo 1: Criar Projeto (Console Application Core)
    Passo 2: Importar namespace (using System.Runtime.InteropServices;) para usar C;
    Passo 3: Setar o caminho da Bibliotece e declarar o método (Globalmente)
        - [DllImport("C:\\Users\\Cliente\\Desktop\\MinhaDLL\\YouTube\\shared_lib.dll", CallingConvention = CallingConvention.Cdecl)]
        - static extern int somar(int num1, int num2);
    Passo 4: Consumir o método;
    Passo 5: Selecionar ao lado de Debug a opção Gerenciador de Configurações''
        - Selecionar x86
    Passo 6: Rodar aplicação;


