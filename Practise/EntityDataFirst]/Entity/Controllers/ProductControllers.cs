using BOL;
using DAL;
using Microsoft.AspNetCore.Mvc;

namespace Controller;
[ApiController]
[Route("[controller]")]
public class ProductController : ControllerBase
{
  IDBManager idb = new DBManager();
  private readonly ILogger<ProductController> _logger;
  public ProductController(ILogger<ProductController> logger)
  {
    this._logger = logger;
  }

  [HttpGet]
  public List<Product> Get()
  {

    List<Product> pls = idb.GetAll();
    return pls;

  }
  [HttpPost]
  public void Get([FromBody] Product p)
  {
    Console.WriteLine("sjyr");
    idb.Insert(p);

  }
  [HttpGet("{id}")]
  public Product Get(int id)
  {

    Product p = idb.GetById(id);
    return p;
  }

  [HttpDelete("{id}")]
  public void DeleteById(int id)
  {

    idb.Delete(id);

  }


  [HttpPut("{id}")]
  public void UpdateById([FromBody] Product p, int id)
  {

    idb.Update(p, id);

  }


}