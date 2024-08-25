using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaiaIO.FactoryWatch.Domain.UseCases.CRUD.Entities
{
    public class Machine : Entity
    {

        public string name { get; set; }
        public string description { get; set; }
        public string codeId { get; set; }
        public IEnumerable<Device> devices { get; set; }
        public DateTime lastMaintece { get; set; }
        public MaintenceCode lastMainteceCode { get; set; }



    }
}
