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
            switchTheme = new MaterialSkin.Controls.MaterialSwitch();
            fl_main = new FlowLayoutPanel();
            card_first = new MaterialSkin.Controls.MaterialCard();
            txt_count = new MaterialSkin.Controls.MaterialTextBox();
            list_product = new MaterialSkin.Controls.MaterialListView();
            Product = new ColumnHeader();
            Weight = new ColumnHeader();
            Count = new ColumnHeader();
            btn_add_item = new MaterialSkin.Controls.MaterialButton();
            lbl_distance = new MaterialSkin.Controls.MaterialLabel();
            lbl_distance_field = new MaterialSkin.Controls.MaterialLabel();
            txt_weight = new MaterialSkin.Controls.MaterialTextBox();
            txt_product = new MaterialSkin.Controls.MaterialTextBox();
            btn_add_card = new MaterialSkin.Controls.MaterialFloatingActionButton();
            lbl_total_cost = new MaterialSkin.Controls.MaterialMaskedTextBox();
            cb_vehicles = new MaterialSkin.Controls.MaterialComboBox();
            btn_search = new MaterialSkin.Controls.MaterialButton();
            cb_destination = new MaterialSkin.Controls.MaterialComboBox();
            cb_origin = new MaterialSkin.Controls.MaterialComboBox();
            materialExpansionPanel1 = new MaterialSkin.Controls.MaterialExpansionPanel();
            fl_main.SuspendLayout();
            card_first.SuspendLayout();
            SuspendLayout();
            // 
            // switchTheme
            // 
            switchTheme.AutoSize = true;
            switchTheme.Depth = 0;
            switchTheme.Location = new Point(469, 73);
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
            // fl_main
            // 
            fl_main.AutoScroll = true;
            fl_main.Controls.Add(card_first);
            fl_main.Location = new Point(61, 104);
            fl_main.Name = "fl_main";
            fl_main.Size = new Size(531, 445);
            fl_main.TabIndex = 1;
            // 
            // card_first
            // 
            card_first.BackColor = Color.FromArgb(255, 255, 255);
            card_first.Controls.Add(txt_count);
            card_first.Controls.Add(list_product);
            card_first.Controls.Add(btn_add_item);
            card_first.Controls.Add(lbl_distance);
            card_first.Controls.Add(lbl_distance_field);
            card_first.Controls.Add(txt_weight);
            card_first.Controls.Add(txt_product);
            card_first.Controls.Add(btn_add_card);
            card_first.Controls.Add(lbl_total_cost);
            card_first.Controls.Add(cb_vehicles);
            card_first.Controls.Add(btn_search);
            card_first.Controls.Add(cb_destination);
            card_first.Controls.Add(cb_origin);
            card_first.Depth = 0;
            card_first.ForeColor = Color.FromArgb(222, 0, 0, 0);
            card_first.Location = new Point(15, 15);
            card_first.Margin = new Padding(15);
            card_first.MouseState = MaterialSkin.MouseState.HOVER;
            card_first.Name = "card_first";
            card_first.Padding = new Padding(14);
            card_first.Size = new Size(500, 280);
            card_first.TabIndex = 0;
            // 
            // txt_count
            // 
            txt_count.AnimateReadOnly = false;
            txt_count.BorderStyle = BorderStyle.None;
            txt_count.Depth = 0;
            txt_count.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txt_count.Hint = "Count";
            txt_count.LeadingIcon = null;
            txt_count.Location = new Point(317, 146);
            txt_count.MaxLength = 50;
            txt_count.MouseState = MaterialSkin.MouseState.OUT;
            txt_count.Multiline = false;
            txt_count.Name = "txt_count";
            txt_count.Size = new Size(86, 50);
            txt_count.TabIndex = 15;
            txt_count.Text = "";
            txt_count.TrailingIcon = null;
            txt_count.TextChanged += txt_count_TextChanged;
            // 
            // list_product
            // 
            list_product.AutoSizeTable = false;
            list_product.BackColor = Color.FromArgb(255, 255, 255);
            list_product.BorderStyle = BorderStyle.None;
            list_product.Columns.AddRange(new ColumnHeader[] { Product, Weight, Count });
            list_product.Depth = 0;
            list_product.FullRowSelect = true;
            list_product.Location = new Point(17, 202);
            list_product.MinimumSize = new Size(200, 100);
            list_product.MouseLocation = new Point(-1, -1);
            list_product.MouseState = MaterialSkin.MouseState.OUT;
            list_product.Name = "list_product";
            list_product.OwnerDraw = true;
            list_product.Size = new Size(229, 100);
            list_product.TabIndex = 14;
            list_product.UseCompatibleStateImageBehavior = false;
            list_product.View = View.Details;
            // 
            // Product
            // 
            Product.Text = "Products";
            Product.Width = 85;
            // 
            // Weight
            // 
            Weight.Text = "Weight";
            Weight.TextAlign = HorizontalAlignment.Center;
            Weight.Width = 80;
            // 
            // Count
            // 
            Count.Text = "Count";
            Count.Width = 75;
            // 
            // btn_add_item
            // 
            btn_add_item.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_add_item.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btn_add_item.Depth = 0;
            btn_add_item.Enabled = false;
            btn_add_item.HighEmphasis = true;
            btn_add_item.Icon = null;
            btn_add_item.Location = new Point(418, 155);
            btn_add_item.Margin = new Padding(4, 6, 4, 6);
            btn_add_item.MouseState = MaterialSkin.MouseState.HOVER;
            btn_add_item.Name = "btn_add_item";
            btn_add_item.NoAccentTextColor = Color.Empty;
            btn_add_item.Size = new Size(64, 36);
            btn_add_item.TabIndex = 13;
            btn_add_item.Text = "Add";
            btn_add_item.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btn_add_item.UseAccentColor = false;
            btn_add_item.UseVisualStyleBackColor = true;
            btn_add_item.Click += btn_add_item_Click;
            // 
            // lbl_distance
            // 
            lbl_distance.AutoSize = true;
            lbl_distance.Depth = 0;
            lbl_distance.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lbl_distance.Location = new Point(90, 14);
            lbl_distance.MouseState = MaterialSkin.MouseState.HOVER;
            lbl_distance.Name = "lbl_distance";
            lbl_distance.Size = new Size(47, 19);
            lbl_distance.TabIndex = 12;
            lbl_distance.Text = "xxxkm";
            // 
            // lbl_distance_field
            // 
            lbl_distance_field.AutoSize = true;
            lbl_distance_field.Depth = 0;
            lbl_distance_field.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lbl_distance_field.Location = new Point(17, 14);
            lbl_distance_field.MouseState = MaterialSkin.MouseState.HOVER;
            lbl_distance_field.Name = "lbl_distance_field";
            lbl_distance_field.Size = new Size(67, 19);
            lbl_distance_field.TabIndex = 11;
            lbl_distance_field.Text = "Distance:";
            // 
            // txt_weight
            // 
            txt_weight.AnimateReadOnly = false;
            txt_weight.BorderStyle = BorderStyle.None;
            txt_weight.Depth = 0;
            txt_weight.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txt_weight.Hint = "Weight";
            txt_weight.LeadingIcon = null;
            txt_weight.Location = new Point(223, 146);
            txt_weight.MaxLength = 50;
            txt_weight.MouseState = MaterialSkin.MouseState.OUT;
            txt_weight.Multiline = false;
            txt_weight.Name = "txt_weight";
            txt_weight.Size = new Size(86, 50);
            txt_weight.TabIndex = 10;
            txt_weight.Text = "";
            txt_weight.TrailingIcon = null;
            txt_weight.TextChanged += txt_weight_TextChanged;
            // 
            // txt_product
            // 
            txt_product.AnimateReadOnly = false;
            txt_product.BorderStyle = BorderStyle.None;
            txt_product.Depth = 0;
            txt_product.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txt_product.Hint = "Product";
            txt_product.LeadingIcon = null;
            txt_product.Location = new Point(17, 146);
            txt_product.MaxLength = 50;
            txt_product.MouseState = MaterialSkin.MouseState.OUT;
            txt_product.Multiline = false;
            txt_product.Name = "txt_product";
            txt_product.Size = new Size(200, 50);
            txt_product.TabIndex = 9;
            txt_product.Text = "";
            txt_product.TrailingIcon = null;
            txt_product.TextChanged += txt_product_TextChanged;
            // 
            // btn_add_card
            // 
            btn_add_card.Depth = 0;
            btn_add_card.Icon = null;
            btn_add_card.Location = new Point(429, 223);
            btn_add_card.Mini = true;
            btn_add_card.MouseState = MaterialSkin.MouseState.HOVER;
            btn_add_card.Name = "btn_add_card";
            btn_add_card.Size = new Size(40, 40);
            btn_add_card.TabIndex = 8;
            btn_add_card.Text = "+";
            btn_add_card.UseVisualStyleBackColor = false;
            btn_add_card.Click += btn_add_card_Click;
            // 
            // lbl_total_cost
            // 
            lbl_total_cost.AllowPromptAsInput = true;
            lbl_total_cost.AnimateReadOnly = false;
            lbl_total_cost.AsciiOnly = false;
            lbl_total_cost.BackgroundImageLayout = ImageLayout.None;
            lbl_total_cost.BeepOnError = false;
            lbl_total_cost.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            lbl_total_cost.Depth = 0;
            lbl_total_cost.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            lbl_total_cost.HidePromptOnLeave = false;
            lbl_total_cost.HideSelection = true;
            lbl_total_cost.Hint = "xxx.xx";
            lbl_total_cost.InsertKeyMode = InsertKeyMode.Default;
            lbl_total_cost.LeadingIcon = null;
            lbl_total_cost.Location = new Point(223, 92);
            lbl_total_cost.Mask = "";
            lbl_total_cost.MaxLength = 32767;
            lbl_total_cost.MouseState = MaterialSkin.MouseState.OUT;
            lbl_total_cost.Name = "lbl_total_cost";
            lbl_total_cost.PasswordChar = '\0';
            lbl_total_cost.PrefixSuffix = MaterialSkin.Controls.MaterialMaskedTextBox.PrefixSuffixTypes.Prefix;
            lbl_total_cost.PrefixSuffixText = "R$";
            lbl_total_cost.PromptChar = '_';
            lbl_total_cost.ReadOnly = true;
            lbl_total_cost.RejectInputOnFirstFailure = false;
            lbl_total_cost.ResetOnPrompt = true;
            lbl_total_cost.ResetOnSpace = true;
            lbl_total_cost.RightToLeft = RightToLeft.No;
            lbl_total_cost.SelectedText = "";
            lbl_total_cost.SelectionLength = 0;
            lbl_total_cost.SelectionStart = 0;
            lbl_total_cost.ShortcutsEnabled = true;
            lbl_total_cost.Size = new Size(180, 48);
            lbl_total_cost.SkipLiterals = true;
            lbl_total_cost.TabIndex = 7;
            lbl_total_cost.TabStop = false;
            lbl_total_cost.TextAlign = HorizontalAlignment.Right;
            lbl_total_cost.TextMaskFormat = MaskFormat.IncludeLiterals;
            lbl_total_cost.TrailingIcon = null;
            lbl_total_cost.UseSystemPasswordChar = false;
            lbl_total_cost.ValidatingType = null;
            // 
            // cb_vehicles
            // 
            cb_vehicles.AutoResize = false;
            cb_vehicles.BackColor = Color.FromArgb(255, 255, 255);
            cb_vehicles.Depth = 0;
            cb_vehicles.DrawMode = DrawMode.OwnerDrawVariable;
            cb_vehicles.DropDownHeight = 174;
            cb_vehicles.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_vehicles.DropDownWidth = 121;
            cb_vehicles.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cb_vehicles.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cb_vehicles.FormattingEnabled = true;
            cb_vehicles.Hint = "Vehicle type";
            cb_vehicles.IntegralHeight = false;
            cb_vehicles.ItemHeight = 43;
            cb_vehicles.Location = new Point(17, 91);
            cb_vehicles.MaxDropDownItems = 4;
            cb_vehicles.MouseState = MaterialSkin.MouseState.OUT;
            cb_vehicles.Name = "cb_vehicles";
            cb_vehicles.Size = new Size(200, 49);
            cb_vehicles.StartIndex = 0;
            cb_vehicles.TabIndex = 3;
            // 
            // btn_search
            // 
            btn_search.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_search.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btn_search.Depth = 0;
            btn_search.HighEmphasis = true;
            btn_search.Icon = null;
            btn_search.Location = new Point(410, 97);
            btn_search.Margin = new Padding(4, 6, 4, 6);
            btn_search.MouseState = MaterialSkin.MouseState.HOVER;
            btn_search.Name = "btn_search";
            btn_search.NoAccentTextColor = Color.Empty;
            btn_search.Size = new Size(78, 36);
            btn_search.TabIndex = 2;
            btn_search.Text = "Search";
            btn_search.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btn_search.UseAccentColor = false;
            btn_search.UseVisualStyleBackColor = true;
            // 
            // cb_destination
            // 
            cb_destination.AutoResize = false;
            cb_destination.BackColor = Color.FromArgb(255, 255, 255);
            cb_destination.Depth = 0;
            cb_destination.DrawMode = DrawMode.OwnerDrawVariable;
            cb_destination.DropDownHeight = 174;
            cb_destination.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_destination.DropDownWidth = 121;
            cb_destination.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cb_destination.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cb_destination.FormattingEnabled = true;
            cb_destination.Hint = "Destination";
            cb_destination.IntegralHeight = false;
            cb_destination.ItemHeight = 43;
            cb_destination.Location = new Point(223, 36);
            cb_destination.MaxDropDownItems = 4;
            cb_destination.MouseState = MaterialSkin.MouseState.OUT;
            cb_destination.Name = "cb_destination";
            cb_destination.Size = new Size(180, 49);
            cb_destination.StartIndex = 0;
            cb_destination.TabIndex = 1;
            cb_destination.Click += cb_destination_Click;
            // 
            // cb_origin
            // 
            cb_origin.AutoResize = false;
            cb_origin.BackColor = Color.FromArgb(255, 255, 255);
            cb_origin.Depth = 0;
            cb_origin.DrawMode = DrawMode.OwnerDrawVariable;
            cb_origin.DropDownHeight = 174;
            cb_origin.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_origin.DropDownWidth = 121;
            cb_origin.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cb_origin.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cb_origin.FormattingEnabled = true;
            cb_origin.Hint = "Origin";
            cb_origin.IntegralHeight = false;
            cb_origin.ItemHeight = 43;
            cb_origin.Location = new Point(17, 36);
            cb_origin.MaxDropDownItems = 4;
            cb_origin.MouseState = MaterialSkin.MouseState.OUT;
            cb_origin.Name = "cb_origin";
            cb_origin.Size = new Size(200, 49);
            cb_origin.StartIndex = 0;
            cb_origin.TabIndex = 0;
            cb_origin.Click += cb_origin_Click;
            // 
            // materialExpansionPanel1
            // 
            materialExpansionPanel1.BackColor = Color.FromArgb(255, 255, 255);
            materialExpansionPanel1.Collapse = true;
            materialExpansionPanel1.Depth = 0;
            materialExpansionPanel1.ExpandHeight = 200;
            materialExpansionPanel1.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialExpansionPanel1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialExpansionPanel1.Location = new Point(61, 568);
            materialExpansionPanel1.Margin = new Padding(16, 1, 16, 0);
            materialExpansionPanel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialExpansionPanel1.Name = "materialExpansionPanel1";
            materialExpansionPanel1.Padding = new Padding(24, 64, 24, 16);
            materialExpansionPanel1.Size = new Size(531, 48);
            materialExpansionPanel1.TabIndex = 2;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(650, 700);
            Controls.Add(switchTheme);
            Controls.Add(materialExpansionPanel1);
            Controls.Add(fl_main);
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Transport checker";
            fl_main.ResumeLayout(false);
            card_first.ResumeLayout(false);
            card_first.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialSwitch switchTheme;
        private FlowLayoutPanel fl_main;
        private MaterialSkin.Controls.MaterialCard card_first;
        private MaterialSkin.Controls.MaterialButton btn_search;
        private MaterialSkin.Controls.MaterialComboBox cb_destination;
        private MaterialSkin.Controls.MaterialComboBox cb_origin;
        private MaterialSkin.Controls.MaterialComboBox cb_vehicles;
        private MaterialSkin.Controls.MaterialMaskedTextBox lbl_total_cost;
        private MaterialSkin.Controls.MaterialFloatingActionButton btn_add_card;
        private MaterialSkin.Controls.MaterialButton btn_add_item;
        private MaterialSkin.Controls.MaterialLabel lbl_distance;
        private MaterialSkin.Controls.MaterialLabel lbl_distance_field;
        private MaterialSkin.Controls.MaterialTextBox txt_weight;
        private MaterialSkin.Controls.MaterialTextBox txt_product;
        private MaterialSkin.Controls.MaterialListView list_weight;
        private MaterialSkin.Controls.MaterialListView list_product;
        private ColumnHeader Product;
        private ColumnHeader Weight;
        private ColumnHeader Count;
        private MaterialSkin.Controls.MaterialTextBox txt_count;
        private MaterialSkin.Controls.MaterialExpansionPanel materialExpansionPanel1;
    }
}