using System;

class Program
{
    static void Main(string[] args)
    {
        string[] nombres = { "Carlos", "Diego", "Mateo", "Sofia", "Valeria", "Daniel", "Emiliano", "Camila", "Andres", "Javier" };
        string[] apellidos = { "Lopez", "Ramirez", "Torres", "Navarro", "Rojas", "Vargas", "Castillo", "Ortega", "Delgado", "Pineda" };

        Random rd = new Random();

        for (int i = 0; i < 5; i++)
        {
            int indiceNom = rd.Next(0, nombres.Length);
            int indiceApe = rd.Next(0, apellidos.Length);

            string nomAleatorio = nombres[indiceNom];
            string apeAleatorio = apellidos[indiceApe];

            Console.WriteLine((i + 1) + ". " + nomAleatorio + " " + apeAleatorio);
        }
    }
}
