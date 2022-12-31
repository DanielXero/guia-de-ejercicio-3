using System.Runtime.CompilerServices;

namespace Ejercicio_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string opc = string.Empty;
            do
            {
                
                for (int i = 1; i <= 8; i++)
                {
                    Console.WriteLine($"{i}. Ejercicio {i}");
                }
                Console.WriteLine("0. Salir");
                Console.Write("Opción: ");
                opc = Console.ReadLine();

                switch (opc)
                {
                    case "1":
                        Console.Clear();
                        ShowExercise1();
                        Console.Write("Presione cualquier tecla para volver al menú de opciones...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "2":
                        Console.Clear();
                        ShowExercise2();
                        Console.Write("Presione cualquier tecla para volver al menú de opciones...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "3":
                        Console.Clear();
                        ShowExercise3();
                        Console.Write("Presione cualquier tecla para volver al menú de opciones...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "4":
                        Console.Clear();
                        ShowExercise4();
                        Console.Write("Presione cualquier tecla para volver al menú de opciones...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "5":
                        Console.Clear();
                        ShowExercise5();
                        Console.Write("Presione cualquier tecla para volver al menú de opciones...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "6":
                        Console.Clear();
                        ShowExercise6();
                        Console.Write("Presione cualquier tecla para volver al menú de opciones...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "7":
                        Console.Clear();
                        ShowExercise7();
                        Console.Write("Presione cualquier tecla para volver al menú de opciones...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "8":
                        Console.Clear();
                        ShowExercise8();
                        Console.Write("Presione cualquier tecla para volver al menú de opciones...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "0":
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Opción Invalida!!!");
                        Console.Write("Presione cualquier tecla para volver al menú de opciones...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }

            } while (!opc.Equals("0"));
        }

        /*
         1. Dado que se tiene almacenado en una lista, los resultados de los últimos 10
            exámenes de un alumno, calcular su promedio y mostrar por pantalla las 10
            notas de los exámenes y el promedio resultante.
        */
        public static void ShowExercise1()
        {
            double[] listaNotas = { 7.1, 8.3, 7.5, 9.5, 8, 7, 9, 9.2, 10, 9.7 };
            double sumaNotas = 0.0;
            double promedio = 0.0;

            foreach (var item in listaNotas)
            {
                sumaNotas += item;
            }

            promedio = sumaNotas / listaNotas.Length;

            for (int i = 0; i < listaNotas.Length; i++)
            {
                Console.WriteLine($"La nota del {i+1}\u00BA examen es: {listaNotas[i]}");
            }

            Console.WriteLine($"El promedio general de notas del alumno es: {promedio}");

        }

        /*
         2. Dada las edades de 20 personas guardadas en una lista, imprimir por
            pantalla cuántos son mayores de edad y cuántos no.
        */
        public static void ShowExercise2()
        {
            Random rd = new Random();   
            int[] listaEdades = new int[20];
            //int[] listaEdades2 = { 10, 12, 9, 30, 50, 20, 14, 16, 21, 23, 27, 29, 41, 42, 43, 8, 33, 11, 35, 18 };
            int cantidadMayores = 0, cantidadMenores = 0;
            for (int i = 0; i < listaEdades.Length; i++)
            {
                listaEdades[i] = rd.Next(1, 101);

                if (listaEdades[i] >= 18) 
                    cantidadMayores++;
                else 
                    cantidadMenores++;
            }

            for (int i = 0; i < listaEdades.Length; i++)
            {
                Console.WriteLine($"La edad de la {i + 1}\u00BA persona es: {listaEdades[i]}");
            }

            Console.WriteLine($"{cantidadMayores} persona/s son mayores de edad \n{cantidadMenores} persona/s son menores de edad");

        }

        /*
         3. Dado una lista de nombres de estudiantes, imprimir el que tenga más letras, y
            el que tenga menos letras de todos.
        */
        public static void ShowExercise3()
        {
            List<string> listaNombres = new List<string>() { "Juan Jose", "Jorge Luis", "Erika Pamela", "Jessica Janneth", "Juan Andres", "Sofia Veronica", "Jenny Patricia", "Diana Marcela"};
            int countMax = 0;
            int countMin = 0;
            string maxLetras = null;
            string minLetras = null;
            bool isInicializado = false;
            

            foreach (var item in listaNombres)
            {
                if (!isInicializado)
                {
                    countMax = item.Replace(" ", "").Length;
                    countMin = item.Replace(" ", "").Length;
                    maxLetras = item;
                    minLetras = item;
                    isInicializado = true;
                }
                else if(countMax < item.Replace(" ", "").Length)
                {
                    countMax = item.Replace(" ", "").Length;
                    maxLetras = item;
                }
                else if (countMin > item.Replace(" ", "").Length)
                {
                    countMin = item.Replace(" ", "").Length;
                    minLetras = item;
                }

            }

            Console.WriteLine($"El nombre del estudiante con más letras es: {maxLetras}");
            Console.WriteLine($"El nombre del estudiante con menos letras es: {minLetras}");

        }

        /*
         4. Crear una variable para guardar los nombres de elementos para una “lista de
            supermercado”. Solicitar al usuario que ingrese el nombre de un elemento
            que va a comprar en el super y verificar que el elemento esté en la lista. Si no
            está, agregarlo e indicar que no estaba. Si está, quitarlo de la lista, y avisar
            que sí estaba. Al finalizar mostrar por pantalla los elementos que no compró y
            los que compró, pero no estaban en la lista. Si se quiere, mostrar también
            todos los elementos que el usuario compró. Para salir el usuario debe
            ingresar “fin”.
        */
        public static void ShowExercise4()
        {
            List<string> listaProductos = new List<string>() { "Leche", "Arroz", "Azucar", "Cereal", "Gelatina", "Aceite", "Yerba Mate", "Mayonesa",
                                                               "Ketchup", "Detergente", "Cafe", "Jabón", "Shampoo", "Atún", "Queso"};
            List<string> listaProductosQuitados = new List<string>();
            
            List<string> listaNuevosProductos = new List<string>();

            string auxProducto = null;
            string opc = null;
            Console.WriteLine("\t\tSupermercado\n");
            do
            {
                Console.Write("Ingrese el nombre del producto que desea comprar: ");
                string producto = Console.ReadLine();
                //Verificamos
                if (listaProductos.Exists(item => item.Equals(producto, StringComparison.OrdinalIgnoreCase)))
                {
                    auxProducto = listaProductos.Find(item => item.Equals(producto, StringComparison.OrdinalIgnoreCase));
                    listaProductosQuitados.Add(auxProducto);
                          
                    Console.WriteLine($"{auxProducto} se ha quitado de la lista de productos");
                }
                else
                {
                    listaProductos.Add(producto);
                    Console.WriteLine($"{producto} se ha agregado a lista de productos ya que el mismo no estaba");
                    listaNuevosProductos.Add(producto);

                    
                }

                Console.Write("\nIngrese 'fin' para salir o presioner cualquier tecla para continuar...");
                opc = Console.ReadLine();
            } while (!opc.Equals("fin", StringComparison.OrdinalIgnoreCase));

            //Mostrar una lista con los elementos no comprado
            Console.WriteLine("Productos no comprados: ");
            var listaProductosNoComprados = listaProductos.Except(listaNuevosProductos.Concat(listaProductosQuitados));
            foreach (var item in listaProductosNoComprados)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nProductos comprado que no estaban en la lista de compras: ");
            foreach (var item in listaNuevosProductos)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\nLista de todos los productos comprados: ");
            foreach (var item in listaProductosQuitados.Concat(listaNuevosProductos))
            {
                Console.WriteLine(item);
            }


        }

        /*
        5. Crear una matriz de 5 x 5. Almacenar una ‘I’ en lugares impares y una ‘P’ en
           lugares pares. Imprimir la matriz por pantalla
        */
        public static void ShowExercise5()
        {
            char[,] matriz = new char[5, 5];
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if ((i + j) % 2 == 0)
                    {
                        matriz[i, j] = 'P';
                    }
                    else
                    {
                        matriz[i, j] = 'I';
                    }
                }

            }


            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write($"{matriz[i, j]} ");
                }
                Console.WriteLine();

            }

        }

        /*
        6. Se tiene una matriz de 5x7, donde 5 representa la semana de un mes y 7 los
            días de la semana. La estructura es para registrar la temperatura diaria de
            una cabina de pago, estos oscilan entre los 7 y 38 grados. Deberá llenar la
            matriz de forma aleatoria para el mes de mayo donde el primer día inicia en
            lunes y el último (31) se ubica en el miércoles (la matriz puede ser inicializada
            con valores aleatorios desde el principio del programa, no es necesario pedir
            los valores al usuario para cada posición). Se nos pide hacer lo siguiente:
                a. Obtener la temperatura más alta y baja de la semana y que día se produjo (lunes, martes, etc.)
                b. Promedio de temperatura de la semana.
                c. Temperatura más alta del mes y su día.
        */
        public static void ShowExercise6()
        {
            int[,] matriz = new int[5, 7]; 
            Random rd = new Random();
            const int month = 5;
            int daysInMonth = System.DateTime.DaysInMonth(2022, month);
            int auxCount = 0;

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    if (auxCount < daysInMonth)
                    {
                        matriz[i, j] = rd.Next(7, 39);
                        auxCount++;
                    }
                }

            }

            

            int min = 0;
            int max = 0;
            int dayMin = 0;
            int dayMax = 0;
            int sumaTemperatura = 0;
            double promedio = 0;
            int numDiasSemana = 0;
            bool isInicializado = false;
            int auxMaxTemp = 0;
            int auxDayMax = 0;
           

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    if (matriz[i, j] != 0)
                    {
                        if (!isInicializado)
                        {
                            min = matriz[i, j];
                            max = matriz[i, j];
                            dayMax = j + 1;
                            dayMin = j + 1;
                            isInicializado = true;
                        }
                        else if (min > matriz[i, j])
                        {
                            min = matriz[i, j];
                            dayMin = j + 1;
                        }
                        else if (max < matriz[i, j])
                        {
                            max = matriz[i, j];
                            dayMax = j + 1;
                        }
                        sumaTemperatura += matriz[i, j];
                        numDiasSemana++;
                        
                    }

                }
                promedio = sumaTemperatura / (double)numDiasSemana;
                if (auxMaxTemp == 0)
                {
                    auxMaxTemp = max;
                    auxDayMax = dayMax;
                } else if (auxMaxTemp < max)
                {
                    auxMaxTemp = max;
                    auxDayMax = dayMax;
                }

                Console.WriteLine($"{i+1}\u00BA semana");
                Console.WriteLine($"La temperatura más alta de la {i+ 1}\u00BA semana es: {max} y se produjo en el dia {GetDayOfTheWeek(dayMax)}");
                Console.WriteLine($"La temperatura más baja de la {i + 1}\u00BA semana es: {min} y se produjo en el dia {GetDayOfTheWeek(dayMin)}");
                Console.WriteLine($"Promedio de temperatura de la {i+1}\u00BA semana es: {promedio}");
                isInicializado = false;
                dayMax = 0;
                dayMin = 0;
                sumaTemperatura = 0;
                numDiasSemana = 0;
                Console.WriteLine();

            }

            Console.WriteLine($"La temperatura más alta del mes es: {auxMaxTemp} y ocurrio en el dia {GetDayOfTheWeek(auxDayMax)}");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    if (matriz[i, j] != 0)
                    {
                        Console.Write($"{matriz[i, j]} ");
                    }
                    
                }
                Console.WriteLine();

            }

        }

        /*
        7. Almacenar en una matriz las tablas del 1 al 9, teniendo en cuenta que en la
           primera fila y la primera columna se debe guardar los números (de 0 a 9),
           estando el cero en la primera posición (fila 0, columna 0). El resto de los
           lugares debe ser calculado usando los números que se dispone, por ejemplo,
           en la fila 1, calcular 1*1, 1*2, 1*3, etc. usando las posiciones del array o
           arreglo. Al finalizar el cálculo, mostrar la matriz por pantalla
        */
        public static void ShowExercise7()
        {
            int[,] matrizTabla = new int[9, 10];

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    matrizTabla[i, j] = (i + 1) * (j + 1);
                }
            }

            for (int i = 0; i < 9; i++)
            {
                Console.WriteLine($"Tabla del {i+1}");
                for (int j = 0; j < 10; j++)
                {
                    Console.WriteLine($"{i+1} * {j+1} = {matrizTabla[i, j]}");
                }
                Console.WriteLine();
            }
        }

        /*
        8. Crear una matriz de 10 x 10, y “esconder” varias ‘X’ en lugares aleatorios (la
           cantidad que el programador decida, pero no más de la mitad de los lugares
           disponibles en la matriz). El usuario deberá ingresar el lugar donde cree que
           hay una X, ingresando la fila y la columna por separado. Informar si acertó o
           no por cada ingreso. Se debe pedir al usuario ingresar valores por tantas X
           que se haya guardado. El usuario tiene 3 intentos para fallar. Al finalizar (Ya
           sea porque se terminaron los 3 intentos, o el jugador acertó todas las X)
           imprimir por pantalla la matriz con sus correspondientes X, mostrando un *
           donde no haya nada.

        */
        public static void ShowExercise8()
        {
            Random rd = new Random();
            char[,] matriz = new char[10, 10];
            int countD = 0;
            int mitad = (matriz.GetLength(0) * matriz.GetLength(1)) / 2;
            int fila = 0;
            int columna = 0;
            int intentos = 0;
            const int MaxIntentos = 3;
            int aciertos = 0;

            


            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    if (rd.Next(1, 101) % 2 == 0 && countD < mitad)
                    {
                        matriz[i, j] = 'X';
                        countD++;
                    }
                    else
                    {
                        matriz[i, j] = '*';
                    }
                }
            }



            do
            {
                
                fila = GetIntegerDataFromUser("Ingrese el N\u00BA de la fila dónde crees que está la X: ");
                columna = GetIntegerDataFromUser("Ingrese el N\u00BA de la columna dónde crees que está la X: ");
                if (matriz[fila-1, columna-1] != 'X')
                {
                    intentos++;
                }
                else
                {
                    aciertos++;
                }
            } while (intentos < MaxIntentos && aciertos != countD);

            Console.WriteLine("\n");

            if (intentos == MaxIntentos)
            {
                Console.WriteLine("Perdiste se terminaron los intentos disponibles");
            }
            else
            {
                Console.WriteLine("Ganaste acertaste todas las X");
            }
            Console.WriteLine();
            

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine();

            }


        }


        public static string GetDayOfTheWeek(int day) 
        {
            string msg = string.Empty;

            switch (day)
            {
                case 1:
                    msg = "Lunes";
                    break;
                case 2:
                    msg = "Martes";
                    break;
                case 3:
                    msg = "Miercoles";
                    break;
                case 4:
                    msg = "Jueves";
                    break;
                case 5:
                    msg = "Viernes";
                    break;
                case 6:
                    msg = "Sabado";
                    break;
                case 7:
                    msg = "Domingo";
                    break;
            }

            return msg;
        }

        private static int GetIntegerDataFromUser(string message)
        {
            string userData;
            int data = 0;
            bool isDataValid = false;


            while (!isDataValid)
            {
                Console.Write(message);
                userData = Console.ReadLine();

                if (!Int32.TryParse(userData, out data))
                {
                    
                    Console.WriteLine("El dato que ingresaste no es valido. Vuelve a intentarlo");
                }
                else
                {
                    if (data > 0 && data < 11)
                    {
                        isDataValid = true;
                    }
                    else
                    {
                        Console.WriteLine("El valor ingresado está fuera de rango (1..10)");
                    }
                    
                    
                }


            }

            return data;
        }


        
    }
}