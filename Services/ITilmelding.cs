using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Event_application.Services
{
    public interface ITilmeldingGeneric<A>
    {
        List<A> GetAll();
        A GetbyID(int Bestillings_ID);
        List<int> GetAllId();
        // A Read();
        A Update(A updateTilmeld);
        A Delete(int Bestillings_ID);


    }
}
