using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class CollectionDoctors : IEnumerable
    {
        public List<Doctor> Doctors;
        public CollectionDoctors()
        {
            Doctors = new List<Doctor>();
        }
        public IEnumerator GetEnumerator()
        {
            return new Enumerator(Doctors);
        }
    }

    class Enumerator : IEnumerator 
    { 
        private readonly List<Doctor> _doctors;
        private int _position = -1;
        public Enumerator(List<Doctor> doctors)
        {
            this._doctors = doctors;
        }

        public object Current
        {
            get
            {
                if(_position == -1 || _position >= _doctors.Count)
                    throw new IndexOutOfRangeException();

                return _doctors[_position]; 
            }
        }

        public bool MoveNext()
        {
            while (_position < _doctors.Count)
            {
                _position++;
                if (_position < _doctors.Count)
                {
                    return true;
                }
            }

            return false;
        }

        public void Reset()
        {
            _position = -1; 
        }
    }

}
