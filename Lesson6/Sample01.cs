using Microsoft.EntityFrameworkCore;
using Orders.DAL;

internal class Sample01
{
    static void Main(string[] args)
    {
        var dbContextOptionsBuilder = new DbContextOptionsBuilder<OrdersDbContext>()
            .UseSqlServer("data source=; initial catalog=OrdersDatabase;User Id=OrdersUser;Password=12345;");
            // data source = Имя сервера
    }
}
