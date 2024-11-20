public class Materia{
    public static int ContadorIdMateria = 1;
    public int IdMateria {get; set;}
    public string NombreMateria {get; set;}
    public EstatusMateriaEnum EstatusMateria {get; set;}
    

    public Materia(string nombreMateria, EstatusMateriaEnum estatusMateria)
    {
        
        NombreMateria = nombreMateria;
        EstatusMateria = estatusMateria;
    }

    public enum EstatusMateriaEnum
    {
        Activa,
        Inactiva
    }
}