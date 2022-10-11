using System;

namespace DesafioPooApp.Models
{
    public class Program 
    {
        static void Main(string[] args)
        {
            Iphone celular = new Iphone("85985998584", "XR2022", "431233212343243", 256);
            celular.Ligar();
            Console.WriteLine(celular.Numero,celular.Modelo,celular.IMEI,celular.Memoria);
            celular.ReceberLigacao();
            
            Console.WriteLine("Qual aplicativo deseja instalar");
            string nome = Console.ReadLine();
            
            celular.InstalarAplicativo(nome);
            
        }
    }
}
