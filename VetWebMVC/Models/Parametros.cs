namespace VetWeb
{
    public class Parametros
    {
        public int ParametrosId { get; set; }
        public string FrequenciaCardiaca { get; set; }
        public string FrequenciaRespiratoria { get; set; }
        public string PressaoArterialSistemica { get; set; }
        public string Hematocrito { get; set; }

        public string Leucocitos { get; set; }

        public Parametros(int parametrosId, string frequenciaCardiaca, string frequenciaRespiratoria, string pressaoArterialSistemica, string hematocrito, string leucocitos)
        {
            ParametrosId = parametrosId;
            FrequenciaCardiaca = frequenciaCardiaca;
            FrequenciaRespiratoria = frequenciaRespiratoria;
            PressaoArterialSistemica = pressaoArterialSistemica;
            Hematocrito = hematocrito;
            Leucocitos = leucocitos;
        }
    }
}