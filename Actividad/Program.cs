using System;

namespace Actividad
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;
            int opc = 0;
            do {

                Console.WriteLine("-----------------");
                Console.WriteLine("Tienda de Celulares\n\t1. Marca\n\t2. Salir");
                opcion = int.Parse(Console.ReadLine());
                Console.WriteLine("-----------------");

                switch (opcion) {
                    case 1:
                        Console.WriteLine("Marca de celular\n\t1. IPhone\n\t2. Huawei\n\t3. Samsung\n\t4. Lenovo");
                        opc = int.Parse(Console.ReadLine());
                        switch (opc) {
                            case 1:
                                Console.WriteLine("1. IPhone");
                                Console.WriteLine("Elija el color del dispositivo\n\t1. Negro\n\t2. Blanco\n\t3. Rojo\n\t4. Azul");
                                opc = int.Parse(Console.ReadLine());
                                switch (opc) {
                                    case 1:
                                        Console.WriteLine("Modelo: IPhone, Color: Negro");
                                        break;
                                    case 2:
                                        Console.WriteLine("Modelo: IPhone, Color: Blanco");
                                        break;
                                    case 3:
                                        Console.WriteLine("Modelo IPhone, Color: Rojo");
                                        break;
                                    case 4:
                                        Console.WriteLine("Modelo: IPhone, Color: Azul");
                                        break;
                                }
                                Console.WriteLine("Elija las pulgadas del dispositivo\n\t1. 5,5 pulgadas\n\t2. 6,0 pulgadas\n\t3. 6,5 pulgadas\n\t4. 7,0 Pulgadas");
                                opc = int.Parse(Console.ReadLine());
                                switch (opc) {
                                    case 1:
                                        Console.WriteLine("Modelo IPhone, Pulgadas: 5,5");
                                        break;
                                    case 2:
                                        Console.WriteLine("Modelo IPhone, Pulgadas: 6,0");
                                        break;
                                    case 3:
                                        Console.WriteLine("Modelo IPhone, Pulgadas: 6,5");
                                        break;
                                    case 4:
                                        Console.WriteLine("Modelo IPhone, Pulgadas: 7,0");
                                        break;
                                }
                                break;
                            case 2:
                                Console.WriteLine("2. Huawei");
                                Console.WriteLine("Elija el color del dispositivo\n\t1. Negro\n\t2. Blanco\n\t3. Rojo\n\t4. Azul");
                                opc = int.Parse(Console.ReadLine());
                                switch (opc)
                                {
                                    case 1:
                                        Console.WriteLine("Modelo: Huawei, Color: Negro");
                                        break;
                                    case 2:
                                        Console.WriteLine("Modelo: Huawei, Color: Blanco");
                                        break;
                                    case 3:
                                        Console.WriteLine("Modelo Huawei, Color: Rojo");
                                        break;
                                    case 4:
                                        Console.WriteLine("Modelo: Huawei, Color: Azul");
                                        break;
                                }
                                Console.WriteLine("Elija las pulgadas del dispositivo\n\t1. 5,5 pulgadas\n\t2. 6,0 pulgadas\n\t3. 6,5 pulgadas\n\t4. 7,0 Pulgadas");
                                opc = int.Parse(Console.ReadLine());
                                switch (opc)
                                {
                                    case 1:
                                        Console.WriteLine("Modelo Huawei, Pulgadas: 5,5");
                                        break;
                                    case 2:
                                        Console.WriteLine("Modelo Huawei, Pulgadas: 6,0");
                                        break;
                                    case 3:
                                        Console.WriteLine("Modelo Huawei, Pulgadas: 6,5");
                                        break;
                                    case 4:
                                        Console.WriteLine("Modelo Huawei, Pulgadas: 7,0");
                                        break;
                                }
                                break;
                            case 3:
                                Console.WriteLine("3. Samsung");
                                Console.WriteLine("Elija el color del dispositivo\n\t1. Negro\n\t2. Blanco\n\t3. Rojo\n\t4. Azul");
                                opc = int.Parse(Console.ReadLine());
                                switch (opc)
                                {
                                    case 1:
                                        Console.WriteLine("Modelo: Samsung, Color: Negro");
                                        break;
                                    case 2:
                                        Console.WriteLine("Modelo: Samsung, Color: Blanco");
                                        break;
                                    case 3:
                                        Console.WriteLine("Modelo Samsung, Color: Rojo");
                                        break;
                                    case 4:
                                        Console.WriteLine("Modelo: Samsung, Color: Azul");
                                        break;
                                }
                                Console.WriteLine("Elija las pulgadas del dispositivo\n\t1. 5,5 pulgadas\n\t2. 6,0 pulgadas\n\t3. 6,5 pulgadas\n\t4. 7,0 Pulgadas");
                                opc = int.Parse(Console.ReadLine());
                                switch (opc)
                                {
                                    case 1:
                                        Console.WriteLine("Modelo Samsung, Pulgadas: 5,5");
                                        break;
                                    case 2:
                                        Console.WriteLine("Modelo Samsung, Pulgadas: 6,0");
                                        break;
                                    case 3:
                                        Console.WriteLine("Modelo Samsung, Pulgadas: 6,5");
                                        break;
                                    case 4:
                                        Console.WriteLine("Modelo Samsung, Pulgadas: 7,0");
                                        break;
                                }
                                break;
                            case 4:
                                Console.WriteLine("4. Lenovo");
                                Console.WriteLine("Elija el color del dispositivo\n\t1. Negro\n\t2. Blanco\n\t3. Rojo\n\t4. Azul");
                                opc = int.Parse(Console.ReadLine());
                                switch (opc)
                                {
                                    case 1:
                                        Console.WriteLine("Modelo: Lenovo, Color: Negro");
                                        break;
                                    case 2:
                                        Console.WriteLine("Modelo: Lenovo, Color: Blanco");
                                        break;
                                    case 3:
                                        Console.WriteLine("Modelo Lenovo, Color: Rojo");
                                        break;
                                    case 4:
                                        Console.WriteLine("Modelo: Lenovo, Color: Azul");
                                        break;
                                }
                                Console.WriteLine("Elija las pulgadas del dispositivo\n\t1. 5,5 pulgadas\n\t2. 6,0 pulgadas\n\t3. 6,5 pulgadas\n\t4. 7,0 Pulgadas");
                                opc = int.Parse(Console.ReadLine());
                                switch (opc)
                                {
                                    case 1:
                                        Console.WriteLine("Modelo Lenovo, Pulgadas: 5,5");
                                        break;
                                    case 2:
                                        Console.WriteLine("Modelo Lenovo, Pulgadas: 6,0");
                                        break;
                                    case 3:
                                        Console.WriteLine("Modelo Lenovo, Pulgadas: 6,5");
                                        break;
                                    case 4:
                                        Console.WriteLine("Modelo lenovo, Pulgadas: 7,0");
                                        break;
                                }
                                break;
                        }
                        break;
                }

            } while (opcion <= 2);
        }
    }
}
