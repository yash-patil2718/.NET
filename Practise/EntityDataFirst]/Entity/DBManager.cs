using BOL;
using DLL;
namespace DAL;
public class DBManager : IDBManager
{
  public void Delete(int id)
  {
    using (var context = new ProductContext())
    {

      context.Pls.Remove(context.Pls.Find(id));
      context.SaveChanges();
    }
  }

  public List<Product> GetAll()
  {
    using (var context = new ProductContext())
    {
      var products = from product in context.Pls
                     select product;

      return products.ToList<Product>();
    }
  }

  public Product GetById(int id)
  {
    using (var context = new ProductContext())
    {
      var product = context.Pls.Find(id);
      return product;
    }
  }

  public void Insert(Product p)
  {
    using (var context = new ProductContext())
    {

      context.Pls.Add(p);
      context.SaveChanges();
    }
  }



  public void Update(Product p, int id)
  {
    using (var context = new ProductContext())
    {
      var prod = context.Pls.Find(id);
      prod.Pnm = p.Pnm;
      prod.Qyt = p.Qyt;
      prod.Price = p.Price;
      context.SaveChanges();
    }




  }

}