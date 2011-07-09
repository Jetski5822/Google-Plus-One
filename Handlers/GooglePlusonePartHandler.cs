using JetBrains.Annotations;
using NGM.GooglePlusone.Models;
using Orchard.ContentManagement.Handlers;
using Orchard.Data;

namespace NGM.GooglePlusone.Handlers {
    [UsedImplicitly]
    public class GooglePlusonePartHandler : ContentHandler {
        public GooglePlusonePartHandler(IRepository<GooglePlusonePartRecord> repository) {
            Filters.Add(StorageFilter.For(repository));
        }
    }
}