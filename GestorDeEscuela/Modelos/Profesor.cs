public class Profesores{
    public static int ContadorIdProfesor = 1;
    public int IdProfesor {get; set;}
    public string NombreProfesor {get; set;}
    public string DireccionProfesor {get; set;}
    public DateTime FechaIngresoProfesor { get; set; }
    public DateTime FechaSalidaProfesor { get; set; }
    public EstatusProfesorEnum EstatusProfesor {get; set;}
    public List<Materia> MateriasDeProfesor {get; set;}
    public List<Estudiantes> EstudiantesDeProfesor {get; set;}
    public List<Aula> AulaDeProfesor {get; set;}

    public Profesores( string nombreProfesor, string direccionProfesor, DateTime fechaIngresoProfesor, DateTime fechaSalidaProfesor, EstatusProfesorEnum estatusprofesor)
    {
        IdProfesor = ContadorIdProfesor++;
        NombreProfesor = nombreProfesor;
        DireccionProfesor = direccionProfesor;
        EstatusProfesor = estatusprofesor;
        FechaIngresoProfesor = fechaIngresoProfesor ;
        FechaSalidaProfesor = fechaSalidaProfesor;
        MateriasDeProfesor = new List<Materia>();
        EstudiantesDeProfesor = new List<Estudiantes>();
        AulaDeProfesor = new List<Aula>();
    }

    public enum EstatusProfesorEnum
    {
        Activa,
        Inactivo
    }
}