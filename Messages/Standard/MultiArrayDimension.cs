using Newtonsoft.Json;
using RosSharp.RosBridgeClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RosBridgeClient.Messages.Standard
{
    public class MultiArrayDimension : Message
    {
        [JsonIgnore]
        public const string RosMessageName = "std_msgs/MultiArrayDimension";

        public string Label;
        public uint Size;
        public uint Stride;

        public MultiArrayDimension()
        {
            Label = string.Empty;
            Size = 0;
            Stride = 0;
        }
    }
}
