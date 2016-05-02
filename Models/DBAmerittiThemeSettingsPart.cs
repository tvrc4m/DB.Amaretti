using Orchard.ContentManagement;

namespace DBAmaretti.Models {
    public class DBAmarettiThemeSettingsPart : ContentPart {
        public string Swatch {
            get { return this.Retrieve(r => r.Swatch, "default"); }
            set { this.Store(r => r.Swatch, value); }
        }        
        public bool UseStickyFooter {
            get { return this.Retrieve(r => r.UseStickyFooter, false); }
            set { this.Store(r => r.UseStickyFooter, value); }
        }
    }
}