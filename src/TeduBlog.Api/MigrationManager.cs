using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using TeduBlog.Data;

namespace TeduBlog.Api
{
    public static class MigrationManager
    {
        public static WebApplication MigrateDatabase(this WebApplication app)
        {
            using (var scope = app.Services.CreateScope())
            {
                using (var context = scope.ServiceProvider.GetRequiredService<TeduBlogContext>())
                {
                    context.Database.Migrate();
                    new DataSeeding().SeedingAsync(context).Wait();
                }
            }
            return app;
        }
    }
}
