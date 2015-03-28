using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DeskAutomationSystem
{
    //
    // Interface for the Subject
    //
    public interface ISubject
    {
        void addObserver(SupplierOneInventory obj);
        void deleteObserver(SupplierOneInventory obj);
        void notifyObservers();
    }


    //
    // Interface for all potential observers
    //
    interface IObserver
    {
        void update(int numMonitorStands, int numKeyboardTrays);
    }
}
