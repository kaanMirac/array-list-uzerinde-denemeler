using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;

namespace array_list_üzerinde_denmeler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList listem = new ArrayList();

            string seçim;

            do
            {


                
                Console.WriteLine("menü");
                Console.WriteLine("1-Değer ekle");
                Console.WriteLine("2-değer listele");
                Console.WriteLine("3-değer ara");
                Console.WriteLine("4-değer düzenle");
                Console.WriteLine("5-değer sil");
                Console.WriteLine("6-uygulamadan çıkış");
                Console.WriteLine("yapmak istediğiniz işlemin başındaki değeri giriniz ");
                seçim = Console.ReadLine();
                Console.Clear();


                

                switch (seçim)
                {
                    /////////
                    case "1":
                        Console.Write("eklemek istediğiniz değeri griniz: ");
                        listem.Add(Console.ReadLine());
                        Console.WriteLine("istediğiniz değer eklenmiştir.");
                        
                        Console.Write("\nmenüye dönmek için 1 çıkış yapmak için 2 değerini giriniz: ");                        
                        string seçim2 = Console.ReadLine();
                        switch (seçim2)
                        {
                            case "1":
                                break;
                            case "2":
                                seçim = "6";
                                break;
                            default:
                                Console.WriteLine("geçersiz değer girdiniz");
                                System.Threading.Thread.Sleep(2000);
                                Console.Clear();
                                break;
                        }
                        Console.Clear();
                        break;
                    /////////
                    case "2":
                        Console.WriteLine("değerleriniz yazdırılıyor...");
                        System.Threading.Thread.Sleep(2000);
                        foreach (string i in listem)
                        {
                            Console.WriteLine(i);
                        }
                        Console.WriteLine("\nmenüye dönmek için 1 çıkış yapmak için 2 değerini giriniz");
                        string seçim3 = Console.ReadLine();
                        switch (seçim3)
                        {
                            case "1":
                                break;

                            case "2":
                                seçim = "6";
                                break;

                            default:
                                Console.WriteLine("geçersiz değer girdiniz");
                                System.Threading.Thread.Sleep(2000);
                                Console.Clear();
                                break;

                        }
                        Console.Clear();
                        break;
                    /////////
                    case "3":
                        Console.WriteLine("aranacak olan kelimeyi giriniz");
                        string arananKelime = Console.ReadLine();

                        bool cevap = listem.Contains(arananKelime);

                        if (cevap)
                        {
                            Console.WriteLine($"'{arananKelime}' değerleriniz arasında bulunmaktadır, kelime ID'si {listem.IndexOf(arananKelime)}");
                        }
                        else
                        {
                            Console.WriteLine($"'{arananKelime}' değerleriniz arasında bulunmamaktadır");
                        }
                        Console.WriteLine("\nanamenüye dönmek için 1 ,çıkış yapmakiçin 2 değerini giriniz");
                        string seçim5 = Console.ReadLine();
                        switch (seçim5)
                        {
                            case "1":
                                break;
                            case "2":
                                seçim = "6";
                                break;
                            default:
                                Console.WriteLine("geçersiz değer girdiniz ana menüye yönlendiriliyorsunuz.");
                                break;
                        }
                        Console.Clear();
                        break;

                    /////////
                    case "4":
                        Console.Write("düzenlemek istediğiniz kelimenin Id numarasını girin: ");
                        int arananKelimeİndexi = Convert.ToInt32(Console.ReadLine());
                        Console.Write("kelimenizin düzenlenmiş halini girin: ");
                        listem[arananKelimeİndexi] = Console.ReadLine();
                        Console.WriteLine("\nanamenüye dönmek için 1 ,çıkış yapmakiçin 2 değerini giriniz");
                        string seçim6 = Console.ReadLine();
                        switch (seçim6)
                        {
                            case "1":
                                break;
                            case "2":
                                seçim = "6";
                                break;
                            default:
                                Console.WriteLine("geçersiz değer girdiniz ana menüye yönlendiriliyorsunuz.");
                                break;
                        }
                        Console.Clear();
                        break;
                    /////////
                    case "5":
                        Console.WriteLine("silmek istediğiniz değeri girin");

                        listem.Remove(Console.ReadLine());
                        Console.WriteLine("istediğiniz değer silinmiştir");
                        Console.WriteLine("menüye dönmek için 1 çıkış yapmak için 2 değerin giriniz ");
                        string seçim4 = Console.ReadLine();
                        switch (seçim4)
                        {
                            case "1":
                                break;
                            case "2":
                                seçim = "6";
                                break;
                            default:
                                Console.WriteLine("geçersiz değer girdiniz, menüye yönlendiriliyorsunuz...");
                                System.Threading.Thread.Sleep(2000);
                                break;

                        }
                        Console.Clear();
                        break;
                        
                    ////////
                    default:
                        Console.WriteLine("geçrsiz bir değergirdiniz,menüye yönlendiriliyorsunuz...");
                        System.Threading.Thread.Sleep(3000);
                        Console.Clear();
                        break;

                }






                
            } while (seçim != "6");




        }
    }
}
