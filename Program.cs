using System;
using System.Threading;

namespace RedHospitalaria
{
    class Program
    {
        // Variables para los usuarios
        public static string username1 = "", username2 = "", username3 = "", nombre1 = "", nombre2 = "", nombre3 = "", apellido1 = "", apellido2 = "", apellido3 = "",
                             rol1 = "", rol2 = "", rol3 = "", contraseña1 = "", contraseña2 = "", contraseña3 = "", bloqueado1 = "", bloqueado2 = "", bloqueado3 = "",

                             // Variables facturación
                             nombre = "", apellido = "",

                             // Variables de medicamentos
                            medicamento1 = "Diclofenaco", medicamento2 = "Penicilina", medicamento3 = "Panadol Ultra-Fuerte",
                            tipo1 = "Bebible", tipo2 = "Inyección", tipo3 = "Cápsula", rol = "medico",
                            medicamentoSeguro1 = "si", medicamentoSeguro2 = "no", medicamentoSeguro3 = "si";

        // Variables de los hospitales
        public static int totalEspecialidad1 = 0, totalEspecialidad2 = 0, traumatología1 = 0, traumatología2 = 0,
                            cardiología1 = 0, cardiología2 = 0, pediatría1 = 0, pediatría2 = 0, anestesiología1 = 0, anestesiología2 = 0,
                            dermatología1 = 0, dermatología2 = 0, oftalmología1 = 0, oftalmología2 = 0, gastroenterología1 = 0, gastroenterología2 = 0,
                            ginecología1 = 0, ginecología2 = 0, fisioterapia1 = 0, fisioterapia2 = 0, neumología1 = 0, neumología2 = 0,
                            ambulancias1 = 0, ambulancias2 = 0, camillas1 = 0, camillas2 = 0, sillasDeRuedas1 = 0, sillasDeRuedas2 = 0,
                            medicoGeneral1 = 0, medicoGeneral2 = 0, medicoInterna1 = 0, medicoInterna2 = 0,

                            // Variables de los medicamentos
                            stock1 = 15, stock2 = 10, stock3 = 5;

        public static bool vencimiento1 = true, vencimiento2 = false, vencimiento3 = false;

        public static decimal precio1 = 35.0M, precio2 = 15.0M, precio3 = 60.0M, totalVentas = 0.0M;

        static void Farmacia()
        {
            DateTime fechaHora = DateTime.Now;
            string seleccionMedicamento = "";

            do
            {
                Console.Clear();
                Console.WriteLine("MÓDULO DE FARMACIA\n");
                Console.WriteLine("Compra de medicamento. Medicamento disponible: \n");
                Console.WriteLine("1 | Nombre: " + medicamento1);
                Console.WriteLine("  | Precio: Q" + precio1);
                Console.WriteLine("  | Tipo de medicamento: " + tipo1);
                Console.WriteLine("  | Existencia: " + stock1);
                Console.WriteLine("  | Fecha de vencimiento: " + vencimiento1);
                Console.WriteLine("  | Aplica seguro: " + medicamentoSeguro1);
                Console.WriteLine("");
                Console.WriteLine("2 | Nombre: " + medicamento2);
                Console.WriteLine("  | Precio: Q" + precio2);
                Console.WriteLine("  | Tipo de medicamento: " + tipo2);
                Console.WriteLine("  | Existencia: " + stock2);
                Console.WriteLine("  | Fecha de vencimiento: " + vencimiento2);
                Console.WriteLine("  | Aplica seguro: " + medicamentoSeguro2);
                Console.WriteLine("");
                Console.WriteLine("3 | Nombre: " + medicamento3);
                Console.WriteLine("  | Precio: Q" + precio3);
                Console.WriteLine("  | Tipo de medicamento: " + tipo3);
                Console.WriteLine("  | Existencia: " + stock3);
                Console.WriteLine("  | Fecha de vencimiento: " + vencimiento3);
                Console.WriteLine("  | Aplica seguro: " + medicamentoSeguro3);
                Console.WriteLine("\n4 | Salir");
                Console.WriteLine("\n¿Cuenta con seguro? (Sí / No): ");
                string seguro = Console.ReadLine().ToLower();
                Console.WriteLine("\nIntroduzca el número correspondiente al producto que desea comprar: ");
                seleccionMedicamento = Console.ReadLine();
                Console.Clear();

                switch (seleccionMedicamento)
                {
                    case "1":
                        Console.WriteLine("\nNOMBRE DEL MEDICAMENTO: " + medicamento1.ToUpper() + "\n");
                        Console.WriteLine("Precio: Q" + precio1);
                        Console.WriteLine("Tipo de medicamento: " + tipo1);
                        Console.WriteLine("Existencia: " + stock1);
                        Console.WriteLine("Fecha de vencimiento: " + vencimiento1);
                        Console.Write("\nCantidad: ");
                        decimal cantidad1 = Convert.ToDecimal(Console.ReadLine());
                        decimal subtotal, descuento, total;

                        if (cantidad1 > stock1)
                        {
                            Console.Clear();
                            Console.WriteLine("Seleccione una cantidad de medicamento menor o igual a la cantidad en existencia.");
                            Console.WriteLine("Presione Enter para regresar a Farmacia nuevamente...");
                            Console.ReadLine();
                        }
                        else
                        {
                            if (seguro == "si" && vencimiento1 == true)
                            {
                                Console.WriteLine("\n------------------------------ FACTURACIÓN ------------------------------\n");
                                Console.WriteLine("Nombre: " + nombre);
                                Console.WriteLine("Apellido: " + apellido);
                                Console.WriteLine("Fecha: " + fechaHora.ToShortDateString());
                                Console.WriteLine("Hora: " + fechaHora.ToShortTimeString());
                                subtotal = precio1 * cantidad1;
                                Console.WriteLine("Subtotal: Q" + subtotal);
                                descuento = (precio1 * cantidad1) * 0.30M;
                                Console.WriteLine("Descuento: Q" + descuento);
                                Console.WriteLine("  - 10% de descuento por seguro médico.");
                                Console.WriteLine("  - 20% de descuento por proximidad en la fecha de expiración.");
                                total = subtotal - descuento;
                                Console.WriteLine("\nEl total de su factura es de: Q" + total);
                                Console.WriteLine("\n¡Gracias por la compra!\n");
                                Console.WriteLine("Presione Enter para salir...");
                                Console.ReadLine();
                            }
                            else if (seguro == "si" && vencimiento1 == false)
                            {
                                Console.WriteLine("\n------------------------------ FACTURACIÓN ------------------------------\n");
                                Console.WriteLine("Nombre: " + nombre);
                                Console.WriteLine("Apellido: " + apellido);
                                Console.WriteLine("Fecha: " + fechaHora.ToShortDateString());
                                Console.WriteLine("Hora: " + fechaHora.ToShortTimeString());
                                subtotal = precio1 * cantidad1;
                                Console.WriteLine("Subtotal: Q" + subtotal);
                                descuento = (precio1 * cantidad1) * 0.10M;
                                Console.WriteLine("Descuento: Q" + descuento);
                                Console.WriteLine("  - 10% de descuento por seguro médico.");
                                total = subtotal - descuento;
                                Console.WriteLine("\nEl total de su factura es de: Q" + total);
                                Console.WriteLine("\n¡Gracias por la compra!\n");
                                Console.WriteLine("Presione Enter para salir...");
                                Console.ReadLine();
                            }
                            else if (seguro == "no" && vencimiento1 == true)
                            {
                                Console.WriteLine("\n------------------------------ FACTURACIÓN ------------------------------\n");
                                Console.WriteLine("Nombre: " + nombre);
                                Console.WriteLine("Apellido: " + apellido);
                                Console.WriteLine("Fecha: " + fechaHora.ToShortDateString());
                                Console.WriteLine("Hora: " + fechaHora.ToShortTimeString());
                                subtotal = precio1 * cantidad1;
                                Console.WriteLine("Subtotal: Q" + subtotal);
                                descuento = (precio1 * cantidad1) * 0.20M;
                                Console.WriteLine("Descuento: Q" + descuento);
                                Console.WriteLine("  - 20% de descuento por proximidad en la fecha de expiración.");
                                total = subtotal - descuento;
                                Console.WriteLine("\nEl total de su factura es de: Q" + total);
                                Console.WriteLine("\n¡Gracias por la compra!\n");
                                Console.WriteLine("Presione Enter para salir...");
                                Console.ReadLine();
                            }
                            else
                            {
                                Console.WriteLine("\n------------------------------ FACTURACIÓN ------------------------------\n");
                                Console.WriteLine("Nombre: " + nombre);
                                Console.WriteLine("Apellido: " + apellido);
                                Console.WriteLine("Fecha: " + fechaHora.ToShortDateString());
                                Console.WriteLine("Hora: " + fechaHora.ToShortTimeString());
                                subtotal = precio1 * cantidad1;
                                Console.WriteLine("Subtotal: Q" + subtotal);
                                Console.WriteLine("Descuento: Q0.0");
                                Console.WriteLine("  - No se realizó ningún descuento.");
                                total = subtotal;
                                Console.WriteLine("\nEl total de su factura es de: Q" + total);
                                Console.WriteLine("\n¡Gracias por la compra!\n");
                                Console.WriteLine("Presione Enter para salir...");
                                Console.ReadLine();
                            }

                            stock1 = Convert.ToInt16(stock1) - Convert.ToInt16(cantidad1);
                            totalVentas += total;
                        }
                        break;
                    case "2":
                        Console.WriteLine("\nNOMBRE DEL MEDICAMENTO: " + medicamento2.ToUpper() + "\n");
                        Console.WriteLine("Precio: Q" + precio2);
                        Console.WriteLine("Tipo de medicamento: " + tipo2);
                        Console.WriteLine("Existencia: " + stock2);
                        Console.WriteLine("Fecha de vencimiento: " + vencimiento2);
                        Console.Write("\nCantidad: ");
                        decimal cantidad2 = decimal.Parse(Console.ReadLine());

                        if (cantidad2 > stock2)
                        {
                            Console.WriteLine("Seleccione una cantidad menor a la cantidad de existencias.");
                            Console.WriteLine("Presione Enter para regresar a Farmacia nuevamente...");
                            Console.ReadLine();
                        }
                        else
                        {
                            if (seguro == "si" && vencimiento2 == true)
                            {
                                Console.WriteLine("\n------------------------------ FACTURACIÓN ------------------------------\n");
                                Console.WriteLine("Nombre: " + nombre);
                                Console.WriteLine("Apellido: " + apellido);
                                Console.WriteLine("Fecha: " + fechaHora.ToShortDateString());
                                Console.WriteLine("Hora: " + fechaHora.ToShortTimeString());
                                subtotal = precio2 * cantidad2;
                                Console.WriteLine("Subtotal: Q" + subtotal);
                                descuento = (precio2 * cantidad2) * 0.30M;
                                Console.WriteLine("Descuento: Q" + descuento);
                                Console.WriteLine("  - 10% de descuento por seguro médico.");
                                Console.WriteLine("  - 20% de descuento por proximidad en la fecha de expiración.");
                                total = subtotal - descuento;
                                Console.WriteLine("\nEl total de su factura es de: Q" + total);
                                Console.WriteLine("\n¡Gracias por la compra!\n");
                                Console.WriteLine("Presione Enter para salir...");
                                Console.ReadLine();
                            }
                            else if (seguro == "si" && vencimiento2 == false)
                            {
                                Console.WriteLine("\n------------------------------ FACTURACIÓN ------------------------------\n");
                                Console.WriteLine("Nombre: " + nombre);
                                Console.WriteLine("Apellido: " + apellido);
                                Console.WriteLine("Fecha: " + fechaHora.ToShortDateString());
                                Console.WriteLine("Hora: " + fechaHora.ToShortTimeString());
                                subtotal = precio2 * cantidad2;
                                Console.WriteLine("Subtotal: Q" + subtotal);
                                descuento = (precio2 * cantidad2) * 0.10M;
                                Console.WriteLine("Descuento: Q" + descuento);
                                Console.WriteLine("  - 10% de descuento por seguro médico.");
                                total = subtotal - descuento;
                                Console.WriteLine("\nEl total de su factura es de: Q" + total);
                                Console.WriteLine("\n¡Gracias por la compra!\n");
                                Console.WriteLine("Presione Enter para salir...");
                                Console.ReadLine();
                            }
                            else if (seguro == "no" && vencimiento2 == true)
                            {
                                Console.WriteLine("\n------------------------------ FACTURACIÓN ------------------------------\n");
                                Console.WriteLine("Nombre: " + nombre);
                                Console.WriteLine("Apellido: " + apellido);
                                Console.WriteLine("Fecha: " + fechaHora.ToShortDateString());
                                Console.WriteLine("Hora: " + fechaHora.ToShortTimeString());
                                subtotal = precio2 * cantidad2;
                                Console.WriteLine("Subtotal: Q" + subtotal);
                                descuento = (precio2 * cantidad2) * 0.20M;
                                Console.WriteLine("Descuento: Q" + descuento);
                                Console.WriteLine("  - 20% de descuento por proximidad en la fecha de expiración.");
                                total = subtotal - descuento;
                                Console.WriteLine("\nEl total de su factura es de: Q" + total);
                                Console.WriteLine("\n¡Gracias por la compra!\n");
                                Console.WriteLine("Presione Enter para salir...");
                                Console.ReadLine();
                            }
                            else
                            {
                                Console.WriteLine("\n------------------------------ FACTURACIÓN ------------------------------\n");
                                Console.WriteLine("Nombre: " + nombre);
                                Console.WriteLine("Apellido: " + apellido);
                                Console.WriteLine("Fecha: " + fechaHora.ToShortDateString());
                                Console.WriteLine("Hora: " + fechaHora.ToShortTimeString());
                                subtotal = precio2 * cantidad2;
                                Console.WriteLine("Subtotal: Q" + subtotal);
                                Console.WriteLine("Descuento: Q0.0");
                                Console.WriteLine("  - No se realizó ningún descuento.");
                                total = subtotal;
                                Console.WriteLine("\nEl total de su factura es de: Q" + total);
                                Console.WriteLine("\n¡Gracias por la compra!\n");
                                Console.WriteLine("Presione Enter para salir...");
                                Console.ReadLine();
                            }

                            stock2 = Convert.ToInt16(stock2) - Convert.ToInt16(cantidad2);
                            totalVentas += total;
                        }
                        break;
                    case "3":
                        Console.WriteLine("\nNOMBRE DEL MEDICAMENTO: " + medicamento3.ToUpper() + "\n");
                        Console.WriteLine("Precio: Q" + precio3);
                        Console.WriteLine("Tipo de medicamento: " + tipo3);
                        Console.WriteLine("Existencia: " + stock3);
                        Console.WriteLine("Fecha de vencimiento: " + vencimiento3);
                        Console.Write("\nCantidad: ");
                        decimal cantidad3 = decimal.Parse(Console.ReadLine());

                        if (cantidad3 > stock3)
                        {
                            Console.WriteLine("Seleccione una cantidad menor a la cantidad de existencias.");
                            Console.WriteLine("Presione Enter para regresar a Farmacia nuevamente...");
                            Console.ReadLine();
                        }
                        else
                        {
                            if (seguro == "si" && vencimiento3 == true)
                            {
                                Console.WriteLine("\n------------------------------ FACTURACIÓN ------------------------------\n");
                                Console.WriteLine("Nombre: " + nombre);
                                Console.WriteLine("Apellido: " + apellido);
                                Console.WriteLine("Fecha: " + fechaHora.ToShortDateString());
                                Console.WriteLine("Hora: " + fechaHora.ToShortTimeString());
                                subtotal = precio3 * cantidad3;
                                Console.WriteLine("Subtotal: Q" + subtotal);
                                descuento = (precio3 * cantidad3) * 0.30M;
                                Console.WriteLine("Descuento: Q" + descuento);
                                Console.WriteLine("  - 10% de descuento por seguro médico.");
                                Console.WriteLine("  - 20% de descuento por proximidad en la fecha de expiración.");
                                total = subtotal - descuento;
                                Console.WriteLine("\nEl total de su factura es de: Q" + total);
                                Console.WriteLine("\n¡Gracias por la compra!\n");
                                Console.WriteLine("Presione Enter para salir...");
                                Console.ReadLine();
                            }
                            else if (seguro == "si" && vencimiento3 == false)
                            {
                                Console.WriteLine("\n------------------------------ FACTURACIÓN ------------------------------\n");
                                Console.WriteLine("Nombre: " + nombre);
                                Console.WriteLine("Apellido: " + apellido);
                                Console.WriteLine("Fecha: " + fechaHora.ToShortDateString());
                                Console.WriteLine("Hora: " + fechaHora.ToShortTimeString());
                                subtotal = precio3 * cantidad3;
                                Console.WriteLine("Subtotal: Q" + subtotal);
                                descuento = (precio3 * cantidad3) * 0.10M;
                                Console.WriteLine("Descuento: Q" + descuento);
                                Console.WriteLine("  - 10% de descuento por seguro médico.");
                                total = subtotal - descuento;
                                Console.WriteLine("\nEl total de su factura es de: Q" + total);
                                Console.WriteLine("\n¡Gracias por la compra!\n");
                                Console.WriteLine("Presione Enter para salir...");
                                Console.ReadLine();
                            }
                            else if (seguro == "no" && vencimiento3 == true)
                            {
                                Console.WriteLine("\n------------------------------ FACTURACIÓN ------------------------------\n");
                                Console.WriteLine("Nombre: " + nombre);
                                Console.WriteLine("Apellido: " + apellido);
                                Console.WriteLine("Fecha: " + fechaHora.ToShortDateString());
                                Console.WriteLine("Hora: " + fechaHora.ToShortTimeString());
                                subtotal = precio3 * cantidad3;
                                Console.WriteLine("Subtotal: Q" + subtotal);
                                descuento = (precio3 * cantidad3) * 0.20M;
                                Console.WriteLine("Descuento: Q" + descuento);
                                Console.WriteLine("  - 20% de descuento por proximidad en la fecha de expiración.");
                                total = subtotal - descuento;
                                Console.WriteLine("\nEl total de su factura es de: Q" + total);
                                Console.WriteLine("\n¡Gracias por la compra!\n");
                                Console.WriteLine("Presione Enter para salir...");
                                Console.ReadLine();
                            }
                            else
                            {
                                Console.WriteLine("\n------------------------------ FACTURACIÓN ------------------------------\n");
                                Console.WriteLine("Nombre: " + nombre);
                                Console.WriteLine("Apellido: " + apellido);
                                Console.WriteLine("Fecha: " + fechaHora.ToShortDateString());
                                Console.WriteLine("Hora: " + fechaHora.ToShortTimeString());
                                subtotal = precio3 * cantidad3;
                                Console.WriteLine("Subtotal: Q" + subtotal);
                                Console.WriteLine("Descuento: Q0.0");
                                Console.WriteLine("  - No se realizó ningún descuento.");
                                total = subtotal;
                                Console.WriteLine("\nEl total de su factura es de: Q" + total);
                                Console.WriteLine("\n¡Gracias por la compra!\n");
                                Console.WriteLine("Presione Enter para salir...");
                                Console.ReadLine();
                            }

                            stock3 = Convert.ToInt16(stock3) - Convert.ToInt16(cantidad3);
                            totalVentas += total;
                        }
                        break;
                    case "4":
                        seleccionMedicamento = "4";
                        break;
                    default:
                        Console.WriteLine("Seleccione un medicamento correcto.");
                        Console.Write("Espere por favor...");
                        Thread.Sleep(2500);
                        Console.Clear();
                        break;
                }
            } while (seleccionMedicamento != "4");
        }

        static void IngresoDatos()
        {
            string opcionSeleccionada = "";

            do
            {
                Console.Clear();
                Console.WriteLine("MÓDULO DE INGRESO DE DATOS\n");
                Console.WriteLine("Seleccione uno de los dos hospitales disponibles para ingresar los datos.\n");
                Console.WriteLine("1.) Hospital Central");
                Console.WriteLine("2.) Hospital Militar");
                Console.WriteLine("3.) Regresar a la selección del módulo\n");
                Console.Write("Seleccione una opción: ");
                opcionSeleccionada = Console.ReadLine();
                Console.Clear();

                switch (opcionSeleccionada)
                {
                    case "1":
                        try
                        {
                            Console.WriteLine("HOSPITAL CENTRAL\n");
                            Console.WriteLine("Luego de ingresar la cantidad presione Enter para mostrar más campos.\n");
                            Console.Write("a.) Total de médicos de medicina general: ");
                            medicoGeneral1 = int.Parse(Console.ReadLine());
                            Console.Write("b.) Total de médicos de medicina interna: ");
                            medicoInterna1 = int.Parse(Console.ReadLine());
                            Console.Write("c.) Total de médicos con especialidad en traumatología: ");
                            traumatología1 = int.Parse(Console.ReadLine());
                            Console.Write("d.) Total de médicos con especialidad en cardiología: ");
                            cardiología1 = int.Parse(Console.ReadLine());
                            Console.Write("e.) Total de médicos con especialidad en pediatría: ");
                            pediatría1 = int.Parse(Console.ReadLine());
                            Console.Write("f.) Total de médicos con especialidad en anestesiología: ");
                            anestesiología1 = int.Parse(Console.ReadLine());
                            Console.Write("g.) Total de médicos con especialidad en dermatología: ");
                            dermatología1 = int.Parse(Console.ReadLine());
                            Console.Write("h.) Total de médicos con especialidad en oftalmología: ");
                            oftalmología1 = int.Parse(Console.ReadLine());
                            Console.Write("i.) Total de médicos con especialidad en gastroenterología: ");
                            gastroenterología1 = int.Parse(Console.ReadLine());
                            Console.Write("j.) Total de médicos con especialidad en ginecología: ");
                            ginecología1 = int.Parse(Console.ReadLine());
                            Console.Write("k.) Total de médicos con especialidad en fisioterapia: ");
                            fisioterapia1 = int.Parse(Console.ReadLine());
                            Console.Write("l.) Total de médicos con especialidad en neumología: ");
                            neumología1 = int.Parse(Console.ReadLine());
                            Console.Write("m.) Total de ambulancias: ");
                            ambulancias1 = int.Parse(Console.ReadLine());
                            Console.Write("n.) Total de camillas: ");
                            camillas1 = int.Parse(Console.ReadLine());
                            Console.Write("o.) Total de sillas de ruedas: ");
                            sillasDeRuedas1 = int.Parse(Console.ReadLine());
                        }
                        catch(Exception error)
                        {
                            Console.Write("Error: " + error.Message);
                            Console.ReadLine();
                        }
                        finally
                        {
                            IngresoDatos();
                        }
                        
                        totalEspecialidad1 = traumatología1 + cardiología1 + pediatría1 + anestesiología1 + dermatología1 +
                                                 oftalmología1 + gastroenterología1 + ginecología1 + fisioterapia1 + neumología1;
                        Console.Write("\nPresione Enter para guardar y salir...");
                        Console.ReadLine();
                        break;
                    case "2":
                        try
                        {
                            Console.WriteLine("HOSPITAL MILITAR\n");
                            Console.WriteLine("Luego de ingresar la cantidad presione Enter para mostrar más campos.\n");
                            Console.Write("a.) Total de médicos de medicina general: ");
                            medicoGeneral2 = int.Parse(Console.ReadLine());
                            Console.Write("b.) Total de médicos de medicina interna: ");
                            medicoInterna2 = int.Parse(Console.ReadLine());
                            Console.Write("c.) Total de médicos con especialidad en traumatología: ");
                            traumatología2 = int.Parse(Console.ReadLine());
                            Console.Write("d.) Total de médicos con especialidad en cardiología: ");
                            cardiología2 = int.Parse(Console.ReadLine());
                            Console.Write("e.) Total de médicos con especialidad en pediatría: ");
                            pediatría2 = int.Parse(Console.ReadLine());
                            Console.Write("f.) Total de médicos con especialidad en anestesiología: ");
                            anestesiología2 = int.Parse(Console.ReadLine());
                            Console.Write("g.) Total de médicos con especialidad en dermatología: ");
                            dermatología2 = int.Parse(Console.ReadLine());
                            Console.Write("h.) Total de médicos con especialidad en oftalmología: ");
                            oftalmología2 = int.Parse(Console.ReadLine());
                            Console.Write("i.) Total de médicos con especialidad en gastroenterología: ");
                            gastroenterología2 = int.Parse(Console.ReadLine());
                            Console.Write("j.) Total de médicos con especialidad en ginecología: ");
                            ginecología2 = int.Parse(Console.ReadLine());
                            Console.Write("k.) Total de médicos con especialidad en fisioterapia: ");
                            fisioterapia2 = int.Parse(Console.ReadLine());
                            Console.Write("l.) Total de médicos con especialidad en neumología: ");
                            neumología2 = int.Parse(Console.ReadLine());
                            Console.Write("m.) Total de ambulancias: ");
                            ambulancias2 = int.Parse(Console.ReadLine());
                            Console.Write("n.) Total de camillas: ");
                            camillas2 = int.Parse(Console.ReadLine());
                            Console.Write("o.) Total de sillas de ruedas: ");
                            sillasDeRuedas2 = int.Parse(Console.ReadLine());
                        }
                        catch(Exception error)
                        {
                            Console.Write("Erro: " + error.Message);
                        }
                        finally
                        {
                            IngresoDatos();
                        }

                        totalEspecialidad2 = traumatología2 + cardiología2 + pediatría2 + anestesiología2 + dermatología2 +
                                                oftalmología2 + gastroenterología2 + ginecología2 + fisioterapia2 + neumología2;
                        Console.Write("\nPresione Enter para guardar y salir...");
                        Console.ReadLine();
                        break;
                    case "3":
                        opcionSeleccionada = "3";
                        break;
                    default:
                        Console.WriteLine("Seleccione una opción correcta. Espere por favor...");
                        Thread.Sleep(2500);
                        Console.Clear();
                        break;
                }
            } while (opcionSeleccionada != "3");
        }

        static void Reportes()
        {
            string opcionSeleccionada = "";

            do
            {
                Console.Clear();
                Console.WriteLine("MÓDULO DE REPORTES\n");
                Console.WriteLine("Seleccione una de las siguientes opciones para realizar consultas.\n");
                
                if (rol == "paciente")
                {
                    Console.WriteLine("1.) Por hospital");
                    Console.WriteLine("2.) General");
                    Console.WriteLine("3.) Regrear a la selección del módulo");
                    
                }
                else
                {
                    Console.WriteLine("0.) Total de ventas en Farmacia");
                    Console.WriteLine("1.) Por hospital");
                    Console.WriteLine("2.) General");
                    Console.WriteLine("3.) Regrear a la selección del módulo");
                }

                Console.Write("\nSeleccione una opción: ");
                opcionSeleccionada = Console.ReadLine();
                Console.Clear();
                
                switch (opcionSeleccionada)
                {
                    case "0":
                        Console.WriteLine("TOTAL DE VENTAS EN FARMACIA\n");
                        Console.WriteLine("Reportes disponible únicamente para usuarios con rol de médico.\n");
                        Console.WriteLine("Total de ventas en farmacia: Q" + totalVentas);
                        Console.Write("\nPresione Enter para realizar más consultas...");
                        Console.ReadLine();
                        break;
                    case "1":
                        Console.WriteLine("REPORTE POR HOSPITAL\n");
                        Console.WriteLine("Los datos por hospital son los siguientes...\n");
                        Console.WriteLine("a.) Total de médicos: ");
                        Console.WriteLine("         - Hospital General: " + medicoGeneral1);
                        Console.WriteLine("         - Hospital Militar: " + medicoGeneral2);
                        Console.WriteLine("\nb.) Total de médicos por especialidad: ");
                        Console.WriteLine("         - Hospital General: " + totalEspecialidad1);
                        Console.WriteLine("         - Hospital Militar: " + totalEspecialidad2);
                        Console.Write("\nPresione Enter para realizar más consultas...");
                        Console.ReadLine();
                        break;
                    case "2":
                        Console.WriteLine("REPORTE GENERAL\n");
                        Console.WriteLine("Los datos en general son los siguientes...\n");
                        Console.WriteLine("a.) Total de médicos: " + (medicoGeneral1 + medicoGeneral2 + medicoInterna1 + medicoInterna2));
                        Console.WriteLine("b.) Total de médicos por especialidad: " + (totalEspecialidad1 + totalEspecialidad2));
                        Console.WriteLine("c.) Total de médicos por hospital: ");
                        Console.WriteLine("         - Hospital General: " + medicoGeneral1);
                        Console.WriteLine("         - Hospital Militar: " + medicoGeneral2);
                        Console.WriteLine("\nd.) Total de camillas y hospital con más camillas: ");
                        Console.WriteLine("         - Total de camillas: " + (camillas1 + camillas2));
                        Console.WriteLine("         - Hospital con más camillas: " + ((camillas1 >= camillas2) ? "Hospital General" : "Hospital Militar"));
                        Console.WriteLine("\ne.) Total de sillas de ruedas y hospital con más sillas de ruedas: ");
                        Console.WriteLine("         - Total de sillas de ruedas: " + (sillasDeRuedas1 + sillasDeRuedas2));
                        Console.WriteLine("         - Hospital con más sillas de ruedas: " + ((sillasDeRuedas1 >= sillasDeRuedas2) ? "Hospital General" : "Hospital Militar"));
                        Console.WriteLine("\nf.) Total de ambulancias y hospital con menos ambulancias: ");
                        Console.WriteLine("         - Total de ambulacias: " + (ambulancias1 + ambulancias2));
                        Console.WriteLine("         - Hospital con menos ambulancias: " + ((ambulancias1 <= ambulancias2) ? "Hospital General" : "Hospital Militar"));
                        Console.Write("\nPresione Enter para realizar más consultas...");
                        Console.ReadLine();
                        break;
                    case "3":
                        opcionSeleccionada = "3";
                        break;
                    default:
                        Console.WriteLine("Seleccione una opción correcta.");
                        Console.Write("Espere por favor...");
                        Thread.Sleep(2500);
                        Console.Clear();
                        break;
                }
            } while (opcionSeleccionada != "3");
        }

        static void Administrador()
        {
            string opcionSeleccionada = "";

            do
            {
                Console.Clear();
                Console.WriteLine("MÓDULO DE ADMINISTRADOR\n");
                Console.WriteLine("1.) Control de accesos");
                Console.WriteLine("2.) Modificación de información de farmacia");
                Console.WriteLine("3.) Regresar a la selección del módulo\n");
                Console.Write("Seleccione una opción: ");
                opcionSeleccionada = Console.ReadLine();
                Console.Clear();

                switch (opcionSeleccionada)
                {
                    case "1":
                        Console.WriteLine("CONTROL DE ACCESOS\n");
                        Console.WriteLine("1.) Agregar usuarios");
                        Console.WriteLine("2.) Modificar usuario");
                        Console.WriteLine("3.) Salir\n");
                        Console.Write("Seleccione una opción: ");
                        string opcionUsuario = Console.ReadLine();
                            
                            if (opcionUsuario == "1")
                            {
                                int cantidadUsuario = 0;

                                do
                                {
                                    Console.Clear();
                                    cantidadUsuario++;
                                    Console.WriteLine("AGREGAR USUARIO\n");
                                    Console.WriteLine("Usuarios creados: " + cantidadUsuario +"/3.\n");
                                    Console.WriteLine("Ingrese los siguientes datos para crear al usuario.\n");

                                    if (cantidadUsuario == 1)  // Creación primer usuario.
                                    {
                                        Console.Write("Usuario: ");
                                        username1 = Console.ReadLine();
                                        Console.Write("Nombre: ");
                                        nombre1 = Console.ReadLine();
                                        Console.Write("Apellido: ");
                                        apellido1 = Console.ReadLine();
                                        Console.Write("Rol (Paciente o Médico): ");
                                        rol1 = Console.ReadLine().ToLower();
                                        Console.Write("Contraseña: ");
                                        contraseña1 = Console.ReadLine();
                                        Console.Write("Usuario bloqueado (Sí / No): ");
                                        bloqueado1 = Console.ReadLine().ToLower();
                                        Console.WriteLine("\nPresione Enter para guardar y continuar...");
                                        Console.ReadLine();
                                    }
                                    else if (cantidadUsuario == 2)  // Creación primer usuario.
                                    {
                                        Console.Write("Usuario: ");
                                        username2 = Console.ReadLine();
                                        Console.Write("Nombre: ");
                                        nombre2 = Console.ReadLine();
                                        Console.Write("Apellido: ");
                                        apellido2 = Console.ReadLine();
                                        Console.Write("Rol (Paciente o Médico): ");
                                        rol2 = Console.ReadLine().ToLower();
                                        Console.Write("Contraseña: ");
                                        contraseña2 = Console.ReadLine();
                                        Console.Write("Usuario bloqueado (Sí / No): ");
                                        bloqueado2 = Console.ReadLine().ToLower();
                                        Console.WriteLine("\nPresione Enter para guardar y continuar...");
                                        Console.ReadLine();
                                    }
                                    else if (cantidadUsuario == 3)  // Creación primer usuario.
                                    {
                                        Console.Write("Usuario: ");
                                        username3 = Console.ReadLine();
                                        Console.Write("Nombre: ");
                                        nombre3 = Console.ReadLine();
                                        Console.Write("Apellido: ");
                                        apellido3 = Console.ReadLine();
                                        Console.Write("Rol (Paciente o Médico): ");
                                        rol3 = Console.ReadLine().ToLower();
                                        Console.Write("Contraseña: ");
                                        contraseña3 = Console.ReadLine();
                                        Console.Write("Usuario bloqueado (Sí / No): ");
                                        bloqueado3 = Console.ReadLine().ToLower();
                                        Console.WriteLine("\nPresione Enter para guardar...");
                                        Console.ReadLine();
                                    }
                                    else if (cantidadUsuario == 4)
                                    {
                                        Console.WriteLine("Ya no puede crear a más usuarios, el sistema solo permite la creación de 3 usuarios.");
                                        Console.WriteLine("Presione Enter para salir...");
                                        Console.ReadLine();
                                    }
                                } while (cantidadUsuario < 4);
                            }
                            else if (opcionUsuario == "2")
                            {
                                Console.Clear();
                                Console.WriteLine("MODIFICAR USUARIO\n");
                                Console.WriteLine("Los únicos datos que se pueden modificar son contraseña y bloqueo.\n");
                                Console.WriteLine("Seleccione el usuario que desea modificar.\n");
                                Console.WriteLine("1.) " + username1);
                                Console.WriteLine("2.) " + username2);
                                Console.WriteLine("3.) " + username3);
                                Console.WriteLine("4.) Salir\n");
                                Console.Write("Seleccione un usuario: ");
                                string modificarUsuario = Console.ReadLine();

                                if (modificarUsuario == "1")
                                {
                                    Console.Clear();
                                    Console.WriteLine("Introduzca la nueva contraseña del usuario " + username1 + " y si esta bloqueado o no.\n");
                                    Console.Write("Contraseña: ");
                                    contraseña1 = Console.ReadLine();
                                    Console.Write("Usuario bloqueado (Sí / No): ");
                                    bloqueado1 = Console.ReadLine().ToLower();
                                    Console.WriteLine("\nPresione Enter para guardar y salir...");
                                    Console.ReadLine();
                                }
                                else if (modificarUsuario == "2")
                                {
                                    Console.Clear();
                                    Console.WriteLine("Introduzca la nueva contraseña del usuario " + username2 + " y si esta bloqueado o no.\n");
                                    Console.Write("Contraseña: ");
                                    contraseña2 = Console.ReadLine();
                                    Console.Write("Usuario bloqueado (Sí / No): ");
                                    bloqueado2 = Console.ReadLine().ToLower();
                                    Console.WriteLine("\nPresione Enter para guardar y salir...");
                                    Console.ReadLine();
                                }
                                else if (modificarUsuario == "3")
                                {
                                    Console.Clear();
                                    Console.WriteLine("Introduzca la nueva contraseña del usuario " + username3 + " y si esta bloqueado o no.\n");
                                    Console.Write("Contraseña: ");
                                    contraseña3 = Console.ReadLine();
                                    Console.Write("Usuario bloqueado (Sí / No): ");
                                    bloqueado3 = Console.ReadLine().ToLower();
                                    Console.WriteLine("\nPresione Enter para guardar y salir...");
                                    Console.ReadLine();
                                }
                                else if (modificarUsuario == "4")
                                {
                                    Console.Clear();
                                    Console.WriteLine("\nSaliendo...");
                                    Thread.Sleep(2500);
                                }
                            }
                        break;
                    case "2":
                        Console.WriteLine("MODIFICACIÓN DE INFORMACIÓN DE FARMACIA\n");
                        Console.WriteLine("Si es la primera vez que ingresa aquí recuerde que Farmacia ya cuenta con datos precargados.");
                        Console.WriteLine("Presione 'si' para actualizar los datos precargados.\n");
                        Console.WriteLine("Continuar (Sí / No): ");
                        string continuar = Console.ReadLine().ToLower();

                            if (continuar == "si")
                            {
                                Console.WriteLine("A continuación ingrese los datos para los 3 tipos de medicamentos.\n");
                                Console.WriteLine("1 | Nombre: ");
                                medicamento1 = Console.ReadLine();
                                Console.WriteLine("  | Precio: Q");
                                precio1 = Convert.ToDecimal(Console.ReadLine());
                                Console.WriteLine("  | Tipo de medicamento: ");
                                tipo1 = Console.ReadLine();
                                Console.WriteLine("  | Existencia: ");
                                stock1 = Convert.ToInt16(Console.ReadLine());
                                Console.WriteLine("  | Fecha de vencimiento (true / false): ");
                                vencimiento1 = Convert.ToBoolean(Console.ReadLine());
                                Console.WriteLine("  | Aplica seguro (true / false): ");
                                medicamentoSeguro1 = Console.ReadLine();
                                Console.WriteLine("");

                                Console.WriteLine("2 | Nombre: ");
                                medicamento2 = Console.ReadLine();
                                Console.WriteLine("  | Precio: Q");
                                precio2 = Convert.ToDecimal(Console.ReadLine());
                                Console.WriteLine("  | Tipo de medicamento: ");
                                tipo2 = Console.ReadLine();
                                Console.WriteLine("  | Existencia: ");
                                stock2 = Convert.ToInt16(Console.ReadLine());
                                Console.WriteLine("  | Fecha de vencimiento (true / false): ");
                                vencimiento2 = Convert.ToBoolean(Console.ReadLine());
                                Console.WriteLine("  | Aplica seguro (true / false): ");
                                medicamentoSeguro2 = Console.ReadLine();
                                Console.WriteLine("");

                                Console.WriteLine("3 | Nombre: ");
                                medicamento3 = Console.ReadLine();
                                Console.WriteLine("  | Precio: Q");
                                precio3 = Convert.ToDecimal(Console.ReadLine());
                                Console.WriteLine("  | Tipo de medicamento: ");
                                tipo3 = Console.ReadLine();
                                Console.WriteLine("  | Existencia: ");
                                stock3 = Convert.ToInt16(Console.ReadLine());
                                Console.WriteLine("  | Fecha de vencimiento (true / false): ");
                                vencimiento3 = Convert.ToBoolean(Console.ReadLine());
                                Console.WriteLine("  | Aplica seguro (true / false): ");
                                medicamentoSeguro3 = Console.ReadLine();
                                Console.WriteLine("");

                                Console.WriteLine("Presione Enter para guardar y salir...");
                                Console.ReadLine();
                            }
                            else
                            {
                                Console.WriteLine("Por favor espere. Saliendo...");
                                Thread.Sleep(2500);
                            }
                        break;
                    case "3":
                        opcionSeleccionada = "3";
                        break;
                    default:
                        Console.WriteLine("Seleccione una opción correcta.");
                        Console.Write("Espere por favor...");
                        Thread.Sleep(2500);
                        Console.Clear();
                        break;
                }
            } while (opcionSeleccionada != "3");
        }
        static void Main(string[] args)
        {
            int intentos = 3;

            do
            {
                Console.Clear();
                Console.WriteLine("RED HOSPITALARIA IPURL\n");
                Console.WriteLine("Ingrese un usuario y contraseña válidos.\n");
                Console.Write("Usuario: ");
                string usuario = Console.ReadLine();
                Console.Write("Contraseña: ");
                string contraseña = Console.ReadLine();

                if (usuario == "Administrador" && contraseña == "123")
                {
                    Console.Clear();
                    string opcionSeleccionada = "";

                    do
                    {
                        Console.Clear();
                        Console.WriteLine("SELECION DE MÓDULO\n");
                        Console.WriteLine("Módulos disponibles para el Administrador.\n");
                        Console.WriteLine("1.) Módulo de Farmacia");
                        Console.WriteLine("2.) Módulo de Ingreso de Datos");
                        Console.WriteLine("3.) Módulo de Reportes");
                        Console.WriteLine("4.) Módulo de Administrador");
                        Console.WriteLine("5.) Salir\n");
                        Console.Write("Seleccione una opción: ");
                        opcionSeleccionada = Console.ReadLine();

                        switch (opcionSeleccionada)
                        {
                            case "1":
                                Farmacia();
                                break;
                            case "2":
                                IngresoDatos();
                                break;
                            case "3":
                                Reportes();
                                break;
                            case "4":
                                Administrador();
                                break;
                            case "5":
                                opcionSeleccionada = "5";
                                break;
                            default:
                                Console.Clear();
                                Console.Write("Seleccione una opción correcta. Por favor espere...");
                                Thread.Sleep(2500);
                                break;
                        }
                    } while (opcionSeleccionada != "5");
                }

                // USUARIO 1 ----------------------------------------------------------------------
                else if (usuario == username1 && contraseña == contraseña1 && bloqueado1 == "no")
                {
                    Console.Clear();
                    string opcionSeleccionada = "";

                    nombre = nombre1;
                    apellido = apellido1;
                    rol = rol1;

                    if (rol1 == "paciente")
                    {
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("SELECION DE MÓDULO\n");
                            Console.WriteLine("Módulos disponibles para los usuarios con rol de paciente.\n");
                            Console.WriteLine("1.) Módulo de Farmacia");
                            Console.WriteLine("2.) Módulo de Reportes");
                            Console.WriteLine("3.) Salir\n");
                            Console.Write("Seleccione una opción: ");
                            opcionSeleccionada = Console.ReadLine();

                            switch (opcionSeleccionada)
                            {
                                case "1":
                                    Farmacia();
                                    break;
                                case "2":
                                    Reportes();
                                    break;
                                case "3":
                                    opcionSeleccionada = "3";
                                    break;
                                default:
                                    Console.Clear();
                                    Console.Write("Seleccione una opción correcta. Por favor espere...");
                                    Thread.Sleep(2500);
                                    break;
                            }
                        } while (opcionSeleccionada != "3");
                    }
                    else
                    {
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("SELECION DE MÓDULO\n");
                            Console.WriteLine("Módulos disponibles para los usuarios con rol de médico.\n");
                            Console.WriteLine("1.) Módulo de Ingreso de Datos");
                            Console.WriteLine("2.) Módulo de Reportes");
                            Console.WriteLine("3.) Salir\n");
                            Console.Write("Seleccione una opción: ");
                            opcionSeleccionada = Console.ReadLine();

                            switch (opcionSeleccionada)
                            {
                                case "1":
                                    IngresoDatos();
                                    break;
                                case "2":
                                    Reportes();
                                    break;
                                case "3":
                                    opcionSeleccionada = "3";
                                    break;
                                default:
                                    Console.Clear();
                                    Console.Write("Seleccione una opción correcta. Por favor espere...");
                                    Thread.Sleep(2500);
                                    break;
                            }
                        } while (opcionSeleccionada != "3");
                    }

                // USUARIO 2 ----------------------------------------------------------------------
                }
                else if (usuario == username2 && contraseña == contraseña2 && bloqueado2 == "no")
                {
                    Console.Clear();
                    string opcionSeleccionada = "";
                    
                    nombre = nombre2;
                    apellido = apellido2;
                    rol = rol2;

                    if (rol2 == "paciente")
                    {
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("SELECION DE MÓDULO\n");
                            Console.WriteLine("Módulos disponibles para los usuarios con rol de paciente.\n");
                            Console.WriteLine("1.) Módulo de Farmacia");
                            Console.WriteLine("2.) Módulo de Reportes");
                            Console.WriteLine("3.) Salir\n");
                            Console.Write("Seleccione una opción: ");
                            opcionSeleccionada = Console.ReadLine();

                            switch (opcionSeleccionada)
                            {
                                case "1":
                                    Farmacia();
                                    break;
                                case "2":
                                    Reportes();
                                    break;
                                case "3":
                                    opcionSeleccionada = "3";
                                    break;
                                default:
                                    Console.Clear();
                                    Console.Write("Seleccione una opción correcta. Por favor espere...");
                                    Thread.Sleep(2500);
                                    break;
                            }
                        } while (opcionSeleccionada != "3");
                    }
                    else
                    {
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("SELECION DE MÓDULO\n");
                            Console.WriteLine("Módulos disponibles para los usuarios con rol de médico.\n");
                            Console.WriteLine("1.) Módulo de Ingreso de Datos");
                            Console.WriteLine("2.) Módulo de Reportes");
                            Console.WriteLine("3.) Salir\n");
                            Console.Write("Seleccione una opción: ");
                            opcionSeleccionada = Console.ReadLine();

                            switch (opcionSeleccionada)
                            {
                                case "1":
                                    IngresoDatos();
                                    break;
                                case "2":
                                    Reportes();
                                    break;
                                case "3":
                                    opcionSeleccionada = "3";
                                    break;
                                default:
                                    Console.Clear();
                                    Console.Write("Seleccione una opción correcta. Por favor espere...");
                                    Thread.Sleep(2500);
                                    break;
                            }
                        } while (opcionSeleccionada != "3");
                    }
                }

                // USUARIO 3 ----------------------------------------------------------------------
                else if (usuario == username3 && contraseña == contraseña3 && bloqueado3 == "no")
                {
                    Console.Clear();
                    string opcionSeleccionada = "";
                    
                    nombre = nombre3;
                    apellido = apellido3;
                    rol = rol3;

                    if (rol3 == "paciente")
                    {
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("SELECION DE MÓDULO\n");
                            Console.WriteLine("Módulos disponibles para los usuarios con rol de paciente.\n");
                            Console.WriteLine("1.) Módulo de Farmacia");
                            Console.WriteLine("2.) Módulo de Reportes");
                            Console.WriteLine("3.) Salir\n");
                            Console.Write("Seleccione una opción: ");
                            opcionSeleccionada = Console.ReadLine();

                            switch (opcionSeleccionada)
                            {
                                case "1":
                                    Farmacia();
                                    break;
                                case "2":
                                    Reportes();
                                    break;
                                case "3":
                                    opcionSeleccionada = "3";
                                    break;
                                default:
                                    Console.Clear();
                                    Console.Write("Seleccione una opción correcta. Por favor espere...");
                                    Thread.Sleep(2500);
                                    break;
                            }
                        } while (opcionSeleccionada != "3");
                    }
                    else
                    {
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("SELECION DE MÓDULO\n");
                            Console.WriteLine("Módulos disponibles para los usuarios con rol de médico.\n");
                            Console.WriteLine("1.) Módulo de Ingreso de Datos");
                            Console.WriteLine("2.) Módulo de Reportes");
                            Console.WriteLine("3.) Salir\n");
                            Console.Write("Seleccione una opción: ");
                            opcionSeleccionada = Console.ReadLine();

                            switch (opcionSeleccionada)
                            {
                                case "1":
                                    IngresoDatos();
                                    break;
                                case "2":
                                    Reportes();
                                    break;
                                case "3":
                                    opcionSeleccionada = "3";
                                    break;
                                default:
                                    Console.Clear();
                                    Console.Write("Seleccione una opción correcta. Por favor espere...");
                                    Thread.Sleep(2500);
                                    break;
                            }
                        } while (opcionSeleccionada != "3");
                    }
                }
                else  // Si el usuario y la contraseña no son válidos.
                {
                    intentos--;

                    if (intentos == 0)  // Si se llega al límite de intentos se cierra la aplicación.
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.Clear();

                        if (usuario == username1)
                        {
                            bloqueado1 = "si";
                            Console.WriteLine("El usuario " + username1 + " ha sido bloqueado por alcanzar el límite de intentos para iniciar sesión.");
                            Console.WriteLine("Presione Enter para continuar...");
                            Console.ReadLine();
                        }
                        else if (usuario == username2)
                        {
                            bloqueado2 = "si";
                            Console.WriteLine("El usuario " + username2 + " ha sido bloqueado por alcanzar el límite de intentos para iniciar sesión.");
                            Console.WriteLine("Presione Enter para continuar...");
                            Console.ReadLine();
                        }
                        else if (usuario == username3)
                        {
                            bloqueado3 = "si";
                            Console.WriteLine("El usuario " + username3 + " ha sido bloqueado por alcanzar el límite de intentos para iniciar sesión.");
                            Console.WriteLine("Presione Enter para continuar...");
                            Console.ReadLine();
                        }
                        Console.ResetColor();
                        Console.Clear();

                        intentos = 3;
                    }
                    else  // Si aún hay intentos disponibles se mostrarán los intentos disponibles.
                    {
                        Console.WriteLine("\nUsuario y/o contraseña incorrectas, intentos disponibles " + intentos + ".");
                        Console.WriteLine("Puede que el usuario este bloqueado. Por favor espere...");
                        Thread.Sleep(2000);
                    }
                }
            } while (intentos >= 1);
        }
    }
}
