using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaiaIO.FactoryWatch.Domain.UseCases.CRUD.Entities
{
    public class ProcessLine : Entity
    {


        public LineCode lineCode { get; set; }
        public int lineSeq { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public IEnumerable<MachineLine> machines { get; set; }
        public DateTime lastMaintence { get; set; }
        public MaintenceCode lastMainteceCode { get; set; }



    }

    public enum MaintenceCode
    {
        preditive = 0,
        preventive = 1,
        corretive = 2,
    }

    public enum LineCode
    {
        Extruder = 0,
        DrawingCooper = 1,
        DrawingAluminium = 2,
        Spinning = 3
    }
}
