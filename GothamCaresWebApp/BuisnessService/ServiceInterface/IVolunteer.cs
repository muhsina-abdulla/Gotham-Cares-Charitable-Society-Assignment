using System;
using System.Collections.Generic;
using System.Text;
using DataService.Entities;

namespace BuisnessService.ServiceInterface
{
    public interface IVolunteer
    {
        String VolunteerRegister(Volunteers Volunteer);
        List<Volunteers> GetVolunteers();
    }
}
