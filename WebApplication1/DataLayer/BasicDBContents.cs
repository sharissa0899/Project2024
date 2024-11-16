using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.Net.Http.Headers;
using WebApplication1.Models;


namespace WebApplication1.DataLayer{
//create a object that handles the sqlite database
public class BasicDBContext : DbContext {
//allows users to add data to a database/table
public DbSet<Message> messages {get;set;} = null!;

//inheritance set content options 
//constror passing an object = BasicDBcontent type 
    public BasicDBContext(DbContextOptions<BasicDBContext> options):base (options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
{
     base.OnModelCreating(modelBuilder);
     
     modelBuilder.Entity<Message>().HasData(

    new Message {MessageID =1, MessageText = " I am leanring "},
    new Message {MessageID =2, MessageText = " I am learning, and it is painful! "}


     );

}
}
}

