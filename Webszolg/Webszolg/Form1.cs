using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml;
using Webszolg.Entities;
using Webszolg.MNBServiceReference;

namespace Webszolg
{
    public partial class Form1 : Form
    {
        BindingList<RateData> _rates = new BindingList<RateData>();
        BindingList<string> currencies = new BindingList<string>();

        public Form1()
        {
            InitializeComponent();
            LoadCurrencyxml(GetCurrencies());
            cbvaluta.DataSource = currencies;
            RefreshData();
        }

        private void RefreshData()
        {
            if (cbvaluta.SelectedItem == null) return;
            _rates.Clear();
            LoadXML(GetRates());
            dataGridView1.DataSource = _rates;
            MakeChart();
        }

        private void MakeChart()
        {
            chartRate.DataSource = _rates;
            Series sorozatok= chartRate.Series[0];
            sorozatok.ChartType = SeriesChartType.Line;
            sorozatok.XValueMember = "Date";
            sorozatok.YValueMembers = "Value";
            var jelmagyarazat = chartRate.Legends[0];
            jelmagyarazat.Enabled = false;

            var diagramterulet =chartRate.ChartAreas[0];
            diagramterulet.AxisY.IsStartedFromZero = false;
            diagramterulet.AxisY.MajorGrid.Enabled = false;
            diagramterulet.AxisX.MajorGrid.Enabled = false;
        }

        private void LoadXML(string xmlstring)
        {
            XmlDocument xml = new XmlDocument();
            xml.LoadXml(xmlstring);
            foreach (XmlElement item in xml.DocumentElement)
            {
                RateData r = new RateData();
                r.Date = DateTime.Parse(item.GetAttribute("date"));
                var childElement = (XmlElement)item.ChildNodes[0];
                if(childElement!=null)
                {
                    r.Currency = childElement.GetAttribute("curr");
                    int unit = int.Parse(childElement.GetAttribute("unit"));
                    r.Value = decimal.Parse(childElement.InnerText);
                    if (unit != 0)
                        r.Value = r.Value / unit;
                    _rates.Add(r);
                }
                
            }
        }

        private void LoadCurrencyxml(string xmlstring)
        {
            currencies.Clear();
            XmlDocument xml = new XmlDocument();
            xml.LoadXml(xmlstring);
            foreach (XmlElement item in xml.DocumentElement.ChildNodes[0])
            {
                string s = item.InnerText;
                currencies.Add(s);
            }
        }
        private string GetCurrencies()
        {
            var mnbService = new MNBArfolyamServiceSoapClient();
            GetCurrenciesRequestBody req = new GetCurrenciesRequestBody();
            var resp = mnbService.GetCurrencies(req);
            return resp.GetCurrenciesResult;
        }
        private string GetRates()
        {            
            var MNBService = new MNBArfolyamServiceSoapClient();
            GetExchangeRatesRequestBody req = new GetExchangeRatesRequestBody();
            req.currencyNames = cbvaluta.SelectedItem.ToString();
            req.startDate = dateTimePickertol.Value.ToString("yyyy-MM-dd");
            req.endDate = dateTimePickerig.Value.ToString("yyyy-MM-dd");
            var response = MNBService.GetExchangeRates(req);
            return response.GetExchangeRatesResult;
        }

        private void dateTimePickertol_ValueChanged(object sender, EventArgs e)
        {
            RefreshData();
        }
    }
}
