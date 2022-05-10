using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Event_application.Services
{
    public class MService : IParkeringGeneric<T>
    {
        public T Create( T newParkering)
        {
            
        }

        public T Delete(int id)
        {
            _list.Remove(id);
            return id;
        }

        public List<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public T GetbyId(int id)
        {
            throw new NotImplementedException();
        }

        public T Read()
        {
            throw new NotImplementedException();
        }

        public T Update(T updateParkering)
        {
            throw new NotImplementedException();
        }
    }

    
}
