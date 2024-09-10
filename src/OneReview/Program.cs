/*using OneReview.DependencyInjection;
using OneReview.RequestPipeline;

var builder = WebApplication.CreateBuilder(args);
{
    // configure services (DI)
    builder.Services
        .AddServices()
        .AddControllers();
}

var app = builder.Build();
{
    // configure request pipeline
    app.MapControllers();
    app.InitializeDatabase();
}

app.Run();*/


using OneReview.OverServices.Concretes.Payments;
using OneReview.OverServices.Decorator;
using OneReview.OverServices.Interfaces;

namespace OneReview.OverServices;

public class Program
{
    static void Main(string[] args)
    {
        IPaymentStrategy stripePayment = new StripePayment();
        IPayment basePayment = new BasePayment(stripePayment, 100);

        IPayment percentageDiscount = new PercentageDiscountDecorator(basePayment);
        IPayment flatDiscount = new FlatDiscountDecorator(percentageDiscount);

        Console.WriteLine($"Monto con descuento porcentaje y flat: {flatDiscount.GetAmount()}");
    }
}