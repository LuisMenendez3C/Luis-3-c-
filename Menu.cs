using System;
using System.Collections.Generic;
using System.Text;

namespace InstalacionyVentaDeCamarasDeSeguridad

{
    class Menu
    {

        private int opcion;
        public Menu()
        {
            
            do
            {
                do
                {
                    Console.WriteLine("-----------------------------MENU----------------------------");
                    Console.WriteLine(" 1.-Observe los modelos y tipos de Camaras(vigilancia)");
                    Console.WriteLine(" 2.-Elija el tipo de Camara(vigilancia) que desea adquirir ");
                    Console.WriteLine(" 3.-Desea solo comprar la Camara(vigilancia) ");
                    Console.WriteLine(" 4.-Desea comprar y el servicio de la Instalacion ");
                    Console.WriteLine(" 5.-Menu de accesorios extras,desea adquirir alguno ");
                    Console.WriteLine("-------------------------------------------------------------");
                    Console.WriteLine("DIgite la Opcion  ");
                    opcion = Convert.ToInt32(Console.ReadLine());

                    if (opcion < 1 || opcion > 5)
                    {
                        Console.WriteLine("Ingrese una opcion valida entre [1 - 5]");
                    }

                } while (opcion < 1 || opcion > 5);

                switch (opcion)
                {

                    case 1:
                        Console.WriteLine("Ud seleccionó la opción|Observe los modelos y tipos de Camaras(vigilancia)|");
                        Console.WriteLine("--------MENU DE CAMARAS--------------");
                        Console.WriteLine("1.-Camaras exteriores");
                        Console.WriteLine("2.-Camaras de interior");
                        Console.WriteLine("3.-Camaras inalambricas");
                        Console.WriteLine("4.-Camaras ip");
                        Console.WriteLine("5.-Camaras de movimiento y soom");
                        Console.WriteLine("6.-Camaras de vision nocturna");
                        Console.WriteLine("-------------------------------------");
                        Console.Write("Presione una tecla para continuar...");
                        Console.ReadKey();

                        break;

                    case 2:
                        Console.WriteLine("Ud seleccionó la opción|Elija el tipo de Camara(vigilancia) que desea adquirir |");
                        Console.WriteLine("Presione una tecla para continuar...");
                        Console.ReadKey();
                        break;

                    case 3:
                        Console.WriteLine("Ud seleccionó la opción|Desea solo comprar la Camara(vigilancia) |");
                        Console.WriteLine("Por la compra de la camara obtendra un descuento del 10% ");
                        Console.Write("Presione una tecla para continuar...");
                        Console.ReadKey();
                        break;


                    case 4:
                        Console.WriteLine("Ud seleccionó la opción|Desea comprar y el servicio de la Instalacion |");
                        Console.WriteLine("Obtendra un descuento del 15% por el servicio de Instalacion mas el 10% por las camaras ");
                        Console.Write("Presione una tecla para continuar...");
                        Console.ReadKey();
                        break;

                    case 5:
                        Console.WriteLine("Ud seleccionó la opción|Menu de accesorios extras,desea adquirir alguno|");
                        Console.WriteLine("--------MENU DE CAMARAS--------");
                        Console.WriteLine("1.-Teclados");
                        Console.WriteLine("2.-Routers");
                        Console.WriteLine("3.-Discos duros");
                        Console.WriteLine("4.- mas por detallar...........");
                        Console.WriteLine("-------------------------------");
                        Console.Write("Presione una tecla para continuar..");
                        Console.ReadKey();
                        break;


                    default:

                        break;
                }
                Console.ReadKey();

            } while (opcion != 5);



        }
    }
}
