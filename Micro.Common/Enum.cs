using System.ComponentModel;

namespace Micro.Common
{
    public enum PaymentType
    {
        [Description("PrePaid")]
        PrePaid = 0,

        [Description("PostPaid")]
        PostPaid = 1
    }

    public enum PaymentStatus
    {
        [Description("Pending")]
        Pending = 0,

        [Description("Success")]
        Success = 1,

        [Description("Failure")]
        Failure = 2
    }
}