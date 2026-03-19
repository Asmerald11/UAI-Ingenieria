#include <stdio.h>
#include <math.h>

int main() {
  float num1, num2, Per, Ar, Cat1, Cat2, Cat, Dia;

  printf("Ingrese el lado menor: ");
  scanf("%f", &num1);

  printf("Ingrese el lado mayor: ");
  scanf("%f", &num2);
  
  Per = num1 + num2 + num2 + num1;
  
  Ar = num1 * num2;
  
  Cat1 = num1 * num1;
  
  Cat2 = num2 * num2;
  
  Cat = Cat1 + Cat2;
  
  Dia = sqrt(Cat);
  
  printf("El area es: %.2f\n", Ar);
  
  printf("El perimetro es: %.2f\n", Per);
  
  printf("La diagonal mayor es: %.2f\n", Dia);
  
  return 0;
}
