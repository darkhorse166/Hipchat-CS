using HipchatApiV2;
using HipchatApiV2.Enums;
using Xunit;

namespace IntegrationTests
{
    [Trait("GetAllMembers", "")]
    public class GetAllMembersTests
    {
        private readonly HipchatClient _client;
        private readonly int _existingRoomId;
        private readonly string _existingRoomName;

        public GetAllMembersTests()
        {
            const string roomName = "Test GetAllMembers";
            HipchatApiConfig.AuthToken = TestsConfig.AuthToken;
            _client = new HipchatClient();

            var room = _client.CreateRoom(roomName, false, null, RoomPrivacy.Private);
            _existingRoomId = room.Id;
            _existingRoomName = roomName;
        }

        [Fact(DisplayName = "Can get users of a private room by room name")]
        public void CanGetAllMembersByRoomName()
        {
            var members = _client.GetAllMembers(_existingRoomName);

            Assert.NotNull(members);
        }

        [Fact(DisplayName = "Can get users of a private room by room ID")]
        public void CanGetAllMembersByRoomId()
        {
            var members = _client.GetAllMembers(_existingRoomId);

            Assert.NotNull(members);
        }

        public void Dispose()
        {
            _client.DeleteRoom(_existingRoomId);
        }
    }
}
