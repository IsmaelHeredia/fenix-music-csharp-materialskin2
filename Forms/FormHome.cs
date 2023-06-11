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
using FenixMusic.Data;
using FenixMusic.Functions;
using FenixMusic.Forms;
using System.Runtime.InteropServices;
using AxWMPLib;
using FenixMusic.Models;
using System.Collections;
using System.IO;
using WMPLib;
using System.Xml;
using Newtonsoft.Json;
using Formatting = Newtonsoft.Json.Formatting;

namespace FenixMusic
{
    public partial class FormHome : MaterialForm
    {
        [DllImport("User32.dll")]
        private static extern short GetAsyncKeyState(System.Windows.Forms.Keys vKey);
        [DllImport("User32.dll")]
        private static extern short GetAsyncKeyState(System.Int32 vKey);

        DataAccess dataAccess = new DataAccess();
        DataConfiguration dataConfiguration = new DataConfiguration();
        Helper helper = new Helper();
        public string database_name;
        public string program_title;
        public WMPLib.IWMPPlaylist playlist;
        public bool repeat = false;
        public bool ended = false;
        public bool playlist_ended = false;
        FormStation formStation = new FormStation(null, 0);
        public bool closing_app = false;

        public FormHome()
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

            database_name = System.Configuration.ConfigurationManager.AppSettings["database_name"];
            program_title = System.Configuration.ConfigurationManager.AppSettings["program_title"];
        }

        // Functions

        private void ClearTemporaryPlaylists()
        {
            string mymusic_folder = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic);
            ArrayList dirs = new ArrayList();

            dirs.Add(mymusic_folder + "/Playlists");
            dirs.Add(mymusic_folder + "/Listas de reproducción");

            foreach (string dir in dirs)
            {
                if (Directory.Exists(dir))
                {
                    string[] files = System.IO.Directory.GetFiles(dir, "*.wpl");
                    foreach (string file in files)
                    {
                        File.Delete(file);
                    }
                }
            }
        }

        private void generatePlaylists(bool op_loadPlaylist)
        {
            ClearTemporaryPlaylists();

            axWindowsMediaPlayer.Ctlcontrols.stop();

            string directoryToScan = txtDirectory.Text;

            foreach (string playlist in Directory.GetFiles(directoryToScan, "*.m3u"))
            {
                File.Delete(playlist);
            }

            foreach (string dir in Directory.GetDirectories(directoryToScan))
            {
                string playlist_name = new DirectoryInfo(dir).Name; // Filtro
                string playlist_file = directoryToScan + "/" + playlist_name + ".m3u";

                if (playlist_name.ToLower().Contains(txtSearchPlaylist.Text.ToLower())) // Filtra playlists
                {
                    DirectoryInfo info = new DirectoryInfo(dir);

                    FileInfo[] files = info.GetFiles().OrderBy(p => p.CreationTime).ToArray();

                    ArrayList songs = new ArrayList();

                    foreach (FileInfo file in files)
                    {
                        songs.Add(file.FullName);
                    }

                    songs.Reverse();

                    TextWriter tw = new StreamWriter(playlist_file);

                    foreach (string song in songs)
                    {
                        string song_name = Path.GetFileNameWithoutExtension(song);
                        string ext = new FileInfo(song).Extension;
                        if (song_name.ToLower().Contains(txtSearchSong.Text.ToLower())) // Filtra canciones
                        {
                            if (ext == ".mp3")
                            {
                                tw.WriteLine(song);
                            }
                        }
                    }

                    tw.Close();

                }
            }

            if (op_loadPlaylist == true)
            {
                loadPlaylists(directoryToScan);
            }
        }

        private void loadPlaylists(string directoryToScan)
        {
            lvPlaylists.Items.Clear();
            lvSongs.Items.Clear();
            lvStations.Items.Clear();

            if (txtSearchPlaylist.Text == "")
            {
                string[] data = { "All" };
                var item = new ListViewItem(data);

                lvPlaylists.Items.Add(item);
            }

            lvPlaylists.BeginUpdate();

            foreach (string playlist in Directory.GetFiles(directoryToScan, "*.m3u"))
            {
                string name = Path.GetFileNameWithoutExtension(playlist);

                string[] data = { name };
                var item = new ListViewItem(data);

                lvPlaylists.Items.Add(item);
            }

            lvPlaylists.EndUpdate();

            if (lvPlaylists.Items.Count > 0)
            {
                lvPlaylists.Items[0].Selected = true;
            }

            lblPlaylistCount.Text = "Playlists : " + lvPlaylists.Items.Count + " found";

            lblStatus.Text = "[+] Music loaded";
            this.Refresh();
        }

        public void loadStations()
        {
            lvStations.Items.Clear();
            if (File.Exists(Path.GetFullPath(database_name)))
            {
                DataStation ds = new DataStation();
                lvStations.BeginUpdate();
                ArrayList listStations = ds.List(txtSearchStation.Text);
                foreach (Station station in listStations)
                {
                    int id_station = station.Id;
                    string name = station.Name;
                    string link = station.Link;
                    string categories = station.Categories;

                    if (name.ToLower().Contains(txtSearchStation.Text.ToLower()))
                    {
                        string[] data = { Convert.ToString(id_station), name, link, categories };
                        var item = new ListViewItem(data);

                        lvStations.Items.Add(item);
                    }

                }
                lvStations.EndUpdate();

                if (lvStations.Items.Count > 0)
                {
                    lvStations.Items[0].Selected = true;
                }

                lblStationsCount.Text = "Stations : " + lvStations.Items.Count + " found";
            }
        }

        private void loadSongs(string directoryToScan)
        {
            lvSongs.Items.Clear();

            string name = lvPlaylists.SelectedItems[0].Text; // carpeta para argumento
            string fullpath = directoryToScan + "/" + name + ".m3u";

            if (name == "All")
            {
                DirectoryInfo info = new DirectoryInfo(directoryToScan);
                FileInfo[] files = info.GetFiles("*.mp3", SearchOption.AllDirectories).OrderBy(p => p.CreationTime).ToArray();

                ArrayList songs = new ArrayList();

                foreach (FileInfo file in files)
                {
                    songs.Add(file.FullName);
                }
                songs.Reverse();

                playlist = axWindowsMediaPlayer.playlistCollection.newPlaylist("MyPlaylist");
                WMPLib.IWMPMedia media;

                lvSongs.BeginUpdate();

                foreach (string song in songs)
                {
                    string song_name = Path.GetFileNameWithoutExtension(song);

                    if (song_name.ToLower().Contains(txtSearchSong.Text.ToLower())) // Filtra canciones
                    {
                        media = axWindowsMediaPlayer.newMedia(song);
                        playlist.appendItem(media);

                        string[] data = { song_name };
                        var item = new ListViewItem(data);

                        lvSongs.Items.Add(item);
                    }
                }

                lvSongs.EndUpdate();

                axWindowsMediaPlayer.settings.autoStart = false;
                axWindowsMediaPlayer.currentPlaylist = playlist;
            }
            else
            {
                playlist = axWindowsMediaPlayer.playlistCollection.newPlaylist("MyPlaylist");
                WMPLib.IWMPMedia media;

                var songs = File.ReadLines(fullpath);

                lvSongs.BeginUpdate();

                foreach (string song in songs)
                {
                    media = axWindowsMediaPlayer.newMedia(song);
                    playlist.appendItem(media);
                    string song_name = Path.GetFileNameWithoutExtension(song);

                    string[] data = { song_name };
                    var item = new ListViewItem(data);

                    lvSongs.Items.Add(item);
                }

                lvSongs.EndUpdate();

                axWindowsMediaPlayer.settings.autoStart = false;
                axWindowsMediaPlayer.currentPlaylist = playlist;
            }

            if (lvSongs.Items.Count > 0)
            {
                lvSongs.Items[0].Selected = true;
            }

            lblSongsCount.Text = "Songs : " + lvSongs.Items.Count + " found";
        }

        private void stop_player()
        {
            axWindowsMediaPlayer.Ctlcontrols.stop();
        }

        public void sendStatus(string text)
        {
            lblStatus.Text = text;
        }

        // End of functions

        private void FormHome_Load(object sender, EventArgs e)
        {
            string directory_music = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic);

            if (!File.Exists(Path.GetFullPath(database_name)))
            {
                dataAccess.createDB();

                Configuration new_configuration = new Configuration();
                new_configuration.Hotkeys = 0;
                new_configuration.Directory = directory_music;

                dataConfiguration.Add(new_configuration);

                MaterialSnackBar SnackBarMessage = new MaterialSnackBar("Database created");
                SnackBarMessage.Show(this);
            }

            Configuration configuration = dataConfiguration.Get(1);

            int hotkeys = configuration.Hotkeys;
            string directory = configuration.Directory;

            ClearTemporaryPlaylists();

            txtDirectory.Text = directory;

            if (hotkeys == 1)
            {
                cbEnableHotkeys.Checked = true;
                tmDetectHotkeys.Enabled = true;
            }

            axWindowsMediaPlayer.settings.volume = 100;

            generatePlaylists(true);
            loadStations();
        }

        private void btnRepeatSong_Click(object sender, EventArgs e)
        {
            repeat_song();
        }

        private void btnFullScreen_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer.fullScreen = true;
        }

        private void btnAddStation_Click(object sender, EventArgs e)
        {
            formStation = new FormStation(this, 0);
            formStation.Show();
        }

        private void lvPlaylists_DoubleClick(object sender, EventArgs e)
        {
            if (lvPlaylists.SelectedItems[0] != null)
            {
                ClearTemporaryPlaylists();

                string directoryToScan = txtDirectory.Text;

                loadSongs(directoryToScan);
            }
        }

        private void lvSongs_DoubleClick(object sender, EventArgs e)
        {
            if (lvSongs.SelectedItems[0] != null)
            {
                int song_index = lvSongs.SelectedIndices[0];

                WMPLib.IWMPMedia media = axWindowsMediaPlayer.currentPlaylist.get_Item(song_index);
                axWindowsMediaPlayer.Ctlcontrols.playItem(media);
                axWindowsMediaPlayer.settings.autoStart = true;
            }
        }

        private void btnGeneratePlaylists_Click(object sender, EventArgs e)
        {
            generatePlaylists(true);

            MaterialSnackBar SnackBarMessage = new MaterialSnackBar("Playlist generated");
            SnackBarMessage.Show(this);

            lblStatus.Text = "[+] Playlist generated";
            this.Refresh();
        }

        private void repeat_song()
        {
            if (repeat == false)
            {
                repeat = true;
                btnRepeatSong.Text = "Repeat song : OFF";
            }
            else
            {
                repeat = false;
                btnRepeatSong.Text = "Repeat song : ON";
            }
        }

        private void axWindowsMediaPlayer_PlayStateChange(object sender, _WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (e.newState == 10) // Ready
            {
                if (playlist_ended == true)
                {
                    ended = true;
                }
            }
            else if (e.newState == 1) // Stopped
            {
                if (playlist_ended == true && ended == true)
                {
                    playlist_ended = false;
                    axWindowsMediaPlayer.Ctlcontrols.play();
                }
            }
            else if (e.newState == 8) // Song End
            {
                ended = true;

                int song_index = lvSongs.SelectedIndices[0];
                int songs_count = lvSongs.Items.Count - 1;
                if (song_index == songs_count)
                {
                    playlist_ended = true;

                    axWindowsMediaPlayer.Ctlcontrols.play();
                }
            }
            else if (e.newState == 3) // Song start
            {
                if (repeat == true && ended == true)
                {
                    string name = lvSongs.SelectedItems[0].Text;

                    int song_index = lvSongs.SelectedIndices[0];

                    WMPLib.IWMPMedia media = axWindowsMediaPlayer.currentPlaylist.get_Item(song_index);
                    axWindowsMediaPlayer.Ctlcontrols.playItem(media);
                    axWindowsMediaPlayer.settings.autoStart = true;
                }
                else
                {                    
                    string fullpath_play = axWindowsMediaPlayer.currentMedia.sourceURL;

                    if(!fullpath_play.Contains(@"http://")) {
                        foreach (ListViewItem item in lvSongs.Items)
                        {

                            WMPLib.IWMPMedia media = axWindowsMediaPlayer.currentPlaylist.get_Item(item.Index);
                            string fullpath_check = media.sourceURL;

                            if (fullpath_check == fullpath_play)
                            {
                                lvSongs.SelectedItems.Clear();
                                lvSongs.Items[item.Index].Selected = true;
                            }
                        }
                    }
                    
                }

                ended = false;
            }
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            notifyIcon.Visible = false;
        }

        private void btnLoadDirectoryPlaylist_Click(object sender, EventArgs e)
        {
            var dialog = new System.Windows.Forms.FolderBrowserDialog();
            System.Windows.Forms.DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtDirectory.Text = dialog.SelectedPath;
            }
        }

        private void btnShowHotkeys_Click(object sender, EventArgs e)
        {
            string message = "F5 - Stop\n\nF6 - Previous\n\nF7 - Play / Pause\n\nF8 - Next\n\nF9 - Repeat";

            MessageBox.Show(message);
        }

        private void cbEnableHotkeys_CheckStateChanged(object sender, EventArgs e)
        {
            Configuration configuration = dataConfiguration.Get(1);

            if (cbEnableHotkeys.Checked == true)
            {
                configuration.Hotkeys = 1;
                tmDetectHotkeys.Enabled = true;
            }
            else
            {
                configuration.Hotkeys = 0;
                tmDetectHotkeys.Enabled = false;
            }

            dataConfiguration.Update(configuration);
        }

        private void btnSaveDirectory_Click(object sender, EventArgs e)
        {
            Configuration configuration = dataConfiguration.Get(1);
            configuration.Directory = txtDirectory.Text;
            dataConfiguration.Update(configuration);

            MaterialSnackBar SnackBarMessage = new MaterialSnackBar("Directory saved");
            SnackBarMessage.Show(this);
        }

        private void txtSearchPlaylist_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                generatePlaylists(true);

                if (txtSearchPlaylist.Text != "")
                {
                    lblStatus.Text = "[+] Playlists with text \"" + txtSearchPlaylist.Text + "\" loaded";
                    this.Refresh();
                }
            }
        }

        private void txtSearchSong_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                generatePlaylists(false);

                string directoryToScan = txtDirectory.Text;

                loadSongs(directoryToScan);

                if (txtSearchSong.Text != "")
                {
                    lblStatus.Text = "[+] Songs with text \"" + txtSearchSong.Text + "\" loaded";
                    this.Refresh();
                }
            }
        }

        private void btnImportsStations_Click(object sender, EventArgs e)
        {
            stop_player();
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            openFileDialog.Title = "Open JSON File";
            openFileDialog.DefaultExt = "json";
            openFileDialog.Filter = "JSON File (.json)|*.json";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                sendStatus("[+] Importing ...");
                string json_file = openFileDialog.FileName;
                ArrayList listStations = new ArrayList();
                string json_content = File.ReadAllText(json_file);
                DataTable dt = (DataTable)JsonConvert.DeserializeObject(json_content, (typeof(DataTable)));
                foreach (DataRow row in dt.Rows)
                {
                    Station station = new Station();
                    station.Name = Convert.ToString(row["name"]);
                    station.Link = Convert.ToString(row["link"]);
                    station.Categories = Convert.ToString(row["categories"]);
                    listStations.Add(station);
                }
                DataStation ds = new DataStation();
                foreach (Station station in listStations)
                {
                    ds.Add(station);
                }
                loadStations();
                sendStatus("[+] Done");

                MaterialSnackBar SnackBarMessage = new MaterialSnackBar("Table imported");
                SnackBarMessage.Show(this);
            }
        }

        private void btnExportStations_Click(object sender, EventArgs e)
        {
            stop_player();
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialog.Title = "Save JSON File";
            saveFileDialog.DefaultExt = "json";
            saveFileDialog.Filter = "JSON File (.json)|*.json";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string json_file = saveFileDialog.FileName;
                if (File.Exists(json_file))
                {
                    File.Delete(json_file);
                }
                DataAccess da = new DataAccess();
                sendStatus("[+] Exporting ...");
                DataTable dt = da.loadStationTable();
                string JSONString = string.Empty;
                JSONString = JsonConvert.SerializeObject(dt, Formatting.Indented);
                StreamWriter sw = File.CreateText(json_file);
                sw.Write(JSONString);
                sw.Close();
                sendStatus("[+] Done");

                MaterialSnackBar SnackBarMessage = new MaterialSnackBar("Table exported");
                SnackBarMessage.Show(this);
            }
        }

        private void btnValidateStations_Click(object sender, EventArgs e)
        {
            stop_player();
            ArrayList listStationsFail = new ArrayList();
            string message = "";

            foreach (ListViewItem item in lvStations.Items)
            {
                int id = Convert.ToInt32(item.SubItems[0].Text);
                string name = item.SubItems[1].Text;
                string link = item.SubItems[2].Text;

                Station station = new Station();

                station.Id = id;
                station.Name = name;
                station.Link = link;

                sendStatus("[+] Checking station : " + station.Name + " ...");

                if (!helper.check_url(station.Link))
                {
                    listStationsFail.Add(station);
                    message += "Radio name : " + station.Name + "\n";
                }
            }
            
            if (listStationsFail.Count > 0)
            {
                MaterialSnackBar SnackBarMessage = new MaterialSnackBar(message);
                SnackBarMessage.Show(this);

                MaterialDialog materialDialog = new MaterialDialog(this, program_title, "You want delete this stations ?", "OK", true, "Cancel");
                DialogResult result = materialDialog.ShowDialog(this);

                if (result.ToString() == "OK")
                {
                    DataStation dataStation = new DataStation();
                    foreach (Station station in listStationsFail)
                    {
                        dataStation.Delete(station.Id);
                    }
                }
            }
            else
            {
                MaterialSnackBar SnackBarMessage = new MaterialSnackBar("All stations works");
                SnackBarMessage.Show(this);
            }
            loadStations();
            sendStatus("[+] Done");
        }

        private void tmDetectHotkeys_Tick(object sender, EventArgs e)
        {
            if (GetAsyncKeyState(Keys.F5) == -32767)
            {
                sendStatus("[+] Hotkey stop executed");
                axWindowsMediaPlayer.Ctlcontrols.stop();
            }
            else if (GetAsyncKeyState(Keys.F6) == -32767)
            {
                sendStatus("[+] Hotkey previous executed");
                axWindowsMediaPlayer.Ctlcontrols.previous();
            }
            else if (GetAsyncKeyState(Keys.F7) == -32767)
            {
                if (axWindowsMediaPlayer.playState == WMPLib.WMPPlayState.wmppsPlaying)
                {
                    sendStatus("[+] Hotkey pause executed");
                    axWindowsMediaPlayer.Ctlcontrols.pause();
                }
                else
                {
                    sendStatus("[+] Hotkey play executed");
                    axWindowsMediaPlayer.Ctlcontrols.play();
                }
            }
            else if (GetAsyncKeyState(Keys.F8) == -32767)
            {
                sendStatus("[+] Hotkey next executed");
                axWindowsMediaPlayer.Ctlcontrols.next();
            }
            else if (GetAsyncKeyState(Keys.F9) == -32767)
            {
                sendStatus("[+] Hotkey repeat executed");
                repeat_song();
            }
        }

        private void miEdit_Click(object sender, EventArgs e)
        {
            if (!formStation.Visible)
            {
                stop_player();

                var id_station = Convert.ToInt32(lvStations.SelectedItems[0].Text);

                formStation = new FormStation(this, id_station);
                formStation.Show();
            }
        }
    
        private void miDelete_Click(object sender, EventArgs e)
        {
            MaterialDialog materialDialog = new MaterialDialog(this, program_title, "Are you sure ?", "OK", true, "Cancel");
            DialogResult result = materialDialog.ShowDialog(this);

            if (result.ToString() == "OK")
            {
                stop_player();

                var id_station = Convert.ToInt32(lvStations.SelectedItems[0].Text);

                DataStation dataStation = new DataStation();
                if (dataStation.Delete(id_station))
                {
                    MaterialSnackBar SnackBarMessage = new MaterialSnackBar("Station deleted");
                    SnackBarMessage.Show(this);
                }
                else
                {
                    MaterialSnackBar SnackBarMessage = new MaterialSnackBar("Error deleting station");
                    SnackBarMessage.Show(this);
                }
                loadStations();
            }
        }

        private void FormHome_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Visible = false;
                notifyIcon.Visible = true;
            }
        }

        private void FormHome_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (closing_app == false)
            {
                MaterialDialog materialDialog = new MaterialDialog(this, program_title, "Are you sure ?", "OK", true, "Cancel");
                DialogResult result = materialDialog.ShowDialog(this);

                if (result.ToString() != "OK")
                {
                    e.Cancel = true;
                    this.Activate();
                }
                else
                {
                    closing_app = true;
                    ClearTemporaryPlaylists();
                    System.Windows.Forms.Application.Exit();
                }
            }
        }

        private void lvStations_DoubleClick(object sender, EventArgs e)
        {
            if (lvStations.SelectedItems[0] != null)
            {
                string stream_url = lvStations.SelectedItems[0].SubItems[2].Text;
                axWindowsMediaPlayer.URL = stream_url;
            }
        }

        private void txtSearchStation_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                loadStations();
            }
        }
    }
}
