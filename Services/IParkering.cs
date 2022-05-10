using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Event_application.Services
{
    public interface IParkeringGeneric<T>
    {

        List<T> GetAll();

        T GetbyId(int id);

        // CRUD

        T Create(T newParkering);

        T Read();

        T Update(T updateParkering);

        T Delete(int id);

    }
}
