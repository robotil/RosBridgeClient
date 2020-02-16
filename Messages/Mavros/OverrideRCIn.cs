using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;

namespace RosSharp.RosBridgeClient.Messages.Mavros
{
    class OverrideRCIn : Message
    {
        /**
        # Override RC Input
        # Currently MAVLink defines override for 8 channels
    **/

        [JsonIgnore]
        public const string RosMessageName = "mavros_msgs/OverrideRCIn";
        public UInt16 CHAN_RELEASE = 0;
        public UInt16 CHAN_NOCHANGE = 65535;
        
        public UInt16[] channels;

        public OverrideRCIn()
        {
            CHAN_RELEASE = 0;
            CHAN_NOCHANGE = 65535;
            channels = new UInt16[8];
            
        }
    }
}

