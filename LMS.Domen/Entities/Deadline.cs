namespace LMS.Domen.Entities
{
    public class Deadline
    {
        public Guid Id { get; set; }
        public float MaxGrade { get; set; }
        public DateTime StartDate { get; set; }

        /// <summary>
        /// StartDate dan malum vaqt o'tadi 24 soat yoki 48,96
        /// </summary>
        public DateTime ExpiredDate { get; set; }
        
        public DateTime CreatedDate { get; set; } = DateTime.Now;

        public ICollection<Grade>? Grades { get; set; }
    }
}
