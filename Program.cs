WriteLine("Hello, World!");
Empleado empleado1 = new(1200, 500);
empleado1.CambiaSalario(empleado1, 500);
empleado1.CambiaComision(empleado1, 50);
WriteLine(empleado1);
WriteLine($"Total a pagar al empleado: {empleado1.salarioBase + empleado1.comision}");


