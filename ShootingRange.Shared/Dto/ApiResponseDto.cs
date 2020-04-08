using System.Runtime.Serialization;

namespace ShootingRange.Shared.Dto
{
    [DataContract]
    public class ApiResponseDto
    {
        [DataMember]
        public int StatusCode {get; set;}

        [DataMember]
        public string Message {get; set;}

        [DataMember(EmitDefaultValue = false)]
        public object Result {get; set;}
    }
}