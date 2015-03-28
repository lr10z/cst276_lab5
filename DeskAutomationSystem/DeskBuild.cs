using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DeskAutomationSystem
{
    //
    // IDeskBuildFactory interface
    //
    interface IDeskBuildFactory
    {
        Color SelectColor();
        Drawer SelectDrawer();
        Shelves SelectShelves();
    }

    //
    // Abstract material classes declared
    //
    abstract class Color { }
    abstract class Drawer { }
    abstract class Shelves { }

    //
    // Concrete color classes implemented
    //
    class Black : Color
    {
        public override string ToString() { return "Black"; }
    }
    class White : Color
    {
        public override string ToString() { return "White"; }
    }
    class Natural : Color
    {
        public override string ToString() { return "Natural"; }
    }
    class NoDrawer : Drawer
    {
        public override string ToString() { return "No Drawer"; }
    }
    class OneDrawer : Drawer
    {
        public override string ToString() { return "One Drawer"; }
    }
    class NoShelf : Shelves
    {
        public override string ToString() { return "No Shelf"; }
    }
    class OneShelf : Shelves
    {
        public override string ToString() { return "One Shelf"; }
    }
    

    //
    // Concrete IDeskBuildFactory class
    //
    // Left Build Factory implementation
    //
    class LeftDeskBuildFactory : IDeskBuildFactory
    {
        public Color SelectColor() { return new Natural(); }
        public Drawer SelectDrawer() { return new NoDrawer(); }
        public Shelves SelectShelves() { return new NoShelf(); }
    }

    //
    // Right Build Factory implementation
    //
    class RightDeskBuildFactory : IDeskBuildFactory
    {
        public Color SelectColor() { return new Natural(); }
        public Drawer SelectDrawer() { return new NoDrawer(); }
        public Shelves SelectShelves() { return new NoShelf(); }
    }

    //
    // Standard Build Factory implementation
    //
    class StandardDeskBuildFactory : IDeskBuildFactory
    {
        public Color SelectColor() { return new Black(); }
        public Drawer SelectDrawer() { return new OneDrawer(); }
        public Shelves SelectShelves() { return new NoShelf(); }
    }

    //
    // Rolltop Build Factory implementation
    //
    class RolltopDeskBuildFactory : IDeskBuildFactory
    {
        public Color SelectColor() { return new White(); }
        public Drawer SelectDrawer() { return new NoDrawer(); }
        public Shelves SelectShelves() { return new OneShelf(); }
    }

    //
    // Executive Build Factory implementation
    //
    class ExecutiveDeskBuildFactory : IDeskBuildFactory
    {
        public Color SelectColor() { return new Black(); }
        public Drawer SelectDrawer() { return new OneDrawer(); }
        public Shelves SelectShelves() { return new OneShelf(); }
    }



    //
    // Concrete Desk classes
    //
    // Oak Desk implementation
    //
    class OakDesk : Desk
    {
        IDeskBuildFactory buildFactory;

        public OakDesk(IDeskBuildFactory buildFactory)
        {
            this.buildFactory = buildFactory;
        }


        public override void Assemble()
        {
            color = buildFactory.SelectColor();
            drawer = buildFactory.SelectDrawer();
            shelf = buildFactory.SelectShelves();

            Console.Write("\nAssembling " +
                            Name + "\n" +
                            color.ToString() + "\n" +
                            drawer.ToString() + "\n" +
                            shelf.ToString() + "\n");
        }
    }

    //
    // Maple Desk implementation
    //
    class MapleDesk : Desk
    {
        IDeskBuildFactory buildFactory;

        public MapleDesk(IDeskBuildFactory buildFactory)
        {
            this.buildFactory = buildFactory;
        }

        public override void Assemble()
        {
            color = buildFactory.SelectColor();
            drawer = buildFactory.SelectDrawer();
            shelf = buildFactory.SelectShelves();

            Console.Write("\nPreparing " +
                            Name + "\n" +
                            color.ToString() + "\n" +
                            drawer.ToString() + "\n" +
                            shelf.ToString() + "\n\n");
        }
    }

    //
    // Aluminum Desk implementation
    //
    class AluminumDesk : Desk
    {
        IDeskBuildFactory buildFactory;

        public AluminumDesk(IDeskBuildFactory buildFactory)
        {
            this.buildFactory = buildFactory;
        }

        public override void Assemble()
        {
            color = buildFactory.SelectColor();
            drawer = buildFactory.SelectDrawer();
            shelf = buildFactory.SelectShelves();

            Console.Write("\nPreparing " +
                            Name + "\n" +
                            color.ToString() + "\n" +
                            drawer.ToString() + "\n" +
                            shelf.ToString() + "\n\n");
        }
    }

    //
    // Glass Desk implementation
    //
    class GlassDesk : Desk
    {
        IDeskBuildFactory buildFactory;

        public GlassDesk(IDeskBuildFactory buildFactory)
        {
            this.buildFactory = buildFactory;
        }

        public override void Assemble()
        {
            color = buildFactory.SelectColor();
            drawer = buildFactory.SelectDrawer();
            shelf = buildFactory.SelectShelves();

            Console.Write("\nPreparing " +
                            Name + "\n" +
                            color.ToString() + "\n" +
                            drawer.ToString() + "\n" +
                            shelf.ToString() + "\n\n");
        }
    } 
}
