using System.ComponentModel.DataAnnotations;

namespace Micro.GlobalConfig.Domain.Models
{
    public class GlobalConfigModel
    {
        [Key]
        public string Name { set; get; }

        public string Value { set; get; }
    }
}