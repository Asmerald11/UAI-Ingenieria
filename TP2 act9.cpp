#include <stdio.h>
#include <stdlib.h>

int main () {
	int SUEL = 0, ANTI = 0, CAT = 0;
	char RES;
	
	inicio:
		
	printf("Ingrese el sueldo: ");
  	scanf("%i", &SUEL);
  	
  	printf("Ingrese la antigüedad del empleado: ");
  	scanf("%i", &ANTI);
  
  	printf("Ingrese la categoria del empleado: ");
  	scanf("%i", &CAT);
  	
  	
  	if (CAT == 1) {
  			SUEL = SUEL + 50 * ANTI;
  			}else {}
  		printf("El sueldo es: %i\n", SUEL);
    printf("¿Desea ingresar otro empleado? (s/n)\n");
  	scanf(" %c", &RES);
  	if (RES == 's') {
  		goto inicio;
	  } else if (RES == 'n'){
	  } else {
	  	printf("Respuesta no valida.\n");
	  }
	return 0;
}
