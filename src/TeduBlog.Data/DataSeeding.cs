using Microsoft.AspNetCore.Identity;
using TeduBlog.Core.Domain.Identity;

namespace TeduBlog.Data
{
    public class DataSeeding
    {
        public async Task SeedingAsync(TeduBlogContext context)
        {
            var passWordHasher = new PasswordHasher<AppUser>();
            var rootAdminRoleId = Guid.NewGuid();
            if (!context.Roles.Any())
            {
                await context.Roles.AddAsync(new AppRole()
                {
                    Id = rootAdminRoleId,
                    Name = "Admin",
                    NormalizedName = "ADMIN",
                    DisplayName = "Quản trị viên",
                });
                await context.SaveChangesAsync();
            }

            if (!context.Users.Any())
            {
                var userId = Guid.NewGuid();
                var userEntity = new AppUser()
                {
                    Id = userId,
                    FirstName = "Đinh",
                    LastName = "Văn Phương",
                    Email = "phuong.it6@gmail.com",
                    NormalizedEmail = "PHUONG.IT6@GMAIL.COM",
                    NormalizedUserName = "ADMIN",
                    UserName = "admin",
                    IsActive = true,
                    DateCreated = DateTime.Now,
                    LockoutEnabled = false,
                };
                userEntity.PasswordHash = passWordHasher.HashPassword(userEntity, "Abcd@1234");
                await context.Users.AddAsync(userEntity);
                await context.SaveChangesAsync();
                await context.UserRoles.AddAsync(new IdentityUserRole<Guid>()
                {
                    UserId = userId,
                    RoleId = rootAdminRoleId
                });
                await context.SaveChangesAsync();
            }
        }
    }
}
