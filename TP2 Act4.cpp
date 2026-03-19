#include <stdio.h>
#include <stdlib.h>

int main () {
    int NUM1, NUM2, NUM3, SUM;
    float PROM;

	printf("Ingrese el primer numero: ");
  	scanf("%i", &NUM1);
  	
	printf("Ingrese el segundo numero: ");
  	scanf("%i", &NUM2);
  	
	printf("Ingrese el tercer numero: ");
  	scanf("%i", &NUM3);
  	
  	SUM = NUM1 + NUM2 + NUM3;
  	
  	PROM = SUM / 3;
  	
  	if (NUM1 > PROM) {
  		if (NUM2 > PROM) {
  			printf("%i y %i son mayores al promedio", NUM1, NUM2);
		  } else { if (NUM3 > PROM) {
		  	printf("%i y %i son mayores al promedio", NUM1, NUM3);
		  } else {
		  	printf("%i es mayor al promedio", NUM1);
		  }
		  }
	  } else { if (NUM2 > PROM) {
	  	if (NUM3 > PROM) {
	  		printf("%i y %i son mayores al promedio", NUM2, NUM3);
		  } else {
		  	printf("%i es mayor al promedio", NUM2);
		  }
	  } else { if (NUM3 > PROM) {
	  	printf("%i es mayor al promedio", NUM3);
	  } else { 
	  	printf("%i, %i y %i son iguales y por ende iguales al promedio", NUM1, NUM2, NUM3);
	  }
	  }	
	  }

}
