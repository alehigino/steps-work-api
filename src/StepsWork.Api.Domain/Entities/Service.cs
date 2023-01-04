using System;

namespace StepsWork.Api.Domain.Entities
{
    public class Service : BaseEntity
    {
        public int UserId { get; set; }
        public int CategoryId { get; set; }
        public DateTime Date { get; set; }
        public decimal Value { get; set; }
        public int Evaluation { get; set; }
        public string Observation { get; set; }

        public virtual User User { get; set; }
        public virtual Category Category { get; set; }
    }
}
