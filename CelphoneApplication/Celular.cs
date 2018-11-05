using System;
using System.Threading;

namespace equisde
{
    public class Celular
    {
        private string numero_cel;
        private float saldo;

        ~Celular()
        {
            Console.WriteLine("Has dejado el celular");
            Console.ReadKey();
        }

        public Celular()
        {
            numero_cel = "5511223344";
            saldo = 3.0f;
        }

        public Celular(string n)
        {
            numero_cel = n;
        }

        public Celular(string n,float s)
        {
            numero_cel = n;
            saldo = s;
        }
        
        public void LLamar()
        {
            string llamada; 
            do
            {
                Console.Write("Ingrese el numero a llamar : ");
                llamada = Console.ReadLine();
            } while (llamada.Length != 10);
            if (saldo > 0)
            {
                Console.Write("LLamando a {0}",llamada);
                for (int i = 0; i < 3; i++)
                {
                    Thread.Sleep(1000);
                    Console.Write(". ");
                }
                Console.WriteLine();
                Console.WriteLine("Bueno :3");
                saldo -= 10;
            }
            else
            {
                Console.WriteLine("El saldo de tu amigo se ha agotado");
            }
            
        }

        public void Mensajear()
        {
            string mensaje;
            string n_mensaje;
            do
            {
                Console.Write("Ingrese el numero a mensajear : ");
                n_mensaje = Console.ReadLine();
            } while (n_mensaje.Length != 10);
            Console.WriteLine("Ingresa el mensaje :");
            mensaje = Console.ReadLine();
            if (saldo > 0)
            {
                Console.WriteLine("El mensaje se ha mandado con exito.");
                saldo -= 2;
            }
            else
            {
                Console.WriteLine("El saldo de tu amigo se ha agotado");
            }
        }

        public void Ingresar_saldo()
        {
            Console.Write("Ingresa el saldo que vas a depositar : $");
            saldo += int.Parse(Console.ReadLine());
        }

        public void Checar_saldo()
        {
            Console.WriteLine("Tu saldo es de : ${0}",saldo);
        }

        public void Apagar()
        {
            Console.WriteLine("Hasta luego");
            Console.Write("Apagando ");
            for (int i = 0; i < 5; i++)
            {
                Thread.Sleep(1000);
                Console.Write(". ");
            }
            Console.WriteLine();
        } 
    }
}