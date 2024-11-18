class Program
{
     static void Main(string[] args)
    {
        var miEscuela = new Escuela("Escuela Central", "Calle 123", Escuela.TipoDeEscuelaEnum.Escuela);

       /* Console.WriteLine("\n¿Desea registrar un estudiante? (s/n)");
        string respuesta = Console.ReadLine().ToLower();

        while (respuesta == "s")
        {
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
            miEscuela.RegistrarEstudiantes(estudiante);

            Console.WriteLine("\n¿Desea registrar otro estudiante? (s/n)");
            respuesta = Console.ReadLine().ToLower();
        }

        Console.WriteLine("Registro finalizado. Estudiantes registrados:");
        foreach (var est in miEscuela.ListaDeEstudiantes)
        {
            Console.WriteLine($"ID: {est.IdEstudiante}, Nombre: {est.NombreEstudiante}");
        }
*/

         while (true)
        {
            Console.Clear();
            Console.WriteLine("=== Gestión de Escuela ===");
            Console.WriteLine("1. Registrar Estudiante");
            Console.WriteLine("2. Registrar Profesor");
            Console.WriteLine("3. Ver lista de Estudiantes");
            Console.WriteLine("4. Ver lista de Profesores");
            Console.WriteLine("5. Salir");
            Console.Write("Seleccione una opción: ");

            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    RegistrarEstudiante(miEscuela);
                    break;
                case "2":
                    CambirEstatusEstudiante(miEscuela);
                    break;
                case "3":
                    MostrarListaEstudiantes(miEscuela);
                    break;
                case "4":
                    MostrarListaProfesores(miEscuela);
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

    static void CambirEstatusEstudiante(Escuela escuela)
    {
        Console.Clear();
        Console.WriteLine("===Cambio De Estatus Estuidiante===");
        Console.WriteLine("Ingrese El Id Del estudiante que Desea Modificar");
        string idEstudianteEscuela = Console.ReadLine();
        Console.WriteLine("Ingrese El nuevo estatus Del estudiante que Desea Modificar");
        string EstatusEstudianteEscuela = Console.ReadLine();


        Console.WriteLine("En caso de que no recuerde el id precione el 0 luego dele enter Para ver lista de estudiantes");
       MostrarListaEstudiantes(escuela); 
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
}
}
