namespace Empleados
{
    struct Empleado
    {
        public double salarioBase, comision;

        public Empleado(int salarioBase, int comision)
        {
            this.salarioBase = salarioBase;

            this.comision = comision;
        }

        public override string ToString()
        {
            return string.Format("Salario y comision del empleado {0}, {1}", this.salarioBase, this.comision);
        }

        public void CambiaSalario(Empleado emp, double incremento)
        {
            emp.salarioBase += incremento;

        }

        public void CambiaComision(Empleado emp, double incremento)
        {
            emp.comision += incremento;

        }
    }
}
