using Newtonsoft.Json;
using RosSharp.RosBridgeClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RosBridgeClient.Messages.Standard
{
    public class MultiArrayLayout : Message
    {
        [JsonIgnore]
        public const string RosMessageName = "std_msgs/MultiArrayLayout";

        public MultiArrayDimension[] Dim;
        public uint DataOffset;

        public MultiArrayLayout()
        {
            Dim = new MultiArrayDimension[0];
            DataOffset = 0;
        }
    }
}
