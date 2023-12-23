namespace HR;

public class Employee{
    private int pid;
    private string pname;

    public Employee(){
        pid = 0;
        pname = null;
    }

    public Employee(int id, string name){
        this.pid = id;
        this.pname = name;
    }

    public void setpid(int id){
        this.pid = id;
    }

    public int getpid(){
        return pid;
    }

    public void setpname(string name){
        this.pname = name;
    }

    public string getpname(){
        return pname;
    }

    public override string ToString(){
        return this.pid +" " + this.pname;
    }
}