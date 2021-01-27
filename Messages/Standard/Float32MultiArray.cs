using Newtonsoft.Json;
using RosSharp.RosBridgeClient;

namespace RosBridgeClient.Messages.Standard
{
    public class Float32MultiArray : Message
    {
        [JsonIgnore]
        public const string RosMessageName = "std_msgs/Float32MultiArray";

        public MultiArrayLayout Layout;
        public float[] data;

        public Float32MultiArray()
        {
            Layout = new MultiArrayLayout();
            data = new float[0];
        }
    }

}
