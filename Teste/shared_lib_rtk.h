#ifndef SHARED_LIB_RTK_H
#define SHARED_LIB_RTK_H

#include <string>
#include <iostream>
#include <cstdlib>
#include <cstdio>
#include <cstring>
#include <array>

using namespace std;

#ifdef __cplusplus
    extern "C" {
#endif 

/* constants -----------------------------------------------------------------*/
#define NFREQ       3                   /* number of carrier frequencies */

/* type definitions ----------------------------------------------------------*/
typedef struct {
    int codigo;
    char *nome;
    time_t time; 
    double sec;
} estrutura_t;

typedef struct {           /* SNR mask type */
    int ena[2];            /* enable flag {rover,base} */
    double mask[NFREQ][9]; /* mask (dBHz) at 5,10,...85 deg */
} snrmask_t;

typedef struct {
    int mode;
    snrmask_t snrmask;
} prcopt_t;

#ifdef BUILD_MY_DLL
    #define SHARED_LIB_RTK __declspec(dllexport)
#else
    #define SHARED_LIB_RTK __declspec(dllimport)
#endif 

extern int SHARED_LIB_RTK Somar(int num1, int num2);
extern void ShowMessage();
extern void SHARED_LIB_RTK MostrarEstrutura(estrutura_t est);
extern int SHARED_LIB_RTK MostrarEstruturaComArray(snrmask_t snrmask);
extern int SHARED_LIB_RTK MostrarEstruturaDentroDeEstruturaPorPonteiro(const prcopt_t *popt);

#ifdef __cplusplus
    }
#endif 

#endif 
//end of DLL