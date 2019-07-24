/*
© Siemens AG, 2017-2018
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
    public class Imu : Message
    {
        [JsonIgnore]
        public const string RosMessageName = "sensor_msgs/Imu";
        public Standard.Header header;
        public Geometry.Quaternion orientation; 
        public float[] orientation_covariance; //should be -1
        public Geometry.Vector3 angular_velocity; //rad/sec
        public float[] angular_velocity_covariance; //should be -1
        public Geometry.Vector3 linear_acceleration;  //m/s^2
        public float[] linear_acceleration_covariance; //should be -1

        public Imu()
        {
            header = new Standard.Header();
            orientation = new Geometry.Quaternion();
            orientation_covariance = new float[] {-1,0,0,0,-1,0,0,0,-1};
            angular_velocity = new Geometry.Vector3();
            angular_velocity_covariance = new float[9];
            linear_acceleration = new Geometry.Vector3();
            linear_acceleration_covariance = new float[9];
        
        }
    }
}