namespace BrokerSite.Data.Models
{
    using BrokerSite.Data.Common.Models;

    public class SellProperty : BaseDeletableModel<string>
    {
        public string Name { get; set; }

        public string PictureProperty { get; set; }

        public string Location { get; set; }

        public string Details { get; set; }

        public string Type { get; set; }

        public string UserId { get; set; }

        public virtual ApplicationUser User { get; set; }
    }
}
