public class Estudiantes
{
    
    public int IdEstudiante { get; set; }
    public string NombreEstudiante { get; set; }
    public string DireccionEstudiante { get; set; }
    public string EdadEstudiante { get; set; }
    public SexoEstudianteEnum SexoEstudiante { get; set; }
    public EstatusEstudiantesEnum EstatusEstudiante { get; set; }
    public DateTime FechaIngreso { get; set; }
    public DateTime FechaSalida { get; set; }
    public List<Materia> ListaDeMateriasEstudiante { get; set; }


    public Estudiantes(string nombreEstudiante, string direccionEstudiante, string edadEstudiante,
                SexoEstudianteEnum sexoEstudiante, EstatusEstudiantesEnum estatusEstudiante,
                DateTime fechaIngreso, DateTime fechaSalida)
    {
        
        NombreEstudiante = nombreEstudiante;
        DireccionEstudiante = direccionEstudiante;
        EdadEstudiante = edadEstudiante;
        SexoEstudiante = sexoEstudiante;
        EstatusEstudiante = estatusEstudiante;
        FechaIngreso = fechaIngreso;
        FechaSalida = fechaSalida;
        ListaDeMateriasEstudiante = new List<Materia>();
    }



    public enum EstatusEstudiantesEnum
    {
        Activo,
        Inactivo
    }
    public enum SexoEstudianteEnum
    {
        Masculino,
        Femenino,
        Otos
    }
}