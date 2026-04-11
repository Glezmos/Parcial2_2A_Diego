{
    class Program
    {
        static void Main()
        {
            List<int> ventas = new List<int> { 1200, 850, 400, 2100, 950, 1100, 300 };

            string[] dias = { "Lunes", "Martes", "Miércoles", "Jueves", "Viernes", "Sábado", "Domingo" };

            // Mostrar ventas por día  
            Console.WriteLine("Ventas por día:");
            for (int i = 0; i < ventas.Count; i++)
            {
                Console.WriteLine($"{dias[i]}: {ventas[i]}");
            }

            // 1. Suma total  
            Console.WriteLine($"\nSuma total: {ventas.Sum()}");

            // 2. Venta más alta  
            Console.WriteLine($"Venta más alta: {ventas.Max()}");

            // 3. Venta más baja  
            Console.WriteLine($"Venta más baja: {ventas.Min()}");

            // 4. Ordenadas  
            var ventasOrdenadas = ventas.OrderByDescending(v => v);
            Console.WriteLine("Ventas de mayor a menor: " + string.Join(", ", ventasOrdenadas));

            // 5. Verificar si alguna supera 1000  
            bool superoMil = ventas.Any(v => v > 1000);
            Console.WriteLine($"¿Alguna venta superó los 1000?: {superoMil}");
        }
    }

}
