namespace MSIT130_SpecialTopic
{
    partial class frm_Backend_Workouts
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnAddWc = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.grpAddWC = new System.Windows.Forms.GroupBox();
            this.txtAddWC_Name = new System.Windows.Forms.TextBox();
            this.lblAddWC_Test = new System.Windows.Forms.Label();
            this.lblAddWC_Name = new System.Windows.Forms.Label();
            this.grpEditWC = new System.Windows.Forms.GroupBox();
            this.btnEditWC = new System.Windows.Forms.Button();
            this.lblEditWC = new System.Windows.Forms.Label();
            this.lblEditWC_Test = new System.Windows.Forms.Label();
            this.cmbEditWC_Name = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtEditWC_Name = new System.Windows.Forms.TextBox();
            this.dgvWC = new System.Windows.Forms.DataGridView();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.grpEditW = new System.Windows.Forms.GroupBox();
            this.lblEditW_Cal_Test = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblEditW_WC = new System.Windows.Forms.Label();
            this.txtEditW_Name = new System.Windows.Forms.TextBox();
            this.lblEditW_Name_Test = new System.Windows.Forms.Label();
            this.lblEditW_Cal = new System.Windows.Forms.Label();
            this.lblEditW_AL = new System.Windows.Forms.Label();
            this.cmbEditW_AL = new System.Windows.Forms.ComboBox();
            this.cmbEditW_Name = new System.Windows.Forms.ComboBox();
            this.lblEditW_Name = new System.Windows.Forms.Label();
            this.txtEditW_Cal = new System.Windows.Forms.TextBox();
            this.btnEditW = new System.Windows.Forms.Button();
            this.cmbEditW_WC = new System.Windows.Forms.ComboBox();
            this.grpAddW = new System.Windows.Forms.GroupBox();
            this.txtAddW_Name = new System.Windows.Forms.TextBox();
            this.lblAddW_Cal_Test = new System.Windows.Forms.Label();
            this.lblAddW_WC = new System.Windows.Forms.Label();
            this.lblAddW_Name_Test = new System.Windows.Forms.Label();
            this.lblAddW_Cal = new System.Windows.Forms.Label();
            this.lblAddW_AL = new System.Windows.Forms.Label();
            this.cmbAddW_AL = new System.Windows.Forms.ComboBox();
            this.lblAddW_Name = new System.Windows.Forms.Label();
            this.txtAddW_Cal = new System.Windows.Forms.TextBox();
            this.btnAddW = new System.Windows.Forms.Button();
            this.cmbAddW_WC = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvW = new System.Windows.Forms.DataGridView();
            this.bsWC = new System.Windows.Forms.BindingSource(this.components);
            this.bsW = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.grpAddWC.SuspendLayout();
            this.grpEditWC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.grpEditW.SuspendLayout();
            this.grpAddW.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsWC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsW)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddWc
            // 
            this.btnAddWc.Location = new System.Drawing.Point(369, 23);
            this.btnAddWc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddWc.Name = "btnAddWc";
            this.btnAddWc.Size = new System.Drawing.Size(108, 41);
            this.btnAddWc.TabIndex = 0;
            this.btnAddWc.Text = "新增運動類型";
            this.btnAddWc.UseVisualStyleBackColor = true;
            this.btnAddWc.Click += new System.EventHandler(this.btnAddWC_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer1.Size = new System.Drawing.Size(982, 753);
            this.splitContainer1.SplitterDistance = 252;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 1;
            // 
            // splitContainer2
            // 
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.grpAddWC);
            this.splitContainer2.Panel1.Controls.Add(this.grpEditWC);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.dgvWC);
            this.splitContainer2.Size = new System.Drawing.Size(982, 252);
            this.splitContainer2.SplitterDistance = 491;
            this.splitContainer2.TabIndex = 0;
            // 
            // grpAddWC
            // 
            this.grpAddWC.Controls.Add(this.txtAddWC_Name);
            this.grpAddWC.Controls.Add(this.lblAddWC_Test);
            this.grpAddWC.Controls.Add(this.lblAddWC_Name);
            this.grpAddWC.Controls.Add(this.btnAddWc);
            this.grpAddWC.Location = new System.Drawing.Point(3, 11);
            this.grpAddWC.Name = "grpAddWC";
            this.grpAddWC.Size = new System.Drawing.Size(483, 100);
            this.grpAddWC.TabIndex = 0;
            this.grpAddWC.TabStop = false;
            this.grpAddWC.Text = "新增運動類型";
            // 
            // txtAddWC_Name
            // 
            this.txtAddWC_Name.Location = new System.Drawing.Point(253, 33);
            this.txtAddWC_Name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAddWC_Name.Name = "txtAddWC_Name";
            this.txtAddWC_Name.Size = new System.Drawing.Size(100, 25);
            this.txtAddWC_Name.TabIndex = 1;
            // 
            // lblAddWC_Test
            // 
            this.lblAddWC_Test.AutoSize = true;
            this.lblAddWC_Test.ForeColor = System.Drawing.Color.Red;
            this.lblAddWC_Test.Location = new System.Drawing.Point(253, 64);
            this.lblAddWC_Test.Name = "lblAddWC_Test";
            this.lblAddWC_Test.Size = new System.Drawing.Size(0, 15);
            this.lblAddWC_Test.TabIndex = 3;
            // 
            // lblAddWC_Name
            // 
            this.lblAddWC_Name.AutoSize = true;
            this.lblAddWC_Name.Location = new System.Drawing.Point(180, 36);
            this.lblAddWC_Name.Name = "lblAddWC_Name";
            this.lblAddWC_Name.Size = new System.Drawing.Size(67, 15);
            this.lblAddWC_Name.TabIndex = 2;
            this.lblAddWC_Name.Text = "運動類型";
            // 
            // grpEditWC
            // 
            this.grpEditWC.Controls.Add(this.btnEditWC);
            this.grpEditWC.Controls.Add(this.lblEditWC);
            this.grpEditWC.Controls.Add(this.lblEditWC_Test);
            this.grpEditWC.Controls.Add(this.cmbEditWC_Name);
            this.grpEditWC.Controls.Add(this.label8);
            this.grpEditWC.Controls.Add(this.txtEditWC_Name);
            this.grpEditWC.Location = new System.Drawing.Point(3, 117);
            this.grpEditWC.Name = "grpEditWC";
            this.grpEditWC.Size = new System.Drawing.Size(483, 130);
            this.grpEditWC.TabIndex = 6;
            this.grpEditWC.TabStop = false;
            this.grpEditWC.Text = "修改運動類型";
            // 
            // btnEditWC
            // 
            this.btnEditWC.Location = new System.Drawing.Point(369, 23);
            this.btnEditWC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditWC.Name = "btnEditWC";
            this.btnEditWC.Size = new System.Drawing.Size(108, 41);
            this.btnEditWC.TabIndex = 0;
            this.btnEditWC.Text = "修改運動類型";
            this.btnEditWC.UseVisualStyleBackColor = true;
            this.btnEditWC.Click += new System.EventHandler(this.btnEditWC_Click);
            // 
            // lblEditWC
            // 
            this.lblEditWC.AutoSize = true;
            this.lblEditWC.Location = new System.Drawing.Point(7, 36);
            this.lblEditWC.Name = "lblEditWC";
            this.lblEditWC.Size = new System.Drawing.Size(97, 15);
            this.lblEditWC.TabIndex = 2;
            this.lblEditWC.Text = "選擇運動類型";
            // 
            // lblEditWC_Test
            // 
            this.lblEditWC_Test.AutoSize = true;
            this.lblEditWC_Test.ForeColor = System.Drawing.Color.Red;
            this.lblEditWC_Test.Location = new System.Drawing.Point(253, 61);
            this.lblEditWC_Test.Name = "lblEditWC_Test";
            this.lblEditWC_Test.Size = new System.Drawing.Size(0, 15);
            this.lblEditWC_Test.TabIndex = 3;
            // 
            // cmbEditWC_Name
            // 
            this.cmbEditWC_Name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEditWC_Name.FormattingEnabled = true;
            this.cmbEditWC_Name.Location = new System.Drawing.Point(110, 33);
            this.cmbEditWC_Name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbEditWC_Name.Name = "cmbEditWC_Name";
            this.cmbEditWC_Name.Size = new System.Drawing.Size(108, 23);
            this.cmbEditWC_Name.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(224, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 15);
            this.label8.TabIndex = 5;
            this.label8.Text = "=>";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            this.label8.MouseEnter += new System.EventHandler(this.label8_MouseEnter);
            this.label8.MouseLeave += new System.EventHandler(this.label8_MouseLeave);
            // 
            // txtEditWC_Name
            // 
            this.txtEditWC_Name.Location = new System.Drawing.Point(253, 33);
            this.txtEditWC_Name.Name = "txtEditWC_Name";
            this.txtEditWC_Name.Size = new System.Drawing.Size(100, 25);
            this.txtEditWC_Name.TabIndex = 4;
            // 
            // dgvWC
            // 
            this.dgvWC.AllowUserToAddRows = false;
            this.dgvWC.AllowUserToDeleteRows = false;
            this.dgvWC.AllowUserToOrderColumns = true;
            this.dgvWC.AllowUserToResizeColumns = false;
            this.dgvWC.AllowUserToResizeRows = false;
            this.dgvWC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvWC.Location = new System.Drawing.Point(0, 0);
            this.dgvWC.Name = "dgvWC";
            this.dgvWC.RowHeadersWidth = 51;
            this.dgvWC.RowTemplate.Height = 27;
            this.dgvWC.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvWC.Size = new System.Drawing.Size(485, 250);
            this.dgvWC.TabIndex = 0;
            this.dgvWC.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvWC_CellClick);
            // 
            // splitContainer3
            // 
            this.splitContainer3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.grpEditW);
            this.splitContainer3.Panel1.Controls.Add(this.grpAddW);
            this.splitContainer3.Panel1.Controls.Add(this.label2);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.dgvW);
            this.splitContainer3.Size = new System.Drawing.Size(982, 498);
            this.splitContainer3.SplitterDistance = 230;
            this.splitContainer3.TabIndex = 4;
            // 
            // grpEditW
            // 
            this.grpEditW.Controls.Add(this.lblEditW_Cal_Test);
            this.grpEditW.Controls.Add(this.label7);
            this.grpEditW.Controls.Add(this.lblEditW_WC);
            this.grpEditW.Controls.Add(this.txtEditW_Name);
            this.grpEditW.Controls.Add(this.lblEditW_Name_Test);
            this.grpEditW.Controls.Add(this.lblEditW_Cal);
            this.grpEditW.Controls.Add(this.lblEditW_AL);
            this.grpEditW.Controls.Add(this.cmbEditW_AL);
            this.grpEditW.Controls.Add(this.cmbEditW_Name);
            this.grpEditW.Controls.Add(this.lblEditW_Name);
            this.grpEditW.Controls.Add(this.txtEditW_Cal);
            this.grpEditW.Controls.Add(this.btnEditW);
            this.grpEditW.Controls.Add(this.cmbEditW_WC);
            this.grpEditW.Location = new System.Drawing.Point(495, 14);
            this.grpEditW.Name = "grpEditW";
            this.grpEditW.Size = new System.Drawing.Size(475, 200);
            this.grpEditW.TabIndex = 5;
            this.grpEditW.TabStop = false;
            this.grpEditW.Text = "修改運動";
            // 
            // lblEditW_Cal_Test
            // 
            this.lblEditW_Cal_Test.AutoSize = true;
            this.lblEditW_Cal_Test.ForeColor = System.Drawing.Color.Red;
            this.lblEditW_Cal_Test.Location = new System.Drawing.Point(268, 110);
            this.lblEditW_Cal_Test.Name = "lblEditW_Cal_Test";
            this.lblEditW_Cal_Test.Size = new System.Drawing.Size(0, 15);
            this.lblEditW_Cal_Test.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(268, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 15);
            this.label7.TabIndex = 5;
            this.label7.Text = "=>";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            this.label7.MouseEnter += new System.EventHandler(this.label8_MouseEnter);
            this.label7.MouseLeave += new System.EventHandler(this.label8_MouseLeave);
            // 
            // lblEditW_WC
            // 
            this.lblEditW_WC.AutoSize = true;
            this.lblEditW_WC.Location = new System.Drawing.Point(79, 139);
            this.lblEditW_WC.Name = "lblEditW_WC";
            this.lblEditW_WC.Size = new System.Drawing.Size(67, 15);
            this.lblEditW_WC.TabIndex = 2;
            this.lblEditW_WC.Text = "運動類型";
            // 
            // txtEditW_Name
            // 
            this.txtEditW_Name.Location = new System.Drawing.Point(297, 45);
            this.txtEditW_Name.Name = "txtEditW_Name";
            this.txtEditW_Name.Size = new System.Drawing.Size(100, 25);
            this.txtEditW_Name.TabIndex = 4;
            // 
            // lblEditW_Name_Test
            // 
            this.lblEditW_Name_Test.AutoSize = true;
            this.lblEditW_Name_Test.ForeColor = System.Drawing.Color.Red;
            this.lblEditW_Name_Test.Location = new System.Drawing.Point(297, 73);
            this.lblEditW_Name_Test.Name = "lblEditW_Name_Test";
            this.lblEditW_Name_Test.Size = new System.Drawing.Size(0, 15);
            this.lblEditW_Name_Test.TabIndex = 4;
            // 
            // lblEditW_Cal
            // 
            this.lblEditW_Cal.AutoSize = true;
            this.lblEditW_Cal.Location = new System.Drawing.Point(35, 110);
            this.lblEditW_Cal.Name = "lblEditW_Cal";
            this.lblEditW_Cal.Size = new System.Drawing.Size(120, 15);
            this.lblEditW_Cal.TabIndex = 2;
            this.lblEditW_Cal.Text = "卡路里/公斤/小時";
            this.lblEditW_Cal.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblEditW_AL
            // 
            this.lblEditW_AL.AutoSize = true;
            this.lblEditW_AL.Location = new System.Drawing.Point(79, 166);
            this.lblEditW_AL.Name = "lblEditW_AL";
            this.lblEditW_AL.Size = new System.Drawing.Size(67, 15);
            this.lblEditW_AL.TabIndex = 2;
            this.lblEditW_AL.Text = "運動強度";
            // 
            // cmbEditW_AL
            // 
            this.cmbEditW_AL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEditW_AL.FormattingEnabled = true;
            this.cmbEditW_AL.Location = new System.Drawing.Point(152, 163);
            this.cmbEditW_AL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbEditW_AL.Name = "cmbEditW_AL";
            this.cmbEditW_AL.Size = new System.Drawing.Size(108, 23);
            this.cmbEditW_AL.TabIndex = 3;
            // 
            // cmbEditW_Name
            // 
            this.cmbEditW_Name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEditW_Name.FormattingEnabled = true;
            this.cmbEditW_Name.Location = new System.Drawing.Point(152, 45);
            this.cmbEditW_Name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbEditW_Name.Name = "cmbEditW_Name";
            this.cmbEditW_Name.Size = new System.Drawing.Size(108, 23);
            this.cmbEditW_Name.TabIndex = 3;
            // 
            // lblEditW_Name
            // 
            this.lblEditW_Name.AutoSize = true;
            this.lblEditW_Name.Location = new System.Drawing.Point(79, 48);
            this.lblEditW_Name.Name = "lblEditW_Name";
            this.lblEditW_Name.Size = new System.Drawing.Size(67, 15);
            this.lblEditW_Name.TabIndex = 2;
            this.lblEditW_Name.Text = "運動名稱";
            // 
            // txtEditW_Cal
            // 
            this.txtEditW_Cal.Location = new System.Drawing.Point(160, 107);
            this.txtEditW_Cal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEditW_Cal.Name = "txtEditW_Cal";
            this.txtEditW_Cal.Size = new System.Drawing.Size(100, 25);
            this.txtEditW_Cal.TabIndex = 1;
            // 
            // btnEditW
            // 
            this.btnEditW.Location = new System.Drawing.Point(277, 140);
            this.btnEditW.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditW.Name = "btnEditW";
            this.btnEditW.Size = new System.Drawing.Size(87, 41);
            this.btnEditW.TabIndex = 0;
            this.btnEditW.Text = "修改運動";
            this.btnEditW.UseVisualStyleBackColor = true;
            this.btnEditW.Click += new System.EventHandler(this.btnEditW_Click);
            // 
            // cmbEditW_WC
            // 
            this.cmbEditW_WC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEditW_WC.FormattingEnabled = true;
            this.cmbEditW_WC.Location = new System.Drawing.Point(152, 136);
            this.cmbEditW_WC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbEditW_WC.Name = "cmbEditW_WC";
            this.cmbEditW_WC.Size = new System.Drawing.Size(108, 23);
            this.cmbEditW_WC.TabIndex = 3;
            // 
            // grpAddW
            // 
            this.grpAddW.Controls.Add(this.txtAddW_Name);
            this.grpAddW.Controls.Add(this.lblAddW_Cal_Test);
            this.grpAddW.Controls.Add(this.lblAddW_WC);
            this.grpAddW.Controls.Add(this.lblAddW_Name_Test);
            this.grpAddW.Controls.Add(this.lblAddW_Cal);
            this.grpAddW.Controls.Add(this.lblAddW_AL);
            this.grpAddW.Controls.Add(this.cmbAddW_AL);
            this.grpAddW.Controls.Add(this.lblAddW_Name);
            this.grpAddW.Controls.Add(this.txtAddW_Cal);
            this.grpAddW.Controls.Add(this.btnAddW);
            this.grpAddW.Controls.Add(this.cmbAddW_WC);
            this.grpAddW.Location = new System.Drawing.Point(11, 14);
            this.grpAddW.Name = "grpAddW";
            this.grpAddW.Size = new System.Drawing.Size(475, 200);
            this.grpAddW.TabIndex = 5;
            this.grpAddW.TabStop = false;
            this.grpAddW.Text = "新增運動";
            // 
            // txtAddW_Name
            // 
            this.txtAddW_Name.Location = new System.Drawing.Point(159, 48);
            this.txtAddW_Name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAddW_Name.Name = "txtAddW_Name";
            this.txtAddW_Name.Size = new System.Drawing.Size(100, 25);
            this.txtAddW_Name.TabIndex = 1;
            // 
            // lblAddW_Cal_Test
            // 
            this.lblAddW_Cal_Test.AutoSize = true;
            this.lblAddW_Cal_Test.ForeColor = System.Drawing.Color.Red;
            this.lblAddW_Cal_Test.Location = new System.Drawing.Point(267, 110);
            this.lblAddW_Cal_Test.Name = "lblAddW_Cal_Test";
            this.lblAddW_Cal_Test.Size = new System.Drawing.Size(0, 15);
            this.lblAddW_Cal_Test.TabIndex = 4;
            // 
            // lblAddW_WC
            // 
            this.lblAddW_WC.AutoSize = true;
            this.lblAddW_WC.Location = new System.Drawing.Point(78, 139);
            this.lblAddW_WC.Name = "lblAddW_WC";
            this.lblAddW_WC.Size = new System.Drawing.Size(67, 15);
            this.lblAddW_WC.TabIndex = 2;
            this.lblAddW_WC.Text = "運動類型";
            // 
            // lblAddW_Name_Test
            // 
            this.lblAddW_Name_Test.AutoSize = true;
            this.lblAddW_Name_Test.ForeColor = System.Drawing.Color.Red;
            this.lblAddW_Name_Test.Location = new System.Drawing.Point(267, 48);
            this.lblAddW_Name_Test.Name = "lblAddW_Name_Test";
            this.lblAddW_Name_Test.Size = new System.Drawing.Size(0, 15);
            this.lblAddW_Name_Test.TabIndex = 4;
            // 
            // lblAddW_Cal
            // 
            this.lblAddW_Cal.AutoSize = true;
            this.lblAddW_Cal.Location = new System.Drawing.Point(34, 110);
            this.lblAddW_Cal.Name = "lblAddW_Cal";
            this.lblAddW_Cal.Size = new System.Drawing.Size(120, 15);
            this.lblAddW_Cal.TabIndex = 2;
            this.lblAddW_Cal.Text = "卡路里/公斤/小時";
            this.lblAddW_Cal.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblAddW_AL
            // 
            this.lblAddW_AL.AutoSize = true;
            this.lblAddW_AL.Location = new System.Drawing.Point(78, 166);
            this.lblAddW_AL.Name = "lblAddW_AL";
            this.lblAddW_AL.Size = new System.Drawing.Size(67, 15);
            this.lblAddW_AL.TabIndex = 2;
            this.lblAddW_AL.Text = "運動強度";
            // 
            // cmbAddW_AL
            // 
            this.cmbAddW_AL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAddW_AL.FormattingEnabled = true;
            this.cmbAddW_AL.Location = new System.Drawing.Point(151, 163);
            this.cmbAddW_AL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbAddW_AL.Name = "cmbAddW_AL";
            this.cmbAddW_AL.Size = new System.Drawing.Size(108, 23);
            this.cmbAddW_AL.TabIndex = 3;
            // 
            // lblAddW_Name
            // 
            this.lblAddW_Name.AutoSize = true;
            this.lblAddW_Name.Location = new System.Drawing.Point(78, 51);
            this.lblAddW_Name.Name = "lblAddW_Name";
            this.lblAddW_Name.Size = new System.Drawing.Size(67, 15);
            this.lblAddW_Name.TabIndex = 2;
            this.lblAddW_Name.Text = "運動名稱";
            // 
            // txtAddW_Cal
            // 
            this.txtAddW_Cal.Location = new System.Drawing.Point(159, 107);
            this.txtAddW_Cal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAddW_Cal.Name = "txtAddW_Cal";
            this.txtAddW_Cal.Size = new System.Drawing.Size(100, 25);
            this.txtAddW_Cal.TabIndex = 1;
            // 
            // btnAddW
            // 
            this.btnAddW.Location = new System.Drawing.Point(276, 140);
            this.btnAddW.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddW.Name = "btnAddW";
            this.btnAddW.Size = new System.Drawing.Size(87, 41);
            this.btnAddW.TabIndex = 0;
            this.btnAddW.Text = "新增運動";
            this.btnAddW.UseVisualStyleBackColor = true;
            this.btnAddW.Click += new System.EventHandler(this.btnAddW_Click);
            // 
            // cmbAddW_WC
            // 
            this.cmbAddW_WC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAddW_WC.FormattingEnabled = true;
            this.cmbAddW_WC.Location = new System.Drawing.Point(151, 136);
            this.cmbAddW_WC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbAddW_WC.Name = "cmbAddW_WC";
            this.cmbAddW_WC.Size = new System.Drawing.Size(108, 23);
            this.cmbAddW_WC.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-101, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "運動類型";
            // 
            // dgvW
            // 
            this.dgvW.AllowUserToAddRows = false;
            this.dgvW.AllowUserToDeleteRows = false;
            this.dgvW.AllowUserToOrderColumns = true;
            this.dgvW.AllowUserToResizeColumns = false;
            this.dgvW.AllowUserToResizeRows = false;
            this.dgvW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvW.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvW.Location = new System.Drawing.Point(0, 0);
            this.dgvW.Name = "dgvW";
            this.dgvW.RowHeadersWidth = 51;
            this.dgvW.RowTemplate.Height = 27;
            this.dgvW.Size = new System.Drawing.Size(980, 262);
            this.dgvW.TabIndex = 0;
            this.dgvW.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvW_CellClick);
            // 
            // bsWC
            // 
            this.bsWC.ListChanged += new System.ComponentModel.ListChangedEventHandler(this.bsWC_ListChanged);
            // 
            // bsW
            // 
            this.bsW.ListChanged += new System.ComponentModel.ListChangedEventHandler(this.bsW_ListChanged);
            // 
            // frm_Backend_Workouts
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(982, 753);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frm_Backend_Workouts";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frm_Backend_Workouts_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.grpAddWC.ResumeLayout(false);
            this.grpAddWC.PerformLayout();
            this.grpEditWC.ResumeLayout(false);
            this.grpEditWC.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWC)).EndInit();
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.PerformLayout();
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.grpEditW.ResumeLayout(false);
            this.grpEditW.PerformLayout();
            this.grpAddW.ResumeLayout(false);
            this.grpAddW.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsWC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsW)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAddWc;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label lblAddWC_Name;
        private System.Windows.Forms.TextBox txtAddWC_Name;
        private System.Windows.Forms.Label lblAddW_Cal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAddW_Cal;
        private System.Windows.Forms.TextBox txtAddW_Name;
        private System.Windows.Forms.ComboBox cmbAddW_WC;
        private System.Windows.Forms.Label lblAddW_WC;
        private System.Windows.Forms.Label lblAddW_Name;
        private System.Windows.Forms.Label lblAddW_AL;
        private System.Windows.Forms.ComboBox cmbAddW_AL;
        private System.Windows.Forms.Button btnAddW;
        private System.Windows.Forms.TextBox txtEditWC_Name;
        private System.Windows.Forms.Button btnEditWC;
        private System.Windows.Forms.ComboBox cmbEditWC_Name;
        private System.Windows.Forms.Label lblEditWC;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.Label lblAddWC_Test;
        private System.Windows.Forms.Label lblEditWC_Test;
        private System.Windows.Forms.Label lblAddW_Cal_Test;
        private System.Windows.Forms.Label lblAddW_Name_Test;
        private System.Windows.Forms.GroupBox grpAddW;
        private System.Windows.Forms.GroupBox grpEditW;
        private System.Windows.Forms.Label lblEditW_Cal_Test;
        private System.Windows.Forms.Label lblEditW_WC;
        private System.Windows.Forms.Label lblEditW_Name_Test;
        private System.Windows.Forms.Label lblEditW_Cal;
        private System.Windows.Forms.Label lblEditW_AL;
        private System.Windows.Forms.ComboBox cmbEditW_AL;
        private System.Windows.Forms.ComboBox cmbEditW_Name;
        private System.Windows.Forms.Label lblEditW_Name;
        private System.Windows.Forms.TextBox txtEditW_Cal;
        private System.Windows.Forms.Button btnEditW;
        private System.Windows.Forms.ComboBox cmbEditW_WC;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEditW_Name;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.GroupBox grpEditWC;
        private System.Windows.Forms.GroupBox grpAddWC;
        private System.Windows.Forms.DataGridView dgvWC;
        private System.Windows.Forms.DataGridView dgvW;
        private System.Windows.Forms.BindingSource bsWC;
        private System.Windows.Forms.BindingSource bsW;
    }
}

