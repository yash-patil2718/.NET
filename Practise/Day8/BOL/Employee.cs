namespace BOL;

public class Employee
{
    // private int pid;
    // private string pname;
    // private string padd;
    // private long pmobile;

    public Employee(int pid, string pname, string padd, long pmobile){
        this.Pid = pid;
        this.Pname = pname;
        this.Padd = padd;
        this.Pmobile = pmobile;
    }

    public int Pid{get; set;}
    public string Pname{get; set;}
    public long Pmobile{get; set;}
    public string Padd{get; set;}

    public string ToString(){
        return ("Pid : "+ Pid +" Pname : "+ Pname +"Pmobile : "+ Pmobile +" Padd : "+ Padd);
    }

}
