using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Runtime.Serialization;

namespace Organizer.Model
{
    [DataContract]
    public class DataModel
    {
        public static string DataPath = "data.dat";
        [DataMember] public Dictionary<Account, Student> Acounts { get; set; }
        public DataModel()
        {
            Acounts = new Dictionary<Account, Student>(){};
        }
        public DataModel(Dictionary<Account, Student> students)
        {
            Acounts = students;
        }

        

        public static DataModel Load() =>
            File.Exists(DataPath) ? DataSerializer.DeserializerItem(DataPath) : new DataModel();

        public Dictionary<Account, Student> LoadS() => this.Acounts;

        public void Save() => DataSerializer.SerializeData(DataPath, this);
    }
}