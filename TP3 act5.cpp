#include <stdio.h>
#include <stdlib.h>

int main (){
	float MULTA=0, TOT=0, MAS=0, PARC=0, PORCENT=0;
	int i;
	char PATENTE [6];
	
	for (i=1;i<=50;i++){
		printf("Ingrese la patente: ");
		scanf("%s", &PATENTE);
		printf("Ingrese el monto de la multa: ");
		scanf("%f", &MULTA);
		TOT = TOT + MULTA;
		if (MULTA > 40) {
			MAS = MAS + 1;
			PARC = PARC + MULTA;
		} else {}
	}
	PORCENT = (PARC*100)/TOT;
	printf("El porcentaje correspondiente a las multas mayores a 40 es de: %.2f\n", PORCENT);
	printf("La cantidad de multas que superan el monto de 40 es: %.2f\n", MAS);
	return 0;
}
