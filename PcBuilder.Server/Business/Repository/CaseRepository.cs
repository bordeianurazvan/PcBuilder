using System;
using System.Collections.Generic;
using System.Text;
using Business.Repository.Base;
using Data.Core.Domain;
using Data.Core.Interfaces;
using Data.Persistence;

namespace Business.Repository
{
    public class CaseRepository: GenericRepository<Case>, ICaseRepository
    {
        public CaseRepository(DatabaseContext context) : base(context)
        {
        }

    }
}
