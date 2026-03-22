namespace V_CONSOLE
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Canvas = new PictureBox();
            RamGrid = new DataGridView();
            Ram = new DataGridViewTextBoxColumn();
            tabControl1 = new TabControl();
            RamViewTab = new TabPage();
            VRamGrid = new DataGridView();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            RomGrid = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            DebugTab = new TabPage();
            CPUClockSpeedTxt = new Label();
            CPUClockSpeed = new TrackBar();
            RCheck = new CheckBox();
            label4 = new Label();
            LCheck = new CheckBox();
            label5 = new Label();
            OCheck = new CheckBox();
            label6 = new Label();
            NCheck = new CheckBox();
            NegativeFlagText = new Label();
            CCheck = new CheckBox();
            CarryFlagText = new Label();
            ZCheck = new CheckBox();
            ZeroFlagText = new Label();
            PCBox = new RichTextBox();
            PCText = new Label();
            ConsoleTxt = new Label();
            ConsoleBox = new RichTextBox();
            RegistatorCT = new RichTextBox();
            RegistatorCText = new Label();
            RegistatorBT = new RichTextBox();
            RegistatorBText = new Label();
            RegistatorAT = new RichTextBox();
            RegistatorAText = new Label();
            tabControl2 = new TabControl();
            GameViewTab = new TabPage();
            CodeWriteingTab = new TabPage();
            CodeBox = new RichTextBox();
            DrawSpriteTab = new TabPage();
            toolStrip1 = new ToolStrip();
            FileBttn = new ToolStripDropDownButton();
            EditBttn = new ToolStripDropDownButton();
            PlayButton = new ToolStripButton();
            ToolsBttn = new ToolStripDropDownButton();
            BuildBttn = new ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)Canvas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)RamGrid).BeginInit();
            tabControl1.SuspendLayout();
            RamViewTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)VRamGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)RomGrid).BeginInit();
            DebugTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CPUClockSpeed).BeginInit();
            tabControl2.SuspendLayout();
            GameViewTab.SuspendLayout();
            CodeWriteingTab.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // Canvas
            // 
            Canvas.BackColor = Color.White;
            Canvas.Location = new Point(0, 3);
            Canvas.Name = "Canvas";
            Canvas.Size = new Size(775, 654);
            Canvas.TabIndex = 0;
            Canvas.TabStop = false;
            Canvas.Click += Canvas_Click;
            // 
            // RamGrid
            // 
            RamGrid.BackgroundColor = Color.White;
            RamGrid.ColumnHeadersHeight = 32;
            RamGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            RamGrid.Columns.AddRange(new DataGridViewColumn[] { Ram });
            RamGrid.Location = new Point(0, 0);
            RamGrid.Name = "RamGrid";
            RamGrid.RowHeadersWidth = 10;
            RamGrid.Size = new Size(139, 657);
            RamGrid.TabIndex = 0;
            // 
            // Ram
            // 
            Ram.HeaderText = "Ram";
            Ram.MinimumWidth = 6;
            Ram.Name = "Ram";
            Ram.Width = 105;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(RamViewTab);
            tabControl1.Controls.Add(DebugTab);
            tabControl1.Font = new Font("Agency FB", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabControl1.Location = new Point(782, 45);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(448, 698);
            tabControl1.TabIndex = 3;
            // 
            // RamViewTab
            // 
            RamViewTab.Controls.Add(VRamGrid);
            RamViewTab.Controls.Add(RomGrid);
            RamViewTab.Controls.Add(RamGrid);
            RamViewTab.Location = new Point(4, 37);
            RamViewTab.Name = "RamViewTab";
            RamViewTab.Padding = new Padding(3);
            RamViewTab.Size = new Size(440, 657);
            RamViewTab.TabIndex = 0;
            RamViewTab.Text = "RamView";
            RamViewTab.UseVisualStyleBackColor = true;
            // 
            // VRamGrid
            // 
            VRamGrid.BackgroundColor = Color.White;
            VRamGrid.ColumnHeadersHeight = 32;
            VRamGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            VRamGrid.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn2 });
            VRamGrid.Location = new Point(145, 0);
            VRamGrid.Name = "VRamGrid";
            VRamGrid.RowHeadersWidth = 10;
            VRamGrid.Size = new Size(150, 657);
            VRamGrid.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "VRam";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.Width = 115;
            // 
            // RomGrid
            // 
            RomGrid.BackgroundColor = Color.White;
            RomGrid.ColumnHeadersHeight = 32;
            RomGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            RomGrid.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1 });
            RomGrid.Location = new Point(301, 0);
            RomGrid.Name = "RomGrid";
            RomGrid.RowHeadersWidth = 10;
            RomGrid.Size = new Size(139, 660);
            RomGrid.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "ROM";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Width = 105;
            // 
            // DebugTab
            // 
            DebugTab.Controls.Add(CPUClockSpeedTxt);
            DebugTab.Controls.Add(CPUClockSpeed);
            DebugTab.Controls.Add(RCheck);
            DebugTab.Controls.Add(label4);
            DebugTab.Controls.Add(LCheck);
            DebugTab.Controls.Add(label5);
            DebugTab.Controls.Add(OCheck);
            DebugTab.Controls.Add(label6);
            DebugTab.Controls.Add(NCheck);
            DebugTab.Controls.Add(NegativeFlagText);
            DebugTab.Controls.Add(CCheck);
            DebugTab.Controls.Add(CarryFlagText);
            DebugTab.Controls.Add(ZCheck);
            DebugTab.Controls.Add(ZeroFlagText);
            DebugTab.Controls.Add(PCBox);
            DebugTab.Controls.Add(PCText);
            DebugTab.Controls.Add(ConsoleTxt);
            DebugTab.Controls.Add(ConsoleBox);
            DebugTab.Controls.Add(RegistatorCT);
            DebugTab.Controls.Add(RegistatorCText);
            DebugTab.Controls.Add(RegistatorBT);
            DebugTab.Controls.Add(RegistatorBText);
            DebugTab.Controls.Add(RegistatorAT);
            DebugTab.Controls.Add(RegistatorAText);
            DebugTab.Location = new Point(4, 37);
            DebugTab.Name = "DebugTab";
            DebugTab.Padding = new Padding(3);
            DebugTab.Size = new Size(440, 657);
            DebugTab.TabIndex = 1;
            DebugTab.Text = "Debug";
            DebugTab.UseVisualStyleBackColor = true;
            // 
            // CPUClockSpeedTxt
            // 
            CPUClockSpeedTxt.AutoSize = true;
            CPUClockSpeedTxt.Font = new Font("Agency FB", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CPUClockSpeedTxt.Location = new Point(3, 300);
            CPUClockSpeedTxt.Name = "CPUClockSpeedTxt";
            CPUClockSpeedTxt.Size = new Size(144, 28);
            CPUClockSpeedTxt.TabIndex = 23;
            CPUClockSpeedTxt.Text = "CPU Clock Speed:";
            // 
            // CPUClockSpeed
            // 
            CPUClockSpeed.BackColor = SystemColors.Control;
            CPUClockSpeed.Enabled = false;
            CPUClockSpeed.Location = new Point(15, 331);
            CPUClockSpeed.Maximum = 60;
            CPUClockSpeed.Name = "CPUClockSpeed";
            CPUClockSpeed.Size = new Size(411, 56);
            CPUClockSpeed.TabIndex = 22;
            // 
            // RCheck
            // 
            RCheck.AutoSize = true;
            RCheck.Enabled = false;
            RCheck.Location = new Point(383, 270);
            RCheck.Name = "RCheck";
            RCheck.Size = new Size(18, 17);
            RCheck.TabIndex = 21;
            RCheck.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Agency FB", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(290, 239);
            label4.Name = "label4";
            label4.Size = new Size(111, 28);
            label4.TabIndex = 20;
            label4.Text = "Running-Flag:";
            // 
            // LCheck
            // 
            LCheck.AutoSize = true;
            LCheck.Enabled = false;
            LCheck.Location = new Point(232, 270);
            LCheck.Name = "LCheck";
            LCheck.Size = new Size(18, 17);
            LCheck.TabIndex = 19;
            LCheck.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Agency FB", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(163, 239);
            label5.Name = "label5";
            label5.Size = new Size(86, 28);
            label5.TabIndex = 18;
            label5.Text = "Loop-Flag:";
            // 
            // OCheck
            // 
            OCheck.AutoSize = true;
            OCheck.Enabled = false;
            OCheck.Location = new Point(75, 270);
            OCheck.Name = "OCheck";
            OCheck.Size = new Size(18, 17);
            OCheck.TabIndex = 17;
            OCheck.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Agency FB", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(6, 239);
            label6.Name = "label6";
            label6.Size = new Size(123, 28);
            label6.TabIndex = 16;
            label6.Text = "Overflow-Flag:";
            // 
            // NCheck
            // 
            NCheck.AutoSize = true;
            NCheck.Enabled = false;
            NCheck.Location = new Point(383, 206);
            NCheck.Name = "NCheck";
            NCheck.Size = new Size(18, 17);
            NCheck.TabIndex = 15;
            NCheck.UseVisualStyleBackColor = true;
            // 
            // NegativeFlagText
            // 
            NegativeFlagText.AutoSize = true;
            NegativeFlagText.Font = new Font("Agency FB", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NegativeFlagText.Location = new Point(283, 175);
            NegativeFlagText.Name = "NegativeFlagText";
            NegativeFlagText.Size = new Size(118, 28);
            NegativeFlagText.TabIndex = 14;
            NegativeFlagText.Text = "Negative-Flag:";
            // 
            // CCheck
            // 
            CCheck.AutoSize = true;
            CCheck.Enabled = false;
            CCheck.Location = new Point(232, 206);
            CCheck.Name = "CCheck";
            CCheck.Size = new Size(18, 17);
            CCheck.TabIndex = 13;
            CCheck.UseVisualStyleBackColor = true;
            // 
            // CarryFlagText
            // 
            CarryFlagText.AutoSize = true;
            CarryFlagText.Font = new Font("Agency FB", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CarryFlagText.Location = new Point(153, 175);
            CarryFlagText.Name = "CarryFlagText";
            CarryFlagText.Size = new Size(97, 28);
            CarryFlagText.TabIndex = 12;
            CarryFlagText.Text = "Carry-Flag:";
            // 
            // ZCheck
            // 
            ZCheck.AutoSize = true;
            ZCheck.Enabled = false;
            ZCheck.Location = new Point(75, 206);
            ZCheck.Name = "ZCheck";
            ZCheck.Size = new Size(18, 17);
            ZCheck.TabIndex = 11;
            ZCheck.UseVisualStyleBackColor = true;
            // 
            // ZeroFlagText
            // 
            ZeroFlagText.AutoSize = true;
            ZeroFlagText.Font = new Font("Agency FB", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ZeroFlagText.Location = new Point(6, 175);
            ZeroFlagText.Name = "ZeroFlagText";
            ZeroFlagText.Size = new Size(87, 28);
            ZeroFlagText.TabIndex = 10;
            ZeroFlagText.Text = "Zero-Flag:";
            // 
            // PCBox
            // 
            PCBox.BackColor = Color.White;
            PCBox.Location = new Point(15, 122);
            PCBox.Multiline = false;
            PCBox.Name = "PCBox";
            PCBox.ReadOnly = true;
            PCBox.Size = new Size(411, 35);
            PCBox.TabIndex = 9;
            PCBox.Text = "gf";
            // 
            // PCText
            // 
            PCText.AutoSize = true;
            PCText.Font = new Font("Agency FB", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PCText.Location = new Point(6, 91);
            PCText.Name = "PCText";
            PCText.Size = new Size(37, 28);
            PCText.TabIndex = 8;
            PCText.Text = "PC:";
            // 
            // ConsoleTxt
            // 
            ConsoleTxt.AutoSize = true;
            ConsoleTxt.Font = new Font("Agency FB", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ConsoleTxt.Location = new Point(6, 403);
            ConsoleTxt.Name = "ConsoleTxt";
            ConsoleTxt.Size = new Size(76, 28);
            ConsoleTxt.TabIndex = 7;
            ConsoleTxt.Text = "Console:";
            ConsoleTxt.Click += ConsoleTxt_Click;
            // 
            // ConsoleBox
            // 
            ConsoleBox.BackColor = Color.White;
            ConsoleBox.Location = new Point(15, 444);
            ConsoleBox.Name = "ConsoleBox";
            ConsoleBox.ReadOnly = true;
            ConsoleBox.Size = new Size(411, 210);
            ConsoleBox.TabIndex = 6;
            ConsoleBox.Text = "";
            // 
            // RegistatorCT
            // 
            RegistatorCT.BackColor = Color.White;
            RegistatorCT.Location = new Point(324, 42);
            RegistatorCT.Multiline = false;
            RegistatorCT.Name = "RegistatorCT";
            RegistatorCT.ReadOnly = true;
            RegistatorCT.Size = new Size(102, 35);
            RegistatorCT.TabIndex = 5;
            RegistatorCT.Text = "gf";
            // 
            // RegistatorCText
            // 
            RegistatorCText.AutoSize = true;
            RegistatorCText.Font = new Font("Agency FB", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RegistatorCText.Location = new Point(314, 11);
            RegistatorCText.Name = "RegistatorCText";
            RegistatorCText.Size = new Size(112, 28);
            RegistatorCText.TabIndex = 4;
            RegistatorCText.Text = "Registator-C:";
            // 
            // RegistatorBT
            // 
            RegistatorBT.BackColor = Color.White;
            RegistatorBT.Location = new Point(172, 42);
            RegistatorBT.Multiline = false;
            RegistatorBT.Name = "RegistatorBT";
            RegistatorBT.ReadOnly = true;
            RegistatorBT.Size = new Size(103, 35);
            RegistatorBT.TabIndex = 3;
            RegistatorBT.Text = "gf";
            // 
            // RegistatorBText
            // 
            RegistatorBText.AutoSize = true;
            RegistatorBText.Font = new Font("Agency FB", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RegistatorBText.Location = new Point(163, 11);
            RegistatorBText.Name = "RegistatorBText";
            RegistatorBText.Size = new Size(112, 28);
            RegistatorBText.TabIndex = 2;
            RegistatorBText.Text = "Registator-B:";
            // 
            // RegistatorAT
            // 
            RegistatorAT.BackColor = Color.White;
            RegistatorAT.Location = new Point(15, 42);
            RegistatorAT.Multiline = false;
            RegistatorAT.Name = "RegistatorAT";
            RegistatorAT.ReadOnly = true;
            RegistatorAT.Size = new Size(103, 35);
            RegistatorAT.TabIndex = 1;
            RegistatorAT.Text = "gf";
            // 
            // RegistatorAText
            // 
            RegistatorAText.AutoSize = true;
            RegistatorAText.Font = new Font("Agency FB", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RegistatorAText.Location = new Point(6, 11);
            RegistatorAText.Name = "RegistatorAText";
            RegistatorAText.Size = new Size(112, 28);
            RegistatorAText.TabIndex = 0;
            RegistatorAText.Text = "Registator-A:";
            // 
            // tabControl2
            // 
            tabControl2.Controls.Add(GameViewTab);
            tabControl2.Controls.Add(CodeWriteingTab);
            tabControl2.Controls.Add(DrawSpriteTab);
            tabControl2.Font = new Font("Agency FB", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabControl2.Location = new Point(0, 45);
            tabControl2.Name = "tabControl2";
            tabControl2.SelectedIndex = 0;
            tabControl2.Size = new Size(783, 698);
            tabControl2.TabIndex = 4;
            // 
            // GameViewTab
            // 
            GameViewTab.Controls.Add(Canvas);
            GameViewTab.Location = new Point(4, 37);
            GameViewTab.Name = "GameViewTab";
            GameViewTab.Padding = new Padding(3);
            GameViewTab.Size = new Size(775, 657);
            GameViewTab.TabIndex = 0;
            GameViewTab.Text = "GameView";
            GameViewTab.UseVisualStyleBackColor = true;
            // 
            // CodeWriteingTab
            // 
            CodeWriteingTab.Controls.Add(CodeBox);
            CodeWriteingTab.Location = new Point(4, 37);
            CodeWriteingTab.Name = "CodeWriteingTab";
            CodeWriteingTab.Padding = new Padding(3);
            CodeWriteingTab.Size = new Size(775, 657);
            CodeWriteingTab.TabIndex = 1;
            CodeWriteingTab.Text = "Code";
            CodeWriteingTab.UseVisualStyleBackColor = true;
            // 
            // CodeBox
            // 
            CodeBox.Location = new Point(3, 3);
            CodeBox.Name = "CodeBox";
            CodeBox.Size = new Size(772, 654);
            CodeBox.TabIndex = 0;
            CodeBox.Text = "";
            // 
            // DrawSpriteTab
            // 
            DrawSpriteTab.Location = new Point(4, 37);
            DrawSpriteTab.Name = "DrawSpriteTab";
            DrawSpriteTab.Size = new Size(775, 657);
            DrawSpriteTab.TabIndex = 2;
            DrawSpriteTab.Text = "DrawSprite";
            DrawSpriteTab.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            toolStrip1.Font = new Font("Agency FB", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { FileBttn, EditBttn, PlayButton, ToolsBttn, BuildBttn });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1236, 42);
            toolStrip1.TabIndex = 5;
            toolStrip1.Text = "toolStrip1";
            // 
            // FileBttn
            // 
            FileBttn.DisplayStyle = ToolStripItemDisplayStyle.Text;
            FileBttn.Image = (Image)resources.GetObject("FileBttn.Image");
            FileBttn.ImageTransparentColor = Color.Magenta;
            FileBttn.Name = "FileBttn";
            FileBttn.Size = new Size(58, 39);
            FileBttn.Text = "File";
            // 
            // EditBttn
            // 
            EditBttn.DisplayStyle = ToolStripItemDisplayStyle.Text;
            EditBttn.Image = (Image)resources.GetObject("EditBttn.Image");
            EditBttn.ImageTransparentColor = Color.Magenta;
            EditBttn.Name = "EditBttn";
            EditBttn.Size = new Size(60, 39);
            EditBttn.Text = "Edit";
            // 
            // PlayButton
            // 
            PlayButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            PlayButton.Image = (Image)resources.GetObject("PlayButton.Image");
            PlayButton.ImageTransparentColor = Color.Magenta;
            PlayButton.Name = "PlayButton";
            PlayButton.Size = new Size(29, 39);
            PlayButton.Text = "Play";
            PlayButton.Click += PlayButton_Click;
            // 
            // ToolsBttn
            // 
            ToolsBttn.DisplayStyle = ToolStripItemDisplayStyle.Text;
            ToolsBttn.Image = (Image)resources.GetObject("ToolsBttn.Image");
            ToolsBttn.ImageTransparentColor = Color.Magenta;
            ToolsBttn.Name = "ToolsBttn";
            ToolsBttn.Size = new Size(78, 39);
            ToolsBttn.Text = "Tools";
            // 
            // BuildBttn
            // 
            BuildBttn.DisplayStyle = ToolStripItemDisplayStyle.Image;
            BuildBttn.Image = (Image)resources.GetObject("BuildBttn.Image");
            BuildBttn.ImageTransparentColor = Color.Magenta;
            BuildBttn.Name = "BuildBttn";
            BuildBttn.Size = new Size(29, 39);
            BuildBttn.Text = "toolStripButton1";
            BuildBttn.Click += BuildBttn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1236, 745);
            Controls.Add(toolStrip1);
            Controls.Add(tabControl2);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)Canvas).EndInit();
            ((System.ComponentModel.ISupportInitialize)RamGrid).EndInit();
            tabControl1.ResumeLayout(false);
            RamViewTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)VRamGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)RomGrid).EndInit();
            DebugTab.ResumeLayout(false);
            DebugTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)CPUClockSpeed).EndInit();
            tabControl2.ResumeLayout(false);
            GameViewTab.ResumeLayout(false);
            CodeWriteingTab.ResumeLayout(false);
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox Canvas;
        private TabControl tabControl1;
        private TabPage RamViewTab;
        private TabPage DebugTab;
        private TabControl tabControl2;
        private TabPage GameViewTab;
        private TabPage CodeWriteingTab;
        private RichTextBox RegistatorAT;
        private Label RegistatorAText;
        private RichTextBox RegistatorCT;
        private Label RegistatorCText;
        private RichTextBox RegistatorBT;
        private Label RegistatorBText;
        private Label ConsoleTxt;
        private RichTextBox ConsoleBox;
        private RichTextBox PCBox;
        private Label PCText;
        private TabPage DrawSpriteTab;
        private CheckBox NCheck;
        private Label NegativeFlagText;
        private CheckBox CCheck;
        private Label CarryFlagText;
        private CheckBox ZCheck;
        private Label ZeroFlagText;
        private CheckBox RCheck;
        private Label label4;
        private CheckBox LCheck;
        private Label label5;
        private CheckBox OCheck;
        private Label label6;
        private ToolStrip toolStrip1;
        private DataGridView RamGrid;
        private DataGridView VRamGrid;
        private DataGridView RomGrid;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn Ram;
        private ToolStripDropDownButton FileBttn;
        private ToolStripDropDownButton EditBttn;
        private ToolStripButton PlayButton;
        private ToolStripDropDownButton ToolsBttn;
        private TrackBar CPUClockSpeed;
        private Label CPUClockSpeedTxt;
        private RichTextBox CodeBox;
        private ToolStripButton BuildBttn;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    }
}
