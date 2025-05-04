using SignalR.BusinessLayer.Abstract;
using SignalR.BusinessLayer.Concrete;
using SignalR.DataAccessLayer.Abstract;
using SignalR.DataAccessLayer.EntityFramework;
using SignalR.DataAccessLayer.Repositories;
using SignalR.EntityLayer.Entites;

namespace SignalRApi.Extension
{
    public static class EntityExtensions
    {
        public static IServiceCollection AddProjectServices(this IServiceCollection services)
        {
            services.AddScoped<IAboutService, AboutManager>();
            services.AddScoped<IAboutDal, EfAboutDal>();

            services.AddScoped<IBookingService, BookingManager>();
            services.AddScoped<IBookingDal, EfBookingDal>();

            services.AddScoped<ICategoryService, CategoryManager>();
            services.AddScoped<ICategoryDal, EfCategoryDal>();

            services.AddScoped<IContactUsService, ContactUsManager>();
            services.AddScoped<IContactUsDal, EfContactUsDal>();

            services.AddScoped<IDiscountService, DiscountManager>();
            services.AddScoped<IDiscountDal, EfDiscountDal>();

            services.AddScoped<IFeatureService, FeatureManager>();
            services.AddScoped<IFeatureDal, EfFeatureDal>();

            services.AddScoped<IProductService, ProductManager>();
            services.AddScoped<IProductDal, EfProductDal>();

            services.AddScoped<ISocialMediaService, SocialMediaManager>();
            services.AddScoped<ISocialMediaDal, EfSocialMediaDal>();

            services.AddScoped<ITestimonialService, TestimonialManager>();
            services.AddScoped<ITestimonialDal, EfTestimonialDal>();

            services.AddScoped<IGenericDal<About>, GenericRepository<About>>();
            services.AddScoped<IGenericService<About>, AboutManager>();

            services.AddScoped<IGenericDal<Booking>, GenericRepository<Booking>>();
            services.AddScoped<IGenericService<Booking>, BookingManager>();

            services.AddScoped<IGenericDal<Category>, GenericRepository<Category>>();
            services.AddScoped<IGenericService<Category>, CategoryManager>();

            services.AddScoped<IGenericDal<ContactUs>, GenericRepository<ContactUs>>();
            services.AddScoped<IGenericService<ContactUs>, ContactUsManager>();

            services.AddScoped<IGenericDal<Discount>, GenericRepository<Discount>>();
            services.AddScoped<IGenericService<Discount>, DiscountManager>();

            services.AddScoped<IGenericDal<Feature>, GenericRepository<Feature>>();
            services.AddScoped<IGenericService<Feature>, FeatureManager>();

            services.AddScoped<IGenericDal<Product>, GenericRepository<Product>>();
            services.AddScoped<IGenericService<Product>, ProductManager>();

            services.AddScoped<IGenericDal<SocialMedia>, GenericRepository<SocialMedia>>();
            services.AddScoped<IGenericService<SocialMedia>, SocialMediaManager>();

            services.AddScoped<IGenericDal<Testimonial>, GenericRepository<Testimonial>>();    
            services.AddScoped<IGenericService<Testimonial>, TestimonialManager>();

            return services;
        }
    }
}
