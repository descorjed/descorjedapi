using System;
using System.ComponentModel.DataAnnotations;

namespace DescorjedAPI.DAL
{
    public class Entity
    {
        public string ID { get; private set; }


        public Entity()
        {
            ID = Guid.NewGuid().ToString();
        }
    }
}
