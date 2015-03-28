using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DeskAutomationSystem
{
    class Program
    {
        static void Main(string[] args)
        {

            //
            // Loops through desk automation prompt
            //
            while (true)
            {
                Console.Write("Choose a desk style (left, right, standard, rolltop, executive, exit): ");
                string line = Console.ReadLine();

                if (line == "exit")
                {
                    break;
                }
                if (line == "left")
                {
                    LeftMaker lm = new LeftMaker();

                    lm.startLine();
                    lm.makeItem("left");
                    lm.notifyObservers();
                }
                
                if (line == "right")
                {
                    RightMaker rm = new RightMaker();

                    rm.startLine();
                    rm.makeItem("right");
                    rm.notifyObservers();
                }
                if (line == "standard")
                {
                    StandardMaker sm = new StandardMaker();

                    sm.startLine();
                    sm.makeItem("standard");
                    sm.notifyObservers();
                }
                if (line == "rolltop")
                {
                    RolltopMaker rollm = new RolltopMaker();

                    rollm.startLine();
                    rollm.makeItem("rolltop");
                    rollm.notifyObservers();
                }
                if (line == "executive")
                {
                    ExecutiveMaker exm = new ExecutiveMaker();

                    exm.startLine();
                    exm.makeItem("executive");
                    exm.notifyObservers();
                }
            }
        }
    }
}
