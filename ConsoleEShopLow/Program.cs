using System.Threading.Tasks;
using ConsoleEShopLow.Interfaces;
using ConsoleEShopLow.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ConsoleEShopLow.Repository;

namespace ConsoleEShopLow
{
     class Program
    {
        static Task Main(string[] args)
        {
            using IHost host = CreateHostBuilder(args).Build();

            return host.RunAsync();
        }


        static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureServices((_, services) =>
                    services
                            .AddSingleton<ICurrentUser, CurrentUserService>()
                            .AddSingleton<IUserRepository, UsersRepository>()
                            .AddSingleton<IProductRepository, ProductsRepository>()
                            .AddSingleton<IOrderRepository, OrdersRepository>()
                            .AddScoped<IOrdersService, OrdersService>()
                            .AddScoped<IProductService, ProductService>()
                            .AddScoped<IUserService, UsersService>());
                            
                            
    }
}
