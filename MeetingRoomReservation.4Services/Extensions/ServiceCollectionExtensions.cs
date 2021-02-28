using MeetingRoomReservation._3Data.Abstract;
using MeetingRoomReservation._3Data.Concrete;
using MeetingRoomReservation._3Data.Concrete.EntityFrameWork.Contexts;
using MeetingRoomReservation._4Services.Abstract;
using MeetingRoomReservation._4Services.Concrete;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeetingRoomReservation._4Services.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection LoadMyServices(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddDbContext<MeetingRoomReservationContext>();
            //serviceCollection.AddIdentity<User, Role>(options =>
            //{
            //    // User Password Options
            //    options.Password.RequireDigit = false;
            //    options.Password.RequiredLength = 5;
            //    options.Password.RequiredUniqueChars = 0;
            //    options.Password.RequireNonAlphanumeric = false;
            //    options.Password.RequireLowercase = false;
            //    options.Password.RequireUppercase = false;
            //    // User Username and Email Options
            //    options.User.AllowedUserNameCharacters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-._@+$";
            //    options.User.RequireUniqueEmail = true;
            //}).AddEntityFrameworkStores<ProgrammersBlogContext>();
            //serviceCollection.Configure<SecurityStampValidatorOptions>(options => {
            //    options.ValidationInterval = TimeSpan.FromMinutes(10); 
            //});
            serviceCollection.AddScoped<IUnitOfWork, UnitOfWork>();
            serviceCollection.AddScoped<IPlaceService, PlaceManager>();
            //  serviceCollection.AddScoped<IToplantiService, ArticleManager>();
            // serviceCollection.AddScoped<ICommentService, CommentManager>();
            return serviceCollection;
        }
    }
}
