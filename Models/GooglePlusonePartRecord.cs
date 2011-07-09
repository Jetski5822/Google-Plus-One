using Orchard.ContentManagement.Records;

namespace NGM.GooglePlusone.Models {
    public class GooglePlusonePartRecord : ContentPartRecord {
        public virtual bool IncludeCount { get; set; }
        public virtual string Parse { get; set; }
        public virtual string JsCallbackFunction { get; set; }
        public virtual string UrlToPlusone { get; set; }
        public virtual string Size { get; set; }
    }
}