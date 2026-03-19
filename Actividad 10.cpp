#include <stdio.h>
#include <math.h>

int main() {
  float num1, val, tot, cant, bon, suel;

  printf("Ingrese el valor del vehiculo: ");
  scanf("%f", &val);
  
  printf("¿Cuantos vehiculos de ese tipo vendio?: ");
  scanf("%f", &cant);
  
  tot = val * 0.10 * cant;
  
  bon = cant * 50;
  
  suel = tot + bon + 500;
  
  printf("el sueldo es: %.2f\n", suel);
  
  return 0;
}
