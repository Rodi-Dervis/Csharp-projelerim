while(true)
{
    Console.WriteLine("Sayıyı giriniz:");
    int sayi = Convert.ToInt32(Console.ReadLine());

    if (sayi < 0)
    {
        Console.WriteLine("Lütfen pozitif bir sayı giriniz");
        continue;
    }

    if (sayi == 50)
    {
        Console.WriteLine("Tebrikler bildiniz!");
        break;
    }
    else
    {
        sayi_denemesi++;
        Console.WriteLine("Yanlış tahmin! Yapılan deneme: " + sayi_denemesi);
    }

    if (sayi_denemesi >= deneme_haki) 
    {
        Console.WriteLine("Deneme hakkınız bitti, kaybettiniz!");
        break;
    }
}
