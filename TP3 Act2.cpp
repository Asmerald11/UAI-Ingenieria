#include <stdio.h>
#include <stdlib.h>

int main (){
	int POS=0, NEG=0, CER=0, VAL=0, i;
	
	for (i=1;i<=10;i++){
	
	printf("Ingresar un valor: ");
	scanf("%i", &VAL);
	
	if (VAL > 0) {
		POS = POS +1;
	} else { if (VAL < 0){
		NEG = NEG + 1;
	} else {
		CER = CER + 1;
	}
	}
	}
	printf("La cantidad de numeros positivos es de: %i\n", POS);
	printf("La cantidad de numeros negativos es de: %i\n", NEG); 
	printf("La cantidad de ceros es de: %i\n", CER);
	return 0;  
}
