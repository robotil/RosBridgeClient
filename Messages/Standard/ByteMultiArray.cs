using Newtonsoft.Json;
using RosSharp.RosBridgeClient;

namespace RosBridgeClient.Messages.Standard
{
    public class ByteMultiArray : Message
    {
        [JsonIgnore]
        public const string RosMessageName = "std_msgs/ByteMultiArray";

        public MultiArrayLayout Layout;
        public byte[] data;

        public ByteMultiArray()
        {
            Layout = new MultiArrayLayout();
            data = new byte[0];
        }
    }
    
}
