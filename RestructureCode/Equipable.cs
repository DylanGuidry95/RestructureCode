using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;
using PublicEnums;

namespace RestructureCode
{
    class Equipable<T> : IEquipable<T>
    {
        private T m_Item; //Item we are creating
        private string m_Name; //Name of item
        private float m_Weight; //Weight of the item
        private int m_Price; //How much the item cost to sell or buy
        private string m_Description; //Description of what the item is

        //Methods being implemented from the IEquipable interface
        public string Name { get { return m_Name; } }
        public float Weight { get { return m_Weight; } }
        public int Price { get { return m_Price; } }
        public string Description { get { return m_Description; } }
        public T Item { get { return m_Item; } }

        //Constructor to be called when we want to create a new Equipable object for our application
        public Equipable(T obj, string n, float w, int p)
        {
            m_Item = obj;
            m_Name = n;
            m_Weight = w;
            m_Price = p;
        }

        //Default constructor
        public Equipable() { }
    }
}
