
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Radio_player._Entities.Concrete.DatabaseFirst;
using Radio_player.Business.Abstract;
using Radio_player.Business.Concrete;
using Radio_player.DataAccess.Abstract;
using Radio_player.DataAccess.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radio_player.Services
{
    public static class ServiceRegistration
    {
        public static void AddCustomServices(this IServiceCollection services)
        {
            services.AddDbContext<RadioPlayer_DbContext>(options => options.UseSqlServer(ConfigurationSQL.ConnectionString));
        
            services.AddTransient<IRadioService, RadioManager>();
           services.AddTransient<IRadioDAL, EF_RadioDAL>();

        }
    }
}
