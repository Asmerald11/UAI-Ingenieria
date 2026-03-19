#include <stdio.h>
#include <math.h>

int main() {
  float num1, num2, Per, Sup, Cat1, Cat2, Cat, Hip;

  printf("Ingrese el lado menor: ");
  scanf("%f", &num1);

  printf("Ingrese el lado mayor: ");
  scanf("%f", &num2);
  
  Cat1 = num1 * num1;
  
  Cat2 = num2 * num2;
  
  Cat = Cat1 + Cat2;
  
  Hip = sqrt(Cat);
  
  Per = num1 + num2 + Hip;
  
  Sup = num1 * num2 * 0.5;
  
  printf("El perimetro es: %.2f\n", Per);
  
  printf("La hipotenusa es: %.2f\n", Hip);
  
  printf("El area es: %.2f\n", Sup);
  
  return 0;
}
