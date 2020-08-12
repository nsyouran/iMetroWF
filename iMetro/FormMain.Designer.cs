namespace iMetro
{
    partial class FormMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("电子记录");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageERecord = new System.Windows.Forms.TabPage();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolBtnSeach = new System.Windows.Forms.ToolStripButton();
            this.btnSelectTemplate = new System.Windows.Forms.ToolStripButton();
            this.btnPreivew = new System.Windows.Forms.ToolStripButton();
            this.btnPrintAll = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.tbSearchProductName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbSearchProductType = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbSearchZsdwName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbSearchProductNumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbSerachProductFactory = new System.Windows.Forms.TextBox();
            this.tbSearchTaskName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPagePreview = new System.Windows.Forms.TabPage();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.btnPrint = new System.Windows.Forms.ToolStripButton();
            this.docShow = new AxDSOFramer.AxFramerControl();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.printDialog = new System.Windows.Forms.PrintDialog();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.test_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zsdw_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product_factory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.task_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.test_temperature = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.test_humidity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPageERecord.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabPagePreview.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.docShow)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Location = new System.Drawing.Point(11, 11);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.treeView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl);
            this.splitContainer1.Size = new System.Drawing.Size(1042, 539);
            this.splitContainer1.SplitterDistance = 101;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 0;
            // 
            // treeView1
            // 
            this.treeView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeView1.Location = new System.Drawing.Point(2, 2);
            this.treeView1.Margin = new System.Windows.Forms.Padding(2);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "节点0";
            treeNode1.Text = "电子记录";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1});
            this.treeView1.Size = new System.Drawing.Size(93, 531);
            this.treeView1.TabIndex = 0;
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabPageERecord);
            this.tabControl.Controls.Add(this.tabPagePreview);
            this.tabControl.Location = new System.Drawing.Point(2, 2);
            this.tabControl.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(933, 531);
            this.tabControl.TabIndex = 0;
            // 
            // tabPageERecord
            // 
            this.tabPageERecord.Controls.Add(this.dataGridView);
            this.tabPageERecord.Controls.Add(this.toolStrip1);
            this.tabPageERecord.Controls.Add(this.groupBox1);
            this.tabPageERecord.Location = new System.Drawing.Point(4, 22);
            this.tabPageERecord.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageERecord.Name = "tabPageERecord";
            this.tabPageERecord.Padding = new System.Windows.Forms.Padding(2);
            this.tabPageERecord.Size = new System.Drawing.Size(925, 505);
            this.tabPageERecord.TabIndex = 0;
            this.tabPageERecord.Text = "电子记录";
            this.tabPageERecord.UseVisualStyleBackColor = true;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.test_date,
            this.zsdw_name,
            this.product_name,
            this.product_type,
            this.product_number,
            this.product_factory,
            this.task_name,
            this.test_temperature,
            this.test_humidity});
            this.dataGridView.Location = new System.Drawing.Point(6, 152);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 27;
            this.dataGridView.Size = new System.Drawing.Size(910, 349);
            this.dataGridView.TabIndex = 2;
            this.dataGridView.SelectionChanged += new System.EventHandler(this.dataGridView_SelectionChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolBtnSeach,
            this.btnSelectTemplate,
            this.btnPreivew,
            this.btnPrintAll});
            this.toolStrip1.Location = new System.Drawing.Point(2, 2);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(921, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolBtnSeach
            // 
            this.toolBtnSeach.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolBtnSeach.Image = ((System.Drawing.Image)(resources.GetObject("toolBtnSeach.Image")));
            this.toolBtnSeach.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnSeach.Name = "toolBtnSeach";
            this.toolBtnSeach.Size = new System.Drawing.Size(36, 22);
            this.toolBtnSeach.Text = "查询";
            this.toolBtnSeach.Click += new System.EventHandler(this.toolBtnSeach_Click);
            // 
            // btnSelectTemplate
            // 
            this.btnSelectTemplate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnSelectTemplate.Image = ((System.Drawing.Image)(resources.GetObject("btnSelectTemplate.Image")));
            this.btnSelectTemplate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSelectTemplate.Name = "btnSelectTemplate";
            this.btnSelectTemplate.Size = new System.Drawing.Size(60, 22);
            this.btnSelectTemplate.Text = "选择模版";
            this.btnSelectTemplate.Click += new System.EventHandler(this.btnSelectTemplate_Click);
            // 
            // btnPreivew
            // 
            this.btnPreivew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnPreivew.Enabled = false;
            this.btnPreivew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPreivew.Name = "btnPreivew";
            this.btnPreivew.Size = new System.Drawing.Size(36, 22);
            this.btnPreivew.Text = "预览";
            this.btnPreivew.Click += new System.EventHandler(this.btnCreateRecord_Click);
            // 
            // btnPrintAll
            // 
            this.btnPrintAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnPrintAll.Enabled = false;
            this.btnPrintAll.Image = ((System.Drawing.Image)(resources.GetObject("btnPrintAll.Image")));
            this.btnPrintAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPrintAll.Name = "btnPrintAll";
            this.btnPrintAll.Size = new System.Drawing.Size(36, 22);
            this.btnPrintAll.Text = "打印";
            this.btnPrintAll.Click += new System.EventHandler(this.btnPrintAll_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Location = new System.Drawing.Point(5, 37);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(911, 111);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "查询条件";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tbSearchProductName, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tbSearchProductType, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.tbSearchZsdwName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.tbSearchProductNumber, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tbSerachProductFactory, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.tbSearchTaskName, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.label6, 2, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(5, 20);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(902, 82);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "被检单位：";
            // 
            // tbSearchProductName
            // 
            this.tbSearchProductName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSearchProductName.Location = new System.Drawing.Point(522, 3);
            this.tbSearchProductName.Margin = new System.Windows.Forms.Padding(2);
            this.tbSearchProductName.Name = "tbSearchProductName";
            this.tbSearchProductName.Size = new System.Drawing.Size(378, 21);
            this.tbSearchProductName.TabIndex = 2;
            this.tbSearchProductName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSearchProductName_KeyPress);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 34);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "规格型号：";
            // 
            // tbSearchProductType
            // 
            this.tbSearchProductType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSearchProductType.Location = new System.Drawing.Point(71, 30);
            this.tbSearchProductType.Margin = new System.Windows.Forms.Padding(2);
            this.tbSearchProductType.Name = "tbSearchProductType";
            this.tbSearchProductType.Size = new System.Drawing.Size(378, 21);
            this.tbSearchProductType.TabIndex = 2;
            this.tbSearchProductType.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSearchProductType_KeyPress);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(453, 7);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "仪器名称：";
            // 
            // tbSearchZsdwName
            // 
            this.tbSearchZsdwName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSearchZsdwName.Location = new System.Drawing.Point(71, 3);
            this.tbSearchZsdwName.Margin = new System.Windows.Forms.Padding(2);
            this.tbSearchZsdwName.Name = "tbSearchZsdwName";
            this.tbSearchZsdwName.Size = new System.Drawing.Size(378, 21);
            this.tbSearchZsdwName.TabIndex = 0;
            this.tbSearchZsdwName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSearchZsdwName_KeyPress);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(453, 34);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "出厂编号：";
            // 
            // tbSearchProductNumber
            // 
            this.tbSearchProductNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSearchProductNumber.Location = new System.Drawing.Point(522, 30);
            this.tbSearchProductNumber.Margin = new System.Windows.Forms.Padding(2);
            this.tbSearchProductNumber.Name = "tbSearchProductNumber";
            this.tbSearchProductNumber.Size = new System.Drawing.Size(378, 21);
            this.tbSearchProductNumber.TabIndex = 2;
            this.tbSearchProductNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSearchProductNumber_KeyPress);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2, 62);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 3;
            this.label5.Text = "生产厂家：";
            // 
            // tbSerachProductFactory
            // 
            this.tbSerachProductFactory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSerachProductFactory.Location = new System.Drawing.Point(71, 57);
            this.tbSerachProductFactory.Margin = new System.Windows.Forms.Padding(2);
            this.tbSerachProductFactory.Name = "tbSerachProductFactory";
            this.tbSerachProductFactory.Size = new System.Drawing.Size(378, 21);
            this.tbSerachProductFactory.TabIndex = 2;
            this.tbSerachProductFactory.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSerachProductFactory_KeyPress);
            // 
            // tbSearchTaskName
            // 
            this.tbSearchTaskName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSearchTaskName.Location = new System.Drawing.Point(522, 57);
            this.tbSearchTaskName.Margin = new System.Windows.Forms.Padding(2);
            this.tbSearchTaskName.Name = "tbSearchTaskName";
            this.tbSearchTaskName.Size = new System.Drawing.Size(378, 21);
            this.tbSearchTaskName.TabIndex = 2;
            this.tbSearchTaskName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSearchTaskName_KeyPress);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(453, 62);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 3;
            this.label6.Text = "检测地点";
            // 
            // tabPagePreview
            // 
            this.tabPagePreview.Controls.Add(this.toolStrip2);
            this.tabPagePreview.Controls.Add(this.docShow);
            this.tabPagePreview.Location = new System.Drawing.Point(4, 22);
            this.tabPagePreview.Margin = new System.Windows.Forms.Padding(2);
            this.tabPagePreview.Name = "tabPagePreview";
            this.tabPagePreview.Padding = new System.Windows.Forms.Padding(2);
            this.tabPagePreview.Size = new System.Drawing.Size(925, 505);
            this.tabPagePreview.TabIndex = 1;
            this.tabPagePreview.Text = "记录预览";
            this.tabPagePreview.UseVisualStyleBackColor = true;
            this.tabPagePreview.SizeChanged += new System.EventHandler(this.tabPagePreview_SizeChanged);
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnPrint});
            this.toolStrip2.Location = new System.Drawing.Point(2, 2);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(921, 25);
            this.toolStrip2.TabIndex = 1;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // btnPrint
            // 
            this.btnPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
            this.btnPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(36, 22);
            this.btnPrint.Text = "打印";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // docShow
            // 
            this.docShow.Enabled = true;
            this.docShow.Location = new System.Drawing.Point(4, 29);
            this.docShow.Margin = new System.Windows.Forms.Padding(2);
            this.docShow.Name = "docShow";
            this.docShow.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("docShow.OcxState")));
            this.docShow.Size = new System.Drawing.Size(914, 472);
            this.docShow.TabIndex = 0;
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "模版|*.doc*";
            // 
            // printDialog
            // 
            this.printDialog.UseEXDialog = true;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            this.id.Width = 125;
            // 
            // test_date
            // 
            this.test_date.DataPropertyName = "test_date";
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.test_date.DefaultCellStyle = dataGridViewCellStyle1;
            this.test_date.HeaderText = "检测日期";
            this.test_date.Name = "test_date";
            this.test_date.ReadOnly = true;
            // 
            // zsdw_name
            // 
            this.zsdw_name.DataPropertyName = "zsdw_name";
            this.zsdw_name.HeaderText = "被检单位";
            this.zsdw_name.MinimumWidth = 6;
            this.zsdw_name.Name = "zsdw_name";
            this.zsdw_name.ReadOnly = true;
            this.zsdw_name.Width = 125;
            // 
            // product_name
            // 
            this.product_name.DataPropertyName = "product_name";
            this.product_name.HeaderText = "仪器名称";
            this.product_name.MinimumWidth = 6;
            this.product_name.Name = "product_name";
            this.product_name.ReadOnly = true;
            this.product_name.Width = 125;
            // 
            // product_type
            // 
            this.product_type.DataPropertyName = "product_type";
            this.product_type.HeaderText = "规格型号";
            this.product_type.MinimumWidth = 6;
            this.product_type.Name = "product_type";
            this.product_type.ReadOnly = true;
            this.product_type.Width = 125;
            // 
            // product_number
            // 
            this.product_number.DataPropertyName = "product_number";
            this.product_number.HeaderText = "出产编号";
            this.product_number.MinimumWidth = 6;
            this.product_number.Name = "product_number";
            this.product_number.ReadOnly = true;
            this.product_number.Width = 125;
            // 
            // product_factory
            // 
            this.product_factory.DataPropertyName = "product_factory";
            this.product_factory.HeaderText = "生产厂家";
            this.product_factory.MinimumWidth = 6;
            this.product_factory.Name = "product_factory";
            this.product_factory.ReadOnly = true;
            this.product_factory.Width = 125;
            // 
            // task_name
            // 
            this.task_name.DataPropertyName = "task_name";
            this.task_name.HeaderText = "检测地点";
            this.task_name.MinimumWidth = 6;
            this.task_name.Name = "task_name";
            this.task_name.ReadOnly = true;
            this.task_name.Width = 125;
            // 
            // test_temperature
            // 
            this.test_temperature.DataPropertyName = "test_temperature";
            this.test_temperature.HeaderText = "温度";
            this.test_temperature.Name = "test_temperature";
            this.test_temperature.ReadOnly = true;
            this.test_temperature.Visible = false;
            // 
            // test_humidity
            // 
            this.test_humidity.DataPropertyName = "test_humidity";
            this.test_humidity.HeaderText = "湿度";
            this.test_humidity.Name = "test_humidity";
            this.test_humidity.ReadOnly = true;
            this.test_humidity.Visible = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 561);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(1080, 600);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "iMetro";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tabPageERecord.ResumeLayout(false);
            this.tabPageERecord.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tabPagePreview.ResumeLayout(false);
            this.tabPagePreview.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.docShow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageERecord;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolBtnSeach;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.TextBox tbSearchZsdwName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbSearchProductName;
        private System.Windows.Forms.TextBox tbSearchProductType;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbSearchProductNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbSerachProductFactory;
        private System.Windows.Forms.TextBox tbSearchTaskName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolStripButton btnPreivew;
        private System.Windows.Forms.TabPage tabPagePreview;
        private AxDSOFramer.AxFramerControl docShow;
        private System.Windows.Forms.ToolStripButton btnSelectTemplate;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.PrintDialog printDialog;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton btnPrint;
        private System.Windows.Forms.ToolStripButton btnPrintAll;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn test_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn zsdw_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_factory;
        private System.Windows.Forms.DataGridViewTextBoxColumn task_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn test_temperature;
        private System.Windows.Forms.DataGridViewTextBoxColumn test_humidity;
    }
}

