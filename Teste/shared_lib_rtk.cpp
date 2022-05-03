#include "shared_lib_rtk.h"
#include <inttypes.h>
#include <stdio.h>

int Somar(int num1, int num2)
{
    ShowMessage();

    return num1 + num2;
}

extern void ShowMessage()
{
    printf("\n Mensagem!");
}

extern void MostrarEstrutura (estrutura_t est){
    printf("\n Dentro da estrutura!");
    printf("\n ---------------------- ");
    printf("\n %d", est.codigo);
    printf("\n ---------------------- ");
    printf("\n %s", est.nome);
    printf("\n ---------------------- ");
    printf("\n %lu", est.time);
    printf("\n ---------------------- ");
    printf("\n %f", est.sec);
    printf("\n ---------------------- ");
    printf("\n");
    printf("\n");
}