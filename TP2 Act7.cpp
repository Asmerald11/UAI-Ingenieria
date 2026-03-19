#include <stdio.h>
#include <stdlib.h>

int main () {
	float SUELDO, VAL;
	int TIEMPO;
		
	printf("Ingrese el valor de las horas: ");
  	scanf("%f", &VAL);
  	
  	printf("Ingrese el tiempo trabajado del empleado: ");
  	scanf("%i", &TIEMPO);
  	
  	
  	if (TIEMPO < 50) {
  			SUELDO = VAL * TIEMPO;
  			}else { if (TIEMPO < 150) {
  			  SUELDO = VAL * TIEMPO + 100;
  			}else { SUELDO = VAL * TIEMPO + 200 ;}
			}
  		printf("El sueldo es: %.2f\n", SUELDO);
	return 0;
}
