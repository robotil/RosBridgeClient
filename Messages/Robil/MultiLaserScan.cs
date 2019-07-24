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

namespace RosSharp.RosBridgeClient.Messages.Robil
{
    public class MultiLaserScan : Message
    {
        [JsonIgnore]
        public const string RosMessageName = "robil_msgs/MultiLaserScan";
     /***timestamp in the header is the acquisition time of the first ray in the scan.
         In frame frame_id, angles are measured around the positive Z axis (counterclockwise, if Z is up)
        with zero angle being forward along the x axis   ***/
        public Standard.Header header;

        public float angle_min_t;       //start angle of the top planes scan [rad]
        public float angle_max_t;       //end angle of the top planes scan [rad]
        public float angle_min_b;       //start angle of the bottom planes scan [rad]
        public float angle_max_b;       //end angle of the bottom planes scan [rad]
        public float angle_increment;   //angular distance between measurements [rad]
        
        public float angle_t1;           // vertical angle of top plane 1
        public float angle_t2;           // vertical angle of top plane 2
        public float angle_b1;           // vertical angle of bottom plane 1
        public float angle_b2;           // vertical angle of bottom plane 2
        
        public float time_increment;    // time between measurements [seconds] - 
                                        // if your scanner is moving, this will be used in interpolating position
                                        // of 3d points
        public float scan_time;         // time between scans [seconds]
        public float range_min;         // minimum range value [m]
        public float range_max;         // maximum range value [m]

        public float[] ranges_t1;       // range data [m] (Note: values < range_min or > range_max should be discarded)
        public float[] ranges_t2;       // range data [m] (Note: values < range_min or > range_max should be discarded)
        public float[] ranges_b1;       // range data [m] (Note: values < range_min or > range_max should be discarded)
        public float[] ranges_b2;       // range data [m] (Note: values < range_min or > range_max should be discarded)
        public float[] intensities;     // # intensity data [device-specific units].  
                                        // If your device does not provide intensities, please leave the array empty.

        public MultiLaserScan()
        {
            header = new Standard.Header();
            angle_min_t = 0;
            angle_max_t = 0;
            angle_min_b = 0;
            angle_max_b = 0;
            angle_increment = 0;
            angle_t1 = 0;
            angle_t2 = 0;
            angle_b1 = 0;
            angle_b2 = 0;
            time_increment = 0;
            scan_time = 0;
            range_min = 0;
            range_max = 0;
            ranges_t1 = new float[0];
            ranges_t2 = new float[0];
            ranges_b1 = new float[0];
            ranges_b2 = new float[0];
            intensities = new float[0];
        }
    }
}