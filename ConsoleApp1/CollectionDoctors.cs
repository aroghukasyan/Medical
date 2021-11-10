using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class CollectionDoctors<T> : IEnumerable<T>
    {
        private T[] arrayData;
        private int version;
        private const int defaultSize = 2;
        private int index;
        public List<Doctor> Doctors;
        public CollectionDoctors()
        {
            Doctors = new List<Doctor>();
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
        object IEnumerator.Current
        //public Doctor this[int index]
        //{
        //    get { return Doctors[index]; }
        //    set { Doctors.Insert(index, value); }
        //} 
        //public IEnumerator<Doctor> GetEnumerator()
        //{
        //    return Doctors.GetEnumerator();
        //}

        //IEnumerator IEnumerable.GetEnumerator()
        //{
        //    return this.GetEnumerator();
        //}
        
    }
    class Enumerator : IEnumerator 
    { 
        private readonly List<Doctor> Doctors;
        private int index = -1;
        public Enumerator(List<Doctor> doctors)
        {
            this.Doctors = doctors;
        }

        public object Current => throw new NotImplementedException();

        public bool MoveNext()
        {
            throw new NotImplementedException();
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }
    }

}
