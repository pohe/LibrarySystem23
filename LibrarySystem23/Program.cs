// See https://aka.ms/new-console-template for more information


using LibrarySystem23;

//en instans eller et objekt
Media m1 = new Media(1, "C# programming", "John Sharp", "Microsoft", 2021);
Media m2 = new Media(2, "PHP programming", "CHarlotte Heegaard", "Microsoft", 2021);
Media m3 = new Media(3, "HTML programming", "Peter Hansen", "Microsoft", 2021);
Media m4 = new Media("H.C.ANdersens eventyr");

Console.WriteLine(m1);
Console.WriteLine(m2);
Console.WriteLine(m3);
Console.WriteLine(m4);

MediaCatalog catalog = new MediaCatalog();
catalog.AddMedia(m1);
catalog.AddMedia(m2);
catalog.AddMedia(m3);
catalog.AddMedia(m4);

catalog.PrintMediaList();

Console.WriteLine(catalog.GetMedia(2) );

Media ml= catalog.GetMedia(2);
Console.WriteLine(ml);