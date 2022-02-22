using BLL.Extensions;
using System;
using System.Collections.Generic;

namespace BLL.Objects
{
    [Serializable]
    public class CurriculumVitae
    {

        private const string _ERROR_TYPEOBJECTNOTIMPLEMENTED = "Ce type d'objet n'a pas été implémenté";


        #region Publics members
        public AdministrativeDatas AdministrativeDatas { get; set; }
        public List<ProfessionalExperience> ProfessionnalExperiences { get; set; }
        public List<Learning> Learnings { get; set; }
        public List<Skill> Skills { get; set; }
        public List<ComplementaryInformation> ComplementaryInformations { get; set; } 
        #endregion


        #region Constructors
        public CurriculumVitae()
        {
            this.AdministrativeDatas = new AdministrativeDatas();
            this.ProfessionnalExperiences = new List<ProfessionalExperience>();
            this.Learnings = new List<Learning>();
            this.Skills = new List<Skill>();
            this.ComplementaryInformations = new List<ComplementaryInformation>();
        } 
        #endregion


        #region Publics méthods
        public void Add(object obj)
        {
            switch (obj)
            {
                case ProfessionalExperience newExperience:
                    this.ProfessionnalExperiences.Add(newExperience);
                    break;
                case Learning newLearning:
                    this.Learnings.Add(newLearning);
                    break;
                case Skill newSkill:
                    this.Skills.Add(newSkill);
                    break;
                case ComplementaryInformation newComplementaryInformation:
                    this.ComplementaryInformations.Add(newComplementaryInformation);
                    break;
                default:
                    throw new Exception(_ERROR_TYPEOBJECTNOTIMPLEMENTED);
            }
        }

        public void Update(object obj)
        {
            var index = GetIndex(obj);

            switch (obj)
            {
                case ProfessionalExperience updatedExperience:
                    this.ProfessionnalExperiences[index] = updatedExperience;
                    break;
                case Learning updatedLearning:
                    this.Learnings[index] = updatedLearning;
                    break;
                case Skill updatedSkill:
                    this.Skills[index] = updatedSkill;
                    break;
                case ComplementaryInformation updatedComplementaryInformation:
                    this.ComplementaryInformations[index] = updatedComplementaryInformation;
                    break;
                default:
                    throw new Exception(_ERROR_TYPEOBJECTNOTIMPLEMENTED);
            }
        }

        public void Remove(object obj)
        {
            var index = GetIndex(obj);

            switch (obj)
            {
                case ProfessionalExperience:
                    this.ProfessionnalExperiences.RemoveAt(index);
                    break;
                case Learning:
                    this.Learnings.RemoveAt(index);
                    break;
                case Skill:
                    this.Skills.RemoveAt(index);
                    break;
                case ComplementaryInformation:
                    this.ComplementaryInformations.RemoveAt(index);
                    break;
                default:
                    throw new Exception(_ERROR_TYPEOBJECTNOTIMPLEMENTED);
            }
        }

        public void MoveUp(object obj)
        {
            var index = GetIndex(obj);

            switch (obj)
            {
                case ProfessionalExperience experience:
                    if (index >= this.ProfessionnalExperiences.Count - 1) return;
                    this.ProfessionnalExperiences.Swap(index, index + 1);
                    break;
                case Learning learning:
                    if (index >= this.Learnings.Count - 1) return;
                    this.Learnings.Swap(index, index + 1);
                    break;
                case Skill skill:
                    if (index >= this.Skills.Count - 1) return;
                    this.Skills.Swap(index, index + 1);
                    break;
                case ComplementaryInformation complementaryInformation:
                    if (index >= this.ComplementaryInformations.Count - 1) return;
                    this.ComplementaryInformations.Swap(index, index + 1);
                    break;
                default:
                    throw new Exception(_ERROR_TYPEOBJECTNOTIMPLEMENTED);
            }
        }

        public void MoveDown(object obj)
        {
            var index = GetIndex(obj);
            if (index <= 0)
                return;

            switch (obj)
            {
                case ProfessionalExperience:
                    this.ProfessionnalExperiences.Swap(index, index - 1);
                    break;
                case Learning:
                    this.Learnings.Swap(index, index - 1);
                    break;
                case Skill:
                    this.Skills.Swap(index, index - 1);
                    break;
                case ComplementaryInformation:
                    this.ComplementaryInformations.Swap(index, index - 1);
                    break;
                default:
                    throw new Exception(_ERROR_TYPEOBJECTNOTIMPLEMENTED);
            }
        }
        #endregion


        #region Privates methods
        private int GetIndex(object obj)
        {
            switch (obj)
            {
                case ProfessionalExperience experience:
                    return this.ProfessionnalExperiences.IndexOf(experience);
                case Learning learning:
                    return this.Learnings.IndexOf(learning);
                case Skill skill:
                    return this.Skills.IndexOf(skill);
                case ComplementaryInformation complementaryInformation:
                    return this.ComplementaryInformations.IndexOf(complementaryInformation);
                default:
                    throw new Exception(_ERROR_TYPEOBJECTNOTIMPLEMENTED);
            }
        }
        #endregion
    }
}
