#include <stdio.h>
#include <math.h>

int main() {
  float num1, suel;

  printf("Ingrese el tiempo trabajado: ");
  scanf("%f", &num1);
  
  suel = num1 * 10;
  
  printf("el sueldo es: %.0f\n", suel);
  
  return 0;
}
