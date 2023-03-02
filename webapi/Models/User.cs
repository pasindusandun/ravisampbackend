using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
namespace webapi.Models
{
    [BsonIgnoreExtraElements]
    public class User
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; } = String.Empty;

        [BsonElement("firstName")]
        public string FirstName { get; set; }=String.Empty;

        [BsonElement("lastName")]
        public string LastName { get; set; } = String.Empty;

        [BsonElement("gender")]
        public String Gender { get; set; }= String.Empty;

        [BsonElement("password")]
        public string Password { get; set; } = String.Empty;

        [BsonElement("remark")]
        public string Remark { get; set; } = String.Empty;

        [BsonElement("title")]
        public string Title { get; set; } = String.Empty;

    }
}
