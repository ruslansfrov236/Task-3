Console.Write("Adiniz ve soyadiniz daxil edin:");
string adSoyad= Console.ReadLine(); 
for(int i=adSoyad.Length-1; i>=0;i--)
{
    Console.Write(adSoyad[i]);
}