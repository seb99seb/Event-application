using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Event_application.Services
{
    //Model klasse (Interface), der indeholder CRUD samt en generisk liste.
    public interface ITilmeldingGeneric<T>
    {
        List<T> GetAll();
        T GetbyID(int Bestilling_id);
        List<int> GetAllId();
        
       // int deleteTilmelding(int Bestilling_id);
        int PostBrugerTilArrangement(T Tilmeld);


    }
}
