using System;

namespace _03_dependency_injection
{
    /// <summary>
    /// 1.Creational Patterns 
    /// 2.Dependency Injection, bağımlılıkları soyutlamak demektir.
    /// 3.Temel olarak oluşturacağınız bir sınıf içerisinde başka bir sınıfın nesnesini kullanacaksanız new anahtar sözcüğüyle oluşturmamanız gerektiğini söyleyen bir yaklaşımdır
    /// 4.Constructor, setter yoluyla inject edilmeli
    /// 5.Loosely Coupled yani Gevşek Bağlılık
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Yayin yayin = new Yayin(new Televizyon());            

            Console.WriteLine(yayin.YayinAkisi());
        }
    }
}
