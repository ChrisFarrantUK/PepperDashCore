﻿//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using Crestron.SimplSharp;
//using Newtonsoft.Json;
//using Newtonsoft.Json.Linq;

//namespace PepperDash.Core
//{
//    public class DeviceConfig
//    {
//        [JsonProperty("key")]
//        public string Key { get; set; }

//        [JsonProperty("name")]
//        public string Name { get; set; }

//        [JsonProperty("group")]
//        public string Group { get; set; }

//        [JsonProperty("type")]
//        public string Type { get; set; }

//        [JsonProperty("properties")]
//        [JsonConverter(typeof(DevicePropertiesConverter))]
//        public JToken Properties { get; set; }
//    }

//    /// <summary>
//    /// 
//    /// </summary>
//    public class DevicePropertiesConverter : JsonConverter
//    {

//        public override bool CanConvert(Type objectType)
//        {
//            return objectType == typeof(JToken);
//        }

//        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
//        {
//            return JToken.ReadFrom(reader);
//        }

//        public override bool CanWrite
//        {
//            get
//            {
//                return false;
//            }
//        }

//        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
//        {
//            throw new NotImplementedException("SOD OFF HOSER");
//        }
//    }
//}