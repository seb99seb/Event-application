using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Event_application.Model;

namespace Event_application.Services
{
    public interface IService
    {
        Dictionary<int, Almindelig> ALLA();
        Dictionary<int, Vegansk> AllV();
        Dictionary<int, Champagne> ALLC();

    }
}
