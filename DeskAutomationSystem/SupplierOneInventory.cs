using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DeskAutomationSystem
{
    
    //
    // ISubject concrete class: SupplierOneInventory
    // implements IObserver interface
    //
    public class SupplierOneInventory : IObserver
    {

        //
        // SupplierOneInventory class member variable
        //
        private static SupplierOneInventory instance;

        //
        // ISubject member variables
        //
        private ISubject observable;
        private int numMonitorStands, numKeyboardTrays;


        //
        // SupplierOneInventory class ctor
        //
        private SupplierOneInventory() { }

        //
        // SupplierOneInventory class instance getter
        //
        public static SupplierOneInventory getInstance
        {
            get
            {
                if (instance == null)
                {
                    instance = new SupplierOneInventory();
                }

                return instance;
            }
        }


        public static void registerWithSubject(ISubject observable)
        {
            instance.observable = observable;

            observable.addObserver(instance);
        }

        //
        //
        // IObserver method implementation
        //
        //
        public void update(int numMonitorStands, int numKeyboardTrays)
        {
            if (numMonitorStands < 0)   { numMonitorStands = 0; }
            if (numKeyboardTrays < 0)      { numKeyboardTrays = 0; }

            instance.numMonitorStands = numMonitorStands;
            instance.numKeyboardTrays = numKeyboardTrays;

            display();
        }


        //
        // Displays current state of inventory
        //
        public static void display()
        {
            Console.Write("Current accessories left:\n" +
                            "Monitor Stands = " + instance.numMonitorStands + "\n" +
                            "Keyboard Trays = " + instance.numKeyboardTrays + "\n\n");
        }

    }
}
