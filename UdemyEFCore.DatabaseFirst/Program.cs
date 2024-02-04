using Microsoft.EntityFrameworkCore;
using UdemyEFCore.DatabaseFirst.DAL;

DbContextInitializer.Build(); // Nesne örneği üretmeden static olarak ulaştık.

using (var _context = new AppDbContext(/*DbContextInitializer.OptionsBuilder.Options*/))
{
    var product = await _context.Products.ToListAsync();

    product.ForEach(p =>
    {
        Console.WriteLine($"{p.Id} : {p.Name} ürünü {p.Price} tl dir. Stok Durumu : {p.Stock} ");
    });

} // Async olduğu için await ekledik. Async kullanıyoruz çünkü using ifadesinden çıktığı anda context nesnesi memoryden çıkacak.