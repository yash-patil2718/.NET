public class Product{
    
    public int ProductId{get; set;}
    public string ProductName{get; set;}
    public int ProductQty{get; set;}
    public int ProductRate{get; set;}

    public Product(){

    }

    public Product(int id, string name, int qty, int rate){
        ProductId = id;
        ProductName = name;
        ProductQty = qty;
        ProductRate = rate;
    }

    public string ToString(){
        return ProductId + " " + ProductName + " "+ ProductQty+" "+ ProductRate;
    }
}