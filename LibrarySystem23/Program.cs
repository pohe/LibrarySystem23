// See https://aka.ms/new-console-template for more information


using LibrarySystem23;

//en instans eller et objekt
Media m1 = new Media(1, "C# programming", "John Sharp", "Microsoft", 2021);
Media m2 = new Media(2, "PHP programming", "John Sharp", "Microsoft", 2021);
Media m3 = new Media(3, "HTML programming", "Peter Hansen", "Microsoft", 2021);
Media m4 = new Media("H.C.ANdersens eventyr");

Console.WriteLine(m1);
Console.WriteLine(m2);
Console.WriteLine(m3);
Console.WriteLine(m4);

Book b1 = new Book("1141445", 6, "Grimms eventyr", "Grimm", "AEX", 2019);
Console.WriteLine(b1.ToString());

MediaCatalog catalog = new MediaCatalog();
try
{
    
    catalog.AddMedia(m1);
    catalog.AddMedia(m2);
    catalog.AddMedia(m3);
    catalog.AddMedia(b1);
    catalog.AddMedia(m4);
}
catch(ArgumentException aex)
{
    Console.WriteLine(aex.Message);
}
catch(Exception ex)
{
    Console.WriteLine("Generel fejl " + ex.Message);
}

catalog.PrintMediaList();

Console.WriteLine(catalog.GetMedia(2) );
Console.WriteLine("Test af ToString i MediaCatalog");
Console.WriteLine(catalog);


Console.WriteLine("Test af GetMedia");
Media ml= catalog.GetMedia(2);
Console.WriteLine(ml);




//TIlføj book b1 til MeidaCatalog

//try
//{
//    catalog.AddMedia(b1);
//}
//catch(ArgumentException aex)
//{
//    Console.WriteLine(aex.Message);
//}


Console.WriteLine("Udskrivning efter book er tilføjet");
catalog.PrintMediaList();

Console.WriteLine("Test af GetMediaByAuthor");
List<Media> list = catalog.GetMediaByAuthor("John Sharp");
if (list != null)
{
    //foreach (Media media in list)
    //{
    //    Console.WriteLine(media);
    //}
    int i = 0; 
    while ( i < list.Count)
    {
        Console.WriteLine(list[i].ToString());
        i++;
    }
}else
{
    Console.WriteLine("Der er ingen forfattere med det navn");
}
