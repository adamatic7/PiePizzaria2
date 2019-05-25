using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PiePizzaria2.Models
{
    public interface IPieServices
    {

        IEnumerable<Pie> GetAllPies();

        Pie GetPieById(int pieId);
    }
}
