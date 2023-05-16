namespace Course
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.miFile = new System.Windows.Forms.ToolStripMenuItem();
            this.miOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.miSave = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.miImport = new System.Windows.Forms.ToolStripMenuItem();
            this.miExport = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.miAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.miExit = new System.Windows.Forms.ToolStripMenuItem();
            this.miBook = new System.Windows.Forms.ToolStripMenuItem();
            this.niAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.miEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.miDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.miClear = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.miFilter = new System.Windows.Forms.ToolStripMenuItem();
            this.toolBar = new System.Windows.Forms.ToolStrip();
            this.btnAdd = new System.Windows.Forms.ToolStripButton();
            this.btnEdit = new System.Windows.Forms.ToolStripButton();
            this.tsSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnDel = new System.Windows.Forms.ToolStripButton();
            this.btnClear = new System.Windows.Forms.ToolStripButton();
            this.tsSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnOpenFromBinary = new System.Windows.Forms.ToolStripButton();
            this.btnSaveAsBinary = new System.Windows.Forms.ToolStripButton();
            this.tsSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnOpenFromText = new System.Windows.Forms.ToolStripButton();
            this.btnSaveAsText = new System.Windows.Forms.ToolStripButton();
            this.tsSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btnFilter = new System.Windows.Forms.ToolStripButton();
            this.tslSortBy = new System.Windows.Forms.ToolStripLabel();
            this.tslcbSortBy = new System.Windows.Forms.ToolStripComboBox();
            this.tslFind = new System.Windows.Forms.ToolStripLabel();
            this.tsltbSearch = new System.Windows.Forms.ToolStripTextBox();
            this.btnExit = new System.Windows.Forms.ToolStripButton();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.tsslFileName = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslRating = new System.Windows.Forms.ToolStripStatusLabel();
            this.gvBooks = new System.Windows.Forms.DataGridView();
            this.cmsMenuDataGrid = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mictAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.mictEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.mictDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.mictExit = new System.Windows.Forms.ToolStripMenuItem();
            this.bindScrBooks = new System.Windows.Forms.BindingSource(this.components);
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.menuMain.SuspendLayout();
            this.toolBar.SuspendLayout();
            this.statusBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvBooks)).BeginInit();
            this.cmsMenuDataGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindScrBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // menuMain
            // 
            this.menuMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miFile,
            this.miBook});
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.Name = "menuMain";
            this.menuMain.Size = new System.Drawing.Size(800, 28);
            this.menuMain.TabIndex = 0;
            this.menuMain.Text = "menuStrip1";
            // 
            // miFile
            // 
            this.miFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miOpen,
            this.miSave,
            this.toolStripSeparator1,
            this.miImport,
            this.miExport,
            this.toolStripSeparator2,
            this.miAbout,
            this.toolStripSeparator3,
            this.miExit});
            this.miFile.Name = "miFile";
            this.miFile.Size = new System.Drawing.Size(59, 24);
            this.miFile.Text = "&Файл";
            // 
            // miOpen
            // 
            this.miOpen.Image = ((System.Drawing.Image)(resources.GetObject("miOpen.Image")));
            this.miOpen.Name = "miOpen";
            this.miOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.miOpen.Size = new System.Drawing.Size(232, 26);
            this.miOpen.Text = "Відкрити...";
            // 
            // miSave
            // 
            this.miSave.Image = ((System.Drawing.Image)(resources.GetObject("miSave.Image")));
            this.miSave.Name = "miSave";
            this.miSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.miSave.Size = new System.Drawing.Size(232, 26);
            this.miSave.Text = "Зберегти...";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(229, 6);
            // 
            // miImport
            // 
            this.miImport.Image = ((System.Drawing.Image)(resources.GetObject("miImport.Image")));
            this.miImport.Name = "miImport";
            this.miImport.Size = new System.Drawing.Size(232, 26);
            this.miImport.Text = "Імпортувати текст...";
            // 
            // miExport
            // 
            this.miExport.Image = ((System.Drawing.Image)(resources.GetObject("miExport.Image")));
            this.miExport.Name = "miExport";
            this.miExport.Size = new System.Drawing.Size(232, 26);
            this.miExport.Text = "Експортувати текст...";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(229, 6);
            // 
            // miAbout
            // 
            this.miAbout.Image = ((System.Drawing.Image)(resources.GetObject("miAbout.Image")));
            this.miAbout.Name = "miAbout";
            this.miAbout.Size = new System.Drawing.Size(232, 26);
            this.miAbout.Text = "Про програму";
            this.miAbout.Click += new System.EventHandler(this.miAbout_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(229, 6);
            // 
            // miExit
            // 
            this.miExit.Image = ((System.Drawing.Image)(resources.GetObject("miExit.Image")));
            this.miExit.Name = "miExit";
            this.miExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.X)));
            this.miExit.Size = new System.Drawing.Size(232, 26);
            this.miExit.Text = "Вихід";
            // 
            // miBook
            // 
            this.miBook.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.niAdd,
            this.miEdit,
            this.toolStripSeparator4,
            this.miDelete,
            this.miClear,
            this.toolStripSeparator5,
            this.miFilter});
            this.miBook.Name = "miBook";
            this.miBook.Size = new System.Drawing.Size(64, 24);
            this.miBook.Text = "&Книга";
            // 
            // niAdd
            // 
            this.niAdd.Name = "niAdd";
            this.niAdd.Size = new System.Drawing.Size(185, 26);
            this.niAdd.Text = "Додати...";
            // 
            // miEdit
            // 
            this.miEdit.Name = "miEdit";
            this.miEdit.Size = new System.Drawing.Size(185, 26);
            this.miEdit.Text = "Змінити...";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(182, 6);
            // 
            // miDelete
            // 
            this.miDelete.Name = "miDelete";
            this.miDelete.Size = new System.Drawing.Size(185, 26);
            this.miDelete.Text = "Видалити";
            // 
            // miClear
            // 
            this.miClear.Name = "miClear";
            this.miClear.Size = new System.Drawing.Size(185, 26);
            this.miClear.Text = "Очистити всі";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(182, 6);
            // 
            // miFilter
            // 
            this.miFilter.Name = "miFilter";
            this.miFilter.Size = new System.Drawing.Size(185, 26);
            this.miFilter.Text = "Фільтрувати...";
            // 
            // toolBar
            // 
            this.toolBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAdd,
            this.btnEdit,
            this.tsSeparator1,
            this.btnDel,
            this.btnClear,
            this.tsSeparator2,
            this.btnOpenFromBinary,
            this.btnSaveAsBinary,
            this.tsSeparator3,
            this.btnOpenFromText,
            this.btnSaveAsText,
            this.tsSeparator4,
            this.btnFilter,
            this.tslSortBy,
            this.tslcbSortBy,
            this.tslFind,
            this.tsltbSearch,
            this.btnExit});
            this.toolBar.Location = new System.Drawing.Point(0, 28);
            this.toolBar.Name = "toolBar";
            this.toolBar.Size = new System.Drawing.Size(800, 28);
            this.toolBar.TabIndex = 1;
            this.toolBar.Text = "toolStrip1";
            // 
            // btnAdd
            // 
            this.btnAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(29, 25);
            this.btnAdd.Text = "Додати запис про книгу";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(29, 25);
            this.btnEdit.Text = "Редарувати запис";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // tsSeparator1
            // 
            this.tsSeparator1.Name = "tsSeparator1";
            this.tsSeparator1.Size = new System.Drawing.Size(6, 28);
            // 
            // btnDel
            // 
            this.btnDel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDel.Image = ((System.Drawing.Image)(resources.GetObject("btnDel.Image")));
            this.btnDel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(29, 25);
            this.btnDel.Text = "Видалити запис";
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnClear
            // 
            this.btnClear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnClear.Image = ((System.Drawing.Image)(resources.GetObject("btnClear.Image")));
            this.btnClear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(29, 25);
            this.btnClear.Text = "Очистити дані";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // tsSeparator2
            // 
            this.tsSeparator2.Name = "tsSeparator2";
            this.tsSeparator2.Size = new System.Drawing.Size(6, 28);
            // 
            // btnOpenFromBinary
            // 
            this.btnOpenFromBinary.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnOpenFromBinary.Image = ((System.Drawing.Image)(resources.GetObject("btnOpenFromBinary.Image")));
            this.btnOpenFromBinary.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOpenFromBinary.Name = "btnOpenFromBinary";
            this.btnOpenFromBinary.Size = new System.Drawing.Size(29, 25);
            this.btnOpenFromBinary.Text = "Завантажити з бінорного формату";
            this.btnOpenFromBinary.Click += new System.EventHandler(this.btnOpenFromBinary_Click);
            // 
            // btnSaveAsBinary
            // 
            this.btnSaveAsBinary.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSaveAsBinary.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveAsBinary.Image")));
            this.btnSaveAsBinary.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSaveAsBinary.Name = "btnSaveAsBinary";
            this.btnSaveAsBinary.Size = new System.Drawing.Size(29, 25);
            this.btnSaveAsBinary.Text = "Зберегти у бінарному форматі";
            this.btnSaveAsBinary.Click += new System.EventHandler(this.btnSaveAsBinary_Click);
            // 
            // tsSeparator3
            // 
            this.tsSeparator3.Name = "tsSeparator3";
            this.tsSeparator3.Size = new System.Drawing.Size(6, 28);
            // 
            // btnOpenFromText
            // 
            this.btnOpenFromText.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnOpenFromText.Image = ((System.Drawing.Image)(resources.GetObject("btnOpenFromText.Image")));
            this.btnOpenFromText.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOpenFromText.Name = "btnOpenFromText";
            this.btnOpenFromText.Size = new System.Drawing.Size(29, 25);
            this.btnOpenFromText.Text = "Завантажити з текстового файлу";
            this.btnOpenFromText.Click += new System.EventHandler(this.btnOpenFromText_Click);
            // 
            // btnSaveAsText
            // 
            this.btnSaveAsText.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSaveAsText.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveAsText.Image")));
            this.btnSaveAsText.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSaveAsText.Name = "btnSaveAsText";
            this.btnSaveAsText.Size = new System.Drawing.Size(29, 25);
            this.btnSaveAsText.Text = "Зберегти у текстовому форматі";
            this.btnSaveAsText.Click += new System.EventHandler(this.btnSaveAsText_Click);
            // 
            // tsSeparator4
            // 
            this.tsSeparator4.Name = "tsSeparator4";
            this.tsSeparator4.Size = new System.Drawing.Size(6, 28);
            // 
            // btnFilter
            // 
            this.btnFilter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnFilter.Image = ((System.Drawing.Image)(resources.GetObject("btnFilter.Image")));
            this.btnFilter.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(29, 25);
            this.btnFilter.Text = "Фільтрування даних";
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // tslSortBy
            // 
            this.tslSortBy.Name = "tslSortBy";
            this.tslSortBy.Size = new System.Drawing.Size(102, 25);
            this.tslSortBy.Text = "Сортувати за:";
            // 
            // tslcbSortBy
            // 
            this.tslcbSortBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tslcbSortBy.Items.AddRange(new object[] {
            "Id",
            "Назвою",
            "Автором",
            "Роком випуску",
            "Жанром",
            "Рейтингом"});
            this.tslcbSortBy.Name = "tslcbSortBy";
            this.tslcbSortBy.Size = new System.Drawing.Size(90, 28);
            this.tslcbSortBy.SelectedIndexChanged += new System.EventHandler(this.tslcbSortBy_SelectedIndexChanged);
            this.tslcbSortBy.Click += new System.EventHandler(this.tslcbSortBy_Click);
            // 
            // tslFind
            // 
            this.tslFind.Name = "tslFind";
            this.tslFind.Size = new System.Drawing.Size(61, 25);
            this.tslFind.Text = "Знайти:";
            // 
            // tsltbSearch
            // 
            this.tsltbSearch.Name = "tsltbSearch";
            this.tsltbSearch.Size = new System.Drawing.Size(100, 28);
            this.tsltbSearch.TextChanged += new System.EventHandler(this.tsltbSearch_TextChanged);
            // 
            // btnExit
            // 
            this.btnExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(29, 25);
            this.btnExit.Text = "Вийти з програми";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // statusBar
            // 
            this.statusBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslFileName,
            this.tsslRating});
            this.statusBar.Location = new System.Drawing.Point(0, 424);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(800, 26);
            this.statusBar.TabIndex = 2;
            this.statusBar.Text = "statusStrip1";
            // 
            // tsslFileName
            // 
            this.tsslFileName.AutoSize = false;
            this.tsslFileName.Name = "tsslFileName";
            this.tsslFileName.Size = new System.Drawing.Size(151, 20);
            this.tsslFileName.Text = "toolStripStatusLabel1";
            this.tsslFileName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tsslRating
            // 
            this.tsslRating.AutoSize = false;
            this.tsslRating.Name = "tsslRating";
            this.tsslRating.Size = new System.Drawing.Size(200, 20);
            this.tsslRating.Text = "toolStripStatusLabel2";
            this.tsslRating.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gvBooks
            // 
            this.gvBooks.AllowUserToAddRows = false;
            this.gvBooks.AllowUserToDeleteRows = false;
            this.gvBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvBooks.ContextMenuStrip = this.cmsMenuDataGrid;
            this.gvBooks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvBooks.Location = new System.Drawing.Point(0, 56);
            this.gvBooks.MultiSelect = false;
            this.gvBooks.Name = "gvBooks";
            this.gvBooks.ReadOnly = true;
            this.gvBooks.RowHeadersWidth = 51;
            this.gvBooks.RowTemplate.Height = 29;
            this.gvBooks.Size = new System.Drawing.Size(800, 368);
            this.gvBooks.TabIndex = 3;
            this.gvBooks.CurrentCellChanged += new System.EventHandler(this.gvBooks_CurrentCellChanged);
            // 
            // cmsMenuDataGrid
            // 
            this.cmsMenuDataGrid.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsMenuDataGrid.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mictAdd,
            this.mictEdit,
            this.toolStripSeparator6,
            this.mictDelete,
            this.toolStripSeparator7,
            this.mictExit});
            this.cmsMenuDataGrid.Name = "cmsMenuDataGrid";
            this.cmsMenuDataGrid.Size = new System.Drawing.Size(149, 120);
            // 
            // mictAdd
            // 
            this.mictAdd.Image = ((System.Drawing.Image)(resources.GetObject("mictAdd.Image")));
            this.mictAdd.Name = "mictAdd";
            this.mictAdd.Size = new System.Drawing.Size(148, 26);
            this.mictAdd.Text = "Додати...";
            // 
            // mictEdit
            // 
            this.mictEdit.Image = ((System.Drawing.Image)(resources.GetObject("mictEdit.Image")));
            this.mictEdit.Name = "mictEdit";
            this.mictEdit.Size = new System.Drawing.Size(148, 26);
            this.mictEdit.Text = "Змінити...";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(145, 6);
            // 
            // mictDelete
            // 
            this.mictDelete.Image = ((System.Drawing.Image)(resources.GetObject("mictDelete.Image")));
            this.mictDelete.Name = "mictDelete";
            this.mictDelete.Size = new System.Drawing.Size(148, 26);
            this.mictDelete.Text = "Видалити";
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(145, 6);
            // 
            // mictExit
            // 
            this.mictExit.Image = ((System.Drawing.Image)(resources.GetObject("mictExit.Image")));
            this.mictExit.Name = "mictExit";
            this.mictExit.Size = new System.Drawing.Size(148, 26);
            this.mictExit.Text = "Вихід";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gvBooks);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.toolBar);
            this.Controls.Add(this.menuMain);
            this.MainMenuStrip = this.menuMain;
            this.Name = "FormMain";
            this.Text = "Курсова робота: Бібліотека";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.Resize += new System.EventHandler(this.FormMain_Resize);
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            this.toolBar.ResumeLayout(false);
            this.toolBar.PerformLayout();
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvBooks)).EndInit();
            this.cmsMenuDataGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindScrBooks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuMain;
        private ToolStripMenuItem miFile;
        private ToolStripMenuItem miOpen;
        private ToolStripMenuItem miSave;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem miImport;
        private ToolStripMenuItem miExport;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem miAbout;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem miExit;
        private ToolStripMenuItem miBook;
        private ToolStripMenuItem niAdd;
        private ToolStripMenuItem miEdit;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem miDelete;
        private ToolStripMenuItem miClear;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripMenuItem miFilter;
        private ToolStrip toolBar;
        private ToolStripButton btnAdd;
        private ToolStripButton btnEdit;
        private ToolStripSeparator tsSeparator1;
        private ToolStripButton btnDel;
        private ToolStripButton btnClear;
        private ToolStripSeparator tsSeparator2;
        private ToolStripButton btnOpenFromBinary;
        private ToolStripButton btnSaveAsBinary;
        private ToolStripSeparator tsSeparator3;
        private ToolStripButton btnOpenFromText;
        private ToolStripButton btnSaveAsText;
        private ToolStripSeparator tsSeparator4;
        private ToolStripButton btnFilter;
        private ToolStripLabel tslSortBy;
        private ToolStripComboBox tslcbSortBy;
        private ToolStripLabel tslFind;
        private ToolStripTextBox tsltbSearch;
        private ToolStripButton btnExit;
        private StatusStrip statusBar;
        private ToolStripStatusLabel tsslFileName;
        private ToolStripStatusLabel tsslRating;
        private DataGridView gvBooks;
        private ContextMenuStrip cmsMenuDataGrid;
        private ToolStripMenuItem mictAdd;
        private ToolStripMenuItem mictEdit;
        private ToolStripSeparator toolStripSeparator6;
        private ToolStripMenuItem mictDelete;
        private ToolStripSeparator toolStripSeparator7;
        private ToolStripMenuItem mictExit;
        private BindingSource bindScrBooks;
        private OpenFileDialog openFileDialog;
        private SaveFileDialog saveFileDialog;
    }
}