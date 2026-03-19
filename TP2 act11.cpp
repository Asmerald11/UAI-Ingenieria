#include <stdio.h>
#include <stdlib.h>

int main () {
	int HORA = 0, CAT = 0, SUEL = 0;
	
	printf("Ingrese las horas trabajadas: ");
  	scanf("%i", &HORA);
  
  	printf("Ingrese la categoria del empleado: ");
  	scanf("%i", &CAT);
  	
  	switch (CAT) {
  		case 1:
  			SUEL = 50 * HORA;
  			printf("El sueldo es: %i\n", SUEL);
  			break;
  		case 2:
  			SUEL = 70 * HORA;
  			printf("El sueldo es: %i\n", SUEL);
  			break;
  		case 3:
  			SUEL = 80 * HORA;
  			printf("El sueldo es: %i\n", SUEL);
  			break;
  		default:
  			printf("Categoria invalida");
  			break;
	  }
	return 0;
}
