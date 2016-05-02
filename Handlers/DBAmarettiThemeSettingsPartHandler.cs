using Orchard.ContentManagement;
using Orchard.ContentManagement.Handlers;
using Orchard.Localization;

namespace DBAmaretti.Handlers {
    public class DBAmarettiThemeSettingsPartHandler : ContentHandler {
        public DBAmerettiThemeSettingsPartHandler() {
            T = NullLocalizer.Instance;
            Filters.Add(new ActivatingFilter<DBAmarettiThemeSettingsPartHandler>("Site"));
            Filters.Add(new TemplateFilterForPart<DBAmerettiThemeSettingsPart>("DBAmarettiThemeSettings", "Parts/DBAmarettiThemeSettings", "Theme-DB.Ameretti"));
        }

        public Localizer T { get; set; }

        protected override void GetItemMetadata(GetContentItemMetadataContext context) {
            if (context.ContentItem.ContentType != "Site")
                return;
            base.GetItemMetadata(context);
            context.Metadata.EditorGroupInfo.Add(new GroupInfo(T("Theme-DB.Amaretti")));
        }
    }

    internal class DBAmerettiThemeSettingsPart
    {
    }
}
