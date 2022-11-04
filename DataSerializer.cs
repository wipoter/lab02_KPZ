using System.IO;
using System.Runtime.Serialization;

namespace Organizer.Model
{
    public class DataSerializer
    {
        public static void SerializeData(string file, DataModel data)
        {
            var formatter = new DataContractSerializer(typeof(DataModel));
            var s = new FileStream(file, FileMode.Create);
            formatter.WriteObject(s, data);
            s.Close();
        }

        public static DataModel DeserializerItem(string file)
        {
            var s = new FileStream(file, FileMode.Open);
            var formartter = new DataContractSerializer(typeof(DataModel));
            return (DataModel)formartter.ReadObject(s);
        }
    }
}