using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace Weather {
    public class WeatherProxy {
        public async static Task<RootObject> GetWeather (string location) {
            var http = new HttpClient();
            var response = await http.GetAsync("http://apidev.accuweather.com/currentconditions/v1/127964.json?language=en&apikey=hoArfRosT1215");
            var result = await response.Content.ReadAsStringAsync();
            var serializer = new DataContractJsonSerializer(typeof(RootObject));

            var ms = new MemoryStream(Encoding.UTF8.GetBytes(result));
            var data = (RootObject)serializer.ReadObject(ms);

            return data;
        }
    }

    [DataContract]
    public class Metric {
        [DataMember]
        public double Value { get; set; }

        [DataMember]
        public string Unit { get; set; }

        [DataMember]
        public int UnitType { get; set; }
    }

    [DataContract]
    public class Imperial {
        [DataMember]
        public double Value { get; set; }

        [DataMember]
        public string Unit { get; set; }

        [DataMember]
        public int UnitType { get; set; }
    }

    [DataContract]
    public class Temperature {
        [DataMember]
        public Metric Metric { get; set; }

        [DataMember]
        public Imperial Imperial { get; set; }
    }

    [DataContract]
    public class RootObject {
        [DataMember]
        public string LocalObservationDateTime { get; set; }

        [DataMember]
        public int EpochTime { get; set; }

        [DataMember]
        public string WeatherText { get; set; }

        [DataMember]
        public int WeatherIcon { get; set; }

        [DataMember]
        public bool IsDayTime { get; set; }

        [DataMember]
        public Temperature Temperature { get; set; }

        [DataMember]
        public string MobileLink { get; set; }

        [DataMember]
        public string Link { get; set; }
    }
}
