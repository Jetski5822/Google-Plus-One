using NGM.GooglePlusone.Models;
using Orchard.ContentManagement.MetaData;
using Orchard.Core.Contents.Extensions;
using Orchard.Data.Migration;

namespace NGM.GooglePlusone {
    public class Migrations : DataMigrationImpl {
        public int Create() {
            SchemaBuilder.CreateTable("GooglePlusonePartRecord",
                                      table => table
                                                   .ContentPartRecord()
                                                   .Column<bool>("IncludeCount")
                                                   .Column<string>("Parse")
                                                   .Column<string>("JsCallbackFunction")
                                                   .Column<string>("UrlToPlusone")
                                                   .Column<string>("Size")
                );

            ContentDefinitionManager.AlterPartDefinition(typeof(GooglePlusonePart).Name, cfg => cfg.Attachable());

            ContentDefinitionManager.AlterTypeDefinition("GooglePlusoneWidget", cfg => cfg
                                                                                           .WithPart("GooglePlusonePart")
                                                                                           .WithPart("WidgetPart")
                                                                                           .WithPart("CommonPart")
                                                                                           .WithSetting("Stereotype", "Widget"));
            return 1;
        }
    }
}