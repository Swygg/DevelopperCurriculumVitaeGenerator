using BLL.Enums;
using System;
using System.Collections.Generic;

namespace BLL.Objects
{
    [Serializable]
    public class ProfessionalExperience
    {
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string LengthDate { get; set; }
        public EProfessionnalExperienceDateType ProfessionnalExperienceDateType { get; set; }
        public string Name { get; set; }
        public string CompanyName { get; set; }
        public string CompanyCity { get; set; }
        public List<string> Missions { get; set; } = new List<string>();
        public string ContractType { get; set; }
        public bool IsDevelopperJob { get; set; }

        public ProfessionalExperience(DateTime startDate, DateTime endDate)
        {
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.ProfessionnalExperienceDateType = EProfessionnalExperienceDateType.StartDate_EndDate;
        }

        public ProfessionalExperience(DateTime startDate, string lenght)
        {
            this.StartDate = startDate;
            this.LengthDate = lenght;
            this.ProfessionnalExperienceDateType = EProfessionnalExperienceDateType.Lenght;
        }

        public string GetDate()
        {
            switch (ProfessionnalExperienceDateType)
            {
                case EProfessionnalExperienceDateType.StartDate_EndDate:
                    return $"{StartDate.ToString("yyyy")} - {EndDate.Value.ToString("yyyy")}";
                case EProfessionnalExperienceDateType.Lenght:
                    return $"{StartDate.ToString("yyyy")} - ({LengthDate})";
                default:
                    throw new NotImplementedException();
            }
        }

        public override string ToString()
        {
            return $"{GetDate()} - {this.Name} - {this.CompanyName}";
        }

    }
}
