using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Motherload
{
    class Program
    {
       
            /* id reference table
             * Ship = -999
             * Iron = 1
             * Bronze = 2
             * Silver = 3
             * Gold = 4
             * Platinum = 5
             * Einsteinium = 6
             * Emerald = 7
             * Ruby = 8
             * Diamond = 9
             * DogeCoin = 10
             */
            //initilize elements
            //  (storage, value, id);
            Element Iron = new Element(1, 30, 1);
            Element Bronze = new Element(1,60, 2);
            Element Silver = new Element(2, 100, 3);
            Element Gold = new Element(2, 250, 4);
            Element Platinum = new Element(3, 750, 5);
            Element Einsteinium = new Element(4, 2000, 6);
            Element Emerald = new Element(5, 5000, 7);
            Element Ruby = new Element(5, 20000, 8);
            Element Diamond = new Element(6, 40000, 9);
            Element DogeCoin = new Element(1, 100000, 10);

            //init ShipDude
            //ShipDude Ship = new ShipDude();

            const int SIZE = 50;    //set size of array here


            
        //    Ship.print_Element_Array();


       


    } //end of class program


} //end of namespace
