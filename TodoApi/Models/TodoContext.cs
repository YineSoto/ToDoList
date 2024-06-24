using Microsoft.EntityFrameworkCore;

namespace TodoApi.Models;

public class TodoContext : DbContext
{

    public TodoContext(DbContextOptions<TodoContext> options)
        : base(options) // es la super en Java
    {
    }

    /*Conjunto o coleccion que contendrá los datos
    El null tiene un signo de exclamacion afirmando que se va a recibir o 
    ingresar un null*/
    public DbSet<TodoItem> TodoItems { get; set; } = null!;
}