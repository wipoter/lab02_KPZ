
namespace Organizer.Model.Test;

public class Tests
{
    /*[SetUp]
    public void Setup()
    {
    }*/

    [Test]
    public void TestMethodeSerialize()
    {
        var model = new DataModel();
        model.Acounts = new ();
        List<Achievement> achievements = new List<Achievement>();
        achievements.Add(new Achievement(Status.Positive, "First meet", "The first enter.", 5));
        achievements.Add(new Achievement(Status.Positive, "That's one small step for man, one giant leap for mankind.'","The first successfully passed project.", 10));
        model.Acounts.Add(new Account("wipoter", "1234", true),new Student("Dmytro", "Sushchyk", "IKNI","PZ", 32, achievements));
        var tmp = model.Acounts.First().Value;
        DataSerializer.SerializeData(@"D:\data.dat", model);
    }

    [Test]
    public void TestMethodeDeserialize()
    {
        var model = DataSerializer.DeserializerItem(@"D:\data.dat");
        var students = model.Acounts;
        var student = students.First().Value;
        var ac = students.First().Key;
        
        List<Achievement> achievements = new List<Achievement>();
        achievements.Add(new Achievement(Status.Positive, "First meet", "The first enter.", 5));
        achievements.Add(new Achievement(Status.Positive, "That's one small step for man, one giant leap for mankind.'","The first successfully passed project.", 10));
        var studentMustBe = new Student("Dmytro", "Sushchyk", "IKNI", "PZ", 32, achievements);
        var ac1 = new Account("wipoter", "1234", true);
        Assert.AreEqual(true, student == studentMustBe && ac == ac1);
    }
    
    
    
    
}