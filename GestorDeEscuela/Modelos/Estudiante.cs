public class Estudiantes
{
    public int ContadorIdEstudiante =1; 
     public int IdEstudiante {get; set;}
     public string NombreEstudiante {get; set;}
     public string DireccionEstudiante{get; set;}
     public TipoDeEscuelaEnum TipoDeEscuela {get; set;} 
      public List<Aula> ListaDeAula { get; set; }
      public List<Profesores> ListaDeProfesores { get; set; }
      public List<Estudiantes> ListaDeEstudiantes { get; set; }
      public List<Materia> ListaDeMaterias { get; set; }    
}