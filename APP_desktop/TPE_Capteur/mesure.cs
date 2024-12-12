using System;
using System.IO.Ports;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace TPE_Capteur
{
    public partial class mesure : Form
    {
        private SerialPort serialPort;

        public mesure()
        {
            InitializeComponent();
            InitializeComboBoxPorts();
            InitializeChart();
        }

        private void InitializeComboBoxPorts()
        {
            // Ajoutez un ComboBox pour la sélection des ports série
            comboBoxPorts.Items.AddRange(SerialPort.GetPortNames());
            if (comboBoxPorts.Items.Count > 0)
            {
                comboBoxPorts.SelectedIndex = 0; // Sélectionnez le premier port par défaut
            }
            else
            {
                MessageBox.Show("Aucun port série détecté. Connectez un appareil.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void InitializeChart()
        {
            // Configurez le graphique
            chartData.Series.Clear();
            var series = new Series
            {
                Name = "ECG Data",
                ChartType = SeriesChartType.Line,
                BorderWidth = 2
            };

            chartData.Series.Add(series);
            chartData.ChartAreas[0].AxisX.Title = "Temps (points)";
            chartData.ChartAreas[0].AxisY.Title = "Amplitude";
            chartData.ChartAreas[0].AxisY.Minimum = -10; // Ajustez selon vos besoins
            chartData.ChartAreas[0].AxisY.Maximum = 600;  // Ajustez selon vos besoins
        }

        private void InitializeSerialPort(string portName)
        {
            // Configurez le port série
            serialPort = new SerialPort
            {
                PortName = portName,
                BaudRate = 9600,
                DataBits = 8,
                Parity = Parity.None,
                StopBits = StopBits.One,
                Handshake = Handshake.None
            };

            // Ajoutez l'événement pour la réception des données
            serialPort.DataReceived += SerialPort_DataReceived;

            try
            {
                serialPort.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur d'ouverture du port série : {ex.Message}");
            }
        }

        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                // Lire les données envoyées par l'Arduino
                string data = serialPort.ReadLine();

                if (int.TryParse(data, out int value))
                {
                    // Mettre à jour l'interface utilisateur dans le thread principal
                    Invoke(new Action(() =>
                    {
                        labelData.Text = data;

                        // Ajouter les données au graphique
                        var series = chartData.Series["ECG Data"];
                        series.Points.AddY(value);

                        // Limiter le nombre de points visibles à 40
                        if (series.Points.Count > 200)
                        {
                            series.Points.RemoveAt(0);
                        }

                        // Ajuster dynamiquement la plage de l'axe X pour afficher les 20 derniers points
                        chartData.ChartAreas[0].AxisX.Minimum = Math.Max(0, series.Points.Count - 50);
                        chartData.ChartAreas[0].AxisX.Maximum = series.Points.Count;

                        chartData.ResetAutoValues(); // Ajuster automatiquement les autres axes
                    }));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la lecture des données : {ex.Message}");
            }
        }

        private void mesure_Load(object sender, EventArgs e)
        {
            // Charger les ports disponibles au démarrage
            InitializeComboBoxPorts();
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            if (serialPort != null && serialPort.IsOpen)
            {
                serialPort.Close();
            }

            if (comboBoxPorts.SelectedItem != null)
            {
                string selectedPort = comboBoxPorts.SelectedItem.ToString();
                InitializeSerialPort(selectedPort);
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un port série.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            // Fermez proprement le port série
            if (serialPort != null && serialPort.IsOpen)
            {
                serialPort.Close();
            }

            base.OnFormClosing(e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Fermez proprement le port série
            if (serialPort != null && serialPort.IsOpen)
            {
                serialPort.Close();
            }

            MessageBox.Show("Port série déconnecté avec succès.");
        }
    }
}
