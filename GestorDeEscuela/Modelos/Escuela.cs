
public class Escuela
{
    public static int ContadorIdEscuela = 1;
    public int IdEscuela { get; set; }
    public string NombreEscuela { get; set; }
    public string DireccionEscuela { get; set; }
    public TipoDeEscuelaEnum TipoDeEscuela { get; set; }
    public List<Aula> ListaDeAula { get; set; }
    public List<Profesores> ListaDeProfesores { get; set; }
    public List<Estudiantes> ListaDeEstudiantes { get; set; }
    public List<Materia> ListaDeMaterias { get; set; }

    public Escuela(string nombreEscuela, string direccionEscuela, TipoDeEscuelaEnum tipoDeEscuela)
    {
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

    public void RegistrarEstudiantes1(Estudiantes estudiante)
    {
        
        var nuevoEstudiante = new Estudiantes(estudiante.NombreEstudiante, estudiante.DireccionEstudiante,
                                            estudiante.EdadEstudiante, estudiante.SexoEstudiante,
                                            estudiante.EstatusEstudiante, DateTime.Now, DateTime.Now);
        estudiante.IdEstudiante = ContadorIdEscuela++;
        ListaDeEstudiantes.Add(nuevoEstudiante);

        Console.WriteLine($"Estudiante {nuevoEstudiante.NombreEstudiante} con ID {estudiante.IdEstudiante} se agregó correctamente.");
    }

    public void EditarEstatusEstudiante(int EstudianteIdE, Estudiantes.EstatusEstudiantesEnum NuevoEstado)
    {

        Estudiantes? EstudianteEncontrado = ListaDeEstudiantes.Find(t => t.IdEstudiante == EstudianteIdE);
        {
            if (EstudianteEncontrado != null)
            {
                EstudianteEncontrado.EstatusEstudiante = NuevoEstado;
                Console.WriteLine($"Estudiante{EstudianteEncontrado.NombreEstudiante} modificado con exito");
            }
            else
            {
                Console.WriteLine($"Estudiante No encontrado");
            }
        }
    }

    public void RegistrarProfesor(Profesores profesoresE)
    {

        var ProfesorNuevo = new Profesores(profesoresE.NombreProfesor, profesoresE.DireccionProfesor,
        DateTime.Now, DateTime.Now, profesoresE.EstatusProfesor);

        ListaDeProfesores.Add(profesoresE);
        Console.WriteLine($"Profesor {ProfesorNuevo.NombreProfesor} Con Id{ProfesorNuevo.IdProfesor} se agrego correctamente");
    }


    public void RegistrarMateria(Materia materiaE)
    {
        materiaE.IdMateria = ContadorIdEscuela++;

        var MateriaNueva = new Materia(materiaE.NombreMateria, materiaE.EstatusMateria);

        ListaDeMaterias.Add(materiaE);
        Console.WriteLine($"Materia {MateriaNueva.NombreMateria} Con Id{MateriaNueva.IdMateria} se agrego correctamente");
    }

    public void EditarEstatusMateria(int IdmateriaE, Materia.EstatusMateriaEnum NuevoEstado)
    {
        Materia? MateriaEncontrada = ListaDeMaterias.Find(t => t.IdMateria == IdmateriaE);

        if (MateriaEncontrada != null)
        {
            MateriaEncontrada.EstatusMateria = NuevoEstado;

            Console.WriteLine($"Materia{MateriaEncontrada.NombreMateria} modificado con exito");
            }
            else
            {
                Console.WriteLine($"Materia No encontrado");
            }
    }
}


