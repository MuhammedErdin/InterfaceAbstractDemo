using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Adapters;
using InterfaceAbstractDemo.Concrete;
using InterfaceAbstractDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAbstractDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new StarbucksCustomerManager(new MernisServiceAdapter());
            customerManager.Save(new Customer { DateOfBirth = new DateTime ( YIL, AY, GÜN ), FirstName = "İSİM", LastName = "SOYİSİM", NationalityId = "TCNO" });
            Console.ReadLine();
        }
    }
}

//Kahve dükkanları için müşteri yönetimi yapan bir sistem yazmak istiyoruz.
//Starbucks ve Nero firması için çalışıyoruz.İki firma da müşterilerini veri tabanına kaydetmek istiyor.
//Starbucks müşterilerini kaydederken, mutlaka mernis doğrulaması istiyor.
//Nero müşterilerini kaydederken böyle bir şey istemiyor.
//Starbucks müşteriler için her kahve alımında yıldız kazandırmak istiyor.
