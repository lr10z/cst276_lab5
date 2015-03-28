using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DeskAutomationSystem
{
    //
    // MakeItem interface
    //
    interface IMakeItemBehavior
    {
        string makeItem(string deskType);
        void display();
    }


    //
    // MakeItem concrete classes
    //
    //
    // Make Desk implementation
    //
    class MakeDesk : IMakeItemBehavior
    {
        public string usedUp;
        DeskStyle deskstyle = null;

        public string makeItem( string line )
        {
            bool entry = true;

            //
            // Desk style is selected by user
            //
            do
            {
                if (line == "exit")
                {
                    Environment.Exit(0);
                }
                if (line == "left")
                {
                    deskstyle = new LeftDesk();
                    break;
                }
                if (line == "right")
                {
                    deskstyle = new RightDesk();
                    break;
                }
                if (line == "standard")
                {
                    deskstyle = new StandardDesk();
                    break;
                }
                if (line == "rolltop")
                {
                    deskstyle = new RolltopDesk();
                    break;
                }
                if (line == "executive")
                {
                    deskstyle = new ExecutiveDesk();
                    break;
                }
                else
                {
                    entry = false;
                }

            } while (!entry);


            // reset entry check
            entry = true;

            //
            // Desk material is selected by user
            //
            do
            {
                Console.Write("\nChoose material (oak, maple, aluminum, glass, exit): ");
                string material = Console.ReadLine();

                if (material == "exit")
                {
                    Environment.Exit(0);
                }
                if (material == "oak")
                {
                    deskstyle.OrderDesk("oak");
                    break;
                }
                if (material == "maple")
                {
                    deskstyle.OrderDesk("maple");
                    break;
                }
                if (material == "aluminum")
                {
                    deskstyle.OrderDesk("aluminum");
                    break;
                }
                if (material == "glass")
                {
                    deskstyle.OrderDesk("glass");
                    break;
                }
                else
                {
                    entry = false;
                }

            } while (!entry);


            // reset entry check
            entry = true;


            //
            // Accessory is selected by user
            //
            do
            {

                Console.Write("\nChoose accessory (monitor stand, keyboard tray, none, exit): ");
                string accessory = Console.ReadLine();

                if (accessory == "exit")
                {
                    Environment.Exit(0);
                }
                if (accessory == "none")
                {
                    break;
                }
                if (accessory == "monitor stand")
                {
                    deskstyle = new MonitorStand(deskstyle);
                    usedUp = "monitor stand";
                    break;
                }
                if (accessory == "keyboard tray")
                {
                    deskstyle = new KeyboardTray(deskstyle);
                    usedUp = "keyboard tray";
                    break;
                }
                else
                {
                    entry = false;
                }

            } while (!entry);

            return usedUp;
        }


        public void display()
        {
            Console.Write("\nYour " + deskstyle.GetDescription() + " is finished and ready to ship!\n\n");
        }
    }
}
