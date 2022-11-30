namespace VetWeb
{
    public class Parametros
    {
        public string FrequenciaCardiaca { get; set; }
        public string FrequenciaRespiratoria { get; set; }
        public string PressaoArterialSistemica { get; set; }
        public string Hematocrito { get; set; }

        public string Leucocitos { get; set; }

        public Parametros(string frequenciaCardiaca, string frequenciaRespiratoria, string pressaoArterialSistemica, string hematocrito, string leucocitos)
        {
            FrequenciaCardiaca = frequenciaCardiaca;
            FrequenciaRespiratoria = frequenciaRespiratoria;
            PressaoArterialSistemica = pressaoArterialSistemica;
            Hematocrito = hematocrito;
            Leucocitos = leucocitos;
        }
    }
}