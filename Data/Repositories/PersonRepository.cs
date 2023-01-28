using Core.Abstract.Repositories;
using Core.Concrate.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public class PersonRepository : Base<Person>, IPersonRepository { }
}
