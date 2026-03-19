#include <stdio.h>
#include <stdlib.h>

int main () {
	int i, NUM=0;
	float EVEN=0, ODD=0, PROM=0, SUM=0, SUME=0, SUMO=0, PROME=0, PROMO=0, MAS=0;
	
	for (i=1;i<=8;i++) {
		printf("Ingrese un numero: ");
		scanf("%d", &NUM);
		SUM = SUM + NUM;
		if (NUM > 15) {
			MAS = MAS + 1;
		} else {}
		if (NUM % 2 ==0) {
			EVEN = EVEN + 1;
			SUME = SUME + NUM;
		} else {
			ODD = ODD + 1;
			SUMO = SUMO + NUM;
		}
	}
	PROM = SUM / 8;
	PROME = SUME / EVEN;
	PROMO = SUMO / ODD;
	
	printf("El promedio total es de: %.2f\n", PROM);
	printf("El promedio de los numeros pares es de: %.2f\n", PROME);
	printf("El promedio de los numeros impares es de: %.2f\n", PROMO);
	printf("La cantidad de numeros mayores a 15 es de: %.2f\n", MAS);
	return 0;
}

