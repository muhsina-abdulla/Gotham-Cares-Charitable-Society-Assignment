using System;
using System.Collections.Generic;
using System.Text;
using DataService.Entities;


namespace BuisnessService.ServiceInterface
{
    public interface IAdmins
    {

        Admin login(string email, string password);

    }
}
