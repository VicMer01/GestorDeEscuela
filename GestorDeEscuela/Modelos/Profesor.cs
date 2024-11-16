public class Profesores{
    public int ContadorIdProfesor = 1;
    public int IdProfesor {get; set;}
    public string NombreProfesor {get; set;}
    public string DireccionProfesor {get; set;}
    public EstatusProfesorEnum EstatusProfesor {get; set;}
    public List<Materia> MateriasDeProfesor {get; set;}
    public List<Estudiantes> EstudiantesDeProfesor {get; set;}
    public List<Aula> AulaDeProfesor {get; set;}

    public Profesores(int idProfesor, string nombreProfesor, string direccionProfesor, EstatusProfesorEnum estatusprofesor)
    {
        IdProfesor = ContadorIdProfesor++;
        NombreProfesor = nombreProfesor;
        DireccionProfesor = direccionProfesor;
        EstatusProfesor = estatusprofesor;
    }

    public enum EstatusProfesorEnum
    {
        Activa,
        Inactivo
    }
}