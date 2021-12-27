using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using QuestionsAndAnswersDBContext.Data;
using QuestionsAndAnswersDBContext.Services;
using QuestionsAndAnswersWebAPI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuestionsAndAnswersWebAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy(name: "MyPolicy",
                builder =>
                {
                    builder.WithOrigins("https://localhost:44363",
                                            "http://localhost:44302")
                                .WithMethods("POST", "PUT", "DELETE", "GET")
                                .AllowAnyOrigin()
                                .AllowAnyMethod()
                                .AllowAnyHeader();
                });
            });
            services.AddControllers();
            services.AddMvc();
            services.AddTransient<IQuestionAndAnswerService, QuestionAndAnswerService>();
            services.AddTransient<ITechnologyService, TechnologyService>();
            services.AddTransient<IRegistrationService, RegistrationService>();
            services.AddTransient<IAnswersService, AnswersService>();
            services.AddTransient<ILoginService, LoginService>();
            services.AddScoped<IQuestionAndAnswerDBService, QuestionAndAnswerDBService>();
            services.AddScoped<ITechnologyDBService, TechnologyDBService>();
            services.AddScoped<IRegistrationDBService, RegistrationDBService>();
            services.AddScoped<IAnswersDBService, AnswersDBService>();
            var connectionstring = Configuration.GetConnectionString("Myconnection");
            services.AddDbContext<QuestionsandAnswersDBContext>(options => options.UseSqlServer(connectionstring));

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "QuestionsAndAnswersWebAPI", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "QuestionsAndAnswersWebAPI v1"));
            }


            app.UseRouting();
            app.UseCors();
            app.UseAuthorization();
            app.UseAuthorization();
            app.UseHttpsRedirection();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
