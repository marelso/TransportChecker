using MaterialSkin.Controls;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;

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

        private void switchTheme_CheckedChanged(object sender, EventArgs e)
        {
            manager.Theme = switchTheme.Checked
                ? MaterialSkin.MaterialSkinManager.Themes.DARK
                : MaterialSkin.MaterialSkinManager.Themes.LIGHT;
        }

        private void btn_add_card_Click(object sender, EventArgs e)
        {
            MaterialCard card = new MaterialCard();
            card.Width = card_first.Width;
            card.Height = card_first.Height;
        }

        private void txt_product_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_weight.Text)
                && !string.IsNullOrEmpty(txt_product.Text)
                && !string.IsNullOrEmpty(txt_count.Text))
            {
                btn_add_item.Enabled = true;
            }
            else
            {
                btn_add_item.Enabled = false;
            }
        }

        private void txt_weight_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_weight.Text)
                && !string.IsNullOrEmpty(txt_product.Text)
                && !string.IsNullOrEmpty(txt_count.Text))
            {
                btn_add_item.Enabled = true;
            }
            else
            {
                btn_add_item.Enabled = false;
            }
        }

        private void btn_add_item_Click(object sender, EventArgs e)
        {
            double weight;
            bool isWeightDouble = Double.TryParse(txt_weight.Text, out weight);

            int count;
            bool isCountInteger = int.TryParse(txt_count.Text, out count);

            if (isWeightDouble && isCountInteger)
            {
                string[] row = { txt_product.Text, txt_weight.Text, txt_count.Text };

                var item = new ListViewItem(row);
                list_product.Items.Add(item);
            }
            else
            {
                MessageBox.Show("The weight should be an number.", "Error:");
            }
        }

        private void txt_count_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_weight.Text)
                && !string.IsNullOrEmpty(txt_product.Text)
                && !string.IsNullOrEmpty(txt_count.Text))
            {
                btn_add_item.Enabled = true;
            }
            else
            {
                btn_add_item.Enabled = false;
            }
        }
    }
}