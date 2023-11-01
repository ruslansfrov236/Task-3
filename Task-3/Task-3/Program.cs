Console.Write("Adiniz ve soyadiniz daxil edin:");
string adSoyad= Console.ReadLine(); 
for(int i=adSoyad.Length-1; i>=0;i--)
{
    Console.Write(adSoyad[i]);
}

  static string Tersi(string metin)
{
    char[] simvovlar = metin.ToCharArray();
    Array.Reverse(simvovlar);
    return new string(simvovlar);
}
Console.Write("Tam adinizi daxil edin :");
string adSoyad = Console.ReadLine();
string tersadSoyad = Tersi(adSoyad);
Console.WriteLine(tersadSoyad);
Console.WriteLine(tersadSoyad);
