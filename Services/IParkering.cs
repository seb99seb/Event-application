using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Event_application.Services
{

    /// <summary>
    /// En model klasse - Interface der indeholder En generisk Liste, samt CRUD(Create, Read, Update, Delete).
    /// </summary>
    /// <typeparam name="T"></typeparam>

    public interface IParkeringGeneric<T>
    {

        /// <summary>
        /// En generisk liste, hvor man kan se alle parkeringspladserne.
        /// </summary>
        /// <returns></returns>
        List<T> GetAll();

        List<int> GetAllId();

        /// <summary>
        /// En generisk metode, hvor man kan få kundernes parkerings id.    
        /// </summary>
        /// <param name="id">Kunders parkeringsid.</param>
        /// <returns></returns>
        T GetbyId(int id);


        // CRUD

        //T Create(T newParkering);

        //T Read(); //Todo Tilføj Read til CRUD, når vi har de nødvendige informationer til at lave den.

        /// <summary>
        /// En generisk metode, hvor man kan opdatere kundernes parkeringsplads.
        /// </summary>
        /// <param name="updateParkering"></param>
        /// <returns></returns>
        T Update(T updateParkering);


        /// <summary>
        /// En generisk metode, hvor man kan slette kundens parkeringsplads, hvis de har fortrudt deres booking af den.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        T Delete(int id);

        

    }
}
