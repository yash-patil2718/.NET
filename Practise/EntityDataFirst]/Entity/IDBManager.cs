using BOL;
namespace DAL;

public interface IDBManager
{
  List<Product> GetAll();
  Product GetById(int id);
  void Insert(Product p);
  void Update(Product p, int id);
  void Delete(int id);
}