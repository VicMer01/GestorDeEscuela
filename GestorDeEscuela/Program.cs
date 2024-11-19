class Program
{
     static void Main(string[] args)
    {
        var miEscuela = new Escuela("Escuela Central", "Calle 123", Escuela.TipoDeEscuelaEnum.Escuela);

        while (true)
        {
            Console.Clear();
            Console.WriteLine("===Gestion de Escuela===");
            Console.WriteLine("===1- Gestion de Estudiante===");
            Console.WriteLine("===2- Gestion de Profesor===");
            Console.WriteLine("===3- Gestion de Materia===");
            Console.WriteLine("===4- Gestion de Aula===");
            Console.WriteLine("===5- Gestion de Expediente===");
            Console.WriteLine("===6- Salir===");

            Console.WriteLine("Selecciona una opcion:");

            string opcion1 = Console.ReadLine();
            switch (opcion1)
            {
                case "1":
                    GestionEstudiante(miEscuela);
                    break;
                case "2":
                    GestionProfesor(miEscuela);
                    break;
                case "3":
                    GestionMateria(miEscuela);
                    break;
                case "4":
                    GestionAula(miEscuela);
                    break;
                case "5":
                    GestionExpediente(miEscuela);
                    break;
                case "6":
                    Console.WriteLine("Saliendo del programa. ¡Adiós!");
                    return;
                default:
                    Console.WriteLine("Opción inválida. Presione Enter para continuar.");
                    Console.ReadLine();
                    break;
            }

        

        static void GestionEstudiante(Escuela escuela)
        {
            while (true)
        {
            Console.Clear();
            Console.WriteLine("=== Gestión de Escuela ===");
            Console.WriteLine("1. Registrar Estudiante");
            Console.WriteLine("2. Cambiar estatus del Estudiante");
            Console.WriteLine("3. Mostrar lista de estudiante");
            Console.WriteLine("4. Asignar materia al estudiante");
            Console.WriteLine("5. Salir");
            Console.Write("Seleccione una opción: ");

            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    RegistrarEstudiante(escuela);
                    break;
                case "2":
                    CambiarEstatusEstudiante(escuela);
                    break;
                case "3":
                    MostrarListaEstudiantes(escuela);
                    break;
                case "4":
                    AsignarMateriaEstudiante(escuela);
                    break;
                case "5":
                    Console.WriteLine("Saliendo del programa. ¡Adiós!");
                    return;
                default:
                    Console.WriteLine("Opción inválida. Presione Enter para continuar.");
                    Console.ReadLine();
                    break;
            }
        }

         static void RegistrarEstudiante(Escuela escuela)
    {
        Console.Clear();
        Console.WriteLine("=== Registrar Estudiante ===");

        Console.Write("Ingrese el nombre del estudiante: ");
        string nombre = Console.ReadLine();

        Console.Write("Ingrese la dirección del estudiante: ");
        string direccion = Console.ReadLine();

        Console.Write("Ingrese la edad del estudiante: ");
        string edad = Console.ReadLine();

        Console.Write("Ingrese el sexo del estudiante (Masculino, Femenino, Otros): ");
        var sexo = Enum.Parse<Estudiantes.SexoEstudianteEnum>(Console.ReadLine(), true);

        Console.Write("Ingrese el estado del estudiante (Activo, Inactivo): ");
        var estado = Enum.Parse<Estudiantes.EstatusEstudiantesEnum>(Console.ReadLine(), true);

        var estudiante = new Estudiantes(nombre, direccion, edad, sexo, estado, DateTime.Now, DateTime.Now);
        escuela.RegistrarEstudiantes(estudiante);

        Console.WriteLine("Estudiante registrado correctamente. Presione Enter para continuar.");
        Console.ReadLine();
    }


    static void CambiarEstatusEstudiante(Escuela escuela)
{
    Console.Clear();
    Console.WriteLine("=== Cambio de Estatus del Estudiante ===");
    
    Console.WriteLine("Ingrese el ID del estudiante que desea modificar:");
    string idEstudiante = Console.ReadLine();
    
    
    if (idEstudiante == "00")
    {
        Console.WriteLine("Lista de estudiantes:");
        MostrarListaEstudiantes(escuela);
        Console.WriteLine("Ingrese nuevamente el ID del estudiante:");
        idEstudiante = Console.ReadLine();
    }

    
    var estudiante = escuela.ListaDeEstudiantes.FirstOrDefault(e => e.IdEstudiante.ToString() == idEstudiante);
    if (estudiante == null)
    {
        Console.WriteLine("El estudiante con el ID proporcionado no existe.");
        return;
    }

    
    Console.WriteLine($"Estudiante seleccionado: {estudiante.NombreEstudiante}");
    Console.WriteLine("Ingrese el nuevo estatus del estudiante: 0-Activo 1-Inactivo");
    var nuevoEstatuss = Enum.Parse<Estudiantes.EstatusEstudiantesEnum>(Console.ReadLine(), true);

    estudiante.EstatusEstudiante = nuevoEstatuss;
    Console.WriteLine($"Estatus del estudiante {estudiante.NombreEstudiante} actualizado a '{nuevoEstatuss}' exitosamente.");
}


    static void MostrarListaEstudiantes(Escuela escuela)
    {
        Console.Clear();
        Console.WriteLine("=== Lista de Estudiantes ===");

        if (escuela.ListaDeEstudiantes.Count == 0)
        {
            Console.WriteLine("No hay estudiantes registrados.");
        }
        else
        {
            foreach (var estudiante in escuela.ListaDeEstudiantes)
            {
                Console.WriteLine($"ID: {estudiante.IdEstudiante}, Nombre: {estudiante.NombreEstudiante}, Edad: {estudiante.EdadEstudiante}, Fecha Ingreso: {estudiante.FechaIngreso}, Estado: {estudiante.EstatusEstudiante}" );
            }
        }

        Console.WriteLine("Presione Enter para continuar.");
        Console.ReadLine();
    }

    static void AsignarMateriaEstudiante(Escuela escuela)
    {
        Console.Clear();
        Console.WriteLine("=== Asignar Materia Al Estudante");
    }
}

  static void GestionProfesor(Escuela escuela)
  {

     while (true)
        {
            Console.Clear();
            Console.WriteLine("=== Gestión de Profesor ===");
            Console.WriteLine("1. Registrar Profesor");
            Console.WriteLine("2. Cambiar estatus del Profesor");
            Console.WriteLine("3. Mostrar lista de Profesor");
            Console.WriteLine("4. Asignar materia al Profesor");
            Console.WriteLine("5. Salir");
            Console.Write("Seleccione una opción: ");

            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    RegistrarProfesor(escuela);
                    break;
                case "2":
                    CambiarEstatusProfesor(escuela);
                    break;
                case "3":
                    MostrarListaProfesores(escuela);
                    break;
                case "4":
                    AsignarMateriaProfesor(escuela);
                    break;
                case "5":
                    Console.WriteLine("Saliendo del programa. ¡Adiós!");
                    return;
                default:
                    Console.WriteLine("Opción inválida. Presione Enter para continuar.");
                    Console.ReadLine();
                    break;
            }
        }

    static void RegistrarProfesor(Escuela escuela)
    {
        Console.Clear();
        Console.WriteLine("=== Registrar Profesor ===");

        Console.Write("Ingrese el nombre del profesor: ");
        string nombre = Console.ReadLine();

        Console.Write("Ingrese la dirección del profesor: ");
        string direccion = Console.ReadLine();

        Console.Write("Ingrese la fecha de ingreso del profesor (YYYY-MM-DD): ");
        DateTime fechaIngreso = DateTime.Parse(Console.ReadLine());

        Console.Write("Ingrese la fecha de salida del profesor (YYYY-MM-DD): ");
        DateTime fechaSalida = DateTime.Parse(Console.ReadLine());

        Console.Write("Ingrese el estado del profesor (Activo, Inactivo): ");
        var estado = Enum.Parse<Profesores.EstatusProfesorEnum>(Console.ReadLine(), true);

        var profesor = new Profesores(nombre, direccion, fechaIngreso, fechaSalida, estado);
        escuela.RegistrarProfesor(profesor);

        Console.WriteLine("Profesor registrado correctamente. Presione Enter para continuar.");
        Console.ReadLine();
    }

    

    static void MostrarListaProfesores(Escuela escuela)
    {
        Console.Clear();
        Console.WriteLine("=== Lista de Profesores ===");

        if (escuela.ListaDeProfesores.Count == 0)
        {
            Console.WriteLine("No hay profesores registrados.");
        }
        else
        {
            foreach (var profesor in escuela.ListaDeProfesores)
            {
                Console.WriteLine($"ID: {profesor.IdProfesor}, Nombre: {profesor.NombreProfesor}, Fecha Ingreso: {profesor.FechaIngresoProfesor}");
            }
        }

        Console.WriteLine("Presione Enter para continuar.");
        Console.ReadLine();
    }

    static void CambiarEstatusProfesor(Escuela escuela)
    {

    }

    static void AsignarMateriaProfesor(Escuela escuela)
    {
        
    }
  }

    static void GestionMateria(Escuela escuela)
  {

  }

  static void GestionAula(Escuela escuela)
  {

  }
  static void GestionExpediente(Escuela escuela)
  {

  }   

         

    
    static void AgregarMaterias(Escuela escuela)
    {
        Console.Clear();
        Console.WriteLine("=== Agregar Materia ===");

        Console.WriteLine("Nombre de la Materia");
        string NombreMateriaes= Console.ReadLine();

        Console.Write("Ingrese el estado de la materia (Activo, Inactivo): ");
        var estado = Enum.Parse<Materia.EstatusMateriaEnum>(Console.ReadLine(), true);

        var materia = new Materia (NombreMateriaes , estado);
        escuela.RegistrarMateria(materia);

        Console.WriteLine("Materia registrada correctamente. Presione Enter para continuar.");
        Console.ReadLine();
       

    }
    
    }
}
}
