using ConsolaCacheRedis.Models;
using ConsolaCacheRedis.Services;

namespace ConsolaCacheRedis
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Cliente Movil de Azure Cache Redis.");
            ServiceCacheRedis service = new ServiceCacheRedis();
            List<Producto> productos = await service.GetProductosFavoritosAsync();
            if (productos == null)
            {
                Console.WriteLine("No existen productos favoritos");
            }
            else
            {
                int i = 1;
                foreach (var item in productos)
                {
                    Console.WriteLine(i + ".- " + item.Nombre);
                    i++;
                }
            }
            Console.WriteLine("Pulsa ENTER para finalizar.");
            Console.ReadLine();
            await Task.CompletedTask;
        }
    }
}