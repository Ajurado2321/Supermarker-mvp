panel1 = new Panel();
label1 = new Label();
TxtPayModeId = new TabControl();
tabPage1 = new TabPage();
tabPage2 = new TabPage();
label2 = new Label();
TxtSearch = new TextBox();
TexBox = new Button();
DgPayMode = new DataGridView();
BtnNew = new Button();
BtnEdit = new Button();
BtnDelete = new Button();
tabControl1 = new TabPage();
BtnClose = new Button();
label3 = new Label();
TxtPayModelId = new TextBox();
label4 = new Label();
TxtPayModeName = new TextBox();
label5 = new Label();
TxtPayModeObservation = new TextBox();
BtnSave = new Button();
BtnDelete = new Button();
BtnEdit = new Button();
BtnNew = new Button();
DgPayMode = new DataGridView();
BtnSearch = new Button();
TxtSearch = new TextBox();
label2 = new Label();
tabPage2 = new TabPage();
BtnCancel = new Button();
BtnSave = new Button();
TxtPayModeObservation = new TextBox();
label5 = new Label();
TxtPayModeName = new TextBox();
label4 = new Label();
TxtPayModelId = new TextBox();
label3 = new Label();
panel1.SuspendLayout();
TxtPayModeId.SuspendLayout();
tabPage1.SuspendLayout();
tabPage2.SuspendLayout();
tabControl1.SuspendLayout();
((System.ComponentModel.ISupportInitialize)DgPayMode).BeginInit();
tabPage2.SuspendLayout();
SuspendLayout();
            // 
            // panel1
@@ -77,7 + 77,7 @@ private void InitializeComponent()
            // 
            // TxtPayModeId
            // 
            TxtPayModeId.Controls.Add(tabPage1);
TxtPayModeId.Controls.Add(tabControl1);
TxtPayModeId.Controls.Add(tabPage2);
TxtPayModeId.Dock = DockStyle.Fill;
TxtPayModeId.Location = new Point(0, 100);
@@ -86,67 + 86,59 @@ private void InitializeComponent()
            TxtPayModeId.Size = new Size(800, 350);
TxtPayModeId.TabIndex = 1;
// 
// tabPage1
// 
tabPage1.Controls.Add(BtnClose);
tabPage1.Controls.Add(BtnDelete);
tabPage1.Controls.Add(BtnEdit);
tabPage1.Controls.Add(BtnNew);
tabPage1.Controls.Add(DgPayMode);
tabPage1.Controls.Add(TexBox);
tabPage1.Controls.Add(TxtSearch);
tabPage1.Controls.Add(label2);
tabPage1.Location = new Point(4, 24);
tabPage1.Name = "tabPage1";
tabPage1.Padding = new Padding(3);
tabPage1.Size = new Size(792, 322);
tabPage1.TabIndex = 0;
tabPage1.Text = " Pay Mode List";
tabPage1.UseVisualStyleBackColor = true;
// tabControl1
// 
tabControl1.Controls.Add(BtnClose);
tabControl1.Controls.Add(BtnDelete);
tabControl1.Controls.Add(BtnEdit);
tabControl1.Controls.Add(BtnNew);
tabControl1.Controls.Add(DgPayMode);
tabControl1.Controls.Add(BtnSearch);
tabControl1.Controls.Add(TxtSearch);
tabControl1.Controls.Add(label2);
tabControl1.Location = new Point(4, 24);
tabControl1.Name = "tabControl1";
tabControl1.Padding = new Padding(3);
tabControl1.Size = new Size(792, 322);
tabControl1.TabIndex = 0;
tabControl1.Text = " Pay Mode List";
tabControl1.UseVisualStyleBackColor = true;
// 
// tabPage2
// BtnClose
// 
tabPage2.Controls.Add(BtnCancel);
tabPage2.Controls.Add(BtnSave);
tabPage2.Controls.Add(TxtPayModeObservation);
tabPage2.Controls.Add(label5);
tabPage2.Controls.Add(TxtPayModeName);
tabPage2.Controls.Add(label4);
tabPage2.Controls.Add(TxtPayModelId);
tabPage2.Controls.Add(label3);
tabPage2.Location = new Point(4, 24);
tabPage2.Name = "tabPage2";
tabPage2.Padding = new Padding(3);
tabPage2.Size = new Size(792, 322);
tabPage2.TabIndex = 1;
tabPage2.Text = " Pay Mode Detail";
tabPage2.UseVisualStyleBackColor = true;
BtnClose.Location = new Point(701, 234);
BtnClose.Name = "BtnClose";
BtnClose.Size = new Size(75, 23);
BtnClose.TabIndex = 7;
BtnClose.Text = "Close";
BtnClose.UseVisualStyleBackColor = true;
// 
// label2
// BtnDelete
// 
label2.AutoSize = true;
label2.Location = new Point(25, 25);
label2.Name = "label2";
label2.Size = new Size(98, 15);
label2.TabIndex = 0;
label2.Text = "Search Pay Mode";
BtnDelete.Location = new Point(701, 187);
BtnDelete.Name = "BtnDelete";
BtnDelete.Size = new Size(75, 23);
BtnDelete.TabIndex = 6;
BtnDelete.Text = "Delet";
BtnDelete.UseVisualStyleBackColor = true;
// 
// TxtSearch
// BtnEdit
// 
TxtSearch.Location = new Point(25, 52);
TxtSearch.Name = "TxtSearch";
TxtSearch.PlaceholderText = "Data to search";
TxtSearch.Size = new Size(360, 23);
TxtSearch.TabIndex = 1;
BtnEdit.Location = new Point(701, 141);
BtnEdit.Name = "BtnEdit";
BtnEdit.Size = new Size(75, 23);
BtnEdit.TabIndex = 5;
BtnEdit.Text = "Edit";
BtnEdit.UseVisualStyleBackColor = true;
// 
// TexBox
// BtnNew
// 
TexBox.Location = new Point(391, 52);
TexBox.Name = "TexBox";
TexBox.Size = new Size(75, 23);
TexBox.TabIndex = 2;
TexBox.Text = "Search";
TexBox.UseVisualStyleBackColor = true;
BtnNew.Location = new Point(701, 94);
BtnNew.Name = "BtnNew";
BtnNew.Size = new Size(75, 23);
BtnNew.TabIndex = 4;
BtnNew.Text = "New";
BtnNew.UseVisualStyleBackColor = true;
            // 
            // DgPayMode
            // 
@@ -157,75 + 149,77 @@ private void InitializeComponent()
            DgPayMode.Size = new Size(670, 209);
DgPayMode.TabIndex = 3;
// 
// BtnNew
// BtnSearch
// 
BtnNew.Location = new Point(701, 94);
BtnNew.Name = "BtnNew";
BtnNew.Size = new Size(75, 23);
BtnNew.TabIndex = 4;
BtnNew.Text = "New";
BtnNew.UseVisualStyleBackColor = true;
// 
// BtnEdit
BtnSearch.Location = new Point(391, 52);
BtnSearch.Name = "BtnSearch";
BtnSearch.Size = new Size(75, 23);
BtnSearch.TabIndex = 2;
BtnSearch.Text = "Search";
BtnSearch.UseVisualStyleBackColor = true;
// 
BtnEdit.Location = new Point(701, 141);
BtnEdit.Name = "BtnEdit";
BtnEdit.Size = new Size(75, 23);
BtnEdit.TabIndex = 5;
BtnEdit.Text = "Edit";
BtnEdit.UseVisualStyleBackColor = true;
// 
// BtnDelete
// TxtSearch
// 
BtnDelete.Location = new Point(701, 187);
BtnDelete.Name = "BtnDelete";
BtnDelete.Size = new Size(75, 23);
BtnDelete.TabIndex = 6;
BtnDelete.Text = "Delet";
BtnDelete.UseVisualStyleBackColor = true;
TxtSearch.Location = new Point(25, 52);
TxtSearch.Name = "TxtSearch";
TxtSearch.PlaceholderText = "Data to search";
TxtSearch.Size = new Size(360, 23);
TxtSearch.TabIndex = 1;
// 
// BtnClose
// label2
// 
BtnClose.Location = new Point(701, 234);
BtnClose.Name = "BtnClose";
BtnClose.Size = new Size(75, 23);
BtnClose.TabIndex = 7;
BtnClose.Text = "Close";
BtnClose.UseVisualStyleBackColor = true;
label2.AutoSize = true;
label2.Location = new Point(25, 25);
label2.Name = "label2";
label2.Size = new Size(98, 15);
label2.TabIndex = 0;
label2.Text = "Search Pay Mode";
// 
// label3
// tabPage2
// 
label3.AutoSize = true;
label3.Location = new Point(55, 32);
label3.Name = "label3";
label3.Size = new Size(73, 15);
label3.TabIndex = 0;
label3.Text = "Pay Mode Id";
label3.Click += label3_Click;
tabPage2.Controls.Add(BtnCancel);
tabPage2.Controls.Add(BtnSave);
tabPage2.Controls.Add(TxtPayModeObservation);
tabPage2.Controls.Add(label5);
tabPage2.Controls.Add(TxtPayModeName);
tabPage2.Controls.Add(label4);
tabPage2.Controls.Add(TxtPayModelId);
tabPage2.Controls.Add(label3);
tabPage2.Location = new Point(4, 24);
tabPage2.Name = "tabPage2";
tabPage2.Padding = new Padding(3);
tabPage2.Size = new Size(792, 322);
tabPage2.TabIndex = 1;
tabPage2.Text = " Pay Mode Detail";
tabPage2.UseVisualStyleBackColor = true;
// 
// TxtPayModelId
// BtnCancel
// 
TxtPayModelId.Location = new Point(55, 50);
TxtPayModelId.Name = "TxtPayModelId";
TxtPayModelId.Size = new Size(100, 23);
TxtPayModelId.TabIndex = 1;
BtnCancel.Location = new Point(159, 278);
BtnCancel.Name = "BtnCancel";
BtnCancel.Size = new Size(75, 23);
BtnCancel.TabIndex = 7;
BtnCancel.Text = "Cancel";
BtnCancel.UseVisualStyleBackColor = true;
// 
// label4
// BtnSave
// 
label4.AutoSize = true;
label4.Location = new Point(55, 86);
label4.Name = "label4";
label4.Size = new Size(95, 15);
label4.TabIndex = 2;
label4.Text = "Pay Mode Name";
BtnSave.Location = new Point(57, 278);
BtnSave.Name = "BtnSave";
BtnSave.Size = new Size(75, 23);
BtnSave.TabIndex = 6;
BtnSave.Text = "Save";
BtnSave.UseVisualStyleBackColor = true;
// 
// TxtPayModeName
// TxtPayModeObservation
// 
TxtPayModeName.Location = new Point(55, 104);
TxtPayModeName.Name = "TxtPayModeName";
TxtPayModeName.PlaceholderText = "Pay Mode Name";
TxtPayModeName.Size = new Size(301, 23);
TxtPayModeName.TabIndex = 3;
TxtPayModeObservation.Location = new Point(55, 162);
TxtPayModeObservation.Multiline = true;
TxtPayModeObservation.Name = "TxtPayModeObservation";
TxtPayModeObservation.PlaceholderText = "Pay Mode Name";
TxtPayModeObservation.Size = new Size(301, 82);
TxtPayModeObservation.TabIndex = 5;
TxtPayModeObservation.TextChanged += TxtPayModeObservation_TextChanged;
            // 
            // label5
            // 
@@ -237,33 + 231,39 @@ private void InitializeComponent()
            label5.Text = "Pay Mode Observation";
label5.Click += label5_Click;
// 
// TxtPayModeObservation
// TxtPayModeName
// 
TxtPayModeObservation.Location = new Point(55, 162);
TxtPayModeObservation.Multiline = true;
TxtPayModeObservation.Name = "TxtPayModeObservation";
TxtPayModeObservation.PlaceholderText = "Pay Mode Name";
TxtPayModeObservation.Size = new Size(301, 82);
TxtPayModeObservation.TabIndex = 5;
TxtPayModeObservation.TextChanged += TxtPayModeObservation_TextChanged;
TxtPayModeName.Location = new Point(55, 104);
TxtPayModeName.Name = "TxtPayModeName";
TxtPayModeName.PlaceholderText = "Pay Mode Name";
TxtPayModeName.Size = new Size(301, 23);
TxtPayModeName.TabIndex = 3;
// 
// BtnSave
// label4
// 
BtnSave.Location = new Point(57, 278);
BtnSave.Name = "BtnSave";
BtnSave.Size = new Size(75, 23);
BtnSave.TabIndex = 6;
BtnSave.Text = "Save";
BtnSave.UseVisualStyleBackColor = true;
label4.AutoSize = true;
label4.Location = new Point(55, 86);
label4.Name = "label4";
label4.Size = new Size(95, 15);
label4.TabIndex = 2;
label4.Text = "Pay Mode Name";
// 
// BtnCancel
// TxtPayModelId
// 
BtnCancel.Location = new Point(159, 278);
BtnCancel.Name = "BtnCancel";
BtnCancel.Size = new Size(75, 23);
BtnCancel.TabIndex = 7;
BtnCancel.Text = "Cancel";
BtnCancel.UseVisualStyleBackColor = true;
TxtPayModelId.Location = new Point(55, 50);
TxtPayModelId.Name = "TxtPayModelId";
TxtPayModelId.Size = new Size(100, 23);
TxtPayModelId.TabIndex = 1;
// 
// label3
// 
label3.AutoSize = true;
label3.Location = new Point(55, 32);
label3.Name = "label3";
label3.Size = new Size(73, 15);
label3.TabIndex = 0;
label3.Text = "Pay Mode Id";
label3.Click += label3_Click;
            // 
            // PayModeView
            // 
@@ -277,11 + 277,11 @@ private void InitializeComponent()
            panel1.ResumeLayout(false);
panel1.PerformLayout();
TxtPayModeId.ResumeLayout(false);
tabPage1.ResumeLayout(false);
tabPage1.PerformLayout();
tabControl1.ResumeLayout(false);
tabControl1.PerformLayout();
((System.ComponentModel.ISupportInitialize)DgPayMode).EndInit();
tabPage2.ResumeLayout(false);
tabPage2.PerformLayout();
((System.ComponentModel.ISupportInitialize)DgPayMode).EndInit();
ResumeLayout(false);
        }

@@ -290,9 + 290,9 @@ private void InitializeComponent()
        private Panel panel1;
private Label label1;
private TabControl TxtPayModeId;
private TabPage tabPage1;
private TabPage tabControl1;
private TabPage tabPage2;
private Button TexBox;
private Button BtnSearch;
private TextBox TxtSearch;
private Label label2;
private Button BtnNew;