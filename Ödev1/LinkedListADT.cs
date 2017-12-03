using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ödev1
{
    public abstract class LinkedListADT
    {
        public Node Head;
        public int Size = 0;
        public abstract void InsertFirst(Musteri value);
        public abstract void InsertLast(Musteri value);
        public abstract void InsertPos(int position, Musteri value);
        public abstract void DeleteFirst();
        public abstract void DeleteLast();
        public abstract void DeletePos(int position);
        public abstract string GetElement(String ad, string soyad);

        public abstract string DisplayElements();
    }
}
