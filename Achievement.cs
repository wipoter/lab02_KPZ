using System.Reflection.Emit;
using System.Runtime.Serialization;

namespace Organizer.Model
{
    [DataContract]
    public class Achievement
    {
        [DataMember] private Status isPositive;
        
        [DataMember] private string name;
        
        [DataMember] private string descripyion;

        [DataMember] private int cost;

        public Achievement() => isPositive = Status.Negative;
        public Achievement(Status isPositive, string name, string descripyion, int cost)
        {
            this.isPositive = isPositive;
            this.name = name;
            this.descripyion = descripyion;
            this.cost = cost;
        }

        #region Getters & Setters

        public Status IsPositive
        {
            get => isPositive;
            set => isPositive = value;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public int Cost
        {
            get => cost;
            set => cost = value;
        }

        public string Descripyion
        {
            get => descripyion;
            set => descripyion = value;
        }

        #endregion
        
    }
}

public enum Status
{
    Positive,
    Negative
}