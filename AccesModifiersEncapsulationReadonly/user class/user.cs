using System;
namespace AccesModifiersEncapsulationReadonly.userclass
{
    public class user
    {
        public string Username;
        private int _age;
        private string _password;

        public user(string userName, string passWord)

        {
            Username = userName;
            Password = passWord;

        }
        public string username
        {
            get
            {
                { return username; }


            }
            set
            {
                { username = value; }

            }



        }
        public int age
        {

            get
            {
                return _age;
            }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Age is not correct");
                    return;
                }
                    

                _age = value;

            }
        }

        public string Password
        {
            get { return _password; }




            set
            {
                if (String.IsNullOrEmpty(value) == false && value.Length >= 8 == true && DifferentCase(value) == true)
                {
                    _password = value;
                    return;

                }
                Console.WriteLine("Password invalid try again:            ");
                return;


            }



        }

        internal static void Info()
        {
            throw new NotImplementedException();
        }

        public bool DifferentCase(string pass)
        {
            char[] arr = pass.ToCharArray();
            bool result = false;
            bool result1 = false;
            bool result2 = false;

            for (int i = 0; i < arr.Length; i++)
            {


                if (result1 != char.IsUpper(arr[i]))
                {
                    result = true;
                }

                if (result2 != char.IsNumber(arr[i]))
                {
                    result = true;
                }

                if (result1 == true && result2 == true)
                {
                    result = true;
                }
                return result;
            }
            return result;
        }

       


    }

    public void Info()

    {
        Console.WriteLine("User info");
    }

}
    
      




 

