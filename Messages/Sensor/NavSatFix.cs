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

using Newtonsoft.Json;

namespace RosSharp.RosBridgeClient.Messages.Sensor
{
    public class NavSatFix : Message
    {
        [JsonIgnore]
        public const string RosMessageName = "sensor_msgs/NavSatFix";
        public Standard.Header header;
        public Sensor.NavSatStatus status;
        public float latitude;
        public float longitude;
        public float altitude;
        public float[] position_covariance;
        public enum PositionCovarianceType: sbyte {COVARIANCE_TYPE_UNKNOWN=0, 
                                                    COVARIANCE_TYPE_APPROXIMATED =1, 
                                                    COVARIANCE_TYPE_DIAGONAL_KNOWN =2, 
                                                    COVARIANCE_TYPE_KNOWN =3};
        public sbyte position_covariance_type; //8 bits
        public NavSatFix()
        {
            header = new Standard.Header();
            status = new NavSatStatus();
            latitude = 0;
            longitude = 0;
            altitude = 0;
            position_covariance = new float[9];
            position_covariance_type = (sbyte)PositionCovarianceType.COVARIANCE_TYPE_UNKNOWN;
        }
    }
}