using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Event_application.Services
{
    /// <summary>
    /// Dette interface er obygget på CRUD- metoden
    /// </summary>
    /// <typeparam name="T">.........</typeparam>
    public interface IParkeringGeneric<T>
    {
        /// <summary>
        /// Henter en specefik ID ud fra listerne
        /// </summary>
        /// <returns>Hvis listerne er tomme bliver de returneret</returns>

        List<T> GetAll();

        /// <summary>
        /// Opretter nye ID til listerne eller systemet
        /// </summary>
        /// <param name="id">Det nye ID tilføjes eller add</param>
        /// <returns>Det ID objekt som er gemt i listerne eller systemet</returns>
        T GetbyId(int id);

        // CRUD

        //T Create(T newParkering);

        //T Read(); //Todo Tilføj Read til CRUD, når vi har de nødvendige informationer til at lave den.

        /// <summary>
        /// Opdatere det specefikke objekter med nye værider
        /// </summary>
        /// <param name="updateParkering"> Det nye værdier</param>
        /// <returns>Objektet i listen eller i systemet</returns>
        T Update(T updateParkering);

        /// <summary>
        /// Sletter ID fra listen eller systemet
        /// </summary>
        /// <param name="id">Det specefikke ID bliver slettet fra listen eller systemet</param>
        /// <returns></returns>
        T Delete(int id);

        //hej

    }
}
