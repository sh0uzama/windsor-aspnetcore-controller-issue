using Castle.Core;
using Castle.Facilities.AspNetCore;
using Castle.Windsor;
using Library;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WindsorWorking.Controllers;

namespace WindsorWorking
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
      services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
      var container = new WindsorContainer();
      services.AddWindsor(container, opts =>
      {
        opts.RegisterControllers(typeof(LibraryController).Assembly, LifestyleType.Transient);
        opts.RegisterControllers(typeof(ApplicationController).Assembly, LifestyleType.Transient);
      });
    }

    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    public void Configure(IApplicationBuilder app, IHostingEnvironment env)
    {
      app.UseDeveloperExceptionPage();
      app.UseMvcWithDefaultRoute();
    }
  }
}
