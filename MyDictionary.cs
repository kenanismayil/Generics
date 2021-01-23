using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    class MyDictionary<K>
    {
        K[] workers;
        public MyDictionary()
        {
            workers = new K[0];
        }

        public void Add(K worker)
        {
            K[] tempworkers = workers;
            workers = new K[workers.Length + 1];

            for (int i = 0; i < tempworkers.Length; i++)
            {
                workers[i] = tempworkers[i];
            }

            workers[workers.Length - 1] = worker;
        }

        public K[] Workers
        {
            get { return workers; }
        }

        public int Length
        {
            get { return workers.Length; }
        }
    }
}
