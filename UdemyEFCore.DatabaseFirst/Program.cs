using Microsoft.EntityFrameworkCore;
using UdemyEFCore.DatabaseFirst.DAL;

using (var _context = new AppDbContext())
{
    var product = await _context.Products.ToListAsync();

    product.ForEach(p =>
    {
        Console.WriteLine($"{p.Id} : {p.Name}");
    });

} // Async olduğu için await ekledik. Async kullanıyoruz çünkü using ifadesinden çıktığı anda context nesnesi memoryden çıkacak.