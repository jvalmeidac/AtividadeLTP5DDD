using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SharedContext
{
    public class EntityBase
    {
        public EntityBase()
        {
            ID = Guid.NewGuid();
        }
        [Key]
        public Guid ID { get; private set; }
        public string Nome { get; private set; }
        public string Sobrenome { get; private set; }
    }
}
