using System;

namespace ConsoleTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var usuario = new ApplicationCore.Business.UsuarioBO();
            usuario.GetUsuarios();
        }
    }
}
