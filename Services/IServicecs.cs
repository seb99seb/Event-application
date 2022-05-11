using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Event_application.Model;

namespace Event_application.Services
{
    public  interface IServicecs
    {
        /*
         * Get all 
         */
        List<Almindelig> GetAllA();
        List<Vegansk> GetAllV();
        List<Champagne> GetAllC();

        Almindelig GetByIdA(int id);
        Almindelig CreateA(Almindelig newAlmindelig);
        Almindelig DeleteA(int id);
        Almindelig ModifyA(Almindelig modifiedAlmindelig);

        Vegansk GetByIdV(int id);
        Vegansk CreateV(Vegansk newVegansk);
        Vegansk DeleteV(int id);
        Vegansk ModifyV(Vegansk modifiedVegansk);

        Champagne GetByIdC(int id);
        Champagne CreateC(Champagne newChampagne);
        Champagne DeleteC(int id);
        Champagne ModifyC(Champagne modifiedChampagne);

    }
}
