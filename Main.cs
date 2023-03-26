using MaterialSkin.Controls;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace TransportChecker
{
    public partial class Main : MaterialForm
    {
        private readonly MaterialSkin.MaterialSkinManager manager;

        private string source = $"{AppDomain.CurrentDomain.BaseDirectory}\\DNIT-Distancias.csv";

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

        private MaterialComboBox createComboBox(string name, string hint, int width)
        {
            MaterialComboBox comboBox = new MaterialComboBox();

            comboBox.Name = name;
            comboBox.Hint = hint;
            comboBox.Width = width;

            return comboBox;
        }

        private MaterialLabel createLabel(string name, string text)
        {
            MaterialLabel label = new MaterialLabel();
            label.Name = name;
            label.Text = text;
            label.Width = 200;

            return label;
        }

        private MaterialTextBox createTextBox(string name, string hint, int width)
        {
            MaterialTextBox textBox = new MaterialTextBox();

            textBox.Name = name;
            textBox.Hint = hint;
            textBox.Width = width;

            return textBox;
        }

        private MaterialCard includeCard(int id)
        {
            var card = new MaterialCard();
            card.Name = $"card_{id}";
            card.Width = 500;
            card.Height = 320;

            int containerHeight = 50;

            #region Title
            var titleContainer = new FlowLayoutPanel();
            titleContainer.Name = $"flTitle_{id}";
            titleContainer.Height = containerHeight;
            titleContainer.Dock = DockStyle.Top;
            titleContainer.FlowDirection = FlowDirection.LeftToRight;

            var lblDistance = createLabel($"lblDistance_{id}", "Distance: ");

            var btnAddCard = new MaterialButton();
            btnAddCard.Margin = new Padding(85, 0, 0, 0);
            btnAddCard.Text = $"New delivery route";
            btnAddCard.Name = $"btnAddCard_{id}";
            btnAddCard.Enabled = false;

            titleContainer.Controls.AddRange(new Control[] {
                lblDistance, btnAddCard
            });
            #endregion

            #region Top container
            var topContainer = new FlowLayoutPanel();
            topContainer.Name = $"flTop_{id}";
            topContainer.Height = containerHeight;
            topContainer.Dock = DockStyle.Top;
            topContainer.FlowDirection = FlowDirection.LeftToRight;

            var origin = createComboBox($"cbOrigin_{id}", "Origin", 185);
            origin.Click += new EventHandler(cbLocationClick);

            var destination = createComboBox($"cbDestination_{id}", "Destination", 185);
            destination.Click += new EventHandler(cbLocationClick);

            topContainer.Controls.AddRange(new Control[] { origin, destination });
            #endregion

            #region Middle
            var middleContainer = new FlowLayoutPanel();
            middleContainer.Name = $"flMiddle_{id}";
            middleContainer.Height = containerHeight;
            middleContainer.Dock = DockStyle.Top;
            middleContainer.FlowDirection = FlowDirection.LeftToRight;

            var textProduct = createTextBox($"text_product_{id}", $"Product", 185);
            textProduct.TextChanged += new EventHandler(txtCheckTextChange);

            var textWeight = createTextBox($"text_weight_{id}", $"Weight", 90);
            textWeight.TextChanged += new EventHandler(txtCheckTextChange);

            var textCount = createTextBox($"text_count_{id}", $"Count", 90);
            textCount.TextChanged += new EventHandler(txtCheckTextChange);

            var btnAdd = new MaterialButton();
            btnAdd.Name = $"btnAdd_{id}";
            btnAdd.Text = $"Add";
            btnAdd.Enabled = false;
            btnAdd.Click += new EventHandler(btnAddItemClick);

            middleContainer.Controls.AddRange(new Control[] {
                textProduct, textWeight, textCount, btnAdd
            });
            #endregion

            #region Bottom
            var bottomContainer = new FlowLayoutPanel();
            bottomContainer.Name = $"flBottom_{id}";
            bottomContainer.Height = containerHeight + 20;
            bottomContainer.Dock = DockStyle.Top;
            bottomContainer.FlowDirection = FlowDirection.LeftToRight;

            var cbVehicleType = createComboBox($"cbVehicleType_{id}", "Vehicle type", 185);
            //TODO CLICK

            var textTotalCost = new MaterialMaskedTextBox();
            textTotalCost.Name = $"textTotalCost_{id}";
            textTotalCost.Hint = "R$ xxx.xx";
            textTotalCost.PrefixSuffix = MaterialMaskedTextBox.PrefixSuffixTypes.Prefix;
            textTotalCost.PrefixSuffixText = "R$";
            textTotalCost.Width = 185;
            textTotalCost.Enabled = false;

            var btnSearch = new MaterialButton();
            btnSearch.Name = $"btnSearch_{id}";
            btnSearch.Text = "Search";
            //TODO Click =

            bottomContainer.Controls.AddRange(new Control[] {
                cbVehicleType, textTotalCost, btnSearch
            });
            #endregion

            #region Footer
            var productsContainer = new FlowLayoutPanel();
            productsContainer.Dock = DockStyle.Fill;
            productsContainer.Name = $"fl_product_{id}";
            productsContainer.Height = containerHeight;

            var products = new MaterialListView();

            products.Width = 230;
            products.Scrollable = true;
            products.Name = $"list_{id}";
            products.Columns.AddRange(new[] {
                    new ColumnHeader { Text = "Product", Width = 95 },
                    new ColumnHeader { Text = "Weight", Width = 60 },
                    new ColumnHeader { Text = "Count", Width = 75 }
                });

            var btnSubmit = new MaterialButton();
            btnSubmit.Margin = new Padding(145, 0, 0, 0);
            btnSubmit.Name = $"btnSubmit_{id}";
            btnSubmit.Text = $"Subtmit";
            btnSubmit.Enabled = false;
            //TODO CLICK

            productsContainer.Controls.AddRange(new Control[] { products, btnSubmit });
            #endregion

            card.Controls.Add(productsContainer);
            card.Controls.Add(bottomContainer);
            card.Controls.Add(middleContainer);
            card.Controls.Add(topContainer);
            card.Controls.Add(titleContainer);

            return card;
        }

        private void btn_add_card_Click(object sender, EventArgs e)
        {
            var count = getCardCount();
            var card = includeCard(count + 1);
            fl_main.Controls.Add(card);

            card.Focus();
        }

        private void btnAddItemClick(object sender, EventArgs e)
        {
            #region Initialize components
            var button = (MaterialButton)sender;
            var parentPainel = (FlowLayoutPanel)button.Parent;
            var parentCard = (MaterialCard)parentPainel.Parent;
            var listParent = parentCard.Controls.OfType<FlowLayoutPanel>()
                .FirstOrDefault(painel =>
                    painel.Name.ToLower().Contains("product")
                );

            var textProduct = parentPainel.Controls.OfType<MaterialTextBox>()
                .FirstOrDefault(textBox =>
                    textBox.Name.ToLower().Contains("product")
                );
            var textWeight = parentPainel.Controls.OfType<MaterialTextBox>()
                .FirstOrDefault(textBox =>
                    textBox.Name.ToLower().Contains("weight")
                );
            var textCount = parentPainel.Controls.OfType<MaterialTextBox>()
                .FirstOrDefault(textBox =>
                    textBox.Name.ToLower().Contains("count")
                );

            var addButton = parentPainel.Controls
                .OfType<MaterialButton>()
                .First(button => button.Name.ToLower().Contains("add"));

            var products = listParent.Controls
                .OfType<MaterialListView>()
                .First(list => list.Name.Contains("list"));
            #endregion

            double weight;
            bool isWeightDouble = double.TryParse(textWeight.Text, out weight);

            int count;
            bool isCountInteger = int.TryParse(textCount.Text, out count);

            if (isWeightDouble && isCountInteger)
            {
                var item = new ListViewItem(new string[] {
                    textProduct.Text,
                    textWeight.Text,
                    textCount.Text
                });

                products.Items.Add(item);
            }
            else
            {
                MessageBox.Show("The weight should be an number.", "Error:");
            }
        }

        private void validateDatabaseFile()
        {
            if (!File.Exists(this.source))
            {
                throw new Exception("Error:\n datafile not found. Please check if you have any .csv file in your folder.");
            }
        }

        private List<string> findAllCities()
        {
            List<string> result = new List<string>();

            validateDatabaseFile();

            List<string> list = File.ReadAllLines(this.source)[0].Split(';').ToList();
            result.AddRange(list);

            return result;
        }

        private int findDistanceBetweenCities(string origin, string destination)
        {
            validateDatabaseFile();

            Dictionary<string, Dictionary<string, int>> distance = new Dictionary<string, Dictionary<string, int>>();
            string[] rows = File.ReadAllLines(this.source);
            string[] cities = rows[0].Split(';');

            for (int row = 1; row < rows.Length; row++)
            {
                string[] values = rows[row].Trim().Split(';');

                string start = cities[row - 1];

                for (int column = 0; column < values.Length; column++)
                {
                    string destiny = cities[column];

                    int kms = Convert.ToInt32(values[column]);

                    if (!distance.ContainsKey(start))
                    {
                        distance[start] = new Dictionary<string, int>();
                    }

                    distance[start][destiny] = kms;
                }
            }

            return distance[origin][destination];
        }

        private void cbLocationClick(object sender, EventArgs e)
        {
            var comboBox = (MaterialComboBox)sender;
            comboBox.DataSource = findAllCities();
        }

        private void cb_origin_Click(object sender, EventArgs e)
        {
            cb_origin.DataSource = findAllCities();
        }

        private void cb_destination_Click(object sender, EventArgs e)
        {
            cb_destination.DataSource = findAllCities();
        }

        private void txtCheckTextChange(object sender, EventArgs e)
        {
            var changedTextBox = (MaterialTextBox)sender;
            var parentPainel = (FlowLayoutPanel)changedTextBox.Parent;

            var textBoxes = parentPainel.Controls
                .OfType<MaterialTextBox>()
                .Where(textBox =>
                    textBox.Name.ToLower().Contains("product") ||
                    textBox.Name.ToLower().Contains("weight") ||
                    textBox.Name.ToLower().Contains("count"))
                .ToList();

            var addButton = parentPainel.Controls
                .OfType<MaterialButton>()
                .First(button => button.Name.ToLower().Contains("add"));

            var thereIsAnyEmptyTextBox = textBoxes.FirstOrDefault(x => string.IsNullOrEmpty(x.Text)) == null;

            if (thereIsAnyEmptyTextBox)
            {
                addButton.Enabled = true;
            }
            else
            {
                addButton.Enabled = false;
            }
        }

        private int getCardCount()
        {
            return fl_main.Controls.OfType<MaterialCard>().Count();
        }
    }
}