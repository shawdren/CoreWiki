using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace CoreWiki.Configuration.Startup
{
	public static class ConfigureMediator
	{
		public static IServiceCollection AddMediator(this IServiceCollection services)
		{
			services.AddMediatR(Assembly.GetExecutingAssembly());
			return services;
		}
	}
}
