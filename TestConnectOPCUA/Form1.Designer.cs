namespace TestConnectOPCUA
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.connectServerCtrl1 = new Opc.Ua.Client.Controls.ConnectServerCtrl();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cbDBIntergratedSecurity = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDBPassword = new System.Windows.Forms.TextBox();
            this.txtDBUsername = new System.Windows.Forms.TextBox();
            this.txtDBName = new System.Windows.Forms.TextBox();
            this.txtDBServerAddress = new System.Windows.Forms.TextBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.txtKepwareServer = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.txtPLCSlot = new System.Windows.Forms.TextBox();
            this.txtPLCRack = new System.Windows.Forms.TextBox();
            this.Label9 = new System.Windows.Forms.Label();
            this.txtPLCIPAddress = new System.Windows.Forms.TextBox();
            this.Label10 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.lvEventsHistory = new System.Windows.Forms.ListView();
            this.button2 = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.io_out_StartBuild = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.io_out_ProductFamily = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.io_out_FGPartNumber = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.io_out_SerialNr = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.io_out_Color = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.io_out_Recipe = new System.Windows.Forms.TextBox();
            this.lbl_Recipe = new System.Windows.Forms.Label();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.cbAcknowledge = new System.Windows.Forms.CheckBox();
            this.btnExecSP_Validate_Production = new System.Windows.Forms.Button();
            this.io_in_SerialNumber = new System.Windows.Forms.TextBox();
            this.lbl_In_Override = new System.Windows.Forms.Label();
            this.lblItemIDPrefix = new System.Windows.Forms.Label();
            this.txtConnectionOK = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.txtHeartBeat = new System.Windows.Forms.TextBox();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.txtOp10P703StationName_Value = new System.Windows.Forms.TextBox();
            this.txtOp10P703StationName = new System.Windows.Forms.TextBox();
            this.txtOp10P703SerialNumber_Value = new System.Windows.Forms.TextBox();
            this.txtOp10P703SerialNumber = new System.Windows.Forms.TextBox();
            this.txtOp10P703OperationStatus_Value = new System.Windows.Forms.TextBox();
            this.txtOp10P703OperationStatus = new System.Windows.Forms.TextBox();
            this.txtOp10P703FGPartNumber_Value = new System.Windows.Forms.TextBox();
            this.txtOp10P703FGPartNumber = new System.Windows.Forms.TextBox();
            this.txtOp10J73StationName_Value = new System.Windows.Forms.TextBox();
            this.txtOp10J73StationName = new System.Windows.Forms.TextBox();
            this.txtOp10J73SerialNumber_Value = new System.Windows.Forms.TextBox();
            this.txtOp10J73SerialNumber = new System.Windows.Forms.TextBox();
            this.txtOp10J73FGOperationStatus_Value = new System.Windows.Forms.TextBox();
            this.txtOp10J73FGOperationStatus = new System.Windows.Forms.TextBox();
            this.txtOp10J73FGPartNumber_Value = new System.Windows.Forms.TextBox();
            this.txtOp10J73FGPartNumber = new System.Windows.Forms.TextBox();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.txtOp20_2_StationName_Value = new System.Windows.Forms.TextBox();
            this.textBox21 = new System.Windows.Forms.TextBox();
            this.textBox22 = new System.Windows.Forms.TextBox();
            this.txtOp20_2_StationName = new System.Windows.Forms.TextBox();
            this.txtOp20_2_OperationStatus_Value = new System.Windows.Forms.TextBox();
            this.txtOp20_2_OperationStatus = new System.Windows.Forms.TextBox();
            this.textBox26 = new System.Windows.Forms.TextBox();
            this.textBox27 = new System.Windows.Forms.TextBox();
            this.textBox28 = new System.Windows.Forms.TextBox();
            this.textBox29 = new System.Windows.Forms.TextBox();
            this.textBox30 = new System.Windows.Forms.TextBox();
            this.textBox31 = new System.Windows.Forms.TextBox();
            this.txtOp20_1_OperationStatus_Value = new System.Windows.Forms.TextBox();
            this.txtOp20_1_OperationStatus = new System.Windows.Forms.TextBox();
            this.txtOp20_1_FG_PartNumber_Value = new System.Windows.Forms.TextBox();
            this.txtOp20_1_FG_PartNumber = new System.Windows.Forms.TextBox();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.textBox36 = new System.Windows.Forms.TextBox();
            this.textBox37 = new System.Windows.Forms.TextBox();
            this.textBox38 = new System.Windows.Forms.TextBox();
            this.textBox39 = new System.Windows.Forms.TextBox();
            this.textBox40 = new System.Windows.Forms.TextBox();
            this.textBox41 = new System.Windows.Forms.TextBox();
            this.textBox42 = new System.Windows.Forms.TextBox();
            this.textBox43 = new System.Windows.Forms.TextBox();
            this.textBox44 = new System.Windows.Forms.TextBox();
            this.textBox45 = new System.Windows.Forms.TextBox();
            this.textBox46 = new System.Windows.Forms.TextBox();
            this.textBox47 = new System.Windows.Forms.TextBox();
            this.textBox48 = new System.Windows.Forms.TextBox();
            this.textBox49 = new System.Windows.Forms.TextBox();
            this.textBox50 = new System.Windows.Forms.TextBox();
            this.textBox51 = new System.Windows.Forms.TextBox();
            this.tabPage9 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.tabPage8.SuspendLayout();
            this.SuspendLayout();
            // 
            // connectServerCtrl1
            // 
            this.connectServerCtrl1.Configuration = null;
            this.connectServerCtrl1.DisableDomainCheck = false;
            this.connectServerCtrl1.Location = new System.Drawing.Point(12, 12);
            this.connectServerCtrl1.MaximumSize = new System.Drawing.Size(2048, 23);
            this.connectServerCtrl1.MinimumSize = new System.Drawing.Size(500, 23);
            this.connectServerCtrl1.Name = "connectServerCtrl1";
            this.connectServerCtrl1.PreferredLocales = null;
            this.connectServerCtrl1.ServerUrl = "";
            this.connectServerCtrl1.SessionName = "anytext";
            this.connectServerCtrl1.Size = new System.Drawing.Size(500, 23);
            this.connectServerCtrl1.StatusStrip = this.statusStrip1;
            this.connectServerCtrl1.TabIndex = 0;
            this.connectServerCtrl1.UserIdentity = null;
            this.connectServerCtrl1.UseSecurity = true;
            this.connectServerCtrl1.ConnectComplete += new System.EventHandler(this.connectServerCtrl1_ConnectComplete);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 498);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1132, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(680, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(743, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(683, 15);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(158, 20);
            this.textBox1.TabIndex = 4;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 253);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(487, 231);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cbDBIntergratedSecurity);
            this.tabPage1.Controls.Add(this.btnSave);
            this.tabPage1.Controls.Add(this.Label4);
            this.tabPage1.Controls.Add(this.Label3);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.txtDBPassword);
            this.tabPage1.Controls.Add(this.txtDBUsername);
            this.tabPage1.Controls.Add(this.txtDBName);
            this.tabPage1.Controls.Add(this.txtDBServerAddress);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(479, 205);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "ODBC";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cbDBIntergratedSecurity
            // 
            this.cbDBIntergratedSecurity.AutoSize = true;
            this.cbDBIntergratedSecurity.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDBIntergratedSecurity.Location = new System.Drawing.Point(174, 141);
            this.cbDBIntergratedSecurity.Name = "cbDBIntergratedSecurity";
            this.cbDBIntergratedSecurity.Size = new System.Drawing.Size(129, 19);
            this.cbDBIntergratedSecurity.TabIndex = 11;
            this.cbDBIntergratedSecurity.Text = "Integrated Security";
            this.cbDBIntergratedSecurity.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(174, 168);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(256, 27);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Test And Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(27, 107);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(82, 15);
            this.Label4.TabIndex = 2;
            this.Label4.Text = "DB Password:";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(27, 76);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(83, 15);
            this.Label3.TabIndex = 3;
            this.Label3.Text = "DB Username:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "DB Name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(27, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "DB Server Address:";
            // 
            // txtDBPassword
            // 
            this.txtDBPassword.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDBPassword.Location = new System.Drawing.Point(174, 107);
            this.txtDBPassword.Name = "txtDBPassword";
            this.txtDBPassword.PasswordChar = '*';
            this.txtDBPassword.Size = new System.Drawing.Size(256, 23);
            this.txtDBPassword.TabIndex = 6;
            this.txtDBPassword.Text = "1Ti4puraeg3@";
            // 
            // txtDBUsername
            // 
            this.txtDBUsername.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDBUsername.Location = new System.Drawing.Point(174, 76);
            this.txtDBUsername.Name = "txtDBUsername";
            this.txtDBUsername.Size = new System.Drawing.Size(256, 23);
            this.txtDBUsername.TabIndex = 7;
            this.txtDBUsername.Text = "ph17694754111";
            // 
            // txtDBName
            // 
            this.txtDBName.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDBName.Location = new System.Drawing.Point(174, 45);
            this.txtDBName.Name = "txtDBName";
            this.txtDBName.Size = new System.Drawing.Size(256, 23);
            this.txtDBName.TabIndex = 8;
            this.txtDBName.Text = "test";
            // 
            // txtDBServerAddress
            // 
            this.txtDBServerAddress.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDBServerAddress.Location = new System.Drawing.Point(174, 13);
            this.txtDBServerAddress.Name = "txtDBServerAddress";
            this.txtDBServerAddress.Size = new System.Drawing.Size(256, 23);
            this.txtDBServerAddress.TabIndex = 9;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.button3);
            this.tabPage5.Controls.Add(this.label15);
            this.tabPage5.Controls.Add(this.txtKepwareServer);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(479, 205);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Kepware";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(233, 69);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(176, 33);
            this.button3.TabIndex = 13;
            this.button3.Text = "Test And Save";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(22, 25);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(109, 19);
            this.label15.TabIndex = 11;
            this.label15.Text = "Server Address:";
            // 
            // txtKepwareServer
            // 
            this.txtKepwareServer.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKepwareServer.Location = new System.Drawing.Point(169, 25);
            this.txtKepwareServer.Name = "txtKepwareServer";
            this.txtKepwareServer.Size = new System.Drawing.Size(240, 27);
            this.txtKepwareServer.TabIndex = 12;
            this.txtKepwareServer.Text = "opc.tcp://192.168.0.40:4316";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.txtPLCSlot);
            this.tabPage2.Controls.Add(this.txtPLCRack);
            this.tabPage2.Controls.Add(this.Label9);
            this.tabPage2.Controls.Add(this.txtPLCIPAddress);
            this.tabPage2.Controls.Add(this.Label10);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(479, 205);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "PLC Settings";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(200, 108);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 33);
            this.button1.TabIndex = 11;
            this.button1.Text = "Test And Save";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtPLCSlot
            // 
            this.txtPLCSlot.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPLCSlot.Location = new System.Drawing.Point(336, 62);
            this.txtPLCSlot.Name = "txtPLCSlot";
            this.txtPLCSlot.Size = new System.Drawing.Size(40, 27);
            this.txtPLCSlot.TabIndex = 4;
            // 
            // txtPLCRack
            // 
            this.txtPLCRack.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPLCRack.Location = new System.Drawing.Point(200, 62);
            this.txtPLCRack.Name = "txtPLCRack";
            this.txtPLCRack.Size = new System.Drawing.Size(51, 27);
            this.txtPLCRack.TabIndex = 5;
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label9.Location = new System.Drawing.Point(21, 65);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(94, 19);
            this.Label9.TabIndex = 2;
            this.Label9.Text = "PLC Rack No.";
            // 
            // txtPLCIPAddress
            // 
            this.txtPLCIPAddress.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPLCIPAddress.Location = new System.Drawing.Point(200, 27);
            this.txtPLCIPAddress.Name = "txtPLCIPAddress";
            this.txtPLCIPAddress.Size = new System.Drawing.Size(176, 27);
            this.txtPLCIPAddress.TabIndex = 6;
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label10.Location = new System.Drawing.Point(21, 30);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(105, 19);
            this.Label10.TabIndex = 3;
            this.Label10.Text = "PLC IP Address";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.lvEventsHistory);
            this.tabPage4.Controls.Add(this.button2);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(479, 205);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Events Log";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // lvEventsHistory
            // 
            this.lvEventsHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lvEventsHistory.HideSelection = false;
            this.lvEventsHistory.Location = new System.Drawing.Point(20, 13);
            this.lvEventsHistory.Name = "lvEventsHistory";
            this.lvEventsHistory.Size = new System.Drawing.Size(607, 123);
            this.lvEventsHistory.TabIndex = 13;
            this.lvEventsHistory.UseCompatibleStateImageBehavior = false;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(451, 154);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(176, 33);
            this.button2.TabIndex = 12;
            this.button2.Text = "Export Events";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(479, 205);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "System Settings";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.io_out_StartBuild);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.io_out_ProductFamily);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.io_out_FGPartNumber);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.io_out_SerialNr);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.io_out_Color);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.io_out_Recipe);
            this.groupBox2.Controls.Add(this.lbl_Recipe);
            this.groupBox2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(724, 288);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(339, 196);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Out from ODBC";
            // 
            // io_out_StartBuild
            // 
            this.io_out_StartBuild.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.io_out_StartBuild.Location = new System.Drawing.Point(139, 106);
            this.io_out_StartBuild.Name = "io_out_StartBuild";
            this.io_out_StartBuild.Size = new System.Drawing.Size(155, 23);
            this.io_out_StartBuild.TabIndex = 24;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(21, 107);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 15);
            this.label12.TabIndex = 23;
            this.label12.Text = "Start Build";
            // 
            // io_out_ProductFamily
            // 
            this.io_out_ProductFamily.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.io_out_ProductFamily.Location = new System.Drawing.Point(139, 165);
            this.io_out_ProductFamily.Name = "io_out_ProductFamily";
            this.io_out_ProductFamily.Size = new System.Drawing.Size(155, 23);
            this.io_out_ProductFamily.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(21, 169);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 15);
            this.label8.TabIndex = 19;
            this.label8.Text = "Product Family";
            // 
            // io_out_FGPartNumber
            // 
            this.io_out_FGPartNumber.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.io_out_FGPartNumber.Location = new System.Drawing.Point(139, 134);
            this.io_out_FGPartNumber.Name = "io_out_FGPartNumber";
            this.io_out_FGPartNumber.Size = new System.Drawing.Size(155, 23);
            this.io_out_FGPartNumber.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(21, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 15);
            this.label7.TabIndex = 17;
            this.label7.Text = "FG Part ";
            // 
            // io_out_SerialNr
            // 
            this.io_out_SerialNr.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.io_out_SerialNr.Location = new System.Drawing.Point(139, 76);
            this.io_out_SerialNr.Name = "io_out_SerialNr";
            this.io_out_SerialNr.Size = new System.Drawing.Size(155, 23);
            this.io_out_SerialNr.TabIndex = 16;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(21, 82);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 15);
            this.label13.TabIndex = 15;
            this.label13.Text = "SerialNr";
            // 
            // io_out_Color
            // 
            this.io_out_Color.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.io_out_Color.Location = new System.Drawing.Point(139, 49);
            this.io_out_Color.Name = "io_out_Color";
            this.io_out_Color.Size = new System.Drawing.Size(155, 23);
            this.io_out_Color.TabIndex = 14;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(21, 52);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(37, 15);
            this.label14.TabIndex = 13;
            this.label14.Text = "Color";
            // 
            // io_out_Recipe
            // 
            this.io_out_Recipe.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.io_out_Recipe.Location = new System.Drawing.Point(139, 22);
            this.io_out_Recipe.Name = "io_out_Recipe";
            this.io_out_Recipe.Size = new System.Drawing.Size(155, 23);
            this.io_out_Recipe.TabIndex = 12;
            // 
            // lbl_Recipe
            // 
            this.lbl_Recipe.AutoSize = true;
            this.lbl_Recipe.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Recipe.Location = new System.Drawing.Point(21, 25);
            this.lbl_Recipe.Name = "lbl_Recipe";
            this.lbl_Recipe.Size = new System.Drawing.Size(43, 15);
            this.lbl_Recipe.TabIndex = 1;
            this.lbl_Recipe.Text = "Recipe";
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.cbAcknowledge);
            this.GroupBox1.Controls.Add(this.btnExecSP_Validate_Production);
            this.GroupBox1.Controls.Add(this.io_in_SerialNumber);
            this.GroupBox1.Controls.Add(this.lbl_In_Override);
            this.GroupBox1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox1.Location = new System.Drawing.Point(510, 288);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(204, 196);
            this.GroupBox1.TabIndex = 7;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Out from PLC";
            // 
            // cbAcknowledge
            // 
            this.cbAcknowledge.AutoSize = true;
            this.cbAcknowledge.Location = new System.Drawing.Point(24, 26);
            this.cbAcknowledge.Name = "cbAcknowledge";
            this.cbAcknowledge.Size = new System.Drawing.Size(97, 19);
            this.cbAcknowledge.TabIndex = 13;
            this.cbAcknowledge.Text = "Acknowledge";
            this.cbAcknowledge.UseVisualStyleBackColor = true;
            // 
            // btnExecSP_Validate_Production
            // 
            this.btnExecSP_Validate_Production.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExecSP_Validate_Production.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExecSP_Validate_Production.Location = new System.Drawing.Point(24, 134);
            this.btnExecSP_Validate_Production.Name = "btnExecSP_Validate_Production";
            this.btnExecSP_Validate_Production.Size = new System.Drawing.Size(151, 33);
            this.btnExecSP_Validate_Production.TabIndex = 12;
            this.btnExecSP_Validate_Production.Text = "EXEC SP";
            this.btnExecSP_Validate_Production.UseVisualStyleBackColor = true;
            // 
            // io_in_SerialNumber
            // 
            this.io_in_SerialNumber.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.io_in_SerialNumber.Location = new System.Drawing.Point(24, 88);
            this.io_in_SerialNumber.Name = "io_in_SerialNumber";
            this.io_in_SerialNumber.Size = new System.Drawing.Size(149, 27);
            this.io_in_SerialNumber.TabIndex = 11;
            this.io_in_SerialNumber.Text = "N1WB177-NG";
            this.io_in_SerialNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_In_Override
            // 
            this.lbl_In_Override.AutoSize = true;
            this.lbl_In_Override.Location = new System.Drawing.Point(20, 64);
            this.lbl_In_Override.Name = "lbl_In_Override";
            this.lbl_In_Override.Size = new System.Drawing.Size(82, 15);
            this.lbl_In_Override.TabIndex = 1;
            this.lbl_In_Override.Text = "SerialNumber";
            // 
            // lblItemIDPrefix
            // 
            this.lblItemIDPrefix.AutoSize = true;
            this.lblItemIDPrefix.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemIDPrefix.Location = new System.Drawing.Point(14, 46);
            this.lblItemIDPrefix.Name = "lblItemIDPrefix";
            this.lblItemIDPrefix.Size = new System.Drawing.Size(412, 15);
            this.lblItemIDPrefix.TabIndex = 9;
            this.lblItemIDPrefix.Text = "PLC_StationRSB_New.PLC_StationRSB_New.Program_blocks.Qmuzik_trigger.";
            // 
            // txtConnectionOK
            // 
            this.txtConnectionOK.Location = new System.Drawing.Point(17, 117);
            this.txtConnectionOK.Name = "txtConnectionOK";
            this.txtConnectionOK.Size = new System.Drawing.Size(110, 20);
            this.txtConnectionOK.TabIndex = 11;
            this.txtConnectionOK.Text = "ConnectionOK";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.DarkRed;
            this.textBox2.Location = new System.Drawing.Point(144, 117);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(41, 20);
            this.textBox2.TabIndex = 12;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.DarkRed;
            this.textBox3.Location = new System.Drawing.Point(144, 143);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(41, 20);
            this.textBox3.TabIndex = 14;
            // 
            // txtHeartBeat
            // 
            this.txtHeartBeat.Location = new System.Drawing.Point(17, 143);
            this.txtHeartBeat.Name = "txtHeartBeat";
            this.txtHeartBeat.Size = new System.Drawing.Size(110, 20);
            this.txtHeartBeat.TabIndex = 13;
            this.txtHeartBeat.Text = "Heart Beat";
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage6);
            this.tabControl2.Controls.Add(this.tabPage7);
            this.tabControl2.Controls.Add(this.tabPage8);
            this.tabControl2.Controls.Add(this.tabPage9);
            this.tabControl2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl2.Location = new System.Drawing.Point(217, 67);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(847, 182);
            this.tabControl2.TabIndex = 15;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.txtOp10P703StationName_Value);
            this.tabPage6.Controls.Add(this.txtOp10P703StationName);
            this.tabPage6.Controls.Add(this.txtOp10P703SerialNumber_Value);
            this.tabPage6.Controls.Add(this.txtOp10P703SerialNumber);
            this.tabPage6.Controls.Add(this.txtOp10P703OperationStatus_Value);
            this.tabPage6.Controls.Add(this.txtOp10P703OperationStatus);
            this.tabPage6.Controls.Add(this.txtOp10P703FGPartNumber_Value);
            this.tabPage6.Controls.Add(this.txtOp10P703FGPartNumber);
            this.tabPage6.Controls.Add(this.txtOp10J73StationName_Value);
            this.tabPage6.Controls.Add(this.txtOp10J73StationName);
            this.tabPage6.Controls.Add(this.txtOp10J73SerialNumber_Value);
            this.tabPage6.Controls.Add(this.txtOp10J73SerialNumber);
            this.tabPage6.Controls.Add(this.txtOp10J73FGOperationStatus_Value);
            this.tabPage6.Controls.Add(this.txtOp10J73FGOperationStatus);
            this.tabPage6.Controls.Add(this.txtOp10J73FGPartNumber_Value);
            this.tabPage6.Controls.Add(this.txtOp10J73FGPartNumber);
            this.tabPage6.Location = new System.Drawing.Point(4, 24);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(839, 154);
            this.tabPage6.TabIndex = 0;
            this.tabPage6.Text = "OP 10";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // txtOp10P703StationName_Value
            // 
            this.txtOp10P703StationName_Value.BackColor = System.Drawing.Color.LightGray;
            this.txtOp10P703StationName_Value.Location = new System.Drawing.Point(598, 108);
            this.txtOp10P703StationName_Value.Name = "txtOp10P703StationName_Value";
            this.txtOp10P703StationName_Value.Size = new System.Drawing.Size(150, 23);
            this.txtOp10P703StationName_Value.TabIndex = 30;
            // 
            // txtOp10P703StationName
            // 
            this.txtOp10P703StationName.Location = new System.Drawing.Point(406, 108);
            this.txtOp10P703StationName.Name = "txtOp10P703StationName";
            this.txtOp10P703StationName.Size = new System.Drawing.Size(182, 23);
            this.txtOp10P703StationName.TabIndex = 29;
            this.txtOp10P703StationName.Text = "P703.Station Name";
            // 
            // txtOp10P703SerialNumber_Value
            // 
            this.txtOp10P703SerialNumber_Value.BackColor = System.Drawing.Color.LightGray;
            this.txtOp10P703SerialNumber_Value.Location = new System.Drawing.Point(598, 78);
            this.txtOp10P703SerialNumber_Value.Name = "txtOp10P703SerialNumber_Value";
            this.txtOp10P703SerialNumber_Value.Size = new System.Drawing.Size(150, 23);
            this.txtOp10P703SerialNumber_Value.TabIndex = 28;
            // 
            // txtOp10P703SerialNumber
            // 
            this.txtOp10P703SerialNumber.Location = new System.Drawing.Point(406, 78);
            this.txtOp10P703SerialNumber.Name = "txtOp10P703SerialNumber";
            this.txtOp10P703SerialNumber.Size = new System.Drawing.Size(182, 23);
            this.txtOp10P703SerialNumber.TabIndex = 27;
            this.txtOp10P703SerialNumber.Text = "P703.SerialNumber";
            // 
            // txtOp10P703OperationStatus_Value
            // 
            this.txtOp10P703OperationStatus_Value.BackColor = System.Drawing.Color.LightGray;
            this.txtOp10P703OperationStatus_Value.Location = new System.Drawing.Point(598, 49);
            this.txtOp10P703OperationStatus_Value.Name = "txtOp10P703OperationStatus_Value";
            this.txtOp10P703OperationStatus_Value.Size = new System.Drawing.Size(150, 23);
            this.txtOp10P703OperationStatus_Value.TabIndex = 26;
            // 
            // txtOp10P703OperationStatus
            // 
            this.txtOp10P703OperationStatus.Location = new System.Drawing.Point(406, 49);
            this.txtOp10P703OperationStatus.Name = "txtOp10P703OperationStatus";
            this.txtOp10P703OperationStatus.Size = new System.Drawing.Size(182, 23);
            this.txtOp10P703OperationStatus.TabIndex = 25;
            this.txtOp10P703OperationStatus.Text = "P703.OperationStatus";
            // 
            // txtOp10P703FGPartNumber_Value
            // 
            this.txtOp10P703FGPartNumber_Value.BackColor = System.Drawing.Color.LightGray;
            this.txtOp10P703FGPartNumber_Value.Location = new System.Drawing.Point(598, 19);
            this.txtOp10P703FGPartNumber_Value.Name = "txtOp10P703FGPartNumber_Value";
            this.txtOp10P703FGPartNumber_Value.Size = new System.Drawing.Size(150, 23);
            this.txtOp10P703FGPartNumber_Value.TabIndex = 24;
            // 
            // txtOp10P703FGPartNumber
            // 
            this.txtOp10P703FGPartNumber.Location = new System.Drawing.Point(406, 19);
            this.txtOp10P703FGPartNumber.Name = "txtOp10P703FGPartNumber";
            this.txtOp10P703FGPartNumber.Size = new System.Drawing.Size(182, 23);
            this.txtOp10P703FGPartNumber.TabIndex = 23;
            this.txtOp10P703FGPartNumber.Text = "P703.FG Part Number";
            // 
            // txtOp10J73StationName_Value
            // 
            this.txtOp10J73StationName_Value.BackColor = System.Drawing.Color.LightGray;
            this.txtOp10J73StationName_Value.Location = new System.Drawing.Point(212, 108);
            this.txtOp10J73StationName_Value.Name = "txtOp10J73StationName_Value";
            this.txtOp10J73StationName_Value.Size = new System.Drawing.Size(150, 23);
            this.txtOp10J73StationName_Value.TabIndex = 22;
            // 
            // txtOp10J73StationName
            // 
            this.txtOp10J73StationName.Location = new System.Drawing.Point(20, 108);
            this.txtOp10J73StationName.Name = "txtOp10J73StationName";
            this.txtOp10J73StationName.Size = new System.Drawing.Size(182, 23);
            this.txtOp10J73StationName.TabIndex = 21;
            this.txtOp10J73StationName.Text = "J73.Station Name";
            // 
            // txtOp10J73SerialNumber_Value
            // 
            this.txtOp10J73SerialNumber_Value.BackColor = System.Drawing.Color.LightGray;
            this.txtOp10J73SerialNumber_Value.Location = new System.Drawing.Point(212, 78);
            this.txtOp10J73SerialNumber_Value.Name = "txtOp10J73SerialNumber_Value";
            this.txtOp10J73SerialNumber_Value.Size = new System.Drawing.Size(150, 23);
            this.txtOp10J73SerialNumber_Value.TabIndex = 20;
            // 
            // txtOp10J73SerialNumber
            // 
            this.txtOp10J73SerialNumber.Location = new System.Drawing.Point(20, 78);
            this.txtOp10J73SerialNumber.Name = "txtOp10J73SerialNumber";
            this.txtOp10J73SerialNumber.Size = new System.Drawing.Size(182, 23);
            this.txtOp10J73SerialNumber.TabIndex = 19;
            this.txtOp10J73SerialNumber.Text = "J73.SerialNumber";
            // 
            // txtOp10J73FGOperationStatus_Value
            // 
            this.txtOp10J73FGOperationStatus_Value.BackColor = System.Drawing.Color.LightGray;
            this.txtOp10J73FGOperationStatus_Value.Location = new System.Drawing.Point(212, 49);
            this.txtOp10J73FGOperationStatus_Value.Name = "txtOp10J73FGOperationStatus_Value";
            this.txtOp10J73FGOperationStatus_Value.Size = new System.Drawing.Size(150, 23);
            this.txtOp10J73FGOperationStatus_Value.TabIndex = 18;
            // 
            // txtOp10J73FGOperationStatus
            // 
            this.txtOp10J73FGOperationStatus.Location = new System.Drawing.Point(20, 49);
            this.txtOp10J73FGOperationStatus.Name = "txtOp10J73FGOperationStatus";
            this.txtOp10J73FGOperationStatus.Size = new System.Drawing.Size(182, 23);
            this.txtOp10J73FGOperationStatus.TabIndex = 17;
            this.txtOp10J73FGOperationStatus.Text = "J73.OperationStatus";
            // 
            // txtOp10J73FGPartNumber_Value
            // 
            this.txtOp10J73FGPartNumber_Value.BackColor = System.Drawing.Color.LightGray;
            this.txtOp10J73FGPartNumber_Value.Location = new System.Drawing.Point(212, 19);
            this.txtOp10J73FGPartNumber_Value.Name = "txtOp10J73FGPartNumber_Value";
            this.txtOp10J73FGPartNumber_Value.Size = new System.Drawing.Size(150, 23);
            this.txtOp10J73FGPartNumber_Value.TabIndex = 16;
            // 
            // txtOp10J73FGPartNumber
            // 
            this.txtOp10J73FGPartNumber.Location = new System.Drawing.Point(20, 19);
            this.txtOp10J73FGPartNumber.Name = "txtOp10J73FGPartNumber";
            this.txtOp10J73FGPartNumber.Size = new System.Drawing.Size(182, 23);
            this.txtOp10J73FGPartNumber.TabIndex = 15;
            this.txtOp10J73FGPartNumber.Text = "J73.FG Part Number";
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.txtOp20_2_StationName_Value);
            this.tabPage7.Controls.Add(this.textBox21);
            this.tabPage7.Controls.Add(this.textBox22);
            this.tabPage7.Controls.Add(this.txtOp20_2_StationName);
            this.tabPage7.Controls.Add(this.txtOp20_2_OperationStatus_Value);
            this.tabPage7.Controls.Add(this.txtOp20_2_OperationStatus);
            this.tabPage7.Controls.Add(this.textBox26);
            this.tabPage7.Controls.Add(this.textBox27);
            this.tabPage7.Controls.Add(this.textBox28);
            this.tabPage7.Controls.Add(this.textBox29);
            this.tabPage7.Controls.Add(this.textBox30);
            this.tabPage7.Controls.Add(this.textBox31);
            this.tabPage7.Controls.Add(this.txtOp20_1_OperationStatus_Value);
            this.tabPage7.Controls.Add(this.txtOp20_1_OperationStatus);
            this.tabPage7.Controls.Add(this.txtOp20_1_FG_PartNumber_Value);
            this.tabPage7.Controls.Add(this.txtOp20_1_FG_PartNumber);
            this.tabPage7.Location = new System.Drawing.Point(4, 24);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(839, 154);
            this.tabPage7.TabIndex = 1;
            this.tabPage7.Text = "OP 20";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // txtOp20_2_StationName_Value
            // 
            this.txtOp20_2_StationName_Value.BackColor = System.Drawing.Color.LightGray;
            this.txtOp20_2_StationName_Value.Location = new System.Drawing.Point(598, 108);
            this.txtOp20_2_StationName_Value.Name = "txtOp20_2_StationName_Value";
            this.txtOp20_2_StationName_Value.Size = new System.Drawing.Size(150, 23);
            this.txtOp20_2_StationName_Value.TabIndex = 46;
            // 
            // textBox21
            // 
            this.textBox21.Location = new System.Drawing.Point(406, 108);
            this.textBox21.Name = "textBox21";
            this.textBox21.Size = new System.Drawing.Size(182, 23);
            this.textBox21.TabIndex = 45;
            this.textBox21.Text = "-2.Station Name";
            // 
            // textBox22
            // 
            this.textBox22.BackColor = System.Drawing.Color.LightGray;
            this.textBox22.Location = new System.Drawing.Point(598, 78);
            this.textBox22.Name = "textBox22";
            this.textBox22.Size = new System.Drawing.Size(150, 23);
            this.textBox22.TabIndex = 44;
            // 
            // txtOp20_2_StationName
            // 
            this.txtOp20_2_StationName.Location = new System.Drawing.Point(406, 78);
            this.txtOp20_2_StationName.Name = "txtOp20_2_StationName";
            this.txtOp20_2_StationName.Size = new System.Drawing.Size(182, 23);
            this.txtOp20_2_StationName.TabIndex = 43;
            this.txtOp20_2_StationName.Text = "-2.SerialNumber";
            // 
            // txtOp20_2_OperationStatus_Value
            // 
            this.txtOp20_2_OperationStatus_Value.BackColor = System.Drawing.Color.LightGray;
            this.txtOp20_2_OperationStatus_Value.Location = new System.Drawing.Point(598, 49);
            this.txtOp20_2_OperationStatus_Value.Name = "txtOp20_2_OperationStatus_Value";
            this.txtOp20_2_OperationStatus_Value.Size = new System.Drawing.Size(150, 23);
            this.txtOp20_2_OperationStatus_Value.TabIndex = 42;
            // 
            // txtOp20_2_OperationStatus
            // 
            this.txtOp20_2_OperationStatus.Location = new System.Drawing.Point(406, 49);
            this.txtOp20_2_OperationStatus.Name = "txtOp20_2_OperationStatus";
            this.txtOp20_2_OperationStatus.Size = new System.Drawing.Size(182, 23);
            this.txtOp20_2_OperationStatus.TabIndex = 41;
            this.txtOp20_2_OperationStatus.Text = "-2.OperationStatus";
            // 
            // textBox26
            // 
            this.textBox26.BackColor = System.Drawing.Color.LightGray;
            this.textBox26.Location = new System.Drawing.Point(598, 19);
            this.textBox26.Name = "textBox26";
            this.textBox26.Size = new System.Drawing.Size(150, 23);
            this.textBox26.TabIndex = 40;
            // 
            // textBox27
            // 
            this.textBox27.Location = new System.Drawing.Point(406, 19);
            this.textBox27.Name = "textBox27";
            this.textBox27.Size = new System.Drawing.Size(182, 23);
            this.textBox27.TabIndex = 39;
            this.textBox27.Text = "-2.FG Part Number";
            // 
            // textBox28
            // 
            this.textBox28.BackColor = System.Drawing.Color.LightGray;
            this.textBox28.Location = new System.Drawing.Point(212, 108);
            this.textBox28.Name = "textBox28";
            this.textBox28.Size = new System.Drawing.Size(150, 23);
            this.textBox28.TabIndex = 38;
            // 
            // textBox29
            // 
            this.textBox29.Location = new System.Drawing.Point(20, 108);
            this.textBox29.Name = "textBox29";
            this.textBox29.Size = new System.Drawing.Size(182, 23);
            this.textBox29.TabIndex = 37;
            this.textBox29.Text = "-1.Station Name";
            // 
            // textBox30
            // 
            this.textBox30.BackColor = System.Drawing.Color.LightGray;
            this.textBox30.Location = new System.Drawing.Point(212, 78);
            this.textBox30.Name = "textBox30";
            this.textBox30.Size = new System.Drawing.Size(150, 23);
            this.textBox30.TabIndex = 36;
            // 
            // textBox31
            // 
            this.textBox31.Location = new System.Drawing.Point(20, 78);
            this.textBox31.Name = "textBox31";
            this.textBox31.Size = new System.Drawing.Size(182, 23);
            this.textBox31.TabIndex = 35;
            this.textBox31.Text = "-1.SerialNumber";
            // 
            // txtOp20_1_OperationStatus_Value
            // 
            this.txtOp20_1_OperationStatus_Value.BackColor = System.Drawing.Color.LightGray;
            this.txtOp20_1_OperationStatus_Value.Location = new System.Drawing.Point(212, 49);
            this.txtOp20_1_OperationStatus_Value.Name = "txtOp20_1_OperationStatus_Value";
            this.txtOp20_1_OperationStatus_Value.Size = new System.Drawing.Size(150, 23);
            this.txtOp20_1_OperationStatus_Value.TabIndex = 34;
            // 
            // txtOp20_1_OperationStatus
            // 
            this.txtOp20_1_OperationStatus.Location = new System.Drawing.Point(20, 49);
            this.txtOp20_1_OperationStatus.Name = "txtOp20_1_OperationStatus";
            this.txtOp20_1_OperationStatus.Size = new System.Drawing.Size(182, 23);
            this.txtOp20_1_OperationStatus.TabIndex = 33;
            this.txtOp20_1_OperationStatus.Text = "-1.OperationStatus";
            // 
            // txtOp20_1_FG_PartNumber_Value
            // 
            this.txtOp20_1_FG_PartNumber_Value.BackColor = System.Drawing.Color.LightGray;
            this.txtOp20_1_FG_PartNumber_Value.Location = new System.Drawing.Point(212, 19);
            this.txtOp20_1_FG_PartNumber_Value.Name = "txtOp20_1_FG_PartNumber_Value";
            this.txtOp20_1_FG_PartNumber_Value.Size = new System.Drawing.Size(150, 23);
            this.txtOp20_1_FG_PartNumber_Value.TabIndex = 32;
            // 
            // txtOp20_1_FG_PartNumber
            // 
            this.txtOp20_1_FG_PartNumber.Location = new System.Drawing.Point(20, 19);
            this.txtOp20_1_FG_PartNumber.Name = "txtOp20_1_FG_PartNumber";
            this.txtOp20_1_FG_PartNumber.Size = new System.Drawing.Size(182, 23);
            this.txtOp20_1_FG_PartNumber.TabIndex = 31;
            this.txtOp20_1_FG_PartNumber.Text = "-1.FG Part Number";
            // 
            // tabPage8
            // 
            this.tabPage8.Controls.Add(this.textBox36);
            this.tabPage8.Controls.Add(this.textBox37);
            this.tabPage8.Controls.Add(this.textBox38);
            this.tabPage8.Controls.Add(this.textBox39);
            this.tabPage8.Controls.Add(this.textBox40);
            this.tabPage8.Controls.Add(this.textBox41);
            this.tabPage8.Controls.Add(this.textBox42);
            this.tabPage8.Controls.Add(this.textBox43);
            this.tabPage8.Controls.Add(this.textBox44);
            this.tabPage8.Controls.Add(this.textBox45);
            this.tabPage8.Controls.Add(this.textBox46);
            this.tabPage8.Controls.Add(this.textBox47);
            this.tabPage8.Controls.Add(this.textBox48);
            this.tabPage8.Controls.Add(this.textBox49);
            this.tabPage8.Controls.Add(this.textBox50);
            this.tabPage8.Controls.Add(this.textBox51);
            this.tabPage8.Location = new System.Drawing.Point(4, 24);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Size = new System.Drawing.Size(839, 154);
            this.tabPage8.TabIndex = 2;
            this.tabPage8.Text = "OP 30";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // textBox36
            // 
            this.textBox36.BackColor = System.Drawing.Color.LightGray;
            this.textBox36.Location = new System.Drawing.Point(598, 108);
            this.textBox36.Name = "textBox36";
            this.textBox36.Size = new System.Drawing.Size(150, 23);
            this.textBox36.TabIndex = 62;
            // 
            // textBox37
            // 
            this.textBox37.Location = new System.Drawing.Point(406, 108);
            this.textBox37.Name = "textBox37";
            this.textBox37.Size = new System.Drawing.Size(182, 23);
            this.textBox37.TabIndex = 61;
            this.textBox37.Text = "-2.Station Name";
            // 
            // textBox38
            // 
            this.textBox38.BackColor = System.Drawing.Color.LightGray;
            this.textBox38.Location = new System.Drawing.Point(598, 78);
            this.textBox38.Name = "textBox38";
            this.textBox38.Size = new System.Drawing.Size(150, 23);
            this.textBox38.TabIndex = 60;
            // 
            // textBox39
            // 
            this.textBox39.Location = new System.Drawing.Point(406, 78);
            this.textBox39.Name = "textBox39";
            this.textBox39.Size = new System.Drawing.Size(182, 23);
            this.textBox39.TabIndex = 59;
            this.textBox39.Text = "-2.SerialNumber";
            // 
            // textBox40
            // 
            this.textBox40.BackColor = System.Drawing.Color.LightGray;
            this.textBox40.Location = new System.Drawing.Point(598, 49);
            this.textBox40.Name = "textBox40";
            this.textBox40.Size = new System.Drawing.Size(150, 23);
            this.textBox40.TabIndex = 58;
            // 
            // textBox41
            // 
            this.textBox41.Location = new System.Drawing.Point(406, 49);
            this.textBox41.Name = "textBox41";
            this.textBox41.Size = new System.Drawing.Size(182, 23);
            this.textBox41.TabIndex = 57;
            this.textBox41.Text = "-2.OperationStatus";
            // 
            // textBox42
            // 
            this.textBox42.BackColor = System.Drawing.Color.LightGray;
            this.textBox42.Location = new System.Drawing.Point(598, 19);
            this.textBox42.Name = "textBox42";
            this.textBox42.Size = new System.Drawing.Size(150, 23);
            this.textBox42.TabIndex = 56;
            // 
            // textBox43
            // 
            this.textBox43.Location = new System.Drawing.Point(406, 19);
            this.textBox43.Name = "textBox43";
            this.textBox43.Size = new System.Drawing.Size(182, 23);
            this.textBox43.TabIndex = 55;
            this.textBox43.Text = "-2.FG Part Number";
            // 
            // textBox44
            // 
            this.textBox44.BackColor = System.Drawing.Color.LightGray;
            this.textBox44.Location = new System.Drawing.Point(212, 108);
            this.textBox44.Name = "textBox44";
            this.textBox44.Size = new System.Drawing.Size(150, 23);
            this.textBox44.TabIndex = 54;
            // 
            // textBox45
            // 
            this.textBox45.Location = new System.Drawing.Point(20, 108);
            this.textBox45.Name = "textBox45";
            this.textBox45.Size = new System.Drawing.Size(182, 23);
            this.textBox45.TabIndex = 53;
            this.textBox45.Text = "-1.Station Name";
            // 
            // textBox46
            // 
            this.textBox46.BackColor = System.Drawing.Color.LightGray;
            this.textBox46.Location = new System.Drawing.Point(212, 78);
            this.textBox46.Name = "textBox46";
            this.textBox46.Size = new System.Drawing.Size(150, 23);
            this.textBox46.TabIndex = 52;
            // 
            // textBox47
            // 
            this.textBox47.Location = new System.Drawing.Point(20, 78);
            this.textBox47.Name = "textBox47";
            this.textBox47.Size = new System.Drawing.Size(182, 23);
            this.textBox47.TabIndex = 51;
            this.textBox47.Text = "-1.SerialNumber";
            // 
            // textBox48
            // 
            this.textBox48.BackColor = System.Drawing.Color.LightGray;
            this.textBox48.Location = new System.Drawing.Point(212, 49);
            this.textBox48.Name = "textBox48";
            this.textBox48.Size = new System.Drawing.Size(150, 23);
            this.textBox48.TabIndex = 50;
            // 
            // textBox49
            // 
            this.textBox49.Location = new System.Drawing.Point(20, 49);
            this.textBox49.Name = "textBox49";
            this.textBox49.Size = new System.Drawing.Size(182, 23);
            this.textBox49.TabIndex = 49;
            this.textBox49.Text = "-1.OperationStatus";
            // 
            // textBox50
            // 
            this.textBox50.BackColor = System.Drawing.Color.LightGray;
            this.textBox50.Location = new System.Drawing.Point(212, 19);
            this.textBox50.Name = "textBox50";
            this.textBox50.Size = new System.Drawing.Size(150, 23);
            this.textBox50.TabIndex = 48;
            // 
            // textBox51
            // 
            this.textBox51.Location = new System.Drawing.Point(20, 19);
            this.textBox51.Name = "textBox51";
            this.textBox51.Size = new System.Drawing.Size(182, 23);
            this.textBox51.TabIndex = 47;
            this.textBox51.Text = "-1.FG Part Number";
            // 
            // tabPage9
            // 
            this.tabPage9.Location = new System.Drawing.Point(4, 24);
            this.tabPage9.Name = "tabPage9";
            this.tabPage9.Size = new System.Drawing.Size(839, 154);
            this.tabPage9.TabIndex = 3;
            this.tabPage9.Text = "OP 40";
            this.tabPage9.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 520);
            this.Controls.Add(this.tabControl2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.txtHeartBeat);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txtConnectionOK);
            this.Controls.Add(this.lblItemIDPrefix);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.connectServerCtrl1);
            this.Name = "Form1";
            this.Text = "OPC Middleware";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            this.tabPage7.ResumeLayout(false);
            this.tabPage7.PerformLayout();
            this.tabPage8.ResumeLayout(false);
            this.tabPage8.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Opc.Ua.Client.Controls.ConnectServerCtrl connectServerCtrl1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.CheckBox cbDBIntergratedSecurity;
        internal System.Windows.Forms.Button btnSave;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label label5;
        internal System.Windows.Forms.Label label6;
        internal System.Windows.Forms.TextBox txtDBPassword;
        internal System.Windows.Forms.TextBox txtDBUsername;
        internal System.Windows.Forms.TextBox txtDBName;
        internal System.Windows.Forms.TextBox txtDBServerAddress;
        private System.Windows.Forms.TabPage tabPage5;
        internal System.Windows.Forms.Button button3;
        internal System.Windows.Forms.Label label15;
        internal System.Windows.Forms.TextBox txtKepwareServer;
        private System.Windows.Forms.TabPage tabPage2;
        internal System.Windows.Forms.Button button1;
        internal System.Windows.Forms.TextBox txtPLCSlot;
        internal System.Windows.Forms.TextBox txtPLCRack;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.TextBox txtPLCIPAddress;
        internal System.Windows.Forms.Label Label10;
        private System.Windows.Forms.TabPage tabPage4;
        public System.Windows.Forms.ListView lvEventsHistory;
        internal System.Windows.Forms.Button button2;
        private System.Windows.Forms.TabPage tabPage3;
        internal System.Windows.Forms.GroupBox groupBox2;
        internal System.Windows.Forms.TextBox io_out_StartBuild;
        internal System.Windows.Forms.Label label12;
        internal System.Windows.Forms.TextBox io_out_ProductFamily;
        internal System.Windows.Forms.Label label8;
        internal System.Windows.Forms.TextBox io_out_FGPartNumber;
        internal System.Windows.Forms.Label label7;
        internal System.Windows.Forms.TextBox io_out_SerialNr;
        internal System.Windows.Forms.Label label13;
        internal System.Windows.Forms.TextBox io_out_Color;
        internal System.Windows.Forms.Label label14;
        internal System.Windows.Forms.TextBox io_out_Recipe;
        internal System.Windows.Forms.Label lbl_Recipe;
        internal System.Windows.Forms.GroupBox GroupBox1;
        private System.Windows.Forms.CheckBox cbAcknowledge;
        internal System.Windows.Forms.Button btnExecSP_Validate_Production;
        internal System.Windows.Forms.TextBox io_in_SerialNumber;
        internal System.Windows.Forms.Label lbl_In_Override;
        private System.Windows.Forms.Label lblItemIDPrefix;
        private System.Windows.Forms.TextBox txtConnectionOK;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox txtHeartBeat;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.TextBox txtOp10P703StationName_Value;
        private System.Windows.Forms.TextBox txtOp10P703StationName;
        private System.Windows.Forms.TextBox txtOp10P703SerialNumber_Value;
        private System.Windows.Forms.TextBox txtOp10P703SerialNumber;
        private System.Windows.Forms.TextBox txtOp10P703OperationStatus_Value;
        private System.Windows.Forms.TextBox txtOp10P703OperationStatus;
        private System.Windows.Forms.TextBox txtOp10P703FGPartNumber_Value;
        private System.Windows.Forms.TextBox txtOp10P703FGPartNumber;
        private System.Windows.Forms.TextBox txtOp10J73StationName_Value;
        private System.Windows.Forms.TextBox txtOp10J73StationName;
        private System.Windows.Forms.TextBox txtOp10J73SerialNumber_Value;
        private System.Windows.Forms.TextBox txtOp10J73SerialNumber;
        private System.Windows.Forms.TextBox txtOp10J73FGOperationStatus_Value;
        private System.Windows.Forms.TextBox txtOp10J73FGOperationStatus;
        private System.Windows.Forms.TextBox txtOp10J73FGPartNumber_Value;
        private System.Windows.Forms.TextBox txtOp10J73FGPartNumber;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.TabPage tabPage9;
        private System.Windows.Forms.TextBox txtOp20_2_StationName_Value;
        private System.Windows.Forms.TextBox textBox21;
        private System.Windows.Forms.TextBox textBox22;
        private System.Windows.Forms.TextBox txtOp20_2_StationName;
        private System.Windows.Forms.TextBox txtOp20_2_OperationStatus_Value;
        private System.Windows.Forms.TextBox txtOp20_2_OperationStatus;
        private System.Windows.Forms.TextBox textBox26;
        private System.Windows.Forms.TextBox textBox27;
        private System.Windows.Forms.TextBox textBox28;
        private System.Windows.Forms.TextBox textBox29;
        private System.Windows.Forms.TextBox textBox30;
        private System.Windows.Forms.TextBox textBox31;
        private System.Windows.Forms.TextBox txtOp20_1_OperationStatus_Value;
        private System.Windows.Forms.TextBox txtOp20_1_OperationStatus;
        private System.Windows.Forms.TextBox txtOp20_1_FG_PartNumber_Value;
        private System.Windows.Forms.TextBox txtOp20_1_FG_PartNumber;
        private System.Windows.Forms.TextBox textBox36;
        private System.Windows.Forms.TextBox textBox37;
        private System.Windows.Forms.TextBox textBox38;
        private System.Windows.Forms.TextBox textBox39;
        private System.Windows.Forms.TextBox textBox40;
        private System.Windows.Forms.TextBox textBox41;
        private System.Windows.Forms.TextBox textBox42;
        private System.Windows.Forms.TextBox textBox43;
        private System.Windows.Forms.TextBox textBox44;
        private System.Windows.Forms.TextBox textBox45;
        private System.Windows.Forms.TextBox textBox46;
        private System.Windows.Forms.TextBox textBox47;
        private System.Windows.Forms.TextBox textBox48;
        private System.Windows.Forms.TextBox textBox49;
        private System.Windows.Forms.TextBox textBox50;
        private System.Windows.Forms.TextBox textBox51;
    }
}

