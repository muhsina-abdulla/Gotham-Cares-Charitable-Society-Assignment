using System;
using System.Collections.Generic;
using System.Text;
using BuisnessServices.Entities;


namespace BuisnessServices.Services
{
    public interface IAdmin
    {
        List<Volunteers> GetVolunteers();
        String AddOutlet(Outlet Outlet);
        void EditOutletDetails(int id);

        String DeleteOutlet(int id);

    }
}
