using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Template.Application.Services;
using Template.Application.Interfaces;

namespace Template.IoC
{
    public static class NativeInjectors
    {
        public static void RegisterServices(IServiceCollection services)
        {
             services.AddScoped<IUserService, UserService>();
        }
    }
}
