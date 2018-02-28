using Realms;

namespace Realm.Tests.Console
{
    public class TestModel : RealmObject
    {
        [PrimaryKey]
        [Required]
        public string Id { get; set; }
    }
}