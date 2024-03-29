using System;
using System.Net;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using ModbusTCP;

namespace Modbus
{
	public class frmStart : System.Windows.Forms.Form
	{
		private ModbusTCP.Master	MBmaster;
		private TextBox				txtData;
		private Label				labData;
		private byte[]				data;

		private System.Windows.Forms.GroupBox grpData;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnConnect;
		private System.Windows.Forms.TextBox txtIP;
		private System.Windows.Forms.Button btnReadDisInp;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtSize;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtStartAdress;
		private System.Windows.Forms.Button btnReadCoils;
		private System.Windows.Forms.GroupBox grpStart;
		private System.Windows.Forms.GroupBox grpExchange;
		private System.Windows.Forms.Button btnReadHoldReg;
		private System.Windows.Forms.Button btnReadInpReg;
		private System.Windows.Forms.Button btnWriteSingleCoil;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton radBits;
		private System.Windows.Forms.RadioButton radBytes;
		private System.Windows.Forms.RadioButton radWord;
		private System.Windows.Forms.Button btnWriteSingleReg;
		private System.Windows.Forms.Timer Watchdog;
		private System.Windows.Forms.Button btnWriteMultipleCoils;
		private System.Windows.Forms.Button btnWriteMultipleReg;
        private Button button1;
        private Button button2;
        private TextBox textBox1;
        private Button button3;
        private TextBox textBox2;
        private Label label5;
        private Label label4;
        private Button button4;
        private Timer timer1;
		private System.ComponentModel.IContainer components;

		public frmStart()
		{
			InitializeComponent();
		}

		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Vom Windows Form-Designer generierter Code
		/// <summary>
		/// Erforderliche Methode f黵 die Designerunterst黷zung. 
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor ge鋘dert werden.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            this.grpData = new System.Windows.Forms.GroupBox();
            this.grpStart = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.grpExchange = new System.Windows.Forms.GroupBox();
            this.btnWriteMultipleReg = new System.Windows.Forms.Button();
            this.btnWriteMultipleCoils = new System.Windows.Forms.Button();
            this.btnWriteSingleReg = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radWord = new System.Windows.Forms.RadioButton();
            this.radBytes = new System.Windows.Forms.RadioButton();
            this.radBits = new System.Windows.Forms.RadioButton();
            this.btnWriteSingleCoil = new System.Windows.Forms.Button();
            this.btnReadInpReg = new System.Windows.Forms.Button();
            this.btnReadHoldReg = new System.Windows.Forms.Button();
            this.btnReadDisInp = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtStartAdress = new System.Windows.Forms.TextBox();
            this.btnReadCoils = new System.Windows.Forms.Button();
            this.Watchdog = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.grpStart.SuspendLayout();
            this.grpExchange.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpData
            // 
            this.grpData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpData.Location = new System.Drawing.Point(8, 209);
            this.grpData.Name = "grpData";
            this.grpData.Size = new System.Drawing.Size(888, 0);
            this.grpData.TabIndex = 9;
            this.grpData.TabStop = false;
            this.grpData.Text = "Data";
            // 
            // grpStart
            // 
            this.grpStart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpStart.Controls.Add(this.button4);
            this.grpStart.Controls.Add(this.label5);
            this.grpStart.Controls.Add(this.label4);
            this.grpStart.Controls.Add(this.textBox2);
            this.grpStart.Controls.Add(this.button3);
            this.grpStart.Controls.Add(this.textBox1);
            this.grpStart.Controls.Add(this.button2);
            this.grpStart.Controls.Add(this.button1);
            this.grpStart.Controls.Add(this.label1);
            this.grpStart.Controls.Add(this.btnConnect);
            this.grpStart.Controls.Add(this.txtIP);
            this.grpStart.Location = new System.Drawing.Point(8, 7);
            this.grpStart.Name = "grpStart";
            this.grpStart.Size = new System.Drawing.Size(888, 60);
            this.grpStart.TabIndex = 11;
            this.grpStart.TabStop = false;
            this.grpStart.Text = "Modbus开启与通讯（单）";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(807, 33);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 27;
            this.button4.Text = "ReadD";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(619, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 26;
            this.label5.Text = "地址";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(607, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 25;
            this.label4.Text = "变量值";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(688, 33);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 21);
            this.textBox2.TabIndex = 24;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(807, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 11;
            this.button3.Text = "WriteD";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(688, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 10;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(568, 22);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(10, 10);
            this.button2.TabIndex = 9;
            this.button2.Text = "OFF";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(554, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(10, 10);
            this.button1.TabIndex = 8;
            this.button1.Text = "ON";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(16, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "IP 地址";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(342, 18);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(210, 30);
            this.btnConnect.TabIndex = 6;
            this.btnConnect.Text = "Connect";
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(112, 27);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(104, 21);
            this.txtIP.TabIndex = 5;
            this.txtIP.Text = "192.168.0.4";
            this.txtIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // grpExchange
            // 
            this.grpExchange.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpExchange.Controls.Add(this.btnWriteMultipleReg);
            this.grpExchange.Controls.Add(this.btnWriteMultipleCoils);
            this.grpExchange.Controls.Add(this.btnWriteSingleReg);
            this.grpExchange.Controls.Add(this.groupBox1);
            this.grpExchange.Controls.Add(this.btnWriteSingleCoil);
            this.grpExchange.Controls.Add(this.btnReadInpReg);
            this.grpExchange.Controls.Add(this.btnReadHoldReg);
            this.grpExchange.Controls.Add(this.btnReadDisInp);
            this.grpExchange.Controls.Add(this.label3);
            this.grpExchange.Controls.Add(this.txtSize);
            this.grpExchange.Controls.Add(this.label2);
            this.grpExchange.Controls.Add(this.txtStartAdress);
            this.grpExchange.Controls.Add(this.btnReadCoils);
            this.grpExchange.Location = new System.Drawing.Point(8, 75);
            this.grpExchange.Name = "grpExchange";
            this.grpExchange.Size = new System.Drawing.Size(888, 127);
            this.grpExchange.TabIndex = 12;
            this.grpExchange.TabStop = false;
            this.grpExchange.Text = "Data exhange";
            // 
            // btnWriteMultipleReg
            // 
            this.btnWriteMultipleReg.Location = new System.Drawing.Point(688, 82);
            this.btnWriteMultipleReg.Name = "btnWriteMultipleReg";
            this.btnWriteMultipleReg.Size = new System.Drawing.Size(104, 37);
            this.btnWriteMultipleReg.TabIndex = 23;
            this.btnWriteMultipleReg.Text = "Write multiple register";
            this.btnWriteMultipleReg.Click += new System.EventHandler(this.btnWriteMultipleReg_Click);
            // 
            // btnWriteMultipleCoils
            // 
            this.btnWriteMultipleCoils.Location = new System.Drawing.Point(688, 30);
            this.btnWriteMultipleCoils.Name = "btnWriteMultipleCoils";
            this.btnWriteMultipleCoils.Size = new System.Drawing.Size(104, 37);
            this.btnWriteMultipleCoils.TabIndex = 22;
            this.btnWriteMultipleCoils.Text = "Write multiple coils";
            this.btnWriteMultipleCoils.Click += new System.EventHandler(this.btnWriteMultipleCoils_Click);
            // 
            // btnWriteSingleReg
            // 
            this.btnWriteSingleReg.Location = new System.Drawing.Point(568, 82);
            this.btnWriteSingleReg.Name = "btnWriteSingleReg";
            this.btnWriteSingleReg.Size = new System.Drawing.Size(104, 37);
            this.btnWriteSingleReg.TabIndex = 21;
            this.btnWriteSingleReg.Text = "Write single register";
            this.btnWriteSingleReg.Click += new System.EventHandler(this.btnWriteSingleReg_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radWord);
            this.groupBox1.Controls.Add(this.radBytes);
            this.groupBox1.Controls.Add(this.radBits);
            this.groupBox1.Location = new System.Drawing.Point(168, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(104, 97);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Show as";
            // 
            // radWord
            // 
            this.radWord.Location = new System.Drawing.Point(16, 67);
            this.radWord.Name = "radWord";
            this.radWord.Size = new System.Drawing.Size(80, 23);
            this.radWord.TabIndex = 2;
            this.radWord.Text = "Word";
            this.radWord.CheckedChanged += new System.EventHandler(this.ShowAs);
            // 
            // radBytes
            // 
            this.radBytes.Location = new System.Drawing.Point(16, 45);
            this.radBytes.Name = "radBytes";
            this.radBytes.Size = new System.Drawing.Size(80, 22);
            this.radBytes.TabIndex = 1;
            this.radBytes.Text = "Bytes";
            this.radBytes.CheckedChanged += new System.EventHandler(this.ShowAs);
            // 
            // radBits
            // 
            this.radBits.Location = new System.Drawing.Point(16, 22);
            this.radBits.Name = "radBits";
            this.radBits.Size = new System.Drawing.Size(80, 23);
            this.radBits.TabIndex = 0;
            this.radBits.Text = "Bits";
            this.radBits.CheckedChanged += new System.EventHandler(this.ShowAs);
            // 
            // btnWriteSingleCoil
            // 
            this.btnWriteSingleCoil.Location = new System.Drawing.Point(568, 30);
            this.btnWriteSingleCoil.Name = "btnWriteSingleCoil";
            this.btnWriteSingleCoil.Size = new System.Drawing.Size(104, 37);
            this.btnWriteSingleCoil.TabIndex = 19;
            this.btnWriteSingleCoil.Text = "Write single coil";
            this.btnWriteSingleCoil.Click += new System.EventHandler(this.btnWriteSingleCoil_Click);
            // 
            // btnReadInpReg
            // 
            this.btnReadInpReg.Location = new System.Drawing.Point(448, 82);
            this.btnReadInpReg.Name = "btnReadInpReg";
            this.btnReadInpReg.Size = new System.Drawing.Size(104, 37);
            this.btnReadInpReg.TabIndex = 18;
            this.btnReadInpReg.Text = "Read input register";
            this.btnReadInpReg.Click += new System.EventHandler(this.btnReadInpReg_Click);
            // 
            // btnReadHoldReg
            // 
            this.btnReadHoldReg.Location = new System.Drawing.Point(448, 30);
            this.btnReadHoldReg.Name = "btnReadHoldReg";
            this.btnReadHoldReg.Size = new System.Drawing.Size(104, 37);
            this.btnReadHoldReg.TabIndex = 17;
            this.btnReadHoldReg.Text = "Read holding register";
            this.btnReadHoldReg.Click += new System.EventHandler(this.btnReadHoldReg_Click);
            // 
            // btnReadDisInp
            // 
            this.btnReadDisInp.Location = new System.Drawing.Point(328, 82);
            this.btnReadDisInp.Name = "btnReadDisInp";
            this.btnReadDisInp.Size = new System.Drawing.Size(104, 37);
            this.btnReadDisInp.TabIndex = 16;
            this.btnReadDisInp.Text = "Read discrete inputs";
            this.btnReadDisInp.Click += new System.EventHandler(this.btnReadDisInp_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(16, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 15);
            this.label3.TabIndex = 15;
            this.label3.Text = "Size";
            // 
            // txtSize
            // 
            this.txtSize.Location = new System.Drawing.Point(104, 60);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(48, 21);
            this.txtSize.TabIndex = 14;
            this.txtSize.Text = "32";
            this.txtSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(16, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "Start Adress";
            // 
            // txtStartAdress
            // 
            this.txtStartAdress.Location = new System.Drawing.Point(104, 30);
            this.txtStartAdress.Name = "txtStartAdress";
            this.txtStartAdress.Size = new System.Drawing.Size(48, 21);
            this.txtStartAdress.TabIndex = 12;
            this.txtStartAdress.Text = "0";
            this.txtStartAdress.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnReadCoils
            // 
            this.btnReadCoils.Location = new System.Drawing.Point(328, 30);
            this.btnReadCoils.Name = "btnReadCoils";
            this.btnReadCoils.Size = new System.Drawing.Size(104, 37);
            this.btnReadCoils.TabIndex = 11;
            this.btnReadCoils.Text = "Read coils";
            this.btnReadCoils.CursorChanged += new System.EventHandler(this.btnReadCoils_Click);
            this.btnReadCoils.Click += new System.EventHandler(this.btnReadCoils_Click);
            // 
            // Watchdog
            // 
            this.Watchdog.Interval = 500;
            this.Watchdog.Tick += new System.EventHandler(this.Watchdog_Tick);
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmStart
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(904, 76);
            this.Controls.Add(this.grpExchange);
            this.Controls.Add(this.grpStart);
            this.Controls.Add(this.grpData);
            this.Name = "frmStart";
            this.Text = "ModbusTCP Tester V1.0";
            this.Closing += new System.ComponentModel.CancelEventHandler(this.frmStart_Closing);
            this.Load += new System.EventHandler(this.frmStart_Load);
            this.SizeChanged += new System.EventHandler(this.frmStart_Resize);
            this.grpStart.ResumeLayout(false);
            this.grpStart.PerformLayout();
            this.grpExchange.ResumeLayout(false);
            this.grpExchange.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// Der Haupteinstiegspunkt f黵 die Anwendung.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new frmStart());
		}


		// ------------------------------------------------------------------------
		// Programm start
		// ------------------------------------------------------------------------
		private void frmStart_Load(object sender, System.EventArgs e)
		{
			// Set standard format byte, make some textboxes
			radBytes.Checked = true;
			ResizeData();
		}

		// ------------------------------------------------------------------------
		// Programm stop
		// ------------------------------------------------------------------------
		private void frmStart_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			if(MBmaster != null) 
			{
				MBmaster.Dispose();
				MBmaster = null;
			}	
			Application.Exit();
		}
		
		// ------------------------------------------------------------------------
		// Button connect
		// ------------------------------------------------------------------------
		private void btnConnect_Click(object sender, System.EventArgs e)
		{
			try
			{
				// Create new modbus master and add event functions
				MBmaster = new Master(txtIP.Text, 502);
				MBmaster.OnResponseData += new ModbusTCP.Master.ResponseData(MBmaster_OnResponseData);
				MBmaster.OnException	+= new ModbusTCP.Master.ExceptionData(MBmaster_OnException);
                
                // Show additional fields, enable watchdog
                grpExchange.Visible		= true;
				grpData.Visible			= true;	
				Watchdog.Enabled		= true;
			    MessageBox.Show("已连接到台达PLC（DCP24SV）！");
			}
			catch(SystemException error)
			{
				MessageBox.Show(error.Message);
			}
		}

		// ------------------------------------------------------------------------
		// Button read coils
		// ------------------------------------------------------------------------
		private void btnReadCoils_Click(object sender, System.EventArgs e)
		{
			int ID				= 1;
			int StartAddress	= ReadStartAdr();
			byte Length			= Convert.ToByte(txtSize.Text);

			MBmaster.ReadCoils(ID, StartAddress, Length);
		}

		// ------------------------------------------------------------------------
		// Button read discrete inputs
		// ------------------------------------------------------------------------
		private void btnReadDisInp_Click(object sender, System.EventArgs e)
		{
			int ID				= 2;
			int StartAddress	= ReadStartAdr();
			byte Length			= Convert.ToByte(txtSize.Text);

			MBmaster.ReadDiscreteInputs(ID, StartAddress, Length);	
		}

		// ------------------------------------------------------------------------
		// Button read holding register
		// ------------------------------------------------------------------------
		private void btnReadHoldReg_Click(object sender, System.EventArgs e)
		{
			int ID				= 3;
			int StartAddress	= ReadStartAdr();
			byte Length			= Convert.ToByte(txtSize.Text);

			MBmaster.ReadHoldingRegister(ID, StartAddress, Length);		
		}

		// ------------------------------------------------------------------------
		// Button read holding register
		// ------------------------------------------------------------------------
		private void btnReadInpReg_Click(object sender, System.EventArgs e)
		{
			int ID				= 4;
			int StartAddress	= ReadStartAdr();
			byte Length			= Convert.ToByte(txtSize.Text);

			MBmaster.ReadInputRegister(ID, StartAddress, Length);			
		}

		// ------------------------------------------------------------------------
		// Button write single coil
		// ------------------------------------------------------------------------
		private void btnWriteSingleCoil_Click(object sender, System.EventArgs e)
		{
			int ID				= 5;
			int StartAddress	= ReadStartAdr();

			data			= GetData(1);
			txtSize.Text	= "1";

			MBmaster.WriteSingleCoils(ID, StartAddress, Convert.ToBoolean(data[0]));
		}

		// ------------------------------------------------------------------------
		// Button write multiple coils
		// ------------------------------------------------------------------------	
		private void btnWriteMultipleCoils_Click(object sender, System.EventArgs e)
		{
			int ID				= 6;
			int StartAddress	= ReadStartAdr();

			data = GetData(Convert.ToByte(txtSize.Text));
			MBmaster.WriteMultipleCoils(ID, StartAddress, Convert.ToByte(txtSize.Text), data);		
		}

		// ------------------------------------------------------------------------
		// Button write single register
		// ------------------------------------------------------------------------
		private void btnWriteSingleReg_Click(object sender, System.EventArgs e)
		{
			int ID				= 7;
			int StartAddress	= ReadStartAdr();

			data			= GetData(2);
			txtSize.Text	= "1";
			txtData.Text	= data[0].ToString();

			MBmaster.WriteSingleRegister(ID, StartAddress, data);
		}
		
		// ------------------------------------------------------------------------
		// Button write multiple register
		// ------------------------------------------------------------------------	
		private void btnWriteMultipleReg_Click(object sender, System.EventArgs e)
		{
			int ID				= 8;
			int StartAddress	= ReadStartAdr();

			data = GetData(Convert.ToByte(txtSize.Text));
			MBmaster.WriteMultipleRegister(ID, StartAddress, Convert.ToByte(txtSize.Text), data);		
		}

		// ------------------------------------------------------------------------
		// Event for response data
		// ------------------------------------------------------------------------
		private void MBmaster_OnResponseData(int ID, byte function, byte[] values)
		{
			// Ignore watchdog response data
			if(ID == 0xFF) return;

			// ------------------------------------------------------------------------
			// Identify requested data
			switch(ID)
			{
				case 1:
					grpData.Text = "Read coils";
					data = values;
					ShowAs(null, null);
				break;
				case 2:
					grpData.Text = "Read discrete inputs";
					data = values;
					ShowAs(null, null);
				break;
				case 3:
					
					data = values;
                    i = data[0] * 256 + data[1];
                    this.SetText(i.ToString());
					ShowAs(null, null);
				break;
				case 4:
					grpData.Text = "Read input register";
					data = values;
					ShowAs(null, null);
				break;
                //case 5:
                //    grpData.Text = "Write single coil";
                //break;
                //case 6:
                //    grpData.Text = "Write multiple coils";
                //break;
                //case 7:
                //    grpData.Text = "Write single register";
                //break;
                //case 8:
                //    grpData.Text = "Write multiple register";
                //break;
			}	
		}
        // This delegate enables asynchronous calls for setting
        // the text property on a TextBox control.
        delegate void SetTextCallback(string text);


        private void SetText(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.textBox1.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.textBox1.Text = text;
            }
        }


		// ------------------------------------------------------------------------
		// Modbus TCP slave exception
		// ------------------------------------------------------------------------
		private void MBmaster_OnException(int id, byte function, byte exception)
		{
			string exc = "Modbus says error: ";
			switch(exception)
			{
				case Master.excIllegalFunction: exc += "Illegal function!"; break;
				case Master.excIllegalDataAdr: exc += "Illegal data adress!"; break;
				case Master.excIllegalDataVal: exc += "Illegal data value!"; break;
				case Master.excSlaveDeviceFailure: exc += "Slave device failure!"; break;
				case Master.excAck: exc += "Acknoledge!"; break;
				case Master.excMemParityErr: exc += "Memory parity error!"; break;
				case Master.excGatePathUnavailable: exc += "Gateway path unavailbale!"; break;
				case Master.excExceptionTimeout: exc += "Slave timed out!"; break;
				case Master.excExceptionConnectionLost: exc += "Connection is lost!"; break;
				case Master.excExceptionNotConnected: exc += "Not connected!"; break;
			}

			MessageBox.Show(exc, "Modbus slave exception");
		}

		// ------------------------------------------------------------------------
		// Generate new number of text boxes
		// ------------------------------------------------------------------------
		private void ResizeData()
		{
			// Create as many textboxes as fit into window
			grpData.Controls.Clear();
			int x = 0;
			int y = 10;
			int z = 20;
			while(y < grpData.Size.Width - 100)
			{
				labData				= new Label();
				grpData.Controls.Add(labData);
				labData.Size		= new System.Drawing.Size(30, 20);
				labData.Location	= new System.Drawing.Point(y, z);
				labData.Text		= Convert.ToString(x + 1);

				txtData				= new TextBox();
				grpData.Controls.Add(txtData);
				txtData.Size		= new System.Drawing.Size(50, 20);
				txtData.Location	= new System.Drawing.Point(y + 30, z);
				txtData.TextAlign	= System.Windows.Forms.HorizontalAlignment.Right;
				txtData.Tag			= x;

				x++;
				z = z + txtData.Size.Height + 5;
				if(z > grpData.Size.Height - 40) 
				{
					y = y + 100;
					z = 20;
				}
			}
		}

		// ------------------------------------------------------------------------
		// Resize form elements
		// ------------------------------------------------------------------------
		private void frmStart_Resize(object sender, System.EventArgs e)
		{
			if(grpData.Visible == true) ResizeData();
		}

		// ------------------------------------------------------------------------
		// Read start address
		// ------------------------------------------------------------------------
		private int ReadStartAdr()
		{
			// Convert hex numbers into decimal
			if(txtStartAdress.Text.IndexOf("0x", 0, txtStartAdress.Text.Length) == 0) 
			{
				string str = txtStartAdress.Text.Replace("0x", "");
				int hex = Convert.ToInt16(str, 16);
				return hex;
			}
			else 
			{
				return Convert.ToInt32(txtStartAdress.Text);
			}
		}

		// ------------------------------------------------------------------------
		// Read values from textboxes
		// ------------------------------------------------------------------------
		private byte[] GetData(int num)
		{
			bool[] bits	= new bool[num];
			byte[] data	= new Byte[num];
			int[]  word	= new int[num];

			// ------------------------------------------------------------------------
			// Convert data from text boxes
			foreach(Control ctrl in grpData.Controls)
			{
				if (ctrl is TextBox)
				{
					int x = Convert.ToInt16(ctrl.Tag);
					if(radBits.Checked)
					{
						if((x <= bits.GetUpperBound(0)) && (ctrl.Text != "")) bits[x] = Convert.ToBoolean(Convert.ToByte(ctrl.Text));
						else break;
					}
					if(radBytes.Checked)
					{
						if((x <= data.GetUpperBound(0)) && (ctrl.Text != "")) data[x] = Convert.ToByte(ctrl.Text);
						else break;
					}
					if(radWord.Checked)
					{
						if((x <= data.GetUpperBound(0)) && (ctrl.Text != "")) word[x] = Convert.ToByte(ctrl.Text);
						else break;
					}
				}
			}
			if(radBits.Checked)
			{
				int numBytes		= (byte)(num / 8 + (num % 8 > 0 ? 1 : 0));
				data				= new Byte[numBytes];
				BitArray bitArray	= new BitArray(bits);
				bitArray.CopyTo(data, 0);
			}
			if(radWord.Checked)
			{
				data = new Byte[num*2];
				for(int x=0;x<num;x++)
				{
					byte[] dat = BitConverter.GetBytes((short) IPAddress.HostToNetworkOrder((short) word[x]));
					data[x*2]	= dat[0];
					data[x*2+1] = dat[1];
				}
			}
			return data;
		}

        private byte[] GetData1(int num)
        {
            bool[] bits = new bool[num];
            byte[] data = new Byte[num];
            int[] word = new int[num];
            int value;
            // ------------------------------------------------------------------------
            // Convert data from text boxes
            value = Convert.ToInt16(textBox1.Text);
            data[0] =Convert.ToByte( value / 256);
            data[1] =Convert.ToByte( value % 256);
 
            return data;
        }
		// ------------------------------------------------------------------------
		// Show values in selected way
		// ------------------------------------------------------------------------
		private void ShowAs(object sender, System.EventArgs e)
		{
			RadioButton rad;
			if(sender is RadioButton)	
			{
				rad = (RadioButton) sender;
				if(rad.Checked == false) return;
			}

			bool[]	bits = new bool[1];
			int[]	word = new int[1];

			// Convert data to selected data type
			if(radBits.Checked == true)
			{
				BitArray bitArray = new BitArray(data);
				bits = new bool[bitArray.Count];
				bitArray.CopyTo(bits, 0);
			}
			if(radWord.Checked == true)
			{
				if(data.Length < 2) return;
				word = new int[data.Length/2];
				for(int x=0;x<data.Length;x=x+2)
				{
					word[x/2] = data[x] * 256 + data[x+1];
				}
			}

			// ------------------------------------------------------------------------
			// Put new data into text boxes
			foreach(Control ctrl in grpData.Controls)
			{
				if (ctrl is TextBox)
				{
					int x = Convert.ToInt16(ctrl.Tag);
					if(radBits.Checked)
					{
						if(x <= bits.GetUpperBound(0)) 
						{
							ctrl.Text = Convert.ToByte(bits[x]).ToString();
							ctrl.Visible = true;
						}
						else ctrl.Text = "";
					}
					if(radBytes.Checked)
					{
						if(x <= data.GetUpperBound(0)) 
						{
							//ctrl.Text = data[x].ToString();
						//	ctrl.Visible = true;
						}
						else ctrl.Text = "";
					}
					if(radWord.Checked)
					{
						if(x <= word.GetUpperBound(0)) 
						{
							ctrl.Text = word[x].ToString();
							ctrl.Visible = true;
						}
						else ctrl.Text = "";
					}
				}
			}
		}

		// ------------------------------------------------------------------------
		// Call watchdog reset every 500 ms
		// ------------------------------------------------------------------------
		private void Watchdog_Tick(object sender, System.EventArgs e)
		{
			//MBmaster.WriteSingleRegister(0xFF, 0x1044, BitConverter.GetBytes((short) IPAddress.HostToNetworkOrder((short) 0xc1)));
		}

        private void button1_Click(object sender, EventArgs e)
        {
            MBmaster.WriteSingleCoils(5, Convert.ToInt16(textBox1.Text), true);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MBmaster.WriteSingleCoils(5, Convert.ToInt16(textBox1.Text), false);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            data = GetData1(2);
            MBmaster.WriteSingleRegister(7, Convert.ToInt16(textBox2.Text), data);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MBmaster.ReadHoldingRegister(3, Convert.ToInt16(textBox2.Text), 5);		
        }
        public int i;
        private void timer1_Tick(object sender, EventArgs e)
        {
             
            textBox1.Text = i.ToString();
        }  
	}
}
