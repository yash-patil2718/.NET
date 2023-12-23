namespace HR;

public class WageEmployee:Employee{
    private int hours;
    private int rate;

    public WageEmployee(){
        hours = 0;
        rate = 0;
    }

    public WageEmployee(int pid, String pname, String pmail,String des,int hours, int rate):base(pid,pname,pmail,des){
        this.hours = hours;
        this.rate = rate;
    }

    public int Hours{
        get{return this.hours;}
        set{this.hours = value;}
    }

    public int Rate{
        get{return this.rate;}
        set{this.rate = value;}
    }

    public override int calculateWage(){
        return hours * rate;
    }

    public override String ToString(){
        return (base.ToString()+ " "+ this.hours+" "+ this.rate +" "+ calculateWage());
    }
}