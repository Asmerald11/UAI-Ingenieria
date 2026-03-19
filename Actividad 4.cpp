#include <stdio.h>
#include <math.h>

int main() {
  int lad1, lad2, lad3, per;

  printf("Ingrese el primer lado: ");
  scanf("%i", &lad1);

  printf("Ingrese el segundo lado: ");
  scanf("%i", &lad2);
  
  printf("Ingrese el tercer lado: ");
  scanf("%i", &lad3);
  
  per = lad1 + lad2 + lad3;

  printf("el resultado es: %i\n", per);
  
  
  return 0;
}
