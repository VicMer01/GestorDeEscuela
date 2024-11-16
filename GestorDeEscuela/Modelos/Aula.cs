public class Aula
{
    public int ContadorIdAula =1;
    public int IdAula{get; set;}
    public string NombreAula{get; set;}
    public EstatusAulaEnum EstatusAula{get; set;}

    public Aula(int idAula, string nombreAula, EstatusAulaEnum estatusAula)
    {
        IdAula = ContadorIdAula++;
        NombreAula = nombreAula;
        EstatusAula = estatusAula;
    }

    public enum EstatusAulaEnum
    {
        Activo,
        Inactivo
    }
}