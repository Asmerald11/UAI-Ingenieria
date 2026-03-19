#include <stdio.h>


int main (){
	int MAS;
	float FACT, SUM;
	
	printf("Ingrese la factura: ");
	scanf("%f", &FACT);
	
	while(FACT != 0){
		SUM = SUM + FACT;
		if (FACT > 1000){
			MAS ++;
		} else {
		}
		printf("Ingrese la siguiente factura: ");
	    scanf("%f", &FACT);
	}
	
	printf("La suma total es: %.2f\n", SUM);
	printf("La cantidad de facturas que superan el valor de 1000 es: %i\n", MAS);
	return 0;
}
