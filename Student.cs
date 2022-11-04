using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Organizer.Model
{
    [DataContract]
    public class Student
    {
        [DataMember] private string name;
        [DataMember] private string surname;
        [DataMember] private string institute;
        [DataMember] private string group;
        [DataMember] private int numberOfGroup;
        [DataMember] public List<Achievement> achievements;

        public Student()
        {
            achievements = new List<Achievement>();
            achievements.Add(new Achievement(Status.Positive, "First step!", "Registred.", 2));
        }

        public Student(string name, string surname, string institute, string group, int numberOfGroup,
            List<Achievement> achievements)
        {
            this.name = name;
            this.surname = surname;
            this.institute = institute;
            this.group = group;
            this.numberOfGroup = numberOfGroup;
            this.achievements = achievements;
        }

        #region Getters & Setters

        public string Name
        {
            get => name;
            set => name = value;
        }

        public string Surname
        {
            get => surname;
            set => surname = value;
        }

        public string Institute
        {
            get => institute;
            set => institute = value;
        }

        public string Group
        {
            get => group;
            set => group = value;
        }

        public int NumberOfGroup
        {
            get => numberOfGroup;
            set => numberOfGroup = value;
        }

        public List<Achievement> Achievements
        {
            get => achievements;
            set => achievements = value;
        }

        #endregion

        public static bool operator ==(Student student1, Student student2) => student1.Name == student2.Name &&
                                                                              student1.Surname == student2.Surname &&
                                                                              student1.Institute ==
                                                                              student2.Institute &&
                                                                              student1.Group == student2.Group &&
                                                                              student1.NumberOfGroup ==
                                                                              student2.NumberOfGroup;

        public static bool operator !=(Student student1, Student student2) => !(student1.Name == student2.Name &&
            student1.Surname == student2.Surname &&
            student1.Institute == student2.Institute &&
            student1.Group == student2.Group &&
            student1.NumberOfGroup == student2.NumberOfGroup);
        
    }
}

