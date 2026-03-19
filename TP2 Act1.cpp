#include <stdio.h>
#include <stdlib.h>

int main () {
	int NUM, VAL;
		
	printf("Ingrese un numero: ");
  	scanf("%i", &NUM);
  	
  	printf("Ingrese otro numero: ");
  	scanf("%i", &VAL);
  	
  	if (NUM == VAL) {
  			printf("Son numeros iguales");
  			}else {
			printf("Son numeros distintos");
			}
	return 0;
}
