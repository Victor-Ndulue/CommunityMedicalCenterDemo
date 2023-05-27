﻿using CMCDemo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMCDemo.Applications.Contracts
{
    public interface IStaffAddress
    {
        Task <IEnumerable<StaffAddress>> GetAllStaffAddressAsync (bool trackchanges);
        Task <StaffAddress> GetStaffAddressByName (string Name, bool trackchanges);
        void Create(StaffAddress entity);
        void Delete(StaffAddress entity);
    }
}
