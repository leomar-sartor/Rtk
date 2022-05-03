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

/* type definitions ----------------------------------------------------------*/
typedef struct {
    int codigo;
    char *nome;
    time_t time; 
    double sec;
} estrutura_t;

#ifdef BUILD_MY_DLL
    #define SHARED_LIB_RTK __declspec(dllexport)
#else
    #define SHARED_LIB_RTK __declspec(dllimport)
#endif 

extern int SHARED_LIB_RTK Somar(int num1, int num2);
extern void ShowMessage();
extern void SHARED_LIB_RTK MostrarEstrutura(estrutura_t est);

#ifdef __cplusplus
    }
#endif 

#endif 
//end of DLL