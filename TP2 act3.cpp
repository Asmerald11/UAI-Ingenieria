#include <stdio.h>
#include <stdlib.h>

int main () {
	int LAD1 = 0, LAD2 = 0, LAD3 = 0;
		
	printf("Ingrese el primer lado: ");
  	scanf("%i", &LAD1);
  	
	printf("Ingrese el segundo lado: ");
  	scanf("%i", &LAD2);
  	
	printf("Ingrese el tercer lado: ");
  	scanf("%i", &LAD3);
  	
  	if (LAD1 == LAD2 && LAD2 == LAD3) {
  			printf("Es un triangulo equilatero");
  			} else { if ( LAD1 == LAD2 && LAD1 != LAD3 || LAD2 == LAD3 && LAD2 != LAD1 || LAD1 == LAD3 && LAD1 != LAD2) {
  				printf("Es un triangulo isoceles");
			  } 
			  else {
			printf("Es un triangulo escaleno");
			}
	return 0;
}
}

