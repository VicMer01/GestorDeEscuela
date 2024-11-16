
public class Escuela
{
     public int ContadorIdEscuela =1; 
     public int IdEscuela {get; set;}
     public string NombreEscuela {get; set;}
     public string DireccionEscuela{get; set;}
     public TipoDeEscuelaEnum TipoDeEscuela {get; set;} 
      public List<Aula> ListaDeAula { get; set; }
      public List<Profesores> ListaDeProfesores { get; set; }
      public List<Estudiantes> ListaDeEstudiantes { get; set; }
      public List<Materia> ListaDeMaterias { get; set; }

    public Escuela (int IdEscuela, string nombreEscuela, string direccionEscuela, TipoDeEscuelaEnum tipoDeEscuela)
    {
        IdEscuela = ContadorIdEscuela ++;
        NombreEscuela = nombreEscuela;
        DireccionEscuela = direccionEscuela;
        ListaDeAula = new List<Aula>();
        ListaDeProfesores = new List<Profesores>();
        ListaDeEstudiantes = new List<Estudiantes>();
        ListaDeMaterias = new List<Materia>();
    }


    public enum TipoDeEscuelaEnum
    {
        Colegio,
        Escuela,
        univerisidad
    }
}