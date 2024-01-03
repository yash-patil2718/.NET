namespace BOL;

public class Product
{

  public Product(int pid, string pnm, int qyt, float price)
  {
    this.Pid = pid;
    this.Pnm = pnm;
    this.Qyt = qyt;
    this.Price = price;
  }
  public int Pid { get; set; }
  public string Pnm { get; set; }
  public int Qyt { get; set; }
  public float Price { get; set; }


}