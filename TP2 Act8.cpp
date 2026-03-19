#include <stdio.h>
#include <stdlib.h>

int main() {
    int DIA = 0, MES = 0, ANIO = 0;

    printf("Ingrese el dia: ");
    scanf("%i", &DIA);

    printf("Ingrese el mes: ");
    scanf("%i", &MES);

    printf("Ingrese el anio: ");
    scanf("%i", &ANIO);

    if (ANIO > 0 && MES > 0 && MES < 13 && DIA > 0) {
        switch (MES) {
            case 1:
            case 3:
            case 5:
            case 7:
            case 8:
            case 10:
            case 12:
                if (DIA <= 31) {
                    printf("Fecha valida.\n");
                } else {
                    printf("Fecha invalida.\n");
                }
                break;
            case 4:
            case 6:
            case 9:
            case 11:
                if (DIA <= 30) {
                    printf("Fecha valida.\n");
                } else {
                    printf("Fecha invalida.\n");
                }
                break;
            case 2:
                if ((ANIO % 4 == 0 && ANIO % 100 != 0) || (ANIO % 400 == 0)) {
                    if (DIA <= 29) {
                        printf("Fecha valida.\n");
                    } else {
                        printf("Fecha invalida.\n");
                    }
                } else {
                    if (DIA <= 28) {
                        printf("Fecha valida.\n");
                    } else {
                        printf("Fecha invalida.\n");
                    }
                }
                break;
        }
    } else {
        printf("Fecha invalida.\n");
    }

    return 0;
}
