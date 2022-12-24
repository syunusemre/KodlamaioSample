﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjects
{
    internal class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.BirthYear == 1999 && gamer.FirstName == "Yunus" && gamer.LastName == "Şahin" && gamer.IdentityNumber == 12345)
            {
                return true;
            }
            else 
            {
                return false;
            }
        }

       
    }
}
