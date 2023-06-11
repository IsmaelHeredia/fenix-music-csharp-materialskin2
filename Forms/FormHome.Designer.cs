namespace FenixMusic
{
    partial class FormHome
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHome));
            this.tcOptions = new MaterialSkin.Controls.MaterialTabControl();
            this.tpMusic = new System.Windows.Forms.TabPage();
            this.mcSongs = new MaterialSkin.Controls.MaterialCard();
            this.lvSongs = new MaterialSkin.Controls.MaterialListView();
            this.chNameSong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtSearchSong = new MaterialSkin.Controls.MaterialTextBox();
            this.lblSongsSearch = new MaterialSkin.Controls.MaterialLabel();
            this.lblSongsCount = new MaterialSkin.Controls.MaterialLabel();
            this.mcPlaylist = new MaterialSkin.Controls.MaterialCard();
            this.lvPlaylists = new MaterialSkin.Controls.MaterialListView();
            this.chNamePlaylist = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtSearchPlaylist = new MaterialSkin.Controls.MaterialTextBox();
            this.lblSearchPlaylist = new MaterialSkin.Controls.MaterialLabel();
            this.lblPlaylistCount = new MaterialSkin.Controls.MaterialLabel();
            this.tpStations = new System.Windows.Forms.TabPage();
            this.mcStations = new MaterialSkin.Controls.MaterialCard();
            this.lvStations = new MaterialSkin.Controls.MaterialListView();
            this.chID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chLink = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chCategories = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmsOptionsStations = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.miEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.miDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddStation = new MaterialSkin.Controls.MaterialButton();
            this.txtSearchStation = new MaterialSkin.Controls.MaterialTextBox();
            this.lblSearchStation = new MaterialSkin.Controls.MaterialLabel();
            this.lblStationsCount = new MaterialSkin.Controls.MaterialLabel();
            this.tpSettings = new System.Windows.Forms.TabPage();
            this.materialCard3 = new MaterialSkin.Controls.MaterialCard();
            this.btnValidateStations = new MaterialSkin.Controls.MaterialButton();
            this.btnExportStations = new MaterialSkin.Controls.MaterialButton();
            this.btnImportsStations = new MaterialSkin.Controls.MaterialButton();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.btnGeneratePlaylists = new MaterialSkin.Controls.MaterialButton();
            this.btnSaveDirectory = new MaterialSkin.Controls.MaterialButton();
            this.btnLoadDirectoryPlaylist = new MaterialSkin.Controls.MaterialButton();
            this.txtDirectory = new MaterialSkin.Controls.MaterialTextBox();
            this.lblDirectory = new MaterialSkin.Controls.MaterialLabel();
            this.lblGeneratePlaylist = new MaterialSkin.Controls.MaterialLabel();
            this.mcConfiguration = new MaterialSkin.Controls.MaterialCard();
            this.btnShowHotkeys = new MaterialSkin.Controls.MaterialButton();
            this.cbEnableHotkeys = new MaterialSkin.Controls.MaterialCheckbox();
            this.lblConfiguration = new MaterialSkin.Controls.MaterialLabel();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.btnRepeatSong = new MaterialSkin.Controls.MaterialButton();
            this.btnFullScreen = new MaterialSkin.Controls.MaterialButton();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.tmDetectHotkeys = new System.Windows.Forms.Timer(this.components);
            this.lblStatus = new MaterialSkin.Controls.MaterialLabel();
            this.axWindowsMediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.tcOptions.SuspendLayout();
            this.tpMusic.SuspendLayout();
            this.mcSongs.SuspendLayout();
            this.mcPlaylist.SuspendLayout();
            this.tpStations.SuspendLayout();
            this.mcStations.SuspendLayout();
            this.cmsOptionsStations.SuspendLayout();
            this.tpSettings.SuspendLayout();
            this.materialCard3.SuspendLayout();
            this.materialCard2.SuspendLayout();
            this.mcConfiguration.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // tcOptions
            // 
            this.tcOptions.Controls.Add(this.tpMusic);
            this.tcOptions.Controls.Add(this.tpStations);
            this.tcOptions.Controls.Add(this.tpSettings);
            this.tcOptions.Depth = 0;
            this.tcOptions.Location = new System.Drawing.Point(6, 78);
            this.tcOptions.MouseState = MaterialSkin.MouseState.HOVER;
            this.tcOptions.Multiline = true;
            this.tcOptions.Name = "tcOptions";
            this.tcOptions.SelectedIndex = 0;
            this.tcOptions.Size = new System.Drawing.Size(852, 487);
            this.tcOptions.TabIndex = 0;
            // 
            // tpMusic
            // 
            this.tpMusic.Controls.Add(this.mcSongs);
            this.tpMusic.Controls.Add(this.mcPlaylist);
            this.tpMusic.Location = new System.Drawing.Point(4, 22);
            this.tpMusic.Name = "tpMusic";
            this.tpMusic.Padding = new System.Windows.Forms.Padding(3);
            this.tpMusic.Size = new System.Drawing.Size(844, 461);
            this.tpMusic.TabIndex = 0;
            this.tpMusic.Text = "Music";
            this.tpMusic.UseVisualStyleBackColor = true;
            // 
            // mcSongs
            // 
            this.mcSongs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mcSongs.Controls.Add(this.lvSongs);
            this.mcSongs.Controls.Add(this.txtSearchSong);
            this.mcSongs.Controls.Add(this.lblSongsSearch);
            this.mcSongs.Controls.Add(this.lblSongsCount);
            this.mcSongs.Depth = 0;
            this.mcSongs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mcSongs.Location = new System.Drawing.Point(428, 17);
            this.mcSongs.Margin = new System.Windows.Forms.Padding(14);
            this.mcSongs.MouseState = MaterialSkin.MouseState.HOVER;
            this.mcSongs.Name = "mcSongs";
            this.mcSongs.Padding = new System.Windows.Forms.Padding(14);
            this.mcSongs.Size = new System.Drawing.Size(395, 429);
            this.mcSongs.TabIndex = 1;
            // 
            // lvSongs
            // 
            this.lvSongs.AutoSizeTable = false;
            this.lvSongs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lvSongs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvSongs.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chNameSong});
            this.lvSongs.Depth = 0;
            this.lvSongs.FullRowSelect = true;
            this.lvSongs.HideSelection = false;
            this.lvSongs.Location = new System.Drawing.Point(20, 120);
            this.lvSongs.MinimumSize = new System.Drawing.Size(200, 100);
            this.lvSongs.MouseLocation = new System.Drawing.Point(-1, -1);
            this.lvSongs.MouseState = MaterialSkin.MouseState.OUT;
            this.lvSongs.Name = "lvSongs";
            this.lvSongs.OwnerDraw = true;
            this.lvSongs.Size = new System.Drawing.Size(358, 292);
            this.lvSongs.TabIndex = 3;
            this.lvSongs.UseCompatibleStateImageBehavior = false;
            this.lvSongs.View = System.Windows.Forms.View.Details;
            this.lvSongs.DoubleClick += new System.EventHandler(this.lvSongs_DoubleClick);
            // 
            // chNameSong
            // 
            this.chNameSong.Text = "Names";
            this.chNameSong.Width = 360;
            // 
            // txtSearchSong
            // 
            this.txtSearchSong.AnimateReadOnly = false;
            this.txtSearchSong.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearchSong.Depth = 0;
            this.txtSearchSong.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtSearchSong.LeadingIcon = null;
            this.txtSearchSong.Location = new System.Drawing.Point(141, 44);
            this.txtSearchSong.MaxLength = 50;
            this.txtSearchSong.MouseState = MaterialSkin.MouseState.OUT;
            this.txtSearchSong.Multiline = false;
            this.txtSearchSong.Name = "txtSearchSong";
            this.txtSearchSong.Size = new System.Drawing.Size(237, 50);
            this.txtSearchSong.TabIndex = 2;
            this.txtSearchSong.Text = "";
            this.txtSearchSong.TrailingIcon = null;
            this.txtSearchSong.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearchSong_KeyDown);
            // 
            // lblSongsSearch
            // 
            this.lblSongsSearch.AutoSize = true;
            this.lblSongsSearch.Depth = 0;
            this.lblSongsSearch.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblSongsSearch.Location = new System.Drawing.Point(17, 58);
            this.lblSongsSearch.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblSongsSearch.Name = "lblSongsSearch";
            this.lblSongsSearch.Size = new System.Drawing.Size(62, 19);
            this.lblSongsSearch.TabIndex = 1;
            this.lblSongsSearch.Text = "Search : ";
            // 
            // lblSongsCount
            // 
            this.lblSongsCount.AutoSize = true;
            this.lblSongsCount.Depth = 0;
            this.lblSongsCount.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblSongsCount.Location = new System.Drawing.Point(17, 14);
            this.lblSongsCount.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblSongsCount.Name = "lblSongsCount";
            this.lblSongsCount.Size = new System.Drawing.Size(113, 19);
            this.lblSongsCount.TabIndex = 0;
            this.lblSongsCount.Text = "Songs : 0 found";
            // 
            // mcPlaylist
            // 
            this.mcPlaylist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mcPlaylist.Controls.Add(this.lvPlaylists);
            this.mcPlaylist.Controls.Add(this.txtSearchPlaylist);
            this.mcPlaylist.Controls.Add(this.lblSearchPlaylist);
            this.mcPlaylist.Controls.Add(this.lblPlaylistCount);
            this.mcPlaylist.Depth = 0;
            this.mcPlaylist.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mcPlaylist.Location = new System.Drawing.Point(14, 17);
            this.mcPlaylist.Margin = new System.Windows.Forms.Padding(14);
            this.mcPlaylist.MouseState = MaterialSkin.MouseState.HOVER;
            this.mcPlaylist.Name = "mcPlaylist";
            this.mcPlaylist.Padding = new System.Windows.Forms.Padding(14);
            this.mcPlaylist.Size = new System.Drawing.Size(395, 429);
            this.mcPlaylist.TabIndex = 0;
            // 
            // lvPlaylists
            // 
            this.lvPlaylists.AutoSizeTable = false;
            this.lvPlaylists.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lvPlaylists.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvPlaylists.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chNamePlaylist});
            this.lvPlaylists.Depth = 0;
            this.lvPlaylists.FullRowSelect = true;
            this.lvPlaylists.HideSelection = false;
            this.lvPlaylists.Location = new System.Drawing.Point(20, 120);
            this.lvPlaylists.MinimumSize = new System.Drawing.Size(200, 100);
            this.lvPlaylists.MouseLocation = new System.Drawing.Point(-1, -1);
            this.lvPlaylists.MouseState = MaterialSkin.MouseState.OUT;
            this.lvPlaylists.Name = "lvPlaylists";
            this.lvPlaylists.OwnerDraw = true;
            this.lvPlaylists.Size = new System.Drawing.Size(358, 292);
            this.lvPlaylists.TabIndex = 3;
            this.lvPlaylists.UseCompatibleStateImageBehavior = false;
            this.lvPlaylists.View = System.Windows.Forms.View.Details;
            this.lvPlaylists.DoubleClick += new System.EventHandler(this.lvPlaylists_DoubleClick);
            // 
            // chNamePlaylist
            // 
            this.chNamePlaylist.Text = "Name";
            this.chNamePlaylist.Width = 350;
            // 
            // txtSearchPlaylist
            // 
            this.txtSearchPlaylist.AnimateReadOnly = false;
            this.txtSearchPlaylist.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearchPlaylist.Depth = 0;
            this.txtSearchPlaylist.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtSearchPlaylist.LeadingIcon = null;
            this.txtSearchPlaylist.Location = new System.Drawing.Point(141, 44);
            this.txtSearchPlaylist.MaxLength = 50;
            this.txtSearchPlaylist.MouseState = MaterialSkin.MouseState.OUT;
            this.txtSearchPlaylist.Multiline = false;
            this.txtSearchPlaylist.Name = "txtSearchPlaylist";
            this.txtSearchPlaylist.Size = new System.Drawing.Size(237, 50);
            this.txtSearchPlaylist.TabIndex = 2;
            this.txtSearchPlaylist.Text = "";
            this.txtSearchPlaylist.TrailingIcon = null;
            this.txtSearchPlaylist.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearchPlaylist_KeyDown);
            // 
            // lblSearchPlaylist
            // 
            this.lblSearchPlaylist.AutoSize = true;
            this.lblSearchPlaylist.Depth = 0;
            this.lblSearchPlaylist.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblSearchPlaylist.Location = new System.Drawing.Point(17, 58);
            this.lblSearchPlaylist.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblSearchPlaylist.Name = "lblSearchPlaylist";
            this.lblSearchPlaylist.Size = new System.Drawing.Size(62, 19);
            this.lblSearchPlaylist.TabIndex = 1;
            this.lblSearchPlaylist.Text = "Search : ";
            // 
            // lblPlaylistCount
            // 
            this.lblPlaylistCount.AutoSize = true;
            this.lblPlaylistCount.Depth = 0;
            this.lblPlaylistCount.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblPlaylistCount.Location = new System.Drawing.Point(17, 14);
            this.lblPlaylistCount.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPlaylistCount.Name = "lblPlaylistCount";
            this.lblPlaylistCount.Size = new System.Drawing.Size(128, 19);
            this.lblPlaylistCount.TabIndex = 0;
            this.lblPlaylistCount.Text = "Playlists : 0 found";
            // 
            // tpStations
            // 
            this.tpStations.Controls.Add(this.mcStations);
            this.tpStations.Location = new System.Drawing.Point(4, 22);
            this.tpStations.Name = "tpStations";
            this.tpStations.Padding = new System.Windows.Forms.Padding(3);
            this.tpStations.Size = new System.Drawing.Size(844, 461);
            this.tpStations.TabIndex = 1;
            this.tpStations.Text = "Stations";
            this.tpStations.UseVisualStyleBackColor = true;
            // 
            // mcStations
            // 
            this.mcStations.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mcStations.Controls.Add(this.lvStations);
            this.mcStations.Controls.Add(this.btnAddStation);
            this.mcStations.Controls.Add(this.txtSearchStation);
            this.mcStations.Controls.Add(this.lblSearchStation);
            this.mcStations.Controls.Add(this.lblStationsCount);
            this.mcStations.Depth = 0;
            this.mcStations.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mcStations.Location = new System.Drawing.Point(14, 17);
            this.mcStations.Margin = new System.Windows.Forms.Padding(14);
            this.mcStations.MouseState = MaterialSkin.MouseState.HOVER;
            this.mcStations.Name = "mcStations";
            this.mcStations.Padding = new System.Windows.Forms.Padding(14);
            this.mcStations.Size = new System.Drawing.Size(813, 427);
            this.mcStations.TabIndex = 0;
            // 
            // lvStations
            // 
            this.lvStations.AutoSizeTable = false;
            this.lvStations.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lvStations.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvStations.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chID,
            this.chName,
            this.chLink,
            this.chCategories});
            this.lvStations.ContextMenuStrip = this.cmsOptionsStations;
            this.lvStations.Depth = 0;
            this.lvStations.FullRowSelect = true;
            this.lvStations.HideSelection = false;
            this.lvStations.Location = new System.Drawing.Point(17, 119);
            this.lvStations.MinimumSize = new System.Drawing.Size(200, 100);
            this.lvStations.MouseLocation = new System.Drawing.Point(-1, -1);
            this.lvStations.MouseState = MaterialSkin.MouseState.OUT;
            this.lvStations.Name = "lvStations";
            this.lvStations.OwnerDraw = true;
            this.lvStations.Size = new System.Drawing.Size(766, 225);
            this.lvStations.TabIndex = 5;
            this.lvStations.UseCompatibleStateImageBehavior = false;
            this.lvStations.View = System.Windows.Forms.View.Details;
            this.lvStations.DoubleClick += new System.EventHandler(this.lvStations_DoubleClick);
            // 
            // chID
            // 
            this.chID.Text = "ID";
            // 
            // chName
            // 
            this.chName.Text = "Name";
            this.chName.Width = 300;
            // 
            // chLink
            // 
            this.chLink.Text = "Link";
            this.chLink.Width = 250;
            // 
            // chCategories
            // 
            this.chCategories.Text = "Categories";
            this.chCategories.Width = 150;
            // 
            // cmsOptionsStations
            // 
            this.cmsOptionsStations.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miEdit,
            this.miDelete});
            this.cmsOptionsStations.Name = "cmsOptionsStations";
            this.cmsOptionsStations.Size = new System.Drawing.Size(108, 48);
            // 
            // miEdit
            // 
            this.miEdit.Name = "miEdit";
            this.miEdit.Size = new System.Drawing.Size(107, 22);
            this.miEdit.Text = "Edit";
            this.miEdit.Click += new System.EventHandler(this.miEdit_Click);
            // 
            // miDelete
            // 
            this.miDelete.Name = "miDelete";
            this.miDelete.Size = new System.Drawing.Size(107, 22);
            this.miDelete.Text = "Delete";
            this.miDelete.Click += new System.EventHandler(this.miDelete_Click);
            // 
            // btnAddStation
            // 
            this.btnAddStation.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddStation.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAddStation.Depth = 0;
            this.btnAddStation.HighEmphasis = true;
            this.btnAddStation.Icon = null;
            this.btnAddStation.Location = new System.Drawing.Point(17, 371);
            this.btnAddStation.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAddStation.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAddStation.Name = "btnAddStation";
            this.btnAddStation.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAddStation.Size = new System.Drawing.Size(64, 36);
            this.btnAddStation.TabIndex = 4;
            this.btnAddStation.Text = "Add";
            this.btnAddStation.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAddStation.UseAccentColor = false;
            this.btnAddStation.UseVisualStyleBackColor = true;
            this.btnAddStation.Click += new System.EventHandler(this.btnAddStation_Click);
            // 
            // txtSearchStation
            // 
            this.txtSearchStation.AnimateReadOnly = false;
            this.txtSearchStation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearchStation.Depth = 0;
            this.txtSearchStation.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtSearchStation.LeadingIcon = null;
            this.txtSearchStation.Location = new System.Drawing.Point(141, 50);
            this.txtSearchStation.MaxLength = 50;
            this.txtSearchStation.MouseState = MaterialSkin.MouseState.OUT;
            this.txtSearchStation.Multiline = false;
            this.txtSearchStation.Name = "txtSearchStation";
            this.txtSearchStation.Size = new System.Drawing.Size(359, 50);
            this.txtSearchStation.TabIndex = 2;
            this.txtSearchStation.Text = "";
            this.txtSearchStation.TrailingIcon = null;
            this.txtSearchStation.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearchStation_KeyDown);
            // 
            // lblSearchStation
            // 
            this.lblSearchStation.AutoSize = true;
            this.lblSearchStation.Depth = 0;
            this.lblSearchStation.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblSearchStation.Location = new System.Drawing.Point(17, 64);
            this.lblSearchStation.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblSearchStation.Name = "lblSearchStation";
            this.lblSearchStation.Size = new System.Drawing.Size(62, 19);
            this.lblSearchStation.TabIndex = 1;
            this.lblSearchStation.Text = "Search : ";
            // 
            // lblStationsCount
            // 
            this.lblStationsCount.AutoSize = true;
            this.lblStationsCount.Depth = 0;
            this.lblStationsCount.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblStationsCount.Location = new System.Drawing.Point(17, 25);
            this.lblStationsCount.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblStationsCount.Name = "lblStationsCount";
            this.lblStationsCount.Size = new System.Drawing.Size(125, 19);
            this.lblStationsCount.TabIndex = 0;
            this.lblStationsCount.Text = "Stations count : 0";
            // 
            // tpSettings
            // 
            this.tpSettings.Controls.Add(this.materialCard3);
            this.tpSettings.Controls.Add(this.materialCard2);
            this.tpSettings.Controls.Add(this.mcConfiguration);
            this.tpSettings.Location = new System.Drawing.Point(4, 22);
            this.tpSettings.Name = "tpSettings";
            this.tpSettings.Size = new System.Drawing.Size(844, 461);
            this.tpSettings.TabIndex = 2;
            this.tpSettings.Text = "Settings";
            this.tpSettings.UseVisualStyleBackColor = true;
            // 
            // materialCard3
            // 
            this.materialCard3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard3.Controls.Add(this.btnValidateStations);
            this.materialCard3.Controls.Add(this.btnExportStations);
            this.materialCard3.Controls.Add(this.btnImportsStations);
            this.materialCard3.Depth = 0;
            this.materialCard3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard3.Location = new System.Drawing.Point(14, 336);
            this.materialCard3.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard3.Name = "materialCard3";
            this.materialCard3.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard3.Size = new System.Drawing.Size(816, 100);
            this.materialCard3.TabIndex = 2;
            // 
            // btnValidateStations
            // 
            this.btnValidateStations.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnValidateStations.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnValidateStations.Depth = 0;
            this.btnValidateStations.HighEmphasis = true;
            this.btnValidateStations.Icon = null;
            this.btnValidateStations.Location = new System.Drawing.Point(383, 32);
            this.btnValidateStations.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnValidateStations.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnValidateStations.Name = "btnValidateStations";
            this.btnValidateStations.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnValidateStations.Size = new System.Drawing.Size(163, 36);
            this.btnValidateStations.TabIndex = 2;
            this.btnValidateStations.Text = "Validate stations";
            this.btnValidateStations.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnValidateStations.UseAccentColor = false;
            this.btnValidateStations.UseVisualStyleBackColor = true;
            this.btnValidateStations.Click += new System.EventHandler(this.btnValidateStations_Click);
            // 
            // btnExportStations
            // 
            this.btnExportStations.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnExportStations.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnExportStations.Depth = 0;
            this.btnExportStations.HighEmphasis = true;
            this.btnExportStations.Icon = null;
            this.btnExportStations.Location = new System.Drawing.Point(204, 32);
            this.btnExportStations.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnExportStations.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnExportStations.Name = "btnExportStations";
            this.btnExportStations.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnExportStations.Size = new System.Drawing.Size(150, 36);
            this.btnExportStations.TabIndex = 1;
            this.btnExportStations.Text = "Export stations";
            this.btnExportStations.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnExportStations.UseAccentColor = false;
            this.btnExportStations.UseVisualStyleBackColor = true;
            this.btnExportStations.Click += new System.EventHandler(this.btnExportStations_Click);
            // 
            // btnImportsStations
            // 
            this.btnImportsStations.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnImportsStations.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnImportsStations.Depth = 0;
            this.btnImportsStations.HighEmphasis = true;
            this.btnImportsStations.Icon = null;
            this.btnImportsStations.Location = new System.Drawing.Point(31, 32);
            this.btnImportsStations.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnImportsStations.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnImportsStations.Name = "btnImportsStations";
            this.btnImportsStations.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnImportsStations.Size = new System.Drawing.Size(150, 36);
            this.btnImportsStations.TabIndex = 0;
            this.btnImportsStations.Text = "Import stations";
            this.btnImportsStations.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnImportsStations.UseAccentColor = false;
            this.btnImportsStations.UseVisualStyleBackColor = true;
            this.btnImportsStations.Click += new System.EventHandler(this.btnImportsStations_Click);
            // 
            // materialCard2
            // 
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.btnGeneratePlaylists);
            this.materialCard2.Controls.Add(this.btnSaveDirectory);
            this.materialCard2.Controls.Add(this.btnLoadDirectoryPlaylist);
            this.materialCard2.Controls.Add(this.txtDirectory);
            this.materialCard2.Controls.Add(this.lblDirectory);
            this.materialCard2.Controls.Add(this.lblGeneratePlaylist);
            this.materialCard2.Depth = 0;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(14, 150);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard2.Size = new System.Drawing.Size(816, 174);
            this.materialCard2.TabIndex = 1;
            // 
            // btnGeneratePlaylists
            // 
            this.btnGeneratePlaylists.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGeneratePlaylists.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnGeneratePlaylists.Depth = 0;
            this.btnGeneratePlaylists.HighEmphasis = true;
            this.btnGeneratePlaylists.Icon = null;
            this.btnGeneratePlaylists.Location = new System.Drawing.Point(383, 121);
            this.btnGeneratePlaylists.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnGeneratePlaylists.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGeneratePlaylists.Name = "btnGeneratePlaylists";
            this.btnGeneratePlaylists.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnGeneratePlaylists.Size = new System.Drawing.Size(174, 36);
            this.btnGeneratePlaylists.TabIndex = 5;
            this.btnGeneratePlaylists.Text = "Generate playlists";
            this.btnGeneratePlaylists.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnGeneratePlaylists.UseAccentColor = false;
            this.btnGeneratePlaylists.UseVisualStyleBackColor = true;
            this.btnGeneratePlaylists.Click += new System.EventHandler(this.btnGeneratePlaylists_Click);
            // 
            // btnSaveDirectory
            // 
            this.btnSaveDirectory.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSaveDirectory.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSaveDirectory.Depth = 0;
            this.btnSaveDirectory.HighEmphasis = true;
            this.btnSaveDirectory.Icon = null;
            this.btnSaveDirectory.Location = new System.Drawing.Point(204, 121);
            this.btnSaveDirectory.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSaveDirectory.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSaveDirectory.Name = "btnSaveDirectory";
            this.btnSaveDirectory.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSaveDirectory.Size = new System.Drawing.Size(140, 36);
            this.btnSaveDirectory.TabIndex = 4;
            this.btnSaveDirectory.Text = "Save directory";
            this.btnSaveDirectory.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSaveDirectory.UseAccentColor = false;
            this.btnSaveDirectory.UseVisualStyleBackColor = true;
            this.btnSaveDirectory.Click += new System.EventHandler(this.btnSaveDirectory_Click);
            // 
            // btnLoadDirectoryPlaylist
            // 
            this.btnLoadDirectoryPlaylist.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLoadDirectoryPlaylist.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnLoadDirectoryPlaylist.Depth = 0;
            this.btnLoadDirectoryPlaylist.HighEmphasis = true;
            this.btnLoadDirectoryPlaylist.Icon = null;
            this.btnLoadDirectoryPlaylist.Location = new System.Drawing.Point(628, 54);
            this.btnLoadDirectoryPlaylist.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnLoadDirectoryPlaylist.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLoadDirectoryPlaylist.Name = "btnLoadDirectoryPlaylist";
            this.btnLoadDirectoryPlaylist.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnLoadDirectoryPlaylist.Size = new System.Drawing.Size(64, 36);
            this.btnLoadDirectoryPlaylist.TabIndex = 3;
            this.btnLoadDirectoryPlaylist.Text = "...";
            this.btnLoadDirectoryPlaylist.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnLoadDirectoryPlaylist.UseAccentColor = false;
            this.btnLoadDirectoryPlaylist.UseVisualStyleBackColor = true;
            this.btnLoadDirectoryPlaylist.Click += new System.EventHandler(this.btnLoadDirectoryPlaylist_Click);
            // 
            // txtDirectory
            // 
            this.txtDirectory.AnimateReadOnly = false;
            this.txtDirectory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDirectory.Depth = 0;
            this.txtDirectory.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtDirectory.LeadingIcon = null;
            this.txtDirectory.Location = new System.Drawing.Point(151, 51);
            this.txtDirectory.MaxLength = 50;
            this.txtDirectory.MouseState = MaterialSkin.MouseState.OUT;
            this.txtDirectory.Multiline = false;
            this.txtDirectory.Name = "txtDirectory";
            this.txtDirectory.Size = new System.Drawing.Size(447, 50);
            this.txtDirectory.TabIndex = 2;
            this.txtDirectory.Text = "";
            this.txtDirectory.TrailingIcon = null;
            // 
            // lblDirectory
            // 
            this.lblDirectory.AutoSize = true;
            this.lblDirectory.Depth = 0;
            this.lblDirectory.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblDirectory.Location = new System.Drawing.Point(28, 64);
            this.lblDirectory.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDirectory.Name = "lblDirectory";
            this.lblDirectory.Size = new System.Drawing.Size(76, 19);
            this.lblDirectory.TabIndex = 1;
            this.lblDirectory.Text = "Directory : ";
            // 
            // lblGeneratePlaylist
            // 
            this.lblGeneratePlaylist.AutoSize = true;
            this.lblGeneratePlaylist.Depth = 0;
            this.lblGeneratePlaylist.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblGeneratePlaylist.Location = new System.Drawing.Point(349, 14);
            this.lblGeneratePlaylist.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblGeneratePlaylist.Name = "lblGeneratePlaylist";
            this.lblGeneratePlaylist.Size = new System.Drawing.Size(119, 19);
            this.lblGeneratePlaylist.TabIndex = 0;
            this.lblGeneratePlaylist.Text = "Generate playlist";
            // 
            // mcConfiguration
            // 
            this.mcConfiguration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mcConfiguration.Controls.Add(this.btnShowHotkeys);
            this.mcConfiguration.Controls.Add(this.cbEnableHotkeys);
            this.mcConfiguration.Controls.Add(this.lblConfiguration);
            this.mcConfiguration.Depth = 0;
            this.mcConfiguration.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mcConfiguration.Location = new System.Drawing.Point(14, 14);
            this.mcConfiguration.Margin = new System.Windows.Forms.Padding(14);
            this.mcConfiguration.MouseState = MaterialSkin.MouseState.HOVER;
            this.mcConfiguration.Name = "mcConfiguration";
            this.mcConfiguration.Padding = new System.Windows.Forms.Padding(14);
            this.mcConfiguration.Size = new System.Drawing.Size(816, 123);
            this.mcConfiguration.TabIndex = 0;
            // 
            // btnShowHotkeys
            // 
            this.btnShowHotkeys.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnShowHotkeys.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnShowHotkeys.Depth = 0;
            this.btnShowHotkeys.HighEmphasis = true;
            this.btnShowHotkeys.Icon = null;
            this.btnShowHotkeys.Location = new System.Drawing.Point(225, 60);
            this.btnShowHotkeys.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnShowHotkeys.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnShowHotkeys.Name = "btnShowHotkeys";
            this.btnShowHotkeys.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnShowHotkeys.Size = new System.Drawing.Size(133, 36);
            this.btnShowHotkeys.TabIndex = 2;
            this.btnShowHotkeys.Text = "Show hotkeys";
            this.btnShowHotkeys.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnShowHotkeys.UseAccentColor = false;
            this.btnShowHotkeys.UseVisualStyleBackColor = true;
            this.btnShowHotkeys.Click += new System.EventHandler(this.btnShowHotkeys_Click);
            // 
            // cbEnableHotkeys
            // 
            this.cbEnableHotkeys.AutoSize = true;
            this.cbEnableHotkeys.Depth = 0;
            this.cbEnableHotkeys.Location = new System.Drawing.Point(14, 59);
            this.cbEnableHotkeys.Margin = new System.Windows.Forms.Padding(0);
            this.cbEnableHotkeys.MouseLocation = new System.Drawing.Point(-1, -1);
            this.cbEnableHotkeys.MouseState = MaterialSkin.MouseState.HOVER;
            this.cbEnableHotkeys.Name = "cbEnableHotkeys";
            this.cbEnableHotkeys.ReadOnly = false;
            this.cbEnableHotkeys.Ripple = true;
            this.cbEnableHotkeys.Size = new System.Drawing.Size(142, 37);
            this.cbEnableHotkeys.TabIndex = 1;
            this.cbEnableHotkeys.Text = "Enable hotkeys";
            this.cbEnableHotkeys.UseVisualStyleBackColor = true;
            this.cbEnableHotkeys.CheckStateChanged += new System.EventHandler(this.cbEnableHotkeys_CheckStateChanged);
            // 
            // lblConfiguration
            // 
            this.lblConfiguration.AutoSize = true;
            this.lblConfiguration.Depth = 0;
            this.lblConfiguration.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblConfiguration.Location = new System.Drawing.Point(349, 14);
            this.lblConfiguration.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblConfiguration.Name = "lblConfiguration";
            this.lblConfiguration.Size = new System.Drawing.Size(98, 19);
            this.lblConfiguration.TabIndex = 0;
            this.lblConfiguration.Text = "Configuration";
            // 
            // pbLogo
            // 
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(10, 571);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(190, 119);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 1;
            this.pbLogo.TabStop = false;
            // 
            // btnRepeatSong
            // 
            this.btnRepeatSong.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRepeatSong.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnRepeatSong.Depth = 0;
            this.btnRepeatSong.HighEmphasis = true;
            this.btnRepeatSong.Icon = null;
            this.btnRepeatSong.Location = new System.Drawing.Point(210, 654);
            this.btnRepeatSong.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnRepeatSong.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRepeatSong.Name = "btnRepeatSong";
            this.btnRepeatSong.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnRepeatSong.Size = new System.Drawing.Size(150, 36);
            this.btnRepeatSong.TabIndex = 3;
            this.btnRepeatSong.Text = "Repeat song : ON";
            this.btnRepeatSong.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnRepeatSong.UseAccentColor = false;
            this.btnRepeatSong.UseVisualStyleBackColor = true;
            this.btnRepeatSong.Click += new System.EventHandler(this.btnRepeatSong_Click);
            // 
            // btnFullScreen
            // 
            this.btnFullScreen.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnFullScreen.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnFullScreen.Depth = 0;
            this.btnFullScreen.HighEmphasis = true;
            this.btnFullScreen.Icon = null;
            this.btnFullScreen.Location = new System.Drawing.Point(376, 654);
            this.btnFullScreen.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnFullScreen.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnFullScreen.Name = "btnFullScreen";
            this.btnFullScreen.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnFullScreen.Size = new System.Drawing.Size(110, 36);
            this.btnFullScreen.TabIndex = 4;
            this.btnFullScreen.Text = "Fullscreen";
            this.btnFullScreen.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnFullScreen.UseAccentColor = false;
            this.btnFullScreen.UseVisualStyleBackColor = true;
            this.btnFullScreen.Click += new System.EventHandler(this.btnFullScreen_Click);
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Fenix Music 1.3";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // tmDetectHotkeys
            // 
            this.tmDetectHotkeys.Tick += new System.EventHandler(this.tmDetectHotkeys_Tick);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Depth = 0;
            this.lblStatus.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblStatus.Location = new System.Drawing.Point(21, 714);
            this.lblStatus.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(117, 19);
            this.lblStatus.TabIndex = 5;
            this.lblStatus.Text = "[+] Music loaded";
            // 
            // axWindowsMediaPlayer
            // 
            this.axWindowsMediaPlayer.Enabled = true;
            this.axWindowsMediaPlayer.Location = new System.Drawing.Point(210, 571);
            this.axWindowsMediaPlayer.Name = "axWindowsMediaPlayer";
            this.axWindowsMediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer.OcxState")));
            this.axWindowsMediaPlayer.Size = new System.Drawing.Size(648, 69);
            this.axWindowsMediaPlayer.TabIndex = 2;
            this.axWindowsMediaPlayer.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.axWindowsMediaPlayer_PlayStateChange);
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 754);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnFullScreen);
            this.Controls.Add(this.btnRepeatSong);
            this.Controls.Add(this.axWindowsMediaPlayer);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.tcOptions);
            this.DrawerTabControl = this.tcOptions;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormHome";
            this.Text = "Fenix Music 1.3";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormHome_FormClosing);
            this.Load += new System.EventHandler(this.FormHome_Load);
            this.Resize += new System.EventHandler(this.FormHome_Resize);
            this.tcOptions.ResumeLayout(false);
            this.tpMusic.ResumeLayout(false);
            this.mcSongs.ResumeLayout(false);
            this.mcSongs.PerformLayout();
            this.mcPlaylist.ResumeLayout(false);
            this.mcPlaylist.PerformLayout();
            this.tpStations.ResumeLayout(false);
            this.mcStations.ResumeLayout(false);
            this.mcStations.PerformLayout();
            this.cmsOptionsStations.ResumeLayout(false);
            this.tpSettings.ResumeLayout(false);
            this.materialCard3.ResumeLayout(false);
            this.materialCard3.PerformLayout();
            this.materialCard2.ResumeLayout(false);
            this.materialCard2.PerformLayout();
            this.mcConfiguration.ResumeLayout(false);
            this.mcConfiguration.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl tcOptions;
        private System.Windows.Forms.TabPage tpMusic;
        private System.Windows.Forms.TabPage tpStations;
        private System.Windows.Forms.TabPage tpSettings;
        private MaterialSkin.Controls.MaterialCard mcPlaylist;
        private MaterialSkin.Controls.MaterialListView lvPlaylists;
        private System.Windows.Forms.ColumnHeader chNamePlaylist;
        private MaterialSkin.Controls.MaterialTextBox txtSearchPlaylist;
        private MaterialSkin.Controls.MaterialLabel lblSearchPlaylist;
        private MaterialSkin.Controls.MaterialLabel lblPlaylistCount;
        private MaterialSkin.Controls.MaterialCard mcSongs;
        private MaterialSkin.Controls.MaterialListView lvSongs;
        private MaterialSkin.Controls.MaterialTextBox txtSearchSong;
        private MaterialSkin.Controls.MaterialLabel lblSongsSearch;
        private MaterialSkin.Controls.MaterialLabel lblSongsCount;
        private System.Windows.Forms.PictureBox pbLogo;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer;
        private MaterialSkin.Controls.MaterialButton btnRepeatSong;
        private MaterialSkin.Controls.MaterialButton btnFullScreen;
        private MaterialSkin.Controls.MaterialCard mcStations;
        private MaterialSkin.Controls.MaterialButton btnAddStation;
        private MaterialSkin.Controls.MaterialTextBox txtSearchStation;
        private MaterialSkin.Controls.MaterialLabel lblSearchStation;
        private MaterialSkin.Controls.MaterialLabel lblStationsCount;
        private MaterialSkin.Controls.MaterialCard materialCard3;
        private MaterialSkin.Controls.MaterialButton btnValidateStations;
        private MaterialSkin.Controls.MaterialButton btnExportStations;
        private MaterialSkin.Controls.MaterialButton btnImportsStations;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private MaterialSkin.Controls.MaterialButton btnGeneratePlaylists;
        private MaterialSkin.Controls.MaterialButton btnSaveDirectory;
        private MaterialSkin.Controls.MaterialButton btnLoadDirectoryPlaylist;
        private MaterialSkin.Controls.MaterialTextBox txtDirectory;
        private MaterialSkin.Controls.MaterialLabel lblDirectory;
        private MaterialSkin.Controls.MaterialLabel lblGeneratePlaylist;
        private MaterialSkin.Controls.MaterialCard mcConfiguration;
        private MaterialSkin.Controls.MaterialButton btnShowHotkeys;
        private MaterialSkin.Controls.MaterialCheckbox cbEnableHotkeys;
        private MaterialSkin.Controls.MaterialLabel lblConfiguration;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.Timer tmDetectHotkeys;
        private System.Windows.Forms.ContextMenuStrip cmsOptionsStations;
        private System.Windows.Forms.ToolStripMenuItem miEdit;
        private System.Windows.Forms.ToolStripMenuItem miDelete;
        private MaterialSkin.Controls.MaterialLabel lblStatus;
        private System.Windows.Forms.ColumnHeader chNameSong;
        private MaterialSkin.Controls.MaterialListView lvStations;
        private System.Windows.Forms.ColumnHeader chID;
        private System.Windows.Forms.ColumnHeader chName;
        private System.Windows.Forms.ColumnHeader chLink;
        private System.Windows.Forms.ColumnHeader chCategories;
    }
}

