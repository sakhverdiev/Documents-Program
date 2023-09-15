namespace Documents.Models;

class ExpertDocument : Models.ProDocument
{
    public ExpertDocument() { }


    public override void SaveDocument()
    {
        Thread.Sleep(1000);
        Console.WriteLine("Document Saved in PDF Format");
    }
}