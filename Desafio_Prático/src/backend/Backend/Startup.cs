using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Mvc;

namespace MyApp
{
[ApiController]
[Route("api/[controller]")]

public class FornecedoresController : ControllerBase
{
    private readonly IFornecedorService _fornecedorService;

    public FornecedoresController(IFornecedorService fornecedorService)
    {
        _fornecedorService = fornecedorService;
    }

    [HttpGet]
    public IActionResult Get()
    {
        var fornecedores = _fornecedorService.GetFornecedores();

        if (fornecedores == null)
        {
            return NotFound();
        }

        return Ok(fornecedores);
    }

    [HttpPost]
    public IActionResult Post([FromBody] FornecedoresController fornecedor)
    {
        if (fornecedor == null)
        {
            return BadRequest();
        }

        _fornecedorService.AddFornecedor(fornecedor);

        return CreatedAtRoute("GetFornecedor", new { id = fornecedor.Id }, fornecedor);
    }
}

    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            // Configurar serviços necessários para o aplicativo
            services.AddControllers();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }    
}
