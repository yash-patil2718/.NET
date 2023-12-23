namespace HR;
 public class Person{
    private int pid;
    private String pname;
    private String pmail;

    public Person(){
        this.pid=0;
        this.pname=null;
        this.pmail=null;
    }
    public Person(int id,String name,String mail){
        this.pid=id;
        this.pname=name;
        this.pmail=mail;
    }

    public String Pname{
        get{
            return this.pname;
        }
        set{
            this.pname=value;
        }
    }

    public String Pmail{
        get{
            return this.pmail;
         }
         set{
            this.pmail=value;
         }
    }
    public int Pid{
        get{
            return this.pid;
        }
        set{
            this.pid=value;
        }
    }

    public override string ToString() {
      return  (this.pid+" "+this.pname+" "+this.pmail);

    }

 }