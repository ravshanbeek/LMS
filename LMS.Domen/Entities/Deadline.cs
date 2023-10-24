﻿namespace LMS.Domen.Entities
{
    public class Deadline : Auditable
    {
        public float MaxGrade { get; set; }
        public DateTime StartDate { get; set; }

        /// <summary>
        /// StartDate dan malum vaqt o'tadi 24 soat yoki 48,96
        /// automatic qo'yiladi
        /// </summary>
        public DateTime ExpiredDate { get; set; }
        public Guid CourseId { get; set; }

        public Course? Course { get; set; }
        public ICollection<Grade>? Grades { get; set; }
    }
}
