using System;

namespace OralDent.Utils
{
    public class Factura
    {
        public int idPaciente;
        public int idSucursal;
        public string nombrePaciente;
        public string apellidoPaciente;
        public DateTime fecha;
        public string montoTotal;

        public Factura(int idPaciente, int idSucursal)
        {
            this.idPaciente = idPaciente;
            this.idSucursal = idSucursal;
            string[] nombres = DBUtils.GetNameAndLastName(idPaciente);
            nombrePaciente = nombres[0];
            apellidoPaciente = nombres[1];
            fecha = DateTime.Now;
            montoTotal = DBUtils.GetMontoTotal(idPaciente);
        }

        public override string ToString()
        {
            return $"FACTURA:\n" +
                $"MONTO TOTAL A PAGAR: {montoTotal}\n" +
                $"CLIENTE: {nombrePaciente} {apellidoPaciente}\n" +
                $" FACTURADO EL: {fecha}";
        }
    }
}
