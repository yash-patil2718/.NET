namespace Hardware;

public class HPPrinter: IPrinter, IScanner{
    public void print(){
        Console.WriteLine("Printer has Started.....");
    }
    public void scan(){
        Console.WriteLine("Scanner has started....");
    }
}

