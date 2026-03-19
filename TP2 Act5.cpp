#include <stdio.h>
#include <stdlib.h>

int main () {
	int NUM1, NUM2, NUM3, NUM4, SUM1, SUM2;
		
	printf("Ingrese el primer numero: ");
  	scanf("%i", &NUM1);
  	
	printf("Ingrese el segundo numero: ");
  	scanf("%i", &NUM2);
  	
	printf("Ingrese el tercer numero: ");
  	scanf("%i", &NUM3);
  	
	printf("Ingrese el cuarto numero: ");
  	scanf("%i", &NUM4);
  	
  	SUM1 = NUM1 + NUM2;
  	
  	SUM2 = NUM3 + NUM4;
  	
  	if (SUM1 > SUM2) {
  			printf("La suma de los primeros 2 numeros es mayor");
  			}else { 
			printf("La suma de los segundos 2 numeros es mayor");
			}
	return 0;
}
