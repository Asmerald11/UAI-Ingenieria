#include <stdio.h>
#include <stdlib.h>

int main () {
	int NUM;
		
	printf("Ingrese un numero: ");
  	scanf("%i", &NUM);
  	
  	if (NUM > 0) {
  			printf("El numero es positivo");
  			}else { if (NUM == 0) {
  			printf("El numero es 0");
			  } else {
			printf("El numero es negativo");
			}
	return 0;
}
}

