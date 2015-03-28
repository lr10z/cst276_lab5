using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DeskAutomationSystem
{
    //
    // 
    // Abstract class Maker
    // extends ISubject interface
    //
    abstract class Maker : ISubject
    {
        // Maker variables
        private List<IObserver> observers;
        protected static int numMonitorStands = 2, numKeyboardTrays = 2;
        protected IAssemblyLineBehavior assemblyLineBehavior;
        protected IMakeItemBehavior makeItemBehavior;

        // Maker ctor
        public Maker() 
        {
            observers = new List<IObserver>();
            addObserver(SupplierOneInventory.getInstance);
        }

        // Maker methods
        public void startLine() {assemblyLineBehavior.startLine();}

        public void makeItem(string deskType)
        {
            string itemUsed;

            itemUsed = makeItemBehavior.makeItem(deskType);

            if (itemUsed == "monitor stand")
            {
                numMonitorStands -= 1;

                if (numMonitorStands < 0)
                {
                    soldOut();
                    return;
                }
            }
            if (itemUsed == "keyboard tray")
            {
                numKeyboardTrays -= 1;

                if (numKeyboardTrays < 0)
                {
                    soldOut();
                    return;
                }
            }


            makeItemBehavior.display();
        }

        public void soldOut()   
        {
            Console.Write( "\nSorry that accessory is sold out, please make new selections with the following in mind:\n\n");
            return;
        }


        //
        // Product count getters
        //
        public int NumMonitorStands { get { return numMonitorStands; } }
        public int NumKeyboardTrays { get { return numKeyboardTrays; } }
        
        
        //
        // ISubject methods implemented: add, delete, notify
        //
        public void addObserver(SupplierOneInventory newObserver)
        {
            observers.Add(newObserver);
        }
        public void deleteObserver(SupplierOneInventory deleteObserver)
        {
            if (observers.Contains(deleteObserver))
            {
                observers.Remove(deleteObserver);
            }
        }
        public void notifyObservers()
        {
            foreach (IObserver observer in observers)
            {
                observer.update(numMonitorStands, numKeyboardTrays);
            }
        }        
    }



    //
    // 
    // Concrete Makers
    //
    // Left Desk Maker
    //
    class LeftMaker : Maker
    {
        //string item;

        public LeftMaker()
        {
            assemblyLineBehavior = new AssembleLeft();
            makeItemBehavior = new MakeDesk();
        }
    }

    
    //
    // Right Desk Maker
    //
    class RightMaker : Maker
    {
        public RightMaker()
        {
            assemblyLineBehavior = new AssembleRight();
            makeItemBehavior = new MakeDesk();
        }
    }

    //
    // Standard Desk Maker
    //
    class StandardMaker : Maker
    {
        public StandardMaker()
        {
            assemblyLineBehavior = new AssembleStandard();
            makeItemBehavior = new MakeDesk();
        }
    }

    //
    // Rolltop Desk Maker
    //
    class RolltopMaker : Maker
    {
        public RolltopMaker()
        {
            assemblyLineBehavior = new AssembleRolltop();
            makeItemBehavior = new MakeDesk();
        }
    }

    //
    // Executive Desk Maker
    //
    class ExecutiveMaker : Maker
    {
        public ExecutiveMaker()
        {
            assemblyLineBehavior = new AssembleExecutive();
            makeItemBehavior = new MakeDesk();
        }
    }
}
