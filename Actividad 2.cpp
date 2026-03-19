#include <stdio.h>
#include <math.h>

int main() {
  int num1, num2, num3, sumap, sumat;

  printf("Ingrese el primer numero: ");
  scanf("%i", &num1);

  printf("Ingrese el segundo numero: ");
  scanf("%i", &num2);
  
  printf("Ingrese el tercer numero: ");
  scanf("%i", &num3);
  
  sumap = num1 + num2;
  
  sumat = sumap + num3;

  printf("el resultado es: %i\n", sumat);
  
  
  return 0;
}
