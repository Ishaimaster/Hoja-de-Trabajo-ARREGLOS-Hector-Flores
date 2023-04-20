
public class Program
{
  
    static void FillArray(int[] array) //Llena el arreglo del valor de -1
    {
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = -1;
        }
    }

    static int PositionArray(int[] array)
    {
        int pos = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == -1)
            {
                pos = i;

                break;
            }
        }
        return pos;
    }

    static int Valorminimo(int[] array)
    {
        int val = array[0];

       for(int i = 0; i < array.Length;i++)
        {
            if (array[i] < val)
            {
                val = array[i];
            }
        }
        return val;
    }

    
    





    static void Main(string[] _)
    {
        Console.WriteLine("Hector Jose Flores Pineda");
        Console.WriteLine("Carnet: 1199923");
        Console.WriteLine("-------------");
        Console.WriteLine("EJERCICIO 1");
        Console.WriteLine("-------------");
    
        Console.WriteLine("Inciso A");

        //Inicializacion de las variables
        int[] valores = { 85, 95, 65, 70, 55, 45, 62, 95, 74, 100, 74, 83, 93 };
        int contmult_5 = 0;
        int contadorNumPrimos = 0;
        bool primo = true;

        //Recorrido y evaluacion de numeros primos dentro del arreglo
        for (int i = 0; i < valores.Length; i++)
        {
            for (int j = 2; j < valores[i]; j++)
            {
                if (valores[i] % j != 0)
                {
                    primo = true;
                }
            }
        }

        // Si un numero es primo, aumenta el contador a 1
        if (primo == true)
        {
            contadorNumPrimos++;
        }

        //Creacion de un arreglo con un numero de valores igual al contador
        int[] posNumerosPrimos = new int[contadorNumPrimos];

        FillArray(posNumerosPrimos);

        // Vuelve a validar para conocer la posicion en que esta este valor dentro del arreglo
        for (int i = 0; i < valores.Length; i++)
        {
            for (int j = 2; j < valores[i]; j++)
            {
                if (valores[i] % j != 0)
                {
                    posNumerosPrimos[PositionArray(posNumerosPrimos)] = i;
                }
            }
        }
        //Impresion de la posicion de los numeros primos dentro del arreglo
        Console.WriteLine("Numeros primos");
        for (int i = 0; i < posNumerosPrimos.Length; i++)
        {
            Console.WriteLine("La posicion: " + posNumerosPrimos[i] + " del arreglo contiene un numero primo");
        } 

        Console.Write("\n");
        Console.Write("Presiona Enter para continuar");
        Console.ReadKey();
        Console.Clear();

        Console.WriteLine("Inciso B");
    
        //Recorre el arreglo y valida que el residuo de la division del valor de la posicion del arreglo y 5 sea igual a 0
        for (int i = 0; i < valores.Length; i++)
        {
            if (valores[i] % 5 == 0)
            {
                contmult_5++;
            }

        }

        //Crea un arreglo con un numero de valores , segun el contador de numeros dentro del arreglo que son multiplos de 5
        int[] posNumerosMultiplos_5 = new int[contmult_5];

        FillArray(posNumerosMultiplos_5);

        for (int i = 0; i < valores.Length; i++)
        {
            if (valores[i] % 5 == 0)
            {
                posNumerosMultiplos_5[PositionArray(posNumerosMultiplos_5)] = i;

            }
        }

        Console.WriteLine("Numeros multiplos de 5");
        for (int i = 0; i < posNumerosMultiplos_5.Length; i++)
        {
            Console.WriteLine("La posicion: " + posNumerosMultiplos_5[i] + " del arreglo contiene un numero multiplo de 5");

        }

        Console.Write("\n");
        Console.Write("Presiona Enter para continuar");
        Console.ReadKey();
        Console.Clear();

        Console.WriteLine("Inciso C");

        Console.WriteLine("El valor menor del arreglo es: " + Valorminimo(valores));

        Console.Write("\n");
        Console.Write("Presiona Enter para continuar");
        Console.ReadKey();
        Console.Clear();

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        int[] Vector = new int[20];

        for (int i = 0; i <Vector.Length; i++)
        {
            Random r = new Random();
            Vector[i] = r.Next(0, 20);
        }

        while (true)
        {
        
        Console.WriteLine("EJERCICIO 2");
        Console.WriteLine();
        Console.WriteLine("Elija los intervalos de valores que desea del arreglo");
        Console.WriteLine("1. [0-5]");
        Console.WriteLine("2. [6-10]");
        Console.WriteLine("3. [11-15]");
        Console.WriteLine("4. [16-20]");
        Console.WriteLine("5. Cerrar programa");
        Console.Write("opcion: ");

        int op = Convert.ToInt32(Console.ReadLine());

            HashSet<int> numerosUnicos = new HashSet<int>();

            switch (op)
            {
                case 1:

                 Console.Write("[ ");

                    for (int i = 0; i < Vector.Length; i++)
                    {
                        
                        if (Vector[i] >= 0 && Vector[i] < 6 && !numerosUnicos.Contains(Vector[i]))
                        {
                            numerosUnicos.Add(Vector[i]);
                            Console.Write(Vector[i] + " ");
                            
                            
                        }
                        
                    }
                 Console.Write("]");

                    break;
                case 2:

                    Console.Write("[ ");

                    for (int i = 0; i < Vector.Length; i++)
                    {

                        if (Vector[i] >= 6 && Vector[i] < 11 && !numerosUnicos.Contains(Vector[i]))
                        {
                            numerosUnicos.Add(Vector[i]);
                            Console.Write(Vector[i] + " ");

                        }
                    }

                    Console.Write("]");

                    break;


                case 3:

                    Console.Write("[ ");

                    for (int i = 0; i < Vector.Length; i++)
                    {

                        if (Vector[i] >= 11 && Vector[i] < 16 && !numerosUnicos.Contains(Vector[i]))
                        {
                            numerosUnicos.Add(Vector[i]);
                            Console.Write(Vector[i] + " ");

                        }
                    }

                    Console.Write("]");

                    break;

                case 4:

                    Console.Write("[ ");

                    for (int i = 0; i < Vector.Length; i++)
                    {

                        if (Vector[i] >= 16 && Vector[i] < 20 && !numerosUnicos.Contains(Vector[i]))
                        {
                            numerosUnicos.Add(Vector[i]);
                            Console.Write(Vector[i] + " ");

                        }
                    }

                    Console.Write("]");

                    break;                   
                                               
            } 
          
            Console.ReadKey();
            Console.Clear();
            
            if (op == 5)
            {
                break;
            }





        }


    }
}


        












