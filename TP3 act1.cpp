#include <stdio.h>
#include <stdlib.h>


int main (){
	int SUM = 0, i;
	float EDAD = 0, PROM = 0;
	
	for ( i=1; i<=25; i++){
		printf("Ingresar edad: ");
		scanf("%f", &EDAD);
		SUM = SUM + EDAD;
	}
	PROM = SUM/25;
	printf("El promedio es: %f", PROM);
	return 0;
}
