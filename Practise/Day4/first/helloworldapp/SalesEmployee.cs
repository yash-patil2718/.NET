namespace HR;
public class SalesEmployee:Employee{
    private int amount;
    private int target;

    public SalesEmployee(){
        amount=0;
        target=0;
    }
    public SalesEmployee(int pid, String pname, String pmail,String des,int amt,int tar):base(pid,pname,pmail,des){
        this.amount=amt;
        this.target=tar;
    }
    public  int Amount{
        get{
            return this.amount;
        }
        set{
            this.amount=value;
        }
    }
    public  int Target{
        get{
            return this.target;
        }
        set{
            this.target=value;
        }
    }

     public override int calculateWage(){
        return amount * target;
    }
    public override string ToString(){
        return (base.ToString()+""+this.amount+" "+this.target);
    }
}