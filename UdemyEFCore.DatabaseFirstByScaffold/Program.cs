using Microsoft.EntityFrameworkCore;
using UdemyEFCore.DatabaseFirstByScaffold.Models;

using (var context = new UdemyEFCoreDatabaseFirstDbContext())
{
    var product = await context.Products.ToListAsync();

    product.ForEach(p =>
    {
        Console.WriteLine($"{p.Id} : {p.Name} ürünü {p.Price} tl dir. Stok Durumu : {p.Stock} ");
    });
}
