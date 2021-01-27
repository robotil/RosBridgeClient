using Newtonsoft.Json;
using RosSharp.RosBridgeClient;

namespace RosBridgeClient.Messages.Standard
{
    public class UInt32MultiArray : Message
    {
        [JsonIgnore]
        public const string RosMessageName = "std_msgs/UInt32MultiArray";

        public MultiArrayLayout Layout;
        public uint[] data;

        public UInt32MultiArray()
        {
            Layout = new MultiArrayLayout();
            data = new uint[0];
        }
    }
}
