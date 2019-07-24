using System;
using System.Collections.Generic;

namespace DataEntities.Model
{
    public partial class Users
    {
        public Users()
        {
            Contacts = new HashSet<Contacts>();
        }

        public int Id { get; set; }
        public string Lgn { get; set; }
        public string Pwd { get; set; }

        public virtual ICollection<Contacts> Contacts { get; set; }
    }
}
