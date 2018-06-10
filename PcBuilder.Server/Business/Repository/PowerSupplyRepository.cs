using System;
using System.Collections.Generic;
using System.Text;
using Business.Repository.Base;
using Data.Core.Domain;
using Data.Core.Interfaces;
using Data.Persistence;

namespace Business.Repository
{
    public class PowerSupplyRepository: GenericRepository<PowerSupply>, IPowerSupplyRepository
    {
        public PowerSupplyRepository(DatabaseContext context) : base(context)
        {
        }
    }
}
