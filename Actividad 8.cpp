#include <stdio.h>
#include <math.h>

int main() {
  float num1, num2, prod, res;

  printf("Ingrese el valor de la hora: ");
  scanf("%f", &num1);

  printf("Ingrese las horas trabajadas: ");
  scanf("%f", &num2);
  
  prod = num1 * num2;
  
  printf("el sueldo del operario es: %.2f\n", prod);
  
  return 0;
}
