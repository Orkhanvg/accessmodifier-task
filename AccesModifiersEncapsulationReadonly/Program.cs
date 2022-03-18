using System;
using AccesModifiersEncapsulationReadonly.userclass;

namespace AccesModifiersEncapsulationReadonly
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Task: 
             * User class

             - Username
             - Age
             - Password

             Username, password property-ləri olmadan user obyekti yaratmaq olmaz.

             Age propery-i mənfi ola bilməz.

             Password property-i bu şərtləri ödəməlidir:

             1. Boş ola bilməz
             2. Uzunluğu 8-dən kiçik ola bilməz
             3. İçində ən az bir böyük hərf olmalıdır
             4. İçində ən az bir rəqəm olmalıdır

             Üçüncü və dördüncü şərti ayrı bir private methodda yazıb gəlib propertyinin setində istifadə etmək lazımdır.
             */

            Console.Write("Please enter the username:             ");
            string username = Console.ReadLine();

            Console.Write("Please enter the password:             ");
            string password = Console.ReadLine();

            Console.Write("Please enter the age:             ");
            string age = Console.ReadLine();


            user user1 = new user(username, password);

            user.Info();
            


        }

    }
}

    