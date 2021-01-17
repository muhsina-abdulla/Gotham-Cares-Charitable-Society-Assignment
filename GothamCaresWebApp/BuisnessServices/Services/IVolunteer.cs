using System;
using System.Collections.Generic;
using System.Text;
using BuisnessServices.Entities;

namespace BuisnessServices.Services
{
    public interface IVolunteer
    {
        String VolunteerRegister(Volunteers Volunteer);
        List<Outlet> GetOutlets();
    }
}
