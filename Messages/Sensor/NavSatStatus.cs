/*
© Siemens AG, 2017-2019
Author: Dr. Martin Bischoff (martin.bischoff@siemens.com)

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at
<http://www.apache.org/licenses/LICENSE-2.0>.
Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
*/
using System.Collections;
using System.Reflection;
using Newtonsoft.Json;

namespace RosSharp.RosBridgeClient.Messages.Sensor
{
    public class NavSatStatus : Message
    {
        [JsonIgnore]
        public const string RosMessageName = "sensor_msgs/NavSatStatus";
        public enum StatusType: sbyte {STATUS_NO_FIX=-1, STATUS_FIX=0, STATUS_SBAS_FIX=1, STATUS_GBAS_FIX=2};
        public sbyte status; //8 bits
        public enum ServiceType: short {SERVICE_GPS=1, SERVICE_GLONASS=2, SERVICE_COMPASS = 4, SERVICE_GALILEO = 8 };
        public short service; //16 bits
        public double[] velocity;
        public double[] effort;

        public NavSatStatus()
        {
            status = (sbyte) StatusType.STATUS_NO_FIX;
            service = 0;  //Bitmask according ServiceType
            
        }
    }
}