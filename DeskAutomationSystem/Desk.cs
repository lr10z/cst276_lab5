using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DeskAutomationSystem
{
    //
    // Abstract Desk class
    //
    abstract class Desk
    {
        private string name;
        protected Color color;
        protected Drawer drawer;
        protected Shelves shelf;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public abstract void Assemble();
    } 

    //
    // Abstract DeskStyle class
    //
    abstract class DeskStyle
    {
        private string description;

        public Desk OrderDesk(string type)
        {
            Desk desk = this.CreateDesk(type);

            desk.Assemble();

            description = desk.Name;

            return desk;
        }

        protected abstract Desk CreateDesk(string type);


        public virtual string GetDescription()
        {
            return description;
        }
    }

    //
    // Concrete DeskStyle class
    // 
    // Oak Desk implementation
    //
    class LeftDesk : DeskStyle
    {
        protected override Desk CreateDesk(string type)
        {
            Desk desk = null;

            IDeskBuildFactory buildFactory = new LeftDeskBuildFactory();

            switch (type)
            {
                case "oak":
                    desk = new OakDesk(buildFactory);
                    desk.Name = "Left Style Oak Desk";
                    break;

                case "maple":
                    desk = new MapleDesk(buildFactory);
                    desk.Name = "Left Style Maple Desk";
                    break;

                case "aluminum":
                    desk = new AluminumDesk(buildFactory);
                    desk.Name = "Left Style Aluminum Desk";
                    break;

                case "glass":
                    desk = new GlassDesk(buildFactory);
                    desk.Name = "Left Style Glass Desk";
                    break;
            }

            return desk;
        }
    }

    //
    // Right Desk implementation
    //
    class RightDesk : DeskStyle
    {
        protected override Desk CreateDesk(string type)
        {
            Desk desk = null;

            IDeskBuildFactory buildFactory = new RightDeskBuildFactory();

            switch (type)
            {
                case "oak":
                    desk = new OakDesk(buildFactory);
                    desk.Name = "Right Style Oak Desk";
                    break;

                case "maple":
                    desk = new MapleDesk(buildFactory);
                    desk.Name = "Right Style Maple Desk";
                    break;

                case "aluminum":
                    desk = new AluminumDesk(buildFactory);
                    desk.Name = "Right Style Aluminum Desk";
                    break;

                case "glass":
                    desk = new GlassDesk(buildFactory);
                    desk.Name = "Right Style Glass Desk";
                    break;
            }

            return desk;
        }
    }

    //
    // Standard Desk implementation
    //
    class StandardDesk : DeskStyle
    {
        protected override Desk CreateDesk(string type)
        {
            Desk desk = null;

            IDeskBuildFactory buildFactory = new StandardDeskBuildFactory();

            switch (type)
            {
                case "oak":
                    desk = new OakDesk(buildFactory);
                    desk.Name = "Standard Style Oak Desk";
                    break;

                case "maple":
                    desk = new MapleDesk(buildFactory);
                    desk.Name = "Standard Style Maple Desk";
                    break;

                case "aluminum":
                    desk = new AluminumDesk(buildFactory);
                    desk.Name = "Standard Style Aluminum Desk";
                    break;

                case "glass":
                    desk = new GlassDesk(buildFactory);
                    desk.Name = "Standard Style Glass Desk";
                    break;
            }

            return desk;
        }
    }

    //
    // Rolltop Desk implementation
    //
    class RolltopDesk : DeskStyle
    {
        protected override Desk CreateDesk(string type)
        {
            Desk desk = null;

            IDeskBuildFactory buildFactory = new RolltopDeskBuildFactory();

            switch (type)
            {
                case "oak":
                    desk = new OakDesk(buildFactory);
                    desk.Name = "Rolltop Style Oak Desk";
                    break;

                case "maple":
                    desk = new MapleDesk(buildFactory);
                    desk.Name = "Rolltop Style Maple Desk";
                    break;

                case "aluminum":
                    desk = new AluminumDesk(buildFactory);
                    desk.Name = "Rolltop Style Aluminum Desk";
                    break;

                case "glass":
                    desk = new GlassDesk(buildFactory);
                    desk.Name = "Rolltop Style Glass Desk";
                    break;
            }

            return desk;
        }
    }

    //
    // Executive Desk implementation
    //
    class ExecutiveDesk : DeskStyle
    {
        protected override Desk CreateDesk(string type)
        {
            Desk desk = null;

            IDeskBuildFactory buildFactory = new ExecutiveDeskBuildFactory();

            switch (type)
            {
                case "oak":
                    desk = new OakDesk(buildFactory);
                    desk.Name = "Executive Style Oak Desk";
                    break;

                case "maple":
                    desk = new MapleDesk(buildFactory);
                    desk.Name = "Executive Style Maple Desk";
                    break;

                case "aluminum":
                    desk = new AluminumDesk(buildFactory);
                    desk.Name = "Executive Style Aluminum Desk";
                    break;

                case "glass":
                    desk = new GlassDesk(buildFactory);
                    desk.Name = "Executive Style Glass Desk";
                    break;
            }

            return desk;
        }
    }

    //
    // Accessories abstract class
    //
    abstract class Accessories : DeskStyle
    {
        public Accessories() { }
    }


    //
    // Accessories concrete classes
    //

    //
    // Monitor Stand class implementation
    //
    class MonitorStand : Accessories
    {
        DeskStyle deskstyle;

        public MonitorStand(DeskStyle deskstyle)
        {
            this.deskstyle = deskstyle;
        }

        public override string GetDescription()
        {
            return deskstyle.GetDescription() + " with Monitor Stand";
        }

        protected override Desk CreateDesk(string type)
        {
 	        throw new System.NotImplementedException();
        }


    }

    //
    // Keyboard Tray class implementation
    //
    class KeyboardTray : Accessories
    {
        DeskStyle deskstyle;

        public KeyboardTray(DeskStyle deskstyle)
        {
            this.deskstyle = deskstyle;
        }

        public override string GetDescription()
        {
            return deskstyle.GetDescription() + " with Keyboard Tray"; 
        }

        protected override Desk CreateDesk(string type)
        {
            throw new System.NotImplementedException();
        }
    }

}
