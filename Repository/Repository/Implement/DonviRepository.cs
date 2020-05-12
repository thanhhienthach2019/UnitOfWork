using Data;
using Repository.Infrastructure.Implement;
using Repository.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repository.Implement
{
    public class DonviRepository : RepositoryBase<DonVi>, IDonviRepository
    {
        public DonviRepository(ISBEntities entities) : base(entities)
        {

        }
    }
}
