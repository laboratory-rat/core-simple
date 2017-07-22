using System;
using System.Collections.Generic;
using System.Text;

namespace RAMCard.Domain
{
    public class BaseEntity
    {
        public string Id { get; set; }

        public DateTime TimeCreated { get; set; }

        public bool IsDeleted { get; set; }
        public DateTime DeletedTime { get; set; }
    }
}
