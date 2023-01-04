using System.Collections.Generic;

namespace StepsWork.Api.Domain.Entities
{
    public class Category : BaseEntity
    {
        public string Description { get; set; }

        public virtual IList<UserCategory> UserCategories { get; set; }
        public virtual IList<Service> Services { get; set; }
    }
}
