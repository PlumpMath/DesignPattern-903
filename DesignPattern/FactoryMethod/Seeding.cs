using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern.FactoryMethod
{
    public abstract class Seeding
    {
        protected int numLanes;
        protected int[] lanes;
        public abstract IEnumerator GetSwimmers();
        public abstract int GetCount();
        public abstract int GetHeats();
        protected abstract void seed();

    }
}
