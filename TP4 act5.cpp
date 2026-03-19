#include <stdio.h>

int main (){
	float MAX=0, MIN=1000, TEMP=0;
	printf("Ingrese la temperatura: ");
	scanf("%f", &TEMP); 
	
	while(TEMP <= 100){
		if (TEMP > MAX){
			MAX = TEMP;
			if (TEMP < MIN){
			 	MIN = TEMP;
			}else{
			}
		}
		printf("Ingrese la siguiente temperatura: ");
	 	scanf("%f", &TEMP);
        }
	
	printf("La temperatura maxima es: %.2f\n", MAX);
	printf("La temperatura minima es: %.2f\n", MIN);
	return 0;
	}
