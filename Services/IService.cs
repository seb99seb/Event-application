using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Event_application.Model;

namespace Event_application.Services
{
    public interface IService 
    {
        List<Almindelig> GetAll();
        Almindelig Create(Almindelig newAl);
        Almindelig Delete(String AlNavn);
        Almindelig Modify(Almindelig modifiedAl);



    }
}
