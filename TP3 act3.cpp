#include <stdio.h>
#include <stdlib.h>

int main(){
	int i;
	float VAL=0, A=0, B=0, C=0, D=0, PORCA=0, PORCB=0, PORCC=0, PORCD=0;
	
	for (i=1;i<=30;i++){
		printf("Ingresar un valor positivo: ");
		scanf("%f", &VAL);
		
		if (VAL>=1 && VAL<=10){
			A = A + 1;
		} else {if (VAL>=11 && VAL<=20){
			B = B + 1; 
		} else {if (VAL>=21 && VAL<=30){
			C = C + 1;
		} else {if (VAL>30){
			D = D + 1; 
		} else {
			printf("El valor es erroneo \n");
		}
		}
		}
		}
	}
	PORCA = (A*100)/30;
	PORCB = (B*100)/30;
	PORCC = (C*100)/30;
	PORCD = (D*100)/30;
	
	printf("El porcentaje de numeros entre 1 y 10 es de: %.2f\n", PORCA);
	printf("El porcentaje de numeros entre 11 y 20 es de: %.2f\n", PORCB);
	printf("El porcentaje de numeros entre 21 y 30 es de: %.2f\n", PORCC);
	printf("El porcentaje de numeros mayores a 30 es de: %.2f\n", PORCD);
	return 0;
}
