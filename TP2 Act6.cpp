#include <stdio.h>
#include <stdlib.h>

int main () {
	int EDAD1, EDAD2;
	float ALTU1, ALTU2;
		
	printf("Ingrese la altura de la primera persona: ");
  	scanf("%f", &ALTU1);
  	
  	printf("Ingrese la edad de la primera persona: ");
  	scanf(" %i", &EDAD1);
  	
	printf("Ingrese la altura de la segunda persona: ");
  	scanf(" %f", &ALTU2);
  	
  	printf("Ingrese la edad de la segunda persona: ");
  	scanf(" %i", &EDAD2);
  	
  	
  	if (EDAD1 > EDAD2) {
  			printf("La altura es: %.2f\n", ALTU1);
  			}else { 
			printf("La altura es: %.2f\n", ALTU2);
			}
	return 0;
}
