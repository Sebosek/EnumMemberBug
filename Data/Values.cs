using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Data
{
    [JsonConverter(typeof(JsonStringEnumMemberConverter))]
    public enum Values
    {
        [EnumMember(Value = "HELLO")]
        Hello,

        [EnumMember(Value = "bye")]
        Bye,

        [EnumMember(Value = "foo_bar_baz")]
        FooBarBaz
    }
}