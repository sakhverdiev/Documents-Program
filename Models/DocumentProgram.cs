namespace Documents.Models;

class DocumentProgram
{
    public DocumentProgram() { }

    public void OpenDocument()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Thread.Sleep(1000);
        Console.WriteLine("Document Opened");
    }

    virtual public void EditDocument()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Thread.Sleep(1500);
        Console.WriteLine("\nBuy the Pro or Expert Editions to Edit");
    }

    virtual public void SaveDocument()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Thread.Sleep(1000);
        Console.WriteLine("\nBuy the Pro or Expert Editions to Save");
        Thread.Sleep(1500);
        Console.ForegroundColor = ConsoleColor.White;
    }

}