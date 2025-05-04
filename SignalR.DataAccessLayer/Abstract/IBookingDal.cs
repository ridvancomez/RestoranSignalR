﻿using SignalR.EntityLayer.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.DataAccessLayer.Abstract
{
    public interface IBookingDal : IGenericDal<Booking>
    {
        // Custom methods for Booking entity can be added here
    }
}
