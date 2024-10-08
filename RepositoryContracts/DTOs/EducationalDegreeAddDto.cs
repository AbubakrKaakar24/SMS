﻿using SMS.Entities;

namespace RepositoryContracts
{
    public class EducationalDegreeAddDto
    {
        public string EducationalDegreeDescription { get; set; }
        public DateTime CreatedDate { get; set; }


        public EducationalDegree ToEducationalDegree()
        {
            return new EducationalDegree
            {
                EducationalDegreeDescription = EducationalDegreeDescription,
                CreatedDate = CreatedDate,
            };
        }
    }
}
