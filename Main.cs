using MaterialSkin.Controls;
using System.ComponentModel.DataAnnotations;

namespace TransportChecker
{
    public partial class Main : MaterialForm
    {
        private readonly MaterialSkin.MaterialSkinManager manager;

        public Main()
        {
            InitializeComponent();

            manager = MaterialSkin.MaterialSkinManager.Instance;
            manager.EnforceBackcolorOnAllComponents = true;
            manager.AddFormToManage(this);

            manager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            manager.ColorScheme = new MaterialSkin.ColorScheme(
                MaterialSkin.Primary.LightGreen500
                , MaterialSkin.Primary.LightGreen700
                , MaterialSkin.Primary.LightBlue200
                , MaterialSkin.Accent.DeepOrange200
                , MaterialSkin.TextShade.WHITE
                );
        }
    }
}