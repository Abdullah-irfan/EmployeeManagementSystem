using EmployeeManagement.Core;
using EmployeeManagement_.Resources;
using EmployeeManagement_.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement_.Utility
{
   public class Resolver
    {
        public static void ConfigureServices(IServiceCollection services)
        {
            #region Context accesor
            // this is for accessing the http context by interface in view level
            services.AddTransient<IHttpContextAccessor, HttpContextAccessor>();
            #endregion

            #region Services

            services.AddScoped<IEmployeeManagementServices, EmployeeManagementServices>();

            #endregion

            #region Repository

            services.AddScoped<IEmployeeManagementRepositories, EmployeeManagementRepositories>();

            #endregion

        }
    }
}

