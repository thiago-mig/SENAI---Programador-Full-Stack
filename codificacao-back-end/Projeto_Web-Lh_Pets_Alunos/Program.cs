namespace Projeto_Web_Lh_Pets_versão_1;


public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        var app = builder.Build();

        app.MapGet("/", () => "Projeto Web: LH-Pets versão 1.0");
        app.UseStaticFiles();
        app.MapGet("/index", (HttpContext context) => {
          context.Response.Redirect("index.html", false);
        });
        Banco dba = new Banco();
        app.MapGet("ListaClientes", (HttpContext context) => {
          context.Response.WriteAsync(dba.GetListaString());
        });
        app.Run();
    }
}
