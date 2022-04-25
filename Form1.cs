using System.Xml.Serialization;


namespace Visual_Lab3
{
    public partial class Form1 : Form
    {
        private int _currentItemIndex = -1;
        private int _isFiltered = 0;
        private List<BusInfo> busInfos;
        public Form1()
        {
            InitializeComponent();
            busInfos = Program.Buses;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void UpdateList()
        {
            listView1.Items.Clear();

            foreach (var bus in busInfos)
            {
                if (!string.IsNullOrEmpty(bus.Number) && !string.IsNullOrWhiteSpace(bus.Number))
                {
                    listView1.Items.Add(bus.Number);
                }
                else
                {
                    listView1.Items.Add("New Bus Info");
                }
            }
        }
        private void add_Click(object sender, EventArgs e)
        {
            var bus = new BusInfo();
            Program.Buses.Add(bus);
            if (Program.Buses == busInfos)
            {
                listView1.Items.Add("New Bus Info");
            }
        }


        private void apply_Click(object sender, EventArgs e)
        {
            if (_currentItemIndex == -1)
            {
                return;
            }
            int itemIndex = listView1.SelectedIndices[0];
            var item = busInfos[itemIndex];
            item.Number = numberbox.Text;
            item.Destination = destinationbox.Text;
            item.DepartureDate = ddbox.Text;
            item.DepartureTime = dtbox.Text;
            item.Type = typebox.Text;
            item.ArrivalDate = adbox.Text;
            item.ArrivalTime = atbox.Text;
            if (!string.IsNullOrEmpty(numberbox.Text) && !string.IsNullOrWhiteSpace(numberbox.Text))
            {
                listView1.SelectedItems[0].Text = numberbox.Text;
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (_currentItemIndex == -1)
            {
                return;
            }
            busInfos.RemoveAt(_currentItemIndex);
            if (busInfos != Program.Buses)
            {
                Program.Buses.Remove(busInfos[_currentItemIndex]);
            }
            listView1.Items.RemoveAt(_currentItemIndex);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                _currentItemIndex = -1;
                var newItem = new BusInfo();
                numberbox.Text = newItem.Number;
                destinationbox.Text = newItem.Destination;
                ddbox.Text = newItem.DepartureDate;
                dtbox.Text = newItem.DepartureTime;
                typebox.Text = newItem.Type;
                adbox.Text = newItem.ArrivalDate;
                atbox.Text = newItem.ArrivalTime;
                apply.Enabled = false;
                delete.Enabled = false;
                return;
            }
            apply.Enabled = true;
            delete.Enabled = true;
            int itemIndex = listView1.SelectedIndices[0];
            _currentItemIndex = itemIndex;
            var item = busInfos[itemIndex];
            numberbox.Text = item.Number;
            destinationbox.Text = item.Destination;
            ddbox.Text = item.DepartureDate;
            dtbox.Text = item.DepartureTime;
            typebox.Text = item.Type;
            adbox.Text = item.ArrivalDate;
            atbox.Text = item.ArrivalTime;
        }

        private void save_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "XML file|*.xml";
            saveFileDialog.Title = "Save buses Data As XML File";
            saveFileDialog.FileName = "BusesInfo.xml";

            DialogResult result = saveFileDialog.ShowDialog();
            saveFileDialog.RestoreDirectory = true;

            if (result == DialogResult.OK && saveFileDialog.FileName != "")
            {
                try
                {
                    if (saveFileDialog.CheckPathExists)
                    {
                        XmlSerializer serializer = new XmlSerializer(typeof(List<BusInfo>));
                        TextWriter textWriter = new StreamWriter(saveFileDialog.FileName);
                        serializer.Serialize(textWriter, Program.Buses);
                        textWriter.Close();
                    }
                    else
                    {
                        MessageBox.Show("Given Path does not exist");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void open_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "XML file|*.xml";
            openFileDialog.Title = "Open Buses Info";
            openFileDialog.FileName = "BusesInfo.xml";

            DialogResult result = openFileDialog.ShowDialog();
            openFileDialog.RestoreDirectory = true;

            if (result == DialogResult.OK && openFileDialog.FileName != "")
            {
                try
                {
                    if (openFileDialog.CheckPathExists)
                    {
                        XmlSerializer serializer = new XmlSerializer(typeof(List<BusInfo>));
                        TextReader textReader = new StreamReader(openFileDialog.OpenFile());
                        Program.Buses = serializer.Deserialize(textReader) as List<BusInfo>;
                        textReader.Close();
                        busInfos = Program.Buses;
                        UpdateList();
                    }
                    else
                    {
                        MessageBox.Show("Given Path does not exist");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void filter_Click(object sender, EventArgs e)
        {
            if (_isFiltered==0)
            {
                var filteredData =
                from bus in Program.Buses
                where (string.IsNullOrEmpty(numberbox.Text) ? true : bus.Number == numberbox.Text) &&
                    (string.IsNullOrEmpty(typebox.Text) ? true : bus.Type == typebox.Text) &&
                    (string.IsNullOrEmpty(destinationbox.Text) ? true : bus.Destination == destinationbox.Text) &&
                    (string.IsNullOrEmpty(ddbox.Text) ? true : bus.DepartureDate == ddbox.Text) &&
                    (string.IsNullOrEmpty(dtbox.Text) ? true : bus.DepartureTime == dtbox.Text) &&
                    (string.IsNullOrEmpty(adbox.Text) ? true : bus.ArrivalDate == adbox.Text) &&
                    (string.IsNullOrEmpty(atbox.Text) ? true : bus.ArrivalTime == atbox.Text)
                select bus;

                busInfos = new List<BusInfo>(filteredData);

                UpdateList();
                _isFiltered = 1;
            }
            else
            {
                busInfos= Program.Buses;
                UpdateList();
                _isFiltered = 0;
            }
        }
        private bool dcompare(string date,string dateless)
        {
            var d = Convert.ToDateTime(date);
            var dl = Convert.ToDateTime(dateless);
            if (d < dl) return true;
            else return false;
        }
        private bool tcompare(string date, string dateless) 
        {

            return true;
        }
        private void func_Click(object sender, EventArgs e)
        {
            if (Program.Buses.Count() == 0)
            {
                return;
            }
            try
            {
                var dd = DateTime.Parse(ddbox.Text);
            }
            catch
            {
                var dd = DateTime.Parse("1/1/2000");
            }
                var filteredData =
                from Bus in Program.Buses
                where dcompare(Bus.ArrivalDate,adbox.Text)
                && Bus.Destination==destinationbox.Text
                select Bus.Number;
            var count = filteredData.Count();
            filteredData = filteredData.Distinct();
            string message = $"Quantity of Buses: {count}" + "\n";
            foreach (var name in filteredData)
            {
                message += name + "\n";
            }
            MessageBox.Show(message);
        }
        private void trytoparsedate(object sender, EventArgs e)
        {
            var tb = sender as TextBox;
            try
            {
                Convert.ToDateTime(tb.Text);
            }
            catch
            {
                tb.Text = "";
            }
        }
        private void numberbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void typebox_TextChanged(object sender, EventArgs e)
        {

        }

        private void destinationbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ddbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void adbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void atbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}