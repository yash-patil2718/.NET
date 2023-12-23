namespace HR;

public class WageEmployee:Employee{
    private int hours;
    private int rate;


public WageEmployee(){
    hours = 0;
    rate = 0;
}

public WageEmployee(int pid, string pname,int hours, int rate):base(pid, pname){
    this.hours = hours;
    this.rate = rate;
}

public void setHours(int hours){
    this.hours = hours;
}

public void setRate(int rate){
    this.rate = rate;
}

public int getHours(){
    return this.hours;
}

public int getRate(){
    return this.rate;
}

public int calculateWage(){
    return hours * rate;
}

public override String ToString(){
    return base.ToString() + " " + this.hours + " " + this.rate + " " + calculateWage();
}
}

