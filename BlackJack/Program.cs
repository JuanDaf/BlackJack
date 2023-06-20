using System;
//Variables del menú
int opt;
bool salir = false;

//Variables para el juego 
Random rdm =  new Random();
var (totalJugador, totalDealer, jugador, coins, victorias) = (0,0,0,0,0);
var (mensaje, continuar) = ("","");

while (salir == false)
{
    Console.WriteLine("Hola bienvenido a la estación...");
    Console.WriteLine("Selecciona la opcion  que desees, solo estoy acá para que te diviertas =#");
    Console.WriteLine("1. Aquí, compra los coins para jugar...");
    Console.WriteLine("2. iniciar el juego");
    Console.WriteLine("3. Revisa tus victorias :3");
    Console.WriteLine("4. Salir");
    opt = Convert.ToInt32(Console.ReadLine());

    switch (opt)
    {
        case 1:
            Console.WriteLine("Ingresa la cantidad de conins que deseas comprar para el juego... ");
            coins = Convert.ToInt32(Console.ReadLine());
            break;
        case 2:
            if (coins > 0)
            {
                Console.WriteLine("Acá empieza el juego...");
                for (int i = 0; i < coins; i++)
                {
                    totalJugador = 0;
                    totalDealer = 0;
                    Console.WriteLine($"Estas jugando tu coin nuemro {i+1}");

                    do
                    {

                        jugador = rdm.Next(1, 11);
                        Console.WriteLine($"Tu carta tiene: {jugador} Jugador");
                        Console.WriteLine("Quieres continar, escribre si");
                        continuar = Console.ReadLine();

                        totalJugador += jugador;
           

                    } while (continuar == "si" || continuar == "s" || continuar == "yes" || continuar == "y");
                    
                    totalDealer = rdm.Next(14, 22);

                    if (totalJugador > 21)
                    {
                        mensaje = "Perdiste, tus cartas suman mas de 21 puntos...";
                    }
                    else if (totalJugador > totalDealer)
                    {
                        mensaje = $"Gnaste con {totalJugador} puntos, el Dealer tenia {totalDealer}";
                        victorias++;
                    }
                    else
                    {
                        mensaje = $"El Dealer a gando con {totalDealer}, y tu tenias {totalJugador}";
                    }

                    Console.WriteLine(mensaje);
                }
                coins = 0;
            }
            else
            {
                Console.WriteLine("No tienes coins para jugar, debes adquirirlos en la opción 1.");
            }
            break;
        case 3:
            Console.WriteLine($"Tu total de victorias es: {victorias}");
            break;
        case 4:
            Console.WriteLine("Adios....");
            salir = true;
            break;
        default:
            Console.WriteLine("Error, verifica que el valor ingresado sea el correcto...");
            break;
    }

    Console.WriteLine("Click para continuar...");
    Console.ReadKey();
}
