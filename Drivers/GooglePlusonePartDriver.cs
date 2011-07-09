using NGM.GooglePlusone.Models;
using Orchard.ContentManagement;
using Orchard.ContentManagement.Drivers;

namespace NGM.GooglePlusone.Drivers {
    public class GooglePlusonePartDriver : ContentPartDriver<GooglePlusonePart> {
        protected override DriverResult Display(GooglePlusonePart part, string displayType, dynamic shapeHelper) {
            return ContentShape("Parts_Google_Plusone", () => shapeHelper.Parts_Google_Plusone(ContentPart: part));
        }

        protected override DriverResult Editor(GooglePlusonePart part, dynamic shapeHelper) {
            return ContentShape("Parts_Google_Plusone_Fields",
                                () => shapeHelper.EditorTemplate(TemplateName: "Parts.Google.Plusone.Fields", Model: part, Prefix: Prefix));
        }

        protected override DriverResult Editor(GooglePlusonePart part, IUpdateModel updater, dynamic shapeHelper) {
            updater.TryUpdateModel(part, Prefix, null, null);
            return Editor(part, shapeHelper);
        }
    }
}