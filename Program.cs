using Pilas_Colas;

//PILAS

Stack<Alumno> pila = new Stack<Alumno>();

//Apilamos elementos
pila.Push(new Alumno { Id = 1, Nombre = "Julio Pérez", Edad = 21, Carrera = "Desarrollo Software" });
pila.Push(new Alumno { Id = 2, Nombre = "María Jaramillo", Edad = 19, Carrera = "Turismo" });
pila.Push(new Alumno { Id = 3, Nombre = "Pedro Alvarez", Edad = 24, Carrera = "Marketing" });
pila.Push(new Alumno { Id = 4, Nombre = "Alvaro Torres", Edad = 20, Carrera = "Gastronomía" });
pila.Push(new Alumno { Id = 5, Nombre = "Silvia Balboa", Edad = 22, Carrera = "Administración" });

Console.WriteLine("USO DE PILAS\n");

//Mostramos el número de elementos de la pila -> 5
Console.WriteLine(pila.Count);
//Mostramos el nombre del primer elemento de la pila -> Silvia Balboa
Console.WriteLine(pila.Peek().Nombre);
//Mostramos el nombre del primer elemento y lo borramos  -> Silvia Balboa
Console.WriteLine(pila.Pop().Nombre);
//Mostramos el nombre del primer elemento de la pila -> Alvaro Torres (ahora es el primer elemento de la pila)
Console.WriteLine(pila.Peek().Nombre);
//Mostramos el número de elementos de la pila -> 4 (ahora son 4)
Console.WriteLine(pila.Count);

//COLAS

Queue<Alumno> cola = new Queue<Alumno>();

//Ingresamos elementos a la cola
cola.Enqueue(new Alumno { Id = 1, Nombre = "Julio Pérez", Edad = 21, Carrera = "Desarrollo Software" });
cola.Enqueue(new Alumno { Id = 2, Nombre = "María Jaramillo", Edad = 19, Carrera = "Turismo" });
cola.Enqueue(new Alumno { Id = 3, Nombre = "Pedro Alvarez", Edad = 24, Carrera = "Marketing" });
cola.Enqueue(new Alumno { Id = 4, Nombre = "Alvaro Torres", Edad = 20, Carrera = "Gastronomía" });
cola.Enqueue(new Alumno { Id = 5, Nombre = "Silvia Balboa", Edad = 22, Carrera = "Administración" });

Console.WriteLine("\n---------------------\n"); 
Console.WriteLine("USO DE COLAS\n");

//Mostramos el número de elementos de la cola -> 5
Console.WriteLine(cola.Count);
//Mostramos el nombre del primer elemento de la cola -> Julio Pérez
Console.WriteLine(cola.Peek().Nombre);
//Mostramos el nombre del primer elemento y lo borramos  -> Julio Pérez
Console.WriteLine(cola.Dequeue().Nombre);
//Mostramos el nombre del primer elemento de la cola -> María Jaramillo (ahora es el primer elemento de la cola)
Console.WriteLine(cola.Peek().Nombre);
//Mostramos el número de elementos de la cola -> 4 (ahora son 4)
Console.WriteLine(cola.Count);
