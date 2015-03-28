using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DeskAutomationSystem
{
    
    //
    // Assembly Line interface
    //
    interface IAssemblyLineBehavior
    {
        void startLine();
    }


    //
    // AssemblyLineBehavior Concrete classes
    //

    //
    // Assembly Line Left class implementation
    //
    class AssembleLeft : IAssemblyLineBehavior
    {
        public void startLine()
        {
            Console.Write("\nStarting assembly line for left desk style! \n");
        }
    }

    //
    // Assembly Line Right class implementation
    //
    class AssembleRight : IAssemblyLineBehavior
    {
        public void startLine()
        {
            Console.Write("\nStarting assembly line for right desk style! \n");
        }
    }

    //
    // Assembly Line Standard class implementation
    //
    class AssembleStandard : IAssemblyLineBehavior
    {
        public void startLine()
        {
            Console.Write("\nStarting assembly line for standard desk style! \n");
        }
    }

    //
    // Assembly Line Rolltop class implementation
    //
    class AssembleRolltop : IAssemblyLineBehavior
    {
        public void startLine()
        {
            Console.Write("\nStarting assembly line for rolltop desk style! \n");
        }
    }

    //
    // Assembly Line Executive class implementation
    //
    class AssembleExecutive : IAssemblyLineBehavior
    {
        public void startLine()
        {
            Console.Write("\nStarting assembly line for executive desk style! \n");
        }
    }
     
}
