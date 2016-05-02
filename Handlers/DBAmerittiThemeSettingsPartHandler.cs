using Orchard.ContentManagement;
using Orchard.ContentManagement.Handlers;
using Orchard.Localization;

namespace DBAmeretti.Handlers {
    public class DBAmerettiThemeSettingsPartHandler : ContentHandler {
        public DBAmerettiThemeSettingsPartHandler() {
            T = NullLocalizer.Instance;
            Filters.Add(new ActivatingFilter<DBAmerettiThemeSettingsPartHandler>("Site"));
            Filters.Add(new TemplateFilterForPart<DBAmerettiThemeSettingsPart>("DBAmerettiThemeSettings", "Parts/DBAmerettiThemeSettings", "Theme-DB.Ameretti"));
        }

        public Localizer T { get; set; }

        protected override void GetItemMetadata(GetContentItemMetadataContext context) {
            if (context.ContentItem.ContentType != "Site")
                return;
            base.GetItemMetadata(context);
            context.Metadata.EditorGroupInfo.Add(new GroupInfo(T("Theme-DB.Ameretti")));
        }
    }

    internal class DBAmerettiThemeSettingsPart
    {
    }
}