using System;
using System.Collections.Generic;
using System.Text;

namespace StoreDataBase.Entities
{
    public class SectionProduct
    {
        public int Id { get;  set; }
        public string Name { get;  set; }    

        public SectionProduct(string name)
        {
            Name = name;
        }

        public SectionProduct(int id, string name)
        {

            Id = id;
            Name = name;
        }
    }
}
