using Microsoft.EntityFrameworkCore;
using SignalR.BusinessLayer.Abstract;
using SignalR.BusinessLayer.Concrete;
using SignalR.DataAccessLayer.Abstract;
using SignalR.DataAccessLayer.Concrete;
using SignalR.DataAccessLayer.EntityFramework;
using SignalR.DataAccessLayer.Repositories;
using SignalR.EntityLayer.Entites;
using SignalRApi.Mapping;
using System;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddDbContext<Context>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddScoped<IAboutService, AboutManager>();
builder.Services.AddScoped<IAboutDal, EfAboutDal>();

builder.Services.AddScoped<IBookingService, BookingManager>();
builder.Services.AddScoped<IBookingDal, EfBookingDal>();

builder.Services.AddScoped<ICategoryService, CategoryManager>();
builder.Services.AddScoped<ICategoryDal, EfCategoryDal>();

builder.Services.AddScoped<IContactUsService, ContactUsManager>();
builder.Services.AddScoped<IContactUsDal, EfContactUsDal>();

builder.Services.AddScoped<IDiscountService, DiscountManager>();
builder.Services.AddScoped<IDiscountDal, EfDiscountDal>();

builder.Services.AddScoped<IFeatureService, FeatureManager>();
builder.Services.AddScoped<IFeatureDal, EfFeatureDal>();

builder.Services.AddScoped<IProductService, ProductManager>();
builder.Services.AddScoped<IProductDal, EfProductDal>();

builder.Services.AddScoped<ISocialMediaService, SocialMediaManager>();
builder.Services.AddScoped<ISocialMediaDal, EfSocialMediaDal>();

builder.Services.AddScoped<ITestimonialService, TestimonialManager>();
builder.Services.AddScoped<ITestimonialDal, EfTestimonialDal>();

builder.Services.AddScoped<IGenericDal<About>, GenericRepository<About>>();
builder.Services.AddScoped<IGenericDal<Booking>, GenericRepository<Booking>>();
builder.Services.AddScoped<IGenericDal<Category>, GenericRepository<Category>>();
builder.Services.AddScoped<IGenericDal<ContactUs>, GenericRepository<ContactUs>>();
builder.Services.AddScoped<IGenericDal<Discount>, GenericRepository<Discount>>();
builder.Services.AddScoped<IGenericDal<Feature>, GenericRepository<Feature>>();
builder.Services.AddScoped<IGenericDal<Product>, GenericRepository<Product>>();
builder.Services.AddScoped<IGenericDal<SocialMedia>, GenericRepository<SocialMedia>>();
builder.Services.AddScoped<IGenericDal<Testimonial>, GenericRepository<Testimonial>>();

builder.Services.AddScoped<IGenericService<About>, AboutManager>();
builder.Services.AddScoped<IGenericService<Booking>, BookingManager>();
builder.Services.AddScoped<IGenericService<Category>, CategoryManager>();
builder.Services.AddScoped<IGenericService<ContactUs>, ContactUsManager>();
builder.Services.AddScoped<IGenericService<Discount>, DiscountManager>();
builder.Services.AddScoped<IGenericService<Feature>, FeatureManager>();
builder.Services.AddScoped<IGenericService<Product>, ProductManager>();
builder.Services.AddScoped<IGenericService<SocialMedia>, SocialMediaManager>();
builder.Services.AddScoped<IGenericService<Testimonial>, TestimonialManager>();

//builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());


builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
