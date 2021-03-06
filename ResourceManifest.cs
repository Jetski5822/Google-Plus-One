using System.Globalization;
using Orchard;
using Orchard.UI.Resources;

namespace NGM.GooglePlusone {
    public class ResourceManifest : IResourceManifestProvider {
        private readonly IWorkContextAccessor _workContextAccessor;

        public ResourceManifest(IWorkContextAccessor workContextAccessor) {
            _workContextAccessor = workContextAccessor;
        }

        public void BuildManifests(ResourceManifestBuilder builder) {
            var manifest = builder.Add();
            RegisterLocalizedVersionOfJavascriptFiles(manifest);
        }

        private void RegisterLocalizedVersionOfJavascriptFiles(Orchard.UI.Resources.ResourceManifest manifest) {
            string currentCultureName = _workContextAccessor.GetContext().CurrentSite.SiteCulture;

            if (string.IsNullOrEmpty(currentCultureName)) {
                RegisterDefaultLocalizedVersionOfJavascriptFiles(manifest);
            } else {
                try {
                    var ci = new CultureInfo(currentCultureName);
                    // Until I can het the culture stuff plugged in.
                    RegisterDefaultLocalizedVersionOfJavascriptFiles(manifest);
                } catch (CultureNotFoundException) {
                    RegisterDefaultLocalizedVersionOfJavascriptFiles(manifest);
                }
            }
        }

        private static void RegisterDefaultLocalizedVersionOfJavascriptFiles(Orchard.UI.Resources.ResourceManifest manifest) {
            manifest.DefineScript("GooglePlusone").SetUrl("https://apis.google.com/js/plusone.js").SetVersion("0.0.1");
        }
    }
}