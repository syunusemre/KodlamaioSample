using GameProject.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Concrete
{
    public class CustomerManager : ICustomerService
    {
        public void dateBirthControl()
        {
            Console.WriteLine("Doğum Tarihi Kontrol Edildi!");
        }

        public void lastnameControl()
        {
            Console.WriteLine("Soy İsim Kontrol Edildi!");
        }

        public void nameControl()
        {
            Console.WriteLine("İsim Kontrol Edildi!");
        }

        public void tcControl()
        {
            Console.WriteLine("Tc Kontrol Edildi!");
        }
    }
}
