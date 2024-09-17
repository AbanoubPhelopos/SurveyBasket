namespace Survey.Api
{
    public static class ApplicationServiceCollectionExtension
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddControllers();
            
            // Properly chaining Swagger and other services
            services.AddEndpointsApiExplorer()
                .AddSwaggerGen()
                .AddApplicationDependencies();
            
            return services;
        }

        private static IServiceCollection AddApplicationDependencies(this IServiceCollection services)
        {
            // Registering services and FluentValidation dependencies
            services.AddScoped<IPollServices, PollServices>();

            services.AddFluentValidationAutoValidation()  // Ensure FluentValidation setup
                .AddValidatorsFromAssembly(typeof(CreatePollRequestValidation).Assembly);
            
            return services;
        }
    }
}