using System.Collections.Generic;

namespace OralDent.Utils
{
    public static class Servicio
    {
        public static Dictionary<string, int> Servicios = new Dictionary<string, int>();

        static Servicio()
        {
            Servicios.Add("Limpieza", 1000);
            Servicios.Add("Extracción de muela", 1500);
            Servicios.Add("Cirugía", 5000);
            Servicios.Add("Extracción de diente", 400);
            Servicios.Add("Limpieza de caries", 2000);
            Servicios.Add("Implante dental", 10000);
        }
        public static string GetMonto(string tipoServicio) => Servicios[tipoServicio].ToString();
    }
}
