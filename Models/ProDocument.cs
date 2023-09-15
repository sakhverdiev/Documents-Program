namespace Documents.Models;

class ProDocument : Documents.Models.DocumentProgram
{
    public ProDocument() { }

    public override void EditDocument()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Thread.Sleep(1500);
        Console.WriteLine("Document Edited");
        Thread.Sleep(1500);
    }

    public override void SaveDocument()
    {
        Console.WriteLine("\nDocument Saved");
        Thread.Sleep(1000);
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("\nBuy Expert Edition for PDF Format\n");
        Thread.Sleep(1000);
    }
}