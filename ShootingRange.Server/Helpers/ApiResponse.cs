using System;
using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace ShootingRange.Infrastructure.Helpers
{
    [Serializable]
    [DataContract]
    public class ApiResponse
    {
        [DataMember]
        public int StatusCode {get; set;}

        [DataMember]
        public string Message {get; set;}

        [DataMember(EmitDefaultValue = false)]
        public object Result {get; set;}

        [JsonConstructor]
        public ApiResponse(int statusCode, string message = "", object result = null)
        {
            StatusCode = statusCode;
            Message = message;
            Result = result;
        }

    }
}