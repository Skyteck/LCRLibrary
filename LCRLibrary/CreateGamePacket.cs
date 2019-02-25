using LiteNetLib.Utils;
using System;

namespace LCRLibrary
{
    public class CreateGamePacket : INetSerializable
    {
        public string Id { get; set; }
        public int Playernum { get; set; }
        public bool Success { get; set; } = false;

        public CreateGamePacket()
        {
            if(!Success)
            {
                Playernum = 3;
                Random idGen = new Random();
                Id = idGen.Next(1, 100000).ToString();
            }
            
        }

        public CreateGamePacket(string id, int playernum)
        {
            Playernum = playernum;

            Id = id;
        }


        public void Deserialize(NetDataReader reader)
        {
            var data = reader;

            Success = reader.GetBool();

            if(Success)
            {
                Id = reader.GetString();
                Playernum = reader.GetInt();

            }

        }

        public void Serialize(NetDataWriter writer)
        {
            writer.Put(Id);
            writer.Put(Playernum);
            writer.Put(Success);
        }
    }
}
