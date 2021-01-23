using DataService.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuisnessService.ServiceInterface
{
    public interface IOutlets
    {
        List<Outlet> GetOutlets();
        String AddOutlet(Outlet Outlet);
        String EditOutletDetails(Outlet Outlet);
        String DeleteOutlet(int id);

    }
}
