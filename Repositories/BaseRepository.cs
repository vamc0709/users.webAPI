using Microsoft.EntityFrameworkCore;
using users.webAPI.models;


namespace users.webAPI.Repositories;

public class BaseRepository
{
    private readonly IConfiguration _configuration;
    public BaseRepository(IConfiguration configuration)
    {
        _configuration = configuration;
    }
public void ConfigureServices(IServiceCollection services)
{
    var connection = _configuration.GetConnectionString("DefaultConnection");
    services.AddDbContext<SampleDBContext>(options => options.UseSqlServer(connection));
}
}