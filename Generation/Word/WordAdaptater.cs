using BLL.Objects;
using Generation.Classes;
using Generation.Enumerations;
using System.Collections.Generic;
using System.Text;

namespace Generation.Word
{
    public class WordAdaptater
    {
        private WordGeneration _generator;
        private ParagraphStyle _titleStyle;
        private ParagraphStyle _bold;

        private const int _row0Size = 100;
        private const int _row1Size = 450;



        public WordAdaptater(CurriculumVitae cv, string path)
        {
            _titleStyle = new ParagraphStyle()
            {
                Bold = true,
                Alignment = AlignmentType.Right,
                Size = 20
            };

            _bold = new ParagraphStyle()
            {
                Bold = true,
            };


            _generator = new WordGeneration(path);

            GenerateHeader(cv.AdministrativeDatas);
            GenerateProfessionalExperiences(cv.ProfessionnalExperiences);
            GenerateLearnings(cv.Learnings);
            GenerateSkills(cv.Skills);
            GenerateComplementaryInformations(cv.ComplementaryInformations);

            _generator.Save();
        }



        private void GenerateHeader(AdministrativeDatas datas)
        {
            var jobParagraph = new ParagraphStyle()
            {
                Alignment = AlignmentType.Right,
                Bold = true,
                Underline = true,
                Size = 20
            };
            _generator.AddParagraph(datas.JobName, jobParagraph);

            if (datas.Description != null)
            {
                var descriptionParagraph = new ParagraphStyle()
                {
                    Alignment = AlignmentType.Right,
                    Italic = true,
                    Size = 15
                };
                _generator.AddParagraph(datas.Description, descriptionParagraph);
            }

            var administrativDatasParagraph = new ParagraphStyle()
            {

            };

            _generator.AddParagraph($"{datas.LastName.ToUpper()} {datas.FirstName}", administrativDatasParagraph);
            _generator.AddParagraph(datas.Adresse, administrativDatasParagraph);
            _generator.AddParagraph(datas.City, administrativDatasParagraph);
            _generator.AddParagraph(datas.PhoneNumber, administrativDatasParagraph);
            _generator.AddParagraph(datas.EmailAdress, administrativDatasParagraph);
            if (datas.BirthDate != null)
            {
                var age = System.DateTime.Today.Year - datas.BirthDate.Value.Year;
                if (datas.BirthDate.Value > System.DateTime.Today.AddYears(-age)) age--;
                _generator.AddParagraph($"{age} ans", administrativDatasParagraph);
            }
            if (datas.LicenseDriver.Count > 0)
            {
                var licences = "Titulaire permis ";
                licences += string.Join(',', datas.LicenseDriver);

                _generator.AddParagraph(licences, administrativDatasParagraph);
            }
            if (datas.IsVehiculeOwner.HasValue && datas.IsVehiculeOwner.Value == true)
            {
                _generator.AddParagraph("Véhicule possédé", administrativDatasParagraph);
            }
        }

        private void GenerateProfessionalExperiences(List<ProfessionalExperience> experiences)
        {
            if (experiences.Count == 0)
                return;

            InsertTitle("Expériences professionnelles");

            var table = new List<ParagraphPart>[experiences.Count, 2];
            List<ParagraphPart> paragraphs;

            for (int i = 0; i < experiences.Count; i++)
            {
                table[i, 0] = GetParagraphPart($"{experiences[i].GetDate()}");

                paragraphs = new List<ParagraphPart>();
                paragraphs.Add(new ParagraphPart($"{experiences[i].Name} ", _bold));
                paragraphs.Add(new ParagraphPart($"- {experiences[i].CompanyName} - {experiences[i].CompanyCity} - {experiences[i].ContractType}"));


                foreach (var mission in experiences[i].Missions)
                {
                    if (mission.Trim().Length == 0)
                        break;
                    var pp = new ParagraphPart($"- {mission}") { JumpLine = true };
                    paragraphs.Add(pp);
                }

                table[i, 1] = paragraphs;
            }
            _generator.InsertTable(GetTableOptions(table));
        }

        private void GenerateLearnings(List<Learning> learnings)
        {
            if (learnings.Count == 0)
                return;

            InsertTitle("Formations");

            var table = new List<ParagraphPart>[learnings.Count, 2];
            List<ParagraphPart> paragraphs;
            for (int i = 0; i < learnings.Count; i++)
            {
                table[i, 0] = GetParagraphPart($"{learnings[i].StartDate.Year} ");

                paragraphs = new List<ParagraphPart>();
                paragraphs.Add(new ParagraphPart($"{learnings[i].Name}", _bold));
                if (!string.IsNullOrEmpty(learnings[i].Description))
                    paragraphs.Add(new ParagraphPart($", {learnings[i].Description}"));
                paragraphs.Add(new ParagraphPart($"({learnings[i].SchoolName}, {learnings[i].SchoolCity})"));
                if (!learnings[i].IsObtained)
                    paragraphs.Add(new ParagraphPart(" - Non obtenu"));
                table[i, 1] = paragraphs;
            }
            _generator.InsertTable(GetTableOptions(table));
        }

        private void GenerateSkills(List<Skill> skills)
        {
            if (skills.Count == 0)
                return;

            InsertTitle("Compétences informatiques");

            var table = new List<ParagraphPart>[skills.Count, 2];

            for (int i = 0; i < skills.Count; i++)
            {
                table[i, 0] = GetParagraphPart(skills[i].ThemeName, _bold);
                table[i, 1] = GetParagraphPart(string.Join(", ", skills[i].Content));
            }

            _generator.InsertTable(GetTableOptions(table));
        }

        private void GenerateComplementaryInformations(List<ComplementaryInformation> informations)
        {
            if (informations.Count == 0)
                return;

            InsertTitle("Informations complémentaires");

            var table = new List<ParagraphPart>[informations.Count, 2];

            for (int i = 0; i < informations.Count; i++)
            {
                table[i, 0] = GetParagraphPart(informations[i].ThemeName, _bold);
                table[i, 1] = GetParagraphPart(string.Join(", ", informations[i].Content));
            }

            _generator.InsertTable(GetTableOptions(table));
        }



        private void InsertTitle(string title)
        {
            _generator.AddParagraph(title, _titleStyle);
            _generator.InsertLine();
        }

        private TableOptions GetTableOptions(List<ParagraphPart>[,] table)
        {
            return new TableOptions(table,
                new List<ColumnSize>() {
                new ColumnSize(0,_row0Size),
                new ColumnSize(1,_row1Size)
                });
        }

        private List<ParagraphPart> GetParagraphPart(string str, ParagraphStyle style = null)
        {
            ParagraphPart paragraphPart;
            if (style == null)
                paragraphPart = new ParagraphPart(str);
            else
                paragraphPart = new ParagraphPart(str, style);

            return new List<ParagraphPart>()
            {
                paragraphPart
            };
        }
    }
}
