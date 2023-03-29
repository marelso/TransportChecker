namespace TransportChecker
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            switchTheme = new MaterialSkin.Controls.MaterialSwitch();
            icons_list = new ImageList(components);
            tabs = new MaterialSkin.Controls.MaterialTabControl();
            tab_transaction = new TabPage();
            flowLayoutPanel1 = new FlowLayoutPanel();
            card_transaction = new MaterialSkin.Controls.MaterialCard();
            list_totalRecomendedVehicles = new MaterialSkin.Controls.MaterialListView();
            vehicleSize = new ColumnHeader();
            vehicleCount = new ColumnHeader();
            btn_selectRoutes = new MaterialSkin.Controls.MaterialButton();
            btn_reset = new MaterialSkin.Controls.MaterialButton();
            text_count = new MaterialSkin.Controls.MaterialTextBox();
            text_weight = new MaterialSkin.Controls.MaterialTextBox();
            btn_removeProduct = new MaterialSkin.Controls.MaterialButton();
            btn_insertProduct = new MaterialSkin.Controls.MaterialButton();
            text_product = new MaterialSkin.Controls.MaterialTextBox();
            list_totalProducts = new MaterialSkin.Controls.MaterialListView();
            name = new ColumnHeader();
            weight = new ColumnHeader();
            count = new ColumnHeader();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            text_companyName = new MaterialSkin.Controls.MaterialTextBox();
            fl_main = new FlowLayoutPanel();
            tab_entries = new TabPage();
            entries = new FlowLayoutPanel();
            tabs.SuspendLayout();
            tab_transaction.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            card_transaction.SuspendLayout();
            tab_entries.SuspendLayout();
            SuspendLayout();
            // 
            // switchTheme
            // 
            switchTheme.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            switchTheme.AutoSize = true;
            switchTheme.Depth = 0;
            switchTheme.Location = new Point(615, 64);
            switchTheme.Margin = new Padding(0);
            switchTheme.MouseLocation = new Point(-1, -1);
            switchTheme.MouseState = MaterialSkin.MouseState.HOVER;
            switchTheme.Name = "switchTheme";
            switchTheme.Ripple = true;
            switchTheme.Size = new Size(107, 37);
            switchTheme.TabIndex = 0;
            switchTheme.Text = "Theme";
            switchTheme.UseVisualStyleBackColor = true;
            switchTheme.CheckedChanged += switchTheme_CheckedChanged;
            // 
            // icons_list
            // 
            icons_list.ColorDepth = ColorDepth.Depth8Bit;
            icons_list.ImageStream = (ImageListStreamer)resources.GetObject("icons_list.ImageStream");
            icons_list.TransparentColor = Color.Transparent;
            icons_list.Images.SetKeyName(0, "ico_entries");
            icons_list.Images.SetKeyName(1, "ico_new_transaction");
            icons_list.Images.SetKeyName(2, "ico_toggle");
            // 
            // tabs
            // 
            tabs.Controls.Add(tab_transaction);
            tabs.Controls.Add(tab_entries);
            tabs.Depth = 0;
            tabs.ImageList = icons_list;
            tabs.Location = new Point(105, 98);
            tabs.MouseState = MaterialSkin.MouseState.HOVER;
            tabs.Multiline = true;
            tabs.Name = "tabs";
            tabs.RightToLeftLayout = true;
            tabs.SelectedIndex = 0;
            tabs.ShowToolTips = true;
            tabs.Size = new Size(724, 539);
            tabs.TabIndex = 8;
            // 
            // tab_transaction
            // 
            tab_transaction.AutoScroll = true;
            tab_transaction.Controls.Add(flowLayoutPanel1);
            tab_transaction.ImageKey = "ico_new_transaction";
            tab_transaction.Location = new Point(4, 39);
            tab_transaction.Name = "tab_transaction";
            tab_transaction.Padding = new Padding(3);
            tab_transaction.Size = new Size(716, 476);
            tab_transaction.TabIndex = 0;
            tab_transaction.Text = "New transaction";
            tab_transaction.ToolTipText = "Include new transaction";
            tab_transaction.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Controls.Add(card_transaction);
            flowLayoutPanel1.Controls.Add(fl_main);
            flowLayoutPanel1.Location = new Point(44, 6);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(631, 1200);
            flowLayoutPanel1.TabIndex = 5;
            // 
            // card_transaction
            // 
            card_transaction.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            card_transaction.BackColor = Color.FromArgb(255, 255, 255);
            card_transaction.Controls.Add(list_totalRecomendedVehicles);
            card_transaction.Controls.Add(btn_selectRoutes);
            card_transaction.Controls.Add(btn_reset);
            card_transaction.Controls.Add(text_count);
            card_transaction.Controls.Add(text_weight);
            card_transaction.Controls.Add(btn_removeProduct);
            card_transaction.Controls.Add(btn_insertProduct);
            card_transaction.Controls.Add(text_product);
            card_transaction.Controls.Add(list_totalProducts);
            card_transaction.Controls.Add(materialLabel1);
            card_transaction.Controls.Add(text_companyName);
            card_transaction.Depth = 0;
            card_transaction.ForeColor = Color.FromArgb(222, 0, 0, 0);
            card_transaction.Location = new Point(14, 14);
            card_transaction.Margin = new Padding(14);
            card_transaction.MouseState = MaterialSkin.MouseState.HOVER;
            card_transaction.Name = "card_transaction";
            card_transaction.Padding = new Padding(14);
            card_transaction.Size = new Size(550, 322);
            card_transaction.TabIndex = 3;
            // 
            // list_totalRecomendedVehicles
            // 
            list_totalRecomendedVehicles.AutoSizeTable = false;
            list_totalRecomendedVehicles.BackColor = Color.FromArgb(255, 255, 255);
            list_totalRecomendedVehicles.BorderStyle = BorderStyle.None;
            list_totalRecomendedVehicles.Columns.AddRange(new ColumnHeader[] { vehicleSize, vehicleCount });
            list_totalRecomendedVehicles.Depth = 0;
            list_totalRecomendedVehicles.FullRowSelect = true;
            list_totalRecomendedVehicles.Location = new Point(323, 158);
            list_totalRecomendedVehicles.MinimumSize = new Size(200, 100);
            list_totalRecomendedVehicles.MouseLocation = new Point(-1, -1);
            list_totalRecomendedVehicles.MouseState = MaterialSkin.MouseState.OUT;
            list_totalRecomendedVehicles.Name = "list_totalRecomendedVehicles";
            list_totalRecomendedVehicles.OwnerDraw = true;
            list_totalRecomendedVehicles.Size = new Size(200, 100);
            list_totalRecomendedVehicles.TabIndex = 12;
            list_totalRecomendedVehicles.Tag = "Product";
            list_totalRecomendedVehicles.UseCompatibleStateImageBehavior = false;
            list_totalRecomendedVehicles.View = View.Details;
            // 
            // vehicleSize
            // 
            vehicleSize.Text = "Vehicle size";
            vehicleSize.Width = 120;
            // 
            // vehicleCount
            // 
            vehicleCount.Text = "Count";
            vehicleCount.TextAlign = HorizontalAlignment.Center;
            vehicleCount.Width = 75;
            // 
            // btn_selectRoutes
            // 
            btn_selectRoutes.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_selectRoutes.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btn_selectRoutes.Depth = 0;
            btn_selectRoutes.Enabled = false;
            btn_selectRoutes.HighEmphasis = true;
            btn_selectRoutes.Icon = null;
            btn_selectRoutes.Location = new Point(249, 267);
            btn_selectRoutes.Margin = new Padding(4, 6, 4, 6);
            btn_selectRoutes.MouseState = MaterialSkin.MouseState.HOVER;
            btn_selectRoutes.Name = "btn_selectRoutes";
            btn_selectRoutes.NoAccentTextColor = Color.Empty;
            btn_selectRoutes.Size = new Size(132, 36);
            btn_selectRoutes.TabIndex = 11;
            btn_selectRoutes.Text = "Select routes";
            btn_selectRoutes.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btn_selectRoutes.UseAccentColor = false;
            btn_selectRoutes.UseVisualStyleBackColor = true;
            btn_selectRoutes.Click += btnSelectRoutesClick;
            // 
            // btn_reset
            // 
            btn_reset.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_reset.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btn_reset.Depth = 0;
            btn_reset.HighEmphasis = true;
            btn_reset.Icon = null;
            btn_reset.Location = new Point(176, 267);
            btn_reset.Margin = new Padding(4, 6, 4, 6);
            btn_reset.MouseState = MaterialSkin.MouseState.HOVER;
            btn_reset.Name = "btn_reset";
            btn_reset.NoAccentTextColor = Color.Empty;
            btn_reset.Size = new Size(65, 36);
            btn_reset.TabIndex = 10;
            btn_reset.Text = "Reset";
            btn_reset.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btn_reset.UseAccentColor = false;
            btn_reset.UseVisualStyleBackColor = true;
            btn_reset.Click += btnResetClick;
            // 
            // text_count
            // 
            text_count.AnimateReadOnly = false;
            text_count.BorderStyle = BorderStyle.None;
            text_count.Depth = 0;
            text_count.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            text_count.Hint = "Count";
            text_count.LeadingIcon = null;
            text_count.Location = new Point(285, 102);
            text_count.MaxLength = 50;
            text_count.MouseState = MaterialSkin.MouseState.OUT;
            text_count.Multiline = false;
            text_count.Name = "text_count";
            text_count.Size = new Size(80, 50);
            text_count.TabIndex = 9;
            text_count.Text = "";
            text_count.TrailingIcon = null;
            text_count.TextChanged += productTextChanged;
            // 
            // text_weight
            // 
            text_weight.AnimateReadOnly = false;
            text_weight.BorderStyle = BorderStyle.None;
            text_weight.Depth = 0;
            text_weight.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            text_weight.Hint = "Weight";
            text_weight.LeadingIcon = null;
            text_weight.Location = new Point(199, 102);
            text_weight.MaxLength = 50;
            text_weight.MouseState = MaterialSkin.MouseState.OUT;
            text_weight.Multiline = false;
            text_weight.Name = "text_weight";
            text_weight.Size = new Size(80, 50);
            text_weight.TabIndex = 8;
            text_weight.Text = "";
            text_weight.TrailingIcon = null;
            text_weight.TextChanged += productTextChanged;
            // 
            // btn_removeProduct
            // 
            btn_removeProduct.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_removeProduct.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btn_removeProduct.Depth = 0;
            btn_removeProduct.Enabled = false;
            btn_removeProduct.HighEmphasis = true;
            btn_removeProduct.Icon = null;
            btn_removeProduct.Location = new Point(443, 109);
            btn_removeProduct.Margin = new Padding(4, 6, 4, 6);
            btn_removeProduct.MouseState = MaterialSkin.MouseState.HOVER;
            btn_removeProduct.Name = "btn_removeProduct";
            btn_removeProduct.NoAccentTextColor = Color.Empty;
            btn_removeProduct.Size = new Size(80, 36);
            btn_removeProduct.TabIndex = 7;
            btn_removeProduct.Text = "Remove";
            btn_removeProduct.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btn_removeProduct.UseAccentColor = false;
            btn_removeProduct.UseVisualStyleBackColor = true;
            btn_removeProduct.Click += btnRemoveProductClick;
            // 
            // btn_insertProduct
            // 
            btn_insertProduct.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_insertProduct.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btn_insertProduct.Depth = 0;
            btn_insertProduct.Enabled = false;
            btn_insertProduct.HighEmphasis = true;
            btn_insertProduct.Icon = null;
            btn_insertProduct.Location = new Point(372, 109);
            btn_insertProduct.Margin = new Padding(4, 6, 4, 6);
            btn_insertProduct.MouseState = MaterialSkin.MouseState.HOVER;
            btn_insertProduct.Name = "btn_insertProduct";
            btn_insertProduct.NoAccentTextColor = Color.Empty;
            btn_insertProduct.Size = new Size(64, 36);
            btn_insertProduct.TabIndex = 6;
            btn_insertProduct.Text = "Add";
            btn_insertProduct.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btn_insertProduct.UseAccentColor = false;
            btn_insertProduct.UseVisualStyleBackColor = true;
            btn_insertProduct.Click += btnInsertProductClick;
            // 
            // text_product
            // 
            text_product.AnimateReadOnly = false;
            text_product.BorderStyle = BorderStyle.None;
            text_product.Depth = 0;
            text_product.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            text_product.Hint = "Product";
            text_product.LeadingIcon = null;
            text_product.Location = new Point(17, 102);
            text_product.MaxLength = 50;
            text_product.MouseState = MaterialSkin.MouseState.OUT;
            text_product.Multiline = false;
            text_product.Name = "text_product";
            text_product.Size = new Size(176, 50);
            text_product.TabIndex = 5;
            text_product.Text = "";
            text_product.TrailingIcon = null;
            text_product.TextChanged += productTextChanged;
            // 
            // list_totalProducts
            // 
            list_totalProducts.AutoSizeTable = false;
            list_totalProducts.BackColor = Color.FromArgb(255, 255, 255);
            list_totalProducts.BorderStyle = BorderStyle.None;
            list_totalProducts.Columns.AddRange(new ColumnHeader[] { name, weight, count });
            list_totalProducts.Depth = 0;
            list_totalProducts.FullRowSelect = true;
            list_totalProducts.Location = new Point(17, 158);
            list_totalProducts.MinimumSize = new Size(200, 100);
            list_totalProducts.MouseLocation = new Point(-1, -1);
            list_totalProducts.MouseState = MaterialSkin.MouseState.OUT;
            list_totalProducts.Name = "list_totalProducts";
            list_totalProducts.OwnerDraw = true;
            list_totalProducts.Size = new Size(262, 100);
            list_totalProducts.TabIndex = 4;
            list_totalProducts.Tag = "Product";
            list_totalProducts.UseCompatibleStateImageBehavior = false;
            list_totalProducts.View = View.Details;
            // 
            // name
            // 
            name.Text = "Name";
            name.Width = 95;
            // 
            // weight
            // 
            weight.Text = "Weight";
            weight.TextAlign = HorizontalAlignment.Center;
            weight.Width = 78;
            // 
            // count
            // 
            count.Text = "Count";
            count.TextAlign = HorizontalAlignment.Right;
            count.Width = 70;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(17, 14);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(116, 19);
            materialLabel1.TabIndex = 3;
            materialLabel1.Text = "New transaction";
            // 
            // text_companyName
            // 
            text_companyName.AnimateReadOnly = false;
            text_companyName.BorderStyle = BorderStyle.None;
            text_companyName.Depth = 0;
            text_companyName.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            text_companyName.Hint = "Company name";
            text_companyName.LeadingIcon = null;
            text_companyName.Location = new Point(17, 46);
            text_companyName.MaxLength = 50;
            text_companyName.MouseState = MaterialSkin.MouseState.OUT;
            text_companyName.Multiline = false;
            text_companyName.Name = "text_companyName";
            text_companyName.Size = new Size(262, 50);
            text_companyName.TabIndex = 2;
            text_companyName.Text = "";
            text_companyName.TrailingIcon = null;
            // 
            // fl_main
            // 
            fl_main.AutoScroll = true;
            fl_main.Location = new Point(20, 353);
            fl_main.Margin = new Padding(20, 3, 3, 3);
            fl_main.Name = "fl_main";
            fl_main.Size = new Size(601, 450);
            fl_main.TabIndex = 9;
            fl_main.WrapContents = false;
            // 
            // tab_entries
            // 
            tab_entries.Controls.Add(entries);
            tab_entries.ImageKey = "ico_entries";
            tab_entries.Location = new Point(4, 39);
            tab_entries.Name = "tab_entries";
            tab_entries.Padding = new Padding(3);
            tab_entries.Size = new Size(716, 496);
            tab_entries.TabIndex = 1;
            tab_entries.Text = "Entries";
            tab_entries.ToolTipText = "See all entries";
            tab_entries.UseVisualStyleBackColor = true;
            // 
            // entries
            // 
            entries.AutoScroll = true;
            entries.Location = new Point(19, 5);
            entries.Margin = new Padding(3, 2, 3, 2);
            entries.Name = "entries";
            entries.Size = new Size(675, 475);
            entries.TabIndex = 0;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(933, 661);
            Controls.Add(tabs);
            Controls.Add(switchTheme);
            DrawerTabControl = tabs;
            Name = "Main";
            Sizable = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Transport checker";
            tabs.ResumeLayout(false);
            tab_transaction.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            card_transaction.ResumeLayout(false);
            card_transaction.PerformLayout();
            tab_entries.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialSwitch switchTheme;
        private MaterialSkin.Controls.MaterialListView list_weight;
        private ImageList icons_list;
        private MaterialSkin.Controls.MaterialTabControl tabs;
        private TabPage tab_transaction;
        private MaterialSkin.Controls.MaterialCard card_transaction;
        private MaterialSkin.Controls.MaterialButton btn_selectRoutes;
        private MaterialSkin.Controls.MaterialButton btn_reset;
        private MaterialSkin.Controls.MaterialTextBox text_count;
        private MaterialSkin.Controls.MaterialTextBox text_weight;
        private MaterialSkin.Controls.MaterialButton btn_removeProduct;
        private MaterialSkin.Controls.MaterialButton btn_insertProduct;
        private MaterialSkin.Controls.MaterialTextBox text_product;
        private MaterialSkin.Controls.MaterialListView list_totalProducts;
        private ColumnHeader name;
        private ColumnHeader weight;
        private ColumnHeader count;
        public MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox text_companyName;
        private TabPage tab_entries;
        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel fl_main;
        private MaterialSkin.Controls.MaterialListView list_totalRecomendedVehicles;
        private ColumnHeader vehicleSize;
        private ColumnHeader vehicleCount;
        private FlowLayoutPanel entries;
    }
}