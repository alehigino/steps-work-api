using System;
using System.Collections.Generic;

namespace StepsWork.Api.Domain.Entities
{
    public class User : BaseEntity
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public decimal Phone { get; set; }
        public bool WhatsApp { get; set; }
        public string Photo { get; set; }
        public string Street { get; set; }
        public int Number { get; set; }
        public string District { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public virtual IList<UserCategory> UserCategories { get; set; }
        public virtual IList<Service> Services { get; set; }
    }
}
