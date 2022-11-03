using System;

namespace SistemaDeRegistros
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] usersNames = new string[10] {"", "", "", "", "", "", "", "", "", "", };
            int currentIndex = 0;
            string usertype;
            char whileRes = 'y';
            char userRes;
            int userResint;
            Console.WriteLine("= Bienvenido, por favor ingresa tu Nombre, para saber tu reservacion =");
            usertype = Convert.ToString(Console.ReadLine());
            int indexToSearch = Array.IndexOf(usersNames, usertype);

           while(whileRes == 'y')
            {
                if (indexToSearch == -1)
                {
                    Console.WriteLine(" Ops no tienes reservacion \n Deseas hacerla?: y/n");
                    userRes = Convert.ToChar(Console.ReadLine());
                    if (userRes == 'y')
                    {
                        usersNames[currentIndex] = usertype;
                        Console.WriteLine($"=== Reservacion hecha con exito, su posicion en la lista es {currentIndex + 1} ===");
                        currentIndex++;
                        indexToSearch = currentIndex;
                     }
                    else
                    {
                        Console.WriteLine("Vuelva pronto");
                        whileRes = 'n';
                    }
                }
                else
                {
                    Console.WriteLine($" Bienvenido {usersNames[0]}" +
                        $"\n Que informacion desea? " +
                        $"\n 1: Mi posicion " +
                        $"\n 2: Lista de reservados" +
                        $"\n 3: Agregar a la lista" +
                        $"\n 4: Salir") ;
                    userResint = Convert.ToInt32(Console.ReadLine());
                    switch(userResint)
                    {
                        case 1:
                            Console.WriteLine($"tu posicion es: {currentIndex}");
                            break;
                        case 2: 
                            for (int i = 0; i < usersNames.Length; i++)
                            {
                                Console.WriteLine("-" + usersNames[i]);
                            }
                            break;
                        case 3:
                            Console.WriteLine("Ingresa el nombre de la persona a agregar: ");
                            usertype = Console.ReadLine();
                            usersNames[currentIndex] = usertype;
                            Console.WriteLine($"Reservacion hecha con exito, su posicion en la lista es {currentIndex + 1}");
                            currentIndex++;
                            break;
                        case 4:
                            whileRes = 'n';
                            break;
                        default:
                            Console.WriteLine("Opcion invalida");
                            break;
                    }
                }
            }
        }
    }
}