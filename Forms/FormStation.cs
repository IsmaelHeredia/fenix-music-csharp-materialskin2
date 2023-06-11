using FenixMusic.Data;
using FenixMusic.Models;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FenixMusic.Forms
{
    public partial class FormStation : MaterialForm
    {
        public string program_title;
        public FormHome formHome;
        public int id_station;

        public FormStation(FormHome formHome_here, int id_station_here)
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(
                materialSkinManager.Theme == MaterialSkinManager.Themes.DARK ? Primary.Teal500 : Primary.Indigo500,
                materialSkinManager.Theme == MaterialSkinManager.Themes.DARK ? Primary.Teal700 : Primary.Indigo700,
                materialSkinManager.Theme == MaterialSkinManager.Themes.DARK ? Primary.Teal200 : Primary.Indigo100,
                Accent.Pink200,
                TextShade.WHITE);

            program_title = System.Configuration.ConfigurationManager.AppSettings["program_title"];
            formHome = formHome_here;
            id_station = id_station_here;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string link = txtLink.Text;
            string categories = txtCategories.Text;

            if (name != "" && link != "" && categories != "")
            {
                if (id_station == 0)
                {
                    DataStation dataStation = new DataStation();
                    Station station = new Station();
                    station.Name = name;
                    station.Link = link;
                    station.Categories = categories;
                    if (dataStation.Add(station) == true)
                    {
                        MaterialSnackBar SnackBarMessage = new MaterialSnackBar("Station created");
                        SnackBarMessage.Show(this);

                        formHome.loadStations();
                        FormStation.ActiveForm.Close();
                    }
                    else
                    {
                        MaterialSnackBar SnackBarMessage = new MaterialSnackBar("Error making station");
                        SnackBarMessage.Show(this);
                    }
                }
                else
                {
                    DataStation dataStation = new DataStation();
                    Station station = new Station();
                    station.Id = id_station;
                    station.Name = name;
                    station.Link = link;
                    station.Categories = categories;
                    if (dataStation.Update(station) == true)
                    {
                        MaterialSnackBar SnackBarMessage = new MaterialSnackBar("Station updated");
                        SnackBarMessage.Show(this);

                        formHome.loadStations();
                        FormStation.ActiveForm.Close();
                    }
                    else
                    {
                        MaterialSnackBar SnackBarMessage = new MaterialSnackBar("Error updating station");
                        SnackBarMessage.Show(this);
                    }
                }
            }
            else
            {
                MaterialSnackBar SnackBarMessage = new MaterialSnackBar("Complete form");
                SnackBarMessage.Show(this);
            }
        }

        private void FormStation_Load(object sender, EventArgs e)
        {
            if (id_station > 0)
            {
                DataStation dataStation = new DataStation();
                Station stationData = dataStation.Get(id_station);
                string name = stationData.Name;
                string link = stationData.Link;
                string categories = stationData.Categories;
                txtName.Text = name;
                txtLink.Text = link;
                txtCategories.Text = categories;
            }
        }
    }
}
