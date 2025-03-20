using System.Text.Json;

namespace ChatLib.Models
{
    public class ChatHub
    {
        // 역직렬화
        public static ChatHub? Parse(string json) => JsonSerializer.Deserialize<ChatHub>(json);
        public int RoomId { get; set; }
        public int UserId { get; set; }
        public string UserName { get; set; } = string.Empty;
        public string Message { get; set; } = string.Empty;

        // 직렬화
        public string ToJsonString() => JsonSerializer.Serialize(this);

    }
}
