using Orchard.ContentManagement;

namespace NGM.GooglePlusone.Models {
    public class GooglePlusonePart : ContentPart<GooglePlusonePartRecord> {
        public bool IncludeCount {
            get { return Record.IncludeCount; }
            set { Record.IncludeCount = value; }
        }

        public string Parse {
            get { return Record.Parse; }
            set { Record.Parse = value; }
        }

        public string JsCallbackFunction {
            get { return Record.JsCallbackFunction; }
            set { Record.JsCallbackFunction = value; }
        }

        public string UrlToPlusone {
            get { return Record.UrlToPlusone; }
            set { Record.UrlToPlusone = value; }
        }

        public string Size {
            get { return Record.Size; }
            set { Record.Size = value; }
        }
    }
}