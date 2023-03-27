using MaterialSkin.Controls;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using TransportChecker.domain;
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

            var count = getCardCount();
            var card = includeCard(count + 1);
            fl_main.Controls.Add(card);

            card.Focus();
        }

        private void switchTheme_CheckedChanged(object sender, EventArgs e)
        {
            manager.Theme = switchTheme.Checked
                ? MaterialSkin.MaterialSkinManager.Themes.DARK
                : MaterialSkin.MaterialSkinManager.Themes.LIGHT;
        }

        private void btnAddItemClick(object sender, EventArgs e)
        {
            #region Initialize components
            var button = (MaterialButton)sender;
            var id = Convert.ToInt32(button.Name[button.Name.Length - 1].ToString());
            var btnAddRoute = fl_main.Controls.Find($"btnAddCard_{id}", true).FirstOrDefault() as MaterialButton;
            var btnSubmit = fl_main.Controls.Find($"btnSubmit_{id}", true).FirstOrDefault() as MaterialButton;
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

                if (products.Items.Count > 0)
                {
                    btnAddRoute.Enabled = true;
                    btnSubmit.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("The weight should be an number.", "Error:");
            }
        }

        private List<City> findAllCities()
        {
            validateDatabaseFile();

            var result = new List<City>();
            List<string> list = File.ReadAllLines(this.source)[0].Split(';').ToList();

            for (int city = 0; city < list.Count; city++)
                result.Add(new City(list[city], findDistanceBetweenCities(list[city])));

            return result;
        }

        private Dictionary<string, int> findDistanceBetweenCities(string origin)
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

            return distance[origin];
        }

        private void cbVehicleSelectionChange(object sender, EventArgs e)
        {
            var comboBox = (MaterialComboBox)sender;
            var id = Convert.ToInt32(comboBox.Name[comboBox.Name.Length - 1].ToString());

            search(id);
        }

        private void btnSearchClick(object sender, EventArgs e)
        {
            var btn = sender as MaterialButton;
            var id = Convert.ToInt32(btn.Name[btn.Name.Length - 1].ToString());

            search(id);
        }

        private void search(int id)
        {
            #region Parents
            var card = fl_main.Controls.OfType<MaterialCard>()
                  .FirstOrDefault(painel =>
                      painel.Name.ToLower().Contains($"card_{id}")
                  );

            #region Title panel components
            var titlePainel = card.Controls.OfType<FlowLayoutPanel>()
                .FirstOrDefault(painel =>
                    painel.Name.ToLower().Contains("title")
                );
            var label = titlePainel.Controls.OfType<MaterialLabel>()
                .FirstOrDefault(textBox =>
                    textBox.Name.ToLower().Contains("distance")
                );
            #endregion

            #region Top panel components
            var topPainel = card.Controls.OfType<FlowLayoutPanel>()
                .FirstOrDefault(painel =>
                    painel.Name.ToLower().Contains("top")
                );
            var origin = topPainel.Controls.OfType<MaterialComboBox>()
                .FirstOrDefault(painel =>
                    painel.Name.ToLower().Contains("cborigin")
                );
            var destination = topPainel.Controls.OfType<MaterialComboBox>()
                .FirstOrDefault(painel =>
                    painel.Name.ToLower().Contains("cbdestination")
                );
            #endregion

            #region Middle panel components
            var middlePainel = card.Controls.OfType<FlowLayoutPanel>()
                .FirstOrDefault(painel =>
                    painel.Name.ToLower().Contains("middle")
                );
            var textTotalCost = middlePainel.Controls.OfType<MaterialMaskedTextBox>()
                .FirstOrDefault(textBox =>
                    textBox.Name.ToLower().Contains("cost")
            );
            var comboBox = middlePainel.Controls.OfType<MaterialComboBox>()
                .FirstOrDefault(painel =>
                    painel.Name.ToLower().Contains("cbvehicletype")
                );
            #endregion
            #endregion

            if (origin != null && destination != null)
            {
                City originCity = (City)origin.SelectedItem;
                City destinationCity = (City)destination.SelectedItem;
                VehicleType vehicleType = (VehicleType)comboBox.SelectedItem;

                if (!string.IsNullOrEmpty(originCity.name) && !string.IsNullOrEmpty(destinationCity.name))
                {
                    var distance = originCity.findDistanceBetweenCities(destinationCity.name);
                    var vehicle = new Vehicle(vehicleType);
                    var cost = distance * vehicle.costPerKm;

                    label.Text = $"Distance: {distance}";
                    textTotalCost.Text = cost.ToString("N2");
                }
            }
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

        private void validateDatabaseFile()
        {
            if (!File.Exists(this.source))
            {
                throw new Exception("Error:\n datafile not found. Please check if you have any .csv file in your folder.");
            }
        }

        private void btnNewRoute_Click(object sender, EventArgs e)
        {
            MaterialCard newCard = includeCard(getCardCount() + 1);

            MaterialButton btn = (MaterialButton)sender;                        
            MaterialButton? btnSubmit = fl_main.Controls.Find($"btnSubmit_{getCardCount()}", true).FirstOrDefault() as MaterialButton;
            
            ComboBox? origin = newCard.Controls.Find($"cbOrigin_{getCardCount() + 1}", true).FirstOrDefault() as ComboBox;
            ComboBox? lastDestination = fl_main.Controls.Find($"cbDestination_{getCardCount()}", true).FirstOrDefault() as ComboBox;
            
            if (lastDestination != null)
            {
                if (origin != null)
                {
                    fl_main.Controls.Add(newCard);
                    origin.DataSource = lastDestination.DataSource;
                    origin.SelectedItem = lastDestination.SelectedItem;
                    origin.Enabled = false;
                    btn.Enabled = false;
                    btnSubmit.Enabled = false;
                    newCard.Focus();
                }
            }
        }


        #region Factories
        private MaterialCard includeCard(int id)
        {
            var card = new MaterialCard();
            card.Name = $"card_{id}";
            card.Width = 500;
            card.Height = 350;

            #region Title
            var titleContainer = createLayout($"flTitle_{id}", DockStyle.Top);
            var lblDistance = createLabel($"lblDistance_{id}", "Distance: ");

            var btnAddRoute = new MaterialButton();
            btnAddRoute.Margin = new Padding(85, 0, 0, 0);
            btnAddRoute.Text = $"New delivery route";
            btnAddRoute.Name = $"btnAddCard_{id}";
            btnAddRoute.Click += new EventHandler(btnNewRoute_Click);
            btnAddRoute.Enabled = false;

            titleContainer.Controls.AddRange(new Control[] {
                lblDistance, btnAddRoute
            });
            #endregion

            #region Top container
            var topContainer = createLayout($"flTop_{id}", DockStyle.Top);

            var origin = createComboBox($"cbOrigin_{id}", "Origin", 185);
            origin.DataSource = findAllCities();

            var destination = createComboBox($"cbDestination_{id}", "Destination", 185);
            destination.DataSource = findAllCities();

            topContainer.Controls.AddRange(new Control[] { origin, destination });
            #endregion

            #region Middle
            var middleContainer = createLayout($"flMiddle_{id}", DockStyle.Top);

            var cbVehicleType = createComboBox($"cbVehicleType_{id}", "Vehicle type", 185);
            cbVehicleType.DataSource = populateVehicleType();
            cbVehicleType.SelectedIndexChanged += new EventHandler(cbVehicleSelectionChange);

            var textTotalCost = new MaterialMaskedTextBox();
            textTotalCost.Name = $"textTotalCost_{id}";
            textTotalCost.Hint = "R$ xxx.xx";
            textTotalCost.PrefixSuffix = MaterialMaskedTextBox.PrefixSuffixTypes.Prefix;
            textTotalCost.PrefixSuffixText = "R$";
            textTotalCost.Width = 185;
            textTotalCost.ReadOnly = true;

            var btnSearch = new MaterialButton();
            btnSearch.Name = $"btnSearch_{id}";
            btnSearch.Text = "Search";
            btnSearch.Click += new EventHandler(btnSearchClick);

            middleContainer.Controls.AddRange(new Control[] {
                cbVehicleType, textTotalCost, btnSearch
            });
            #endregion

            #region Bottom
            var bottomContainer = createLayout($"flBottom_{id}", DockStyle.Top);

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

            bottomContainer.Controls.AddRange(new Control[] {
                textProduct, textWeight, textCount, btnAdd
            });
            #endregion

            #region Footer
            var productsContainer = createLayout($"fl_product_{id}", DockStyle.Fill);

            var products = new MaterialListView();

            products.Width = 255;
            products.Scrollable = true;
            products.Name = $"list_{id}";
            products.Columns.AddRange(new[] {
                    new ColumnHeader { Text = "Product", Width = 95 },
                    new ColumnHeader { Text = "Weight", Width = 60 },
                    new ColumnHeader { Text = "Count", Width = 75 }
                });

            var btnSubmit = new MaterialButton();
            btnSubmit.Margin = new Padding(115, 0, 0, 0);
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

        private Array populateVehicleType()
        {
            return Enum.GetValues(typeof(VehicleType));
        }

        private FlowLayoutPanel createLayout(string name, DockStyle style, int height = 60)
        {
            var container = new FlowLayoutPanel();
            container.Name = name;
            container.Height = height;
            container.Dock = style;
            container.FlowDirection = FlowDirection.LeftToRight;

            return container;
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
        #endregion
    }
}