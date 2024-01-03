// using BOL;
// using DAL;

// bool status = true;

// while (status)
// {
//     Console.WriteLine("Choose the options ");
//     Console.WriteLine("1 Show list");
//     Console.WriteLine("2 Insert into list");
//     Console.WriteLine("3 Update the list ");
//     Console.WriteLine("4 Delete item int the list ");
//     Console.WriteLine("5 Exit ");

//     switch (int.Parse(Console.ReadLine()))
//     {
//         case 1:
//             List<Product> pls = idb.GetAll();
//             foreach (var product in pls)
//             {
//                 Console.WriteLine("ProductId->" + product.Pid + " Productname->" + product.Pnm + " productPrice->" + product.Price + " ProductQty->" + product.Qyt);
//             }
//             break;

//         case 2:
//             Product p1 = new Product(4, "boat", 20, 10.12f);

//             idb.Insert(p1);
//             break;
//         case 3:
//             Product p2 = new Product(4, "ball", 20, 10.12f);
//             idb.Update(p2, 4);
//             break;

//         case 4:
//             idb.Delete(4);
//             break;

//         case 5:
//             status = false;
//             break;

//     }
// }
using Microsoft.Extensions.FileSystemGlobbing.Internal.Patterns;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
var app = builder.Build();
if (!app.Environment.IsDevelopment())
{
    app.UseHsts();

}
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.MapControllerRoute(
 name: "default",
pattern: "{controller=Product}/{action=Index}/{id?}"
);
app.Run();

