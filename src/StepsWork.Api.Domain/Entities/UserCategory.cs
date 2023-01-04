﻿namespace StepsWork.Api.Domain.Entities
{
    public class UserCategory: BaseEntity
    {
        public int UserId { get; set; }
        public int CategoryId { get; set; }

        public virtual User User { get; set; }
        public virtual Category Category { get; set; }
    }
}
