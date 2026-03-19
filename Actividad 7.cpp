#include <stdio.h>
#include <math.h>

int main() {
  int num1, num2, suma, prod, res;

  printf("Ingrese el primer numero: ");
  scanf("%i", &num1);

  printf("Ingrese el segundo numero: ");
  scanf("%i", &num2);
  
  suma = num1 + num2;
  
  prod = num1 * num2;
  
  res = num1 - num2;

  printf("el resultado de la suma es: %i\n", suma);
  
  printf("el resultado de la multiplicacion es: %i\n", prod);
  
  printf("el resultado de la resta es: %i\n", res);
  
  
  return 0;
}
