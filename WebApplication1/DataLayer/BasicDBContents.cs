using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.Net.Http.Headers;

namespace WebApplication1.DataLayer
{
    //create a object 
public class BasicDBContext : DbContext {
//add data to a database
public DbSet<Message> messages {get;set;} -null!;

//inheritance set content options 
//constror passing an object = BasicDBcontent type 
    public BasicDBContext(DbContextOptions<BasicDBContext> options):base (options)
    {

    }
protected override void OneModelCreating(ModelBulider modelBulider)
{
    base.OneModelCreating{modelBuilder};
    modelBulider.EntityFrameworkCore<Messages>().HasData (
new Message {MessageID - 1, MessageText"message one"},
new Message {MessageID - 2, MessageText-"message two"}
    ) ;

};
    
}
}

