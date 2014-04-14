using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Motherload
{
    using System.Windows.Forms;
    class ShipDude : Element
    {
        protected double _totalFuel;
        protected double _currentFuel;
        protected int _xCoord;
        protected int _yCoord;
        protected int _storageCap;
        public int[] _elementArr = { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 }; //storage array for elements
        //==================================================================================================
        //default constructor
        public ShipDude()
        {
            _totalFuel = 10; //change to default fuel level
            _currentFuel = _totalFuel * 0.8;
            _storage = 0; //change to default storage level
            _storageCap = 10;
            _id = -999; //ship is id 0
            _value = 250000; //inits to zero
            _xCoord = 0;
            _yCoord = 0;
            //_elementArr already initialized to zero's
        }


        //==================================================================================================
        public int calc_value() //sums total value of elements and sets result = _value
        {
            int temp;
            temp = ((_elementArr[0] * 30) + (_elementArr[1] * 60) + (_elementArr[2] * 100) + (_elementArr[3] * 250) + 
             (_elementArr[4] * 750) + (_elementArr[5] * 2000) + (_elementArr[6] * 5000) + (_elementArr[7] * 20000) + 
             (_elementArr[8] * 40000) + (_elementArr[9] * 100000));
            return temp;
        }

        //======== RETURN MEMBERS ============== RETURN MEMBERS ================ RETURN MEMBERS ============
        public int return_value() { return _value; }
        //==================================================================================================
        public int[] return_element_array() { return _elementArr; }
        //==================================================================================================
        public int return_storage() { return _storage; }
        //==================================================================================================
        public int return_total_fuel() { return Convert.ToInt32(_totalFuel); }
        //==================================================================================================        
        public int return_storage_cap() { return _storageCap; }
        //==================================================================================================
        public int current_fuel_level() { return Convert.ToInt32(_currentFuel); }
        //==================================================================================================
        public int total_fuel_level() { return Convert.ToInt32(_totalFuel); }

        //==================================================================================================
        //movement
        public void left_Move() { }
        public void right_Move() { }
        public void up_Move() { }
        public void down_Move() { }

        //== CHANGE MEMBERS ========== CHANGE MEMBERS ================== CHANGE MEMBERS ====================
        public void change_Storage(int num) { _storage = num; } //changes size of _storage
        //==================================================================================================
        public void change_totalFuel(int num) { _totalFuel = num; } //changes size of _fuel
        //==================================================================================================
        public void change_value(int num) { _value -= num; } //changes size of _fuel
        //==================================================================================================
        public void change_storage_cap(int num) { _storageCap = num; }
        //==================================================================================================
        public void refuel(int num) 
        {
            global.temp = num;
            
             
            if (_totalFuel == _currentFuel)
            {
                Tank_Full form = new Tank_Full();
                form.ShowDialog();
               
                return;
            }
            if (_value < num) //if you dont have enough money
            {
                Not_Enough_Cash form = new Not_Enough_Cash();
                form.ShowDialog();
                return;
            }
            
            if (_currentFuel + num > _totalFuel)
            {
                global.temp = Convert.ToInt32(_totalFuel - _currentFuel);
                _currentFuel = _totalFuel;
                _value -= global.temp;
                you_filled_up form = new you_filled_up();
                form.ShowDialog();
                
            }
            else
            {
                _currentFuel += num;
                _value -= num;
                you_filled_up form = new you_filled_up();
                form.ShowDialog();
            }

        }
        //==================================================================================================
        public void fill_tank()
        {
            int num = Convert.ToInt32(_totalFuel - _currentFuel);
            if (_totalFuel == _currentFuel)
            {
                Tank_Full form = new Tank_Full();
                form.ShowDialog();
                return;
            }
            if (_value < num) //if you dont have enough money
            {
                Not_Enough_Cash form = new Not_Enough_Cash();
                form.ShowDialog();
                return;
            }
            else 
            {
                global.temp = Convert.ToInt32(_totalFuel - _currentFuel);
                _currentFuel = _totalFuel;
                _value -= num;
                you_filled_up form = new you_filled_up();
                form.ShowDialog();
            }
        }
        //==================================================================================================
        public void set_value() //sums total value of elements and sets result = _value
        {
            _value += ((_elementArr[0] * 30) + (_elementArr[1] * 60) + (_elementArr[2] * 100) + (_elementArr[3] * 250) +
             (_elementArr[4] * 750) + (_elementArr[5] * 2000) + (_elementArr[6] * 5000) + (_elementArr[7] * 20000) +
             (_elementArr[8] * 40000) + (_elementArr[9] * 100000));
        }
        //==================================================================================================
        public void clear_Element_Array() //clears element array
        {
            for (int i = 0; i <= 9; ++i)
            { _elementArr[i] = 0; }
        }


        //==================================================================================================
        public void print_Element_Array() //prints element array for testing
        {
            Console.WriteLine("Values of _elementArr:");
            for (int i = 0; i <= 9; ++i)
            { Console.Write(_elementArr[i] + ", "); }
            Console.WriteLine();
        }
        //==================================================================================================
        public void print_Ship_Coodinates()
        {
            Console.WriteLine("x Coord = " + _xCoord);
            Console.WriteLine("y Coord = " + _yCoord);
        }
        //==================================================================================================
        public int return_xCoord() { return _xCoord; }
        public int return_yCoord() { return _yCoord; }
        //==================================================================================================
        public void add_to_Storage(int num) { _storage += num; }  //Called when picked up an element
        //==================================================================================================
        public void clear_Storage() { _storage = 0; }
        //==================================================================================================

    }//end of class

}//end of namespace
