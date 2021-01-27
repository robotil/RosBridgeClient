using Newtonsoft.Json;
using RosSharp.RosBridgeClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RosBridgeClient.Messages.Standard
{
    public class Int32MultiArray : Message
    {
        [JsonIgnore]
        public const string RosMessageName = "std_msgs/Int32MultiArray";

        public MultiArrayLayout Layout;
        public int[] data;      

        public Int32MultiArray()
        {
            Layout = new MultiArrayLayout();
            data = new int[0];
        }
    }
}
