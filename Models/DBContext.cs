using Microsoft.EntityFrameworkCore;
using users.webAPI.Models;

namespace users.webAPI.models;

public class SampleDBContext : DbContext
{
    public SampleDBContext(DbContextOptions<SampleDBContext> options)
           : base(options)
    {

    }
public DbSet<usersModel> users { get; set; }

}

