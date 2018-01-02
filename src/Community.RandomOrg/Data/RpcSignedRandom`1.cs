﻿using Community.RandomOrg.Converters;
using Newtonsoft.Json;

namespace Community.RandomOrg.Data
{
    internal abstract class RpcSignedRandom<T> : RpcRandom<T>
    {
        protected RpcSignedRandom()
        {
            License = new RpcLicense();
        }

        [JsonProperty("method", Required = Required.Always)]
        public string Method
        {
            get;
            set;
        }

        [JsonProperty("hashedApiKey", Required = Required.Always)]
        [JsonConverter(typeof(Base64ToByteArrayConverter))]
        public byte[] ApiKeyHash
        {
            get;
            set;
        }

        [JsonProperty("serialNumber", Required = Required.Always)]
        public long SerialNumber
        {
            get;
            set;
        }

        [JsonProperty("userData", Required = Required.AllowNull)]
        public string UserData
        {
            get;
            set;
        }

        [JsonProperty("license", Required = Required.Always)]
        public RpcLicense License
        {
            get;
        }
    }
}