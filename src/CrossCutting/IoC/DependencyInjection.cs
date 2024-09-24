using Application.Abstractions.UseCases;
using Application.Contexts;
using Application.UseCases.Notifications;
using Domain.Interfaces.Factories;
using Domain.Interfaces.Strategies;
using Infrastructure.Factories.Notifications;
using Infrastructure.Strategies.Notifications;
using Microsoft.Extensions.DependencyInjection;

namespace CrossCutting.IoC;

public static class DependencyInjection
{
    public static void AddApplication(this IServiceCollection services)
    {
        AddUseCases(services);
        AddContexts(services);
    }

    public static void AddInfrastructure(this IServiceCollection services)
    {
        AddFactories(services);
        AddStrategies(services);
    }
    
    private static void AddUseCases(IServiceCollection services)
    {
        services.AddScoped<ISendNotificationUseCase, SendNotificationUseCase>();
    }
    
    private static void AddContexts(IServiceCollection services)
    {
        services.AddScoped<NotificationContext>();
    }
    
    private static void AddFactories(IServiceCollection services)
    {
        services.AddSingleton<INotificationStrategyFactory, NotificationStrategyFactory>();
    }
    
    private static void AddStrategies(IServiceCollection services)
    {
        services.AddTransient<INotificationStrategy, EmailNotificationStrategy>();
        services.AddTransient<INotificationStrategy, SmsNotificationStrategy>();
        services.AddTransient<INotificationStrategy, TwitterNotificationStrategy>();
        services.AddTransient<INotificationStrategy, WhatsAppNotificationStrategy>();
    }
}