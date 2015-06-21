using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.FactoryMethod
{
    public abstract class Event
    {
        protected int numLanes;
        protected ArrayList swimmers;
        public Event(string fileName, int lanes)
        {
            this.numLanes = lanes;
            swimmers = new ArrayList();
            //read in swimmers from file
            string[] contents = File.ReadAllLines(fileName);
            foreach (string content in contents)
            {
                Swimmer sw = new Swimmer(content);
                swimmers.Add(sw);
            }
        }
        public abstract Seeding getSeeding();
        public abstract bool isPrelim();
        public abstract bool isFinal();
        public abstract bool isTimedFinal();
    }
}
