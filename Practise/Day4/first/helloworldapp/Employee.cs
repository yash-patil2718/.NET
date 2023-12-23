namespace HR;

public abstract class Employee:Person{
      private string Designation;

      public Employee(){
        this.Designation=null;
      }
      public Employee(int pid, String pname, String pmail,String des):base(pid,pname,pmail){
        this.Designation=des;
      }
      public String Desig{
       get{
        return this.Designation;
       }
       set{
        this.Designation=value;
       }
      }

      public abstract int calculateWage();

      public  override String ToString(){
        return (base.ToString()+" "+this.Designation);
      }
}