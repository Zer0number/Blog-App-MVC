using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogApp.Models
{
    public class TestData
    {
        private readonly UserManager<User> userManager;
        public async Task InitializeUsers(UserApplicationDbContext context)
        {
            if (!context.IdentityUsers.Any())
            {
                User debugUser = new User
                {
                    Email = "debug@debug.com",
                    UserName = "debug"
                };
                await userManager.CreateAsync(debugUser, "Debug_123");
            }
        }
        public static void Initialize(BlogContext context)
        {
            if (!context.Articles.Any())
            {
                User debugUser = new User
                {
                    Email = "debug@debug.com",
                    UserName = "debug"
                };
                context.Articles.AddRange(
                    new Article
                    {
                        Title = "Lorem ipsum dolor sit amet,",
                        MainContent = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                        Date = "01.01.2021 12:00",
                        User = debugUser
                    },
                    new Article
                    {
                        Title = "Lorem ipsum dolor sit amet, consectetur adipiscing elit,",
                        MainContent = "Dui vivamus arcu felis bibendum ut tristique. Rhoncus mattis rhoncus urna neque viverra justo. Mi tempus imperdiet nulla malesuada pellentesque elit. Sagittis purus sit amet volutpat. Gravida arcu ac tortor dignissim convallis aenean et tortor. Ac placerat vestibulum lectus mauris. Sit amet volutpat consequat mauris nunc congue nisi vitae suscipit. Rhoncus est pellentesque elit ullamcorper dignissim cras tincidunt. Nisi lacus sed viverra tellus.",
                        Date = "01.01.2021 12:00",
                        User = debugUser
                    },
                    new Article
                    {
                        Title = "Viverra tellus in hac habitasse platea dictumst vestibulum rhoncus.",
                        MainContent = "Gravida quis blandit turpis cursus in hac habitasse. Ipsum nunc aliquet bibendum enim facilisis gravida neque convallis a. Facilisis sed odio morbi quis. Ullamcorper dignissim cras tincidunt lobortis feugiat vivamus. Erat imperdiet sed euismod nisi porta.",
                        Date = "01.01.2021 12:00",
                        User = debugUser
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
