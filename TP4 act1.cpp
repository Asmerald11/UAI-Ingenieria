#include <stdio.h>


int main (){
	int CONT;
	float SUEL, SUM, PROM;
	
	printf("Ingrese el sueldo: ");
	scanf("%f", &SUEL);
	
	while(SUEL != 0){
		SUM = SUM + SUEL;
		CONT ++;
		printf("Ingrese el siguiente sueldo: ");
	    scanf("%f", &SUEL);
	}
	
	PROM = SUM / CONT;
	printf("La suma total es: %.2f\n", SUM);
	printf("El promedio de los sueldos es: %.2f\n", PROM);
	return 0;
}
