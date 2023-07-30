using razorpages_movie.Data;

namespace razorpages_movie.Extensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureDbContext(this IServiceCollection services)
        {
            services.AddDbContext<razorpages_movieContext>();

            //services.AddDbContext<razorpages_movieContext>(options =>
            // options.UseSqlServer(builder.Configuration.GetConnectionString("razorpages_movieContext") 
            // ?? throw new InvalidOperationException("Connection string 'razorpages_movieContext' not found.")));

        }

    }
}
