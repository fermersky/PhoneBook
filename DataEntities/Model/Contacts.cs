using System;
using System.Collections.Generic;

namespace DataEntities.Model
{
    public partial class Contacts
    {
        public int Id { get; set; }
        public string Phone { get; set; }
        public string Name { get; set; }
        public int? UserId { get; set; }

        public virtual Users User { get; set; }
    }
}
