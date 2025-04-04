// Variables
        string respuesta;
        do
        {
            // Arreglo para almacenar la presión sistólica/diastólica de 15 días
            string[] presionArterial = new string[15];
            int diasConPresionAlta = 0;
            double sumaSistolica = 0, sumaDiastolica = 0;
    Console.BackgroundColor = ConsoleColor.Gray;  // Fondo negro
    Console.ForegroundColor = ConsoleColor.Black;  // Texto blanco
    Console.Clear(); 

    // bucle para ingresar los datos de presión para cada uno de los 15 días
    for (int i = 0; i < 15; i++)
            {
                Console.WriteLine($"Ingrese la presión arterial del día {i + 1} (formato: sistólica/diastólica):");
                presionArterial[i] = Console.ReadLine();
                
                // aqui divide los valores ingresados en sistólica y diastólica
                string[] presion = presionArterial[i].Split('/');
                int sistolica = int.Parse(presion[0]);
                int diastolica = int.Parse(presion[1]);
                
                // aqui suma las presiones para el calculo del promedio
                sumaSistolica += sistolica;
                sumaDiastolica += diastolica;

                // aqui muestra la presion de cada dia e indica si es alta o no
                if (sistolica > 140 || diastolica > 90)
                {
                    diasConPresionAlta++;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Día {i + 1}: {presionArterial[i]} - Presión alta.");
                }
                else
                {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Día {i + 1}: {presionArterial[i]} - Presión normal.");
                }
            }

            // aqui calcula el promedio de la presion
            double promedioSistolica = sumaSistolica / 15;
            double promedioDiastolica = sumaDiastolica / 15;
    Console.ForegroundColor = ConsoleColor.Black;
    // aqui lo imprime y lo delimito a dos decimales con F2
    Console.WriteLine($"\nPromedio de presión sistólica: {promedioSistolica:F2}");
            Console.WriteLine($"Promedio de presión diastólica: {promedioDiastolica:F2}");

            // aqui muestra la cantidad de días con presión alta
            Console.WriteLine($"\nCantidad de días con presión alta: {diasConPresionAlta} de 15 días.");

            //aqui mira si el 70% de los días tiene presión alta
            double porcentajePresionAlta = (double)diasConPresionAlta / 15 * 100;
            if (porcentajePresionAlta >= 70)
            {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("\nALERTA: Necesita intervención médica.");
            }

    // aqui pregunta si desea ingresar otro set de datos
    Console.ForegroundColor = ConsoleColor.Black;
    Console.WriteLine("\n¿Desea ingresar otro monitoreo de presión arterial? (si/no):");
            respuesta = Console.ReadLine().ToLower();

        } while (respuesta == "si");
Console.ForegroundColor = ConsoleColor.Black;
Console.WriteLine("Programa finalizado.");