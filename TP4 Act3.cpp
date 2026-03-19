#include <stdio.h>

int main (){
	int POS=0, NEG=0, CER=0, VAL=0;
	char RES=0;
	printf("Ingrese un numero: ");
	RES = scanf("%i", &VAL); 
	
	while(RES == 1){
		if (VAL > 0){
			POS ++;
		} else {if (VAL < 0){
			 	NEG ++;
			}else{
				CER ++;
			}
		}
		printf("Ingrese el siguiente numero: ");
	 	RES = scanf("%i", &VAL);
        }
	
	printf("La cantidad de numeros positivos es: %i\n", POS);
	printf("La cantidad de numeros negativos es: %i\n", NEG);
	printf("La cantidad de ceros es: %i\n", CER);
	return 0;
	}
