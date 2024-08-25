using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaiaIO.FactoryWatch.Domain.UseCases.CRUD.Entities
{
    public abstract class Entity
    {
        Guid guid { get; }

        public Entity()
        {
            guid = Guid.NewGuid();
        }
    }
}
