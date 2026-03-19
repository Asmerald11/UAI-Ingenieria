#include <stdio.h>

int main (){
	float MAX, MIN=1000, TIEM;
	int AUTO;
	
	printf("Ingrese el numero de auto: ");
	scanf("%i", &AUTO); 
	
	while(AUTO != 0){
		printf("Ingrese el tiempo de carrera: ");
		scanf("%f", &TIEM); 
		if (TIEM > MAX){
			MAX = TIEM;
			}else{if (TIEM < MIN){
			 	MIN = TIEM;
			}else{
			}
		}
		printf("Ingrese el proximo auto: ");
	 	scanf("%i", &AUTO);
        }
	
	printf("El ganador es: %.2f\n", MIN);
	printf("El ultimo es: %.2f\n", MAX);
	return 0;
	}
