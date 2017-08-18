using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyWeb.Model.Passage
{
    public class Passage
    {
        private const int UserTelNumStringLength = 13;
        private const int TitleMaxLength = 100;
        private const int DescriptionMaxLength = 500;


        [Key,Column(Order =1)]
        [StringLength(UserTelNumStringLength)]
        public string UserTelNum { get; set; }

        [Key, Column(Order = 2)]
        public long PassageId { get; set; }

        [ForeignKey("UserTelNum")]
        public virtual User.User user { get; set; }

        [MaxLength(TitleMaxLength)]
        public string Title { get; set; }

        [MaxLength(DescriptionMaxLength)]
        public string Description { get; set; }

        public string Content { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime PublishTime { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime LastEditTime { get; set; }
    }
}
