public class Materia{
    public int ContadorIdMateria = 1;
    public int IdMateria {get; set;}
    public string NombreMateria {get; set;}
    public EstatusMateriaEnum EstatusMateria {get; set;}
    

    public Materia(int idMateria, string nombreMateria, EstatusMateriaEnum estatusMateria)
    {
        IdMateria =ContadorIdMateria++;
        NombreMateria = nombreMateria;
        EstatusMateria = estatusMateria;
    }

    public enum EstatusMateriaEnum
    {
        Activa,
        Inactiva
    }
}