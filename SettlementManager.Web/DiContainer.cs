using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SettlementManager.Contract;
using SettlementManager.Infrastructure.Configuration;
using SettlementManager.Infrastructure.Exceptions.Factories;
using SettlementManager.Infrastructure.Exceptions.Handlers;
using SettlementManager.Infrastructure.Filters;
using SettlementManager.Model;
using SettlementManager.Repository;
using SettlementManager.Service;
using SettlementManager.Service.Factoreies;
using SettlementManager.Service.Factoreies.Mapping;

namespace SettlementManager.Web
{
	public static class DiContainer
	{
		#region Public Methods

		public static void Configure(WebApplicationBuilder builder)
		{
			ConfigureServices(builder.Services);
			ConfigureRepositories(builder.Services, builder.Configuration);
			ConfigureDatabase(builder.Services, builder.Configuration);
			ConfigureMappingProfiles(builder.Services);
			//ConfigureExceptionHandling(builder.Services);
		}

		#endregion


		#region Private Methods

		private static void ConfigureServices(IServiceCollection services)
		{
			services.AddTransient<ICountryService, CountryService>();
			services.AddTransient<ISettlementService, SettlementService>();
			services.AddTransient<ICountryFactory, CountryFactory>();
			services.AddTransient<ISettlementFactory, SettlementFactory>();
		}

		private static void ConfigureRepositories(IServiceCollection services, IConfiguration config)
		{
			services.AddTransient<ICountryRepository, CountryRepository>();
			services.AddTransient<ISettlementRepository, SettlementRepository>();
		}

		private static void ConfigureDatabase(IServiceCollection services, IConfiguration config)
		{
			var databaseConfig = config.GetSection(nameof(DatabaseConfiguration)).Get<DatabaseConfiguration>();

			services.AddDbContext<SettlementMangerDbContext>(
				(options) => options.UseSqlServer(databaseConfig.SettlementManagerConnectionString)
				,
				ServiceLifetime.Scoped
			);
		}

		public static void ConfigureMappingProfiles(IServiceCollection services)
		{
			var mapperConfig = new MapperConfiguration(mc =>
			{
				mc.AddProfile(new CountryMappingProfile());
				mc.AddProfile(new SettlementMappingProfile());
			});

			services.AddSingleton(mapperConfig.CreateMapper());
		}

		private static void ConfigureExceptionHandling(IServiceCollection services)
		{
			services.AddTransient<IExceptionHandlerFactory, ExceptionHandlerFactory>();

			services.AddTransient<IExceptionHandler, DefaultExceptionHandler>();
			services.AddTransient<IExceptionHandler, ValidationEntityExceptionHandler>();
			services.AddTransient<IExceptionHandler, ResourceNotFoundExceptionHandler>();

			services.AddControllers(options =>
			{
				options.Filters.Add<ExceptionFilter>();
			});
		}

		#endregion
	}
}
