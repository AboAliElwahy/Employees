using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Employees
{
    public class Person
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Gender { get; set; } = string.Empty;
        public string Marital { get; set; } = string.Empty;
        public string Milatiry { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string ComputerNO { get; set; } = string.Empty;
        public string FileNO { get; set; } = string.Empty;
        public string MotherName { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string InsuranceNO { get; set; } = string.Empty;
        public string PrevReport { get; set; } = string.Empty;
        public string Punish { get; set; } = string.Empty;
        public string Gradation { get; set; } = string.Empty;
        public string Level { get; set; } = string.Empty;
        public string Cources { get; set; } = string.Empty;
        public string Holiday { get; set; } = string.Empty;
        public string Degree { get; set; } = string.Empty;
        public DateTime DegreeDate { get; set; }
        public string CarrerGroup { get; set; } = string.Empty;
        public string QualityGroup { get; set; } = string.Empty;
        public string JobTitle { get; set; } = string.Empty;
        public string JobWork { get; set; } = string.Empty;
        public string Qualification { get; set; } = string.Empty;
        public string QualificationSpeciality { get; set; } = string.Empty;
        public DateTime HiringDate { get; set; }
        public DateTime BirthDate { get; set; }
        public string NationalID { get; set; } = string.Empty;
        public string Section { get; set; } = string.Empty;
        public string WorkAt { get; set; } = string.Empty;
    }
}
