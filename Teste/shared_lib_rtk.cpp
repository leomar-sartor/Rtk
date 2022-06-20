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

extern int MostrarEstruturaComArray (snrmask_t snrmask){

    int sizeEnaUm = sizeof snrmask.ena[0];
    int sizeEnaDois = sizeof snrmask.ena[1];
    int sizeEnaTres = sizeof snrmask.ena[2];
    int TotalEna = sizeof snrmask.ena;

    int sizeMaskUm = sizeof snrmask.mask[0];
    int sizeMaskDois = sizeof snrmask.mask[1];
    int sizeMaskTres = sizeof snrmask.mask[2];
    int totalMask = sizeof snrmask.mask;

    printf("TAMANHO ENA %u  \n", sizeEnaUm);
    printf("TAMANHO ENA %u  \n", sizeEnaDois);
    printf("TOTAL ENA %u  \n", TotalEna);

    printf("TAMANHO MASK %u \n", sizeMaskUm);
    printf("TAMANHO MASK %u \n", sizeMaskDois);
    printf("TAMANHO MASK %u \n", sizeMaskTres);
    printf("TOTAL MASK %u  \n", totalMask);

    int i=0, tam=2;
    while(i<tam){       
        printf ("%10d", snrmask.ena[i]);
        i=i+1;
    }

    printf("\n Dentro da estrutura com Array!");
    // printf("\n ---------------------- ");
    // printf("\n0 => %10d", snrmask->ena[0]);
    // printf("\n1 => %10d", snrmask->ena[1]);
    // printf("\n ---------------------- ");
    printf("\n0 => %10d", snrmask.ena[0]);
    printf("\n1 => %10d", snrmask.ena[1]);
    // printf("\n0 => %10d", snrmask.ena[0]);
    //printf("\n2 => %10d", snrmask.ena[2]);
    printf("\n");
    
    // int i=0, tam=5;
    // static int vet[5];
    // vet[0]=1;
    // vet[1]=2;
    // vet[2]=3;
    // vet[3]=4;
    // vet[4]=5;

    // while(i<tam){
    //     printf ("%d", vet[i]);
    //     i=i+1;
    // }

    printf("\n Matriz \n");

    for (int i =0; i<3; i++) {
        for (int j =0; j<9; j++) {
            printf ("\n %f", snrmask.mask[i][j]);
        }
    }

    // printf("\n ---------------------- ");
    // printf("\n 0|0 %f", snrmask.mask[0][0]);
    // printf("\n 0|1 %f", snrmask.mask[0][1]);
    // printf("\n 0|2 %f", snrmask.mask[0][2]);
    // printf("\n 0|3 %f", snrmask.mask[0][3]);
    // printf("\n 0|4 %f", snrmask.mask[0][4]);
    // printf("\n 0|5 %f", snrmask.mask[0][5]);
    // printf("\n 0|6 %f", snrmask.mask[0][6]);
    // printf("\n 0|7 %f", snrmask.mask[0][7]);
    // printf("\n 0|8 %f", snrmask.mask[0][8]);
    
    // printf("\n");
    // printf("\n 1|0 %5f", snrmask.mask[1][0]);
    // printf("\n 1|1 %5f", snrmask.mask[1][1]);
    // printf("\n 1|2 %5f", snrmask.mask[1][2]);
    // printf("\n 1|3 %5f", snrmask.mask[1][3]);
    // printf("\n 1|4 %5f", snrmask.mask[1][4]);
    // printf("\n 1|5 %5f", snrmask.mask[1][5]);
    // printf("\n 1|6 %5f", snrmask.mask[1][6]);
    // printf("\n 1|7 %5f", snrmask.mask[1][7]);
    // printf("\n 1|8 %5f", snrmask.mask[1][8]);
    
    // printf("\n");
    // printf("\n 2|0 %5f", snrmask.mask[2][0]);
    // printf("\n 2|1 %5f", snrmask.mask[2][1]);
    // printf("\n 2|2 %5f", snrmask.mask[2][2]);
    // printf("\n 2|3 %5f", snrmask.mask[2][3]);
    // printf("\n 2|4 %5f", snrmask.mask[2][4]);
    // printf("\n 2|5 %5f", snrmask.mask[2][5]);
    // printf("\n 2|6 %5f", snrmask.mask[2][6]);
    // printf("\n 2|7 %5f", snrmask.mask[2][7]);
    // printf("\n 2|8 %5f", snrmask.mask[2][8]);

    printf("\n");

    return 429;
}

extern int MostrarEstruturaDentroDeEstruturaPorPonteiro (const prcopt_t *popt){

    printf("\n Dentro da estrutura por Ponteiro!");

    printf("\n Mode %d", popt->mode);

    printf("\n");

    printf("\n Array \n");

    int i=0, tam=2;
    while(i<tam){       
        printf ("%10d", popt->snrmask.ena[i]);
        i=i+1;
    }

    printf("\n Matriz \n");


    for (int i =0; i<3; i++) {
        for (int j =0; j<9; j++) {
            printf ("\n %f", popt->snrmask.mask[i][j]);
        }
    }

    return 430;
}