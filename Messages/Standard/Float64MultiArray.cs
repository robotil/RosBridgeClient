using Newtonsoft.Json;
using RosSharp.RosBridgeClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RosBridgeClient.Messages.Standard
{
    public class Float64MultiArray : Message
    {
        [JsonIgnore]
        public const string RosMessageName = "std_msgs/Float64MultiArray";

        public MultiArrayLayout Layout;
        public double[] data;

        public Float64MultiArray()
        {
            Layout = new MultiArrayLayout();
            data = new double[0];
        }
    }

}
