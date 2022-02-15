using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOCEx
{
    class Program
    {
        private static Collage collage;
        static void Main(string[] args)
        {
            collage = new Collage(3
                );
            collage.GetEventDetails();

        }
    }
    interface IEvents
    {
        void LoadEventDetails();
    }

    class Collage
    {


        private IEvents Events = null;
        EventsLauncher sl = new EventsLauncher();

        public Collage(int index)
        {
            this.Events = sl.LaunchEvent(index);
        }

        public void GetEventDetails()
        {

            this.Events.LoadEventDetails();

        }


    }

    class EventsLauncher
    {

        public IEvents LaunchEvent(int index)
        {
            if (index == 1)
                return new CE();
            else if (index == 2)
                return new ELC();
            else
                return new EventXp();


        }

    }

    class CE : IEvents
    {

        public void LoadEventDetails()
        {
            Console.WriteLine("Welocme to CollageEvents");
            Console.ReadKey();
        }
    }

    class ELC : IEvents
    {
        public void LoadEventDetails()
        {
            Console.WriteLine("Welocme to ELC");
            Console.ReadKey();
        }
    }

    class EventXp : IEvents
    {
        public void LoadEventDetails()
        {
            Console.WriteLine("Welocme to Events XP");
            Console.ReadKey();
        }
    }
}
