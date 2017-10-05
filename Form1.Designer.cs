namespace lab04
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pointInRect = new System.Windows.Forms.Label();
            this.pointPositionButton = new System.Windows.Forms.Button();
            this.pointPosition = new System.Windows.Forms.Label();
            this.edgePositionBox = new System.Windows.Forms.ComboBox();
            this.pointPositionBox = new System.Windows.Forms.ComboBox();
            this.belongsToRect = new System.Windows.Forms.Button();
            this.groupBoxEdge = new System.Windows.Forms.GroupBox();
            this.intersectionLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.findIntersection = new System.Windows.Forms.Button();
            this.intersectionBox2 = new System.Windows.Forms.ComboBox();
            this.intersectionBox1 = new System.Windows.Forms.ComboBox();
            this.EdgeCenterRotation = new System.Windows.Forms.Button();
            this.comboBoxEPoint2 = new System.Windows.Forms.ComboBox();
            this.comboBoxEPoint1 = new System.Windows.Forms.ComboBox();
            this.comboBoxEdges = new System.Windows.Forms.ComboBox();
            this.buttonAddEdge = new System.Windows.Forms.Button();
            this.buttonDeleteEdge = new System.Windows.Forms.Button();
            this.groupBoxPoint = new System.Windows.Forms.GroupBox();
            this.buttonEditPoint = new System.Windows.Forms.Button();
            this.labelCoordinates = new System.Windows.Forms.Label();
            this.buttonAddPoint = new System.Windows.Forms.Button();
            this.comboBoxPPoint = new System.Windows.Forms.ComboBox();
            this.buttonDeletePoint = new System.Windows.Forms.Button();
            this.groupBoxScaling = new System.Windows.Forms.GroupBox();
            this.buttonScale = new System.Windows.Forms.Button();
            this.textBoxScY = new System.Windows.Forms.TextBox();
            this.textBoxScX = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBoxTranslation = new System.Windows.Forms.GroupBox();
            this.buttonTranslate = new System.Windows.Forms.Button();
            this.textBoxTrY = new System.Windows.Forms.TextBox();
            this.textBoxTrX = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBoxRotate = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pointAboutBox = new System.Windows.Forms.ComboBox();
            this.buttonRotate = new System.Windows.Forms.Button();
            this.labelAngle = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBoxEdge.SuspendLayout();
            this.groupBoxPoint.SuspendLayout();
            this.groupBoxScaling.SuspendLayout();
            this.groupBoxTranslation.SuspendLayout();
            this.groupBoxRotate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.Controls.Add(this.groupBoxEdge);
            this.splitContainer1.Panel1.Controls.Add(this.groupBoxPoint);
            this.splitContainer1.Panel1.Controls.Add(this.groupBoxScaling);
            this.splitContainer1.Panel1.Controls.Add(this.groupBoxTranslation);
            this.splitContainer1.Panel1.Controls.Add(this.groupBoxRotate);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pictureBox1);
            this.splitContainer1.Size = new System.Drawing.Size(879, 669);
            this.splitContainer1.SplitterDistance = 230;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.pointInRect);
            this.groupBox1.Controls.Add(this.pointPositionButton);
            this.groupBox1.Controls.Add(this.pointPosition);
            this.groupBox1.Controls.Add(this.edgePositionBox);
            this.groupBox1.Controls.Add(this.pointPositionBox);
            this.groupBox1.Controls.Add(this.belongsToRect);
            this.groupBox1.Location = new System.Drawing.Point(12, 538);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 128);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Checking";
            // 
            // pointInRect
            // 
            this.pointInRect.AutoSize = true;
            this.pointInRect.Location = new System.Drawing.Point(138, 24);
            this.pointInRect.Name = "pointInRect";
            this.pointInRect.Size = new System.Drawing.Size(50, 13);
            this.pointInRect.TabIndex = 14;
            this.pointInRect.Text = "Yes / No";
            // 
            // pointPositionButton
            // 
            this.pointPositionButton.Location = new System.Drawing.Point(3, 104);
            this.pointPositionButton.Name = "pointPositionButton";
            this.pointPositionButton.Size = new System.Drawing.Size(78, 23);
            this.pointPositionButton.TabIndex = 13;
            this.pointPositionButton.Text = "Position";
            this.pointPositionButton.UseVisualStyleBackColor = true;
            this.pointPositionButton.Click += new System.EventHandler(this.pointPositionButton_Click);
            // 
            // pointPosition
            // 
            this.pointPosition.AutoSize = true;
            this.pointPosition.Location = new System.Drawing.Point(135, 80);
            this.pointPosition.Name = "pointPosition";
            this.pointPosition.Size = new System.Drawing.Size(61, 13);
            this.pointPosition.TabIndex = 12;
            this.pointPosition.Text = "Left / Right";
            // 
            // edgePositionBox
            // 
            this.edgePositionBox.FormattingEnabled = true;
            this.edgePositionBox.Location = new System.Drawing.Point(6, 77);
            this.edgePositionBox.Name = "edgePositionBox";
            this.edgePositionBox.Size = new System.Drawing.Size(121, 21);
            this.edgePositionBox.TabIndex = 11;
            // 
            // pointPositionBox
            // 
            this.pointPositionBox.FormattingEnabled = true;
            this.pointPositionBox.Location = new System.Drawing.Point(6, 21);
            this.pointPositionBox.Name = "pointPositionBox";
            this.pointPositionBox.Size = new System.Drawing.Size(65, 21);
            this.pointPositionBox.TabIndex = 7;
            // 
            // belongsToRect
            // 
            this.belongsToRect.Location = new System.Drawing.Point(6, 48);
            this.belongsToRect.Name = "belongsToRect";
            this.belongsToRect.Size = new System.Drawing.Size(56, 23);
            this.belongsToRect.TabIndex = 9;
            this.belongsToRect.Text = "Belongs";
            this.belongsToRect.UseVisualStyleBackColor = true;
            this.belongsToRect.Click += new System.EventHandler(this.belongsToRect_Click);
            // 
            // groupBoxEdge
            // 
            this.groupBoxEdge.BackColor = System.Drawing.Color.White;
            this.groupBoxEdge.Controls.Add(this.intersectionLabel);
            this.groupBoxEdge.Controls.Add(this.label7);
            this.groupBoxEdge.Controls.Add(this.findIntersection);
            this.groupBoxEdge.Controls.Add(this.intersectionBox2);
            this.groupBoxEdge.Controls.Add(this.intersectionBox1);
            this.groupBoxEdge.Controls.Add(this.EdgeCenterRotation);
            this.groupBoxEdge.Controls.Add(this.comboBoxEPoint2);
            this.groupBoxEdge.Controls.Add(this.comboBoxEPoint1);
            this.groupBoxEdge.Controls.Add(this.comboBoxEdges);
            this.groupBoxEdge.Controls.Add(this.buttonAddEdge);
            this.groupBoxEdge.Controls.Add(this.buttonDeleteEdge);
            this.groupBoxEdge.Location = new System.Drawing.Point(15, 98);
            this.groupBoxEdge.Name = "groupBoxEdge";
            this.groupBoxEdge.Size = new System.Drawing.Size(200, 177);
            this.groupBoxEdge.TabIndex = 4;
            this.groupBoxEdge.TabStop = false;
            this.groupBoxEdge.Text = "Edge";
            // 
            // intersectionLabel
            // 
            this.intersectionLabel.AutoSize = true;
            this.intersectionLabel.Location = new System.Drawing.Point(145, 132);
            this.intersectionLabel.Name = "intersectionLabel";
            this.intersectionLabel.Size = new System.Drawing.Size(22, 13);
            this.intersectionLabel.TabIndex = 10;
            this.intersectionLabel.Text = "( ; )";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(132, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Intersection:";
            // 
            // findIntersection
            // 
            this.findIntersection.Location = new System.Drawing.Point(10, 156);
            this.findIntersection.Name = "findIntersection";
            this.findIntersection.Size = new System.Drawing.Size(95, 21);
            this.findIntersection.TabIndex = 8;
            this.findIntersection.Text = "Find intersection";
            this.findIntersection.UseVisualStyleBackColor = true;
            this.findIntersection.Click += new System.EventHandler(this.findIntersection_Click);
            // 
            // intersectionBox2
            // 
            this.intersectionBox2.FormattingEnabled = true;
            this.intersectionBox2.Location = new System.Drawing.Point(11, 129);
            this.intersectionBox2.Name = "intersectionBox2";
            this.intersectionBox2.Size = new System.Drawing.Size(121, 21);
            this.intersectionBox2.TabIndex = 7;
            // 
            // intersectionBox1
            // 
            this.intersectionBox1.FormattingEnabled = true;
            this.intersectionBox1.Location = new System.Drawing.Point(11, 102);
            this.intersectionBox1.Name = "intersectionBox1";
            this.intersectionBox1.Size = new System.Drawing.Size(121, 21);
            this.intersectionBox1.TabIndex = 6;
            // 
            // EdgeCenterRotation
            // 
            this.EdgeCenterRotation.Location = new System.Drawing.Point(10, 73);
            this.EdgeCenterRotation.Name = "EdgeCenterRotation";
            this.EdgeCenterRotation.Size = new System.Drawing.Size(184, 23);
            this.EdgeCenterRotation.TabIndex = 5;
            this.EdgeCenterRotation.Text = "Rotate edge about center";
            this.EdgeCenterRotation.UseVisualStyleBackColor = true;
            this.EdgeCenterRotation.Click += new System.EventHandler(this.EdgeCenterRotation_Click);
            // 
            // comboBoxEPoint2
            // 
            this.comboBoxEPoint2.FormattingEnabled = true;
            this.comboBoxEPoint2.Location = new System.Drawing.Point(76, 46);
            this.comboBoxEPoint2.Name = "comboBoxEPoint2";
            this.comboBoxEPoint2.Size = new System.Drawing.Size(56, 21);
            this.comboBoxEPoint2.TabIndex = 4;
            // 
            // comboBoxEPoint1
            // 
            this.comboBoxEPoint1.FormattingEnabled = true;
            this.comboBoxEPoint1.Location = new System.Drawing.Point(11, 46);
            this.comboBoxEPoint1.Name = "comboBoxEPoint1";
            this.comboBoxEPoint1.Size = new System.Drawing.Size(59, 21);
            this.comboBoxEPoint1.TabIndex = 3;
            // 
            // comboBoxEdges
            // 
            this.comboBoxEdges.FormattingEnabled = true;
            this.comboBoxEdges.Location = new System.Drawing.Point(11, 19);
            this.comboBoxEdges.Name = "comboBoxEdges";
            this.comboBoxEdges.Size = new System.Drawing.Size(121, 21);
            this.comboBoxEdges.TabIndex = 2;
            // 
            // buttonAddEdge
            // 
            this.buttonAddEdge.Location = new System.Drawing.Point(138, 46);
            this.buttonAddEdge.Name = "buttonAddEdge";
            this.buttonAddEdge.Size = new System.Drawing.Size(56, 23);
            this.buttonAddEdge.TabIndex = 1;
            this.buttonAddEdge.Text = "Add";
            this.buttonAddEdge.UseVisualStyleBackColor = true;
            this.buttonAddEdge.Click += new System.EventHandler(this.buttonAddEdge_Click);
            // 
            // buttonDeleteEdge
            // 
            this.buttonDeleteEdge.Location = new System.Drawing.Point(138, 18);
            this.buttonDeleteEdge.Name = "buttonDeleteEdge";
            this.buttonDeleteEdge.Size = new System.Drawing.Size(56, 23);
            this.buttonDeleteEdge.TabIndex = 0;
            this.buttonDeleteEdge.Text = "Delete";
            this.buttonDeleteEdge.UseVisualStyleBackColor = true;
            this.buttonDeleteEdge.Click += new System.EventHandler(this.buttonDeleteEdge_Click);
            // 
            // groupBoxPoint
            // 
            this.groupBoxPoint.BackColor = System.Drawing.Color.White;
            this.groupBoxPoint.Controls.Add(this.buttonEditPoint);
            this.groupBoxPoint.Controls.Add(this.labelCoordinates);
            this.groupBoxPoint.Controls.Add(this.buttonAddPoint);
            this.groupBoxPoint.Controls.Add(this.comboBoxPPoint);
            this.groupBoxPoint.Controls.Add(this.buttonDeletePoint);
            this.groupBoxPoint.Location = new System.Drawing.Point(13, 9);
            this.groupBoxPoint.Name = "groupBoxPoint";
            this.groupBoxPoint.Size = new System.Drawing.Size(202, 83);
            this.groupBoxPoint.TabIndex = 3;
            this.groupBoxPoint.TabStop = false;
            this.groupBoxPoint.Text = "Point";
            // 
            // buttonEditPoint
            // 
            this.buttonEditPoint.Location = new System.Drawing.Point(139, 17);
            this.buttonEditPoint.Name = "buttonEditPoint";
            this.buttonEditPoint.Size = new System.Drawing.Size(57, 23);
            this.buttonEditPoint.TabIndex = 4;
            this.buttonEditPoint.Text = "Edit";
            this.buttonEditPoint.UseVisualStyleBackColor = true;
            this.buttonEditPoint.Click += new System.EventHandler(this.buttonEditPoint_Click);
            // 
            // labelCoordinates
            // 
            this.labelCoordinates.AutoSize = true;
            this.labelCoordinates.Location = new System.Drawing.Point(158, 57);
            this.labelCoordinates.Name = "labelCoordinates";
            this.labelCoordinates.Size = new System.Drawing.Size(0, 13);
            this.labelCoordinates.TabIndex = 3;
            // 
            // buttonAddPoint
            // 
            this.buttonAddPoint.Location = new System.Drawing.Point(7, 47);
            this.buttonAddPoint.Name = "buttonAddPoint";
            this.buttonAddPoint.Size = new System.Drawing.Size(75, 23);
            this.buttonAddPoint.TabIndex = 2;
            this.buttonAddPoint.Text = "Add";
            this.buttonAddPoint.UseVisualStyleBackColor = true;
            this.buttonAddPoint.Click += new System.EventHandler(this.buttonAddPoint_Click);
            // 
            // comboBoxPPoint
            // 
            this.comboBoxPPoint.FormattingEnabled = true;
            this.comboBoxPPoint.Location = new System.Drawing.Point(7, 19);
            this.comboBoxPPoint.Name = "comboBoxPPoint";
            this.comboBoxPPoint.Size = new System.Drawing.Size(65, 21);
            this.comboBoxPPoint.TabIndex = 1;
            // 
            // buttonDeletePoint
            // 
            this.buttonDeletePoint.Location = new System.Drawing.Point(78, 18);
            this.buttonDeletePoint.Name = "buttonDeletePoint";
            this.buttonDeletePoint.Size = new System.Drawing.Size(57, 23);
            this.buttonDeletePoint.TabIndex = 0;
            this.buttonDeletePoint.Text = "Delete";
            this.buttonDeletePoint.UseVisualStyleBackColor = true;
            this.buttonDeletePoint.Click += new System.EventHandler(this.buttonDeletePoint_Click);
            // 
            // groupBoxScaling
            // 
            this.groupBoxScaling.BackColor = System.Drawing.Color.White;
            this.groupBoxScaling.Controls.Add(this.buttonScale);
            this.groupBoxScaling.Controls.Add(this.textBoxScY);
            this.groupBoxScaling.Controls.Add(this.textBoxScX);
            this.groupBoxScaling.Controls.Add(this.label4);
            this.groupBoxScaling.Controls.Add(this.label5);
            this.groupBoxScaling.Location = new System.Drawing.Point(12, 459);
            this.groupBoxScaling.Name = "groupBoxScaling";
            this.groupBoxScaling.Size = new System.Drawing.Size(200, 73);
            this.groupBoxScaling.TabIndex = 2;
            this.groupBoxScaling.TabStop = false;
            this.groupBoxScaling.Text = "Scaling";
            // 
            // buttonScale
            // 
            this.buttonScale.Location = new System.Drawing.Point(6, 45);
            this.buttonScale.Name = "buttonScale";
            this.buttonScale.Size = new System.Drawing.Size(75, 23);
            this.buttonScale.TabIndex = 9;
            this.buttonScale.Text = "Scale";
            this.buttonScale.UseVisualStyleBackColor = true;
            this.buttonScale.Click += new System.EventHandler(this.buttonScale_Click);
            // 
            // textBoxScY
            // 
            this.textBoxScY.Location = new System.Drawing.Point(140, 19);
            this.textBoxScY.Name = "textBoxScY";
            this.textBoxScY.Size = new System.Drawing.Size(48, 20);
            this.textBoxScY.TabIndex = 8;
            // 
            // textBoxScX
            // 
            this.textBoxScX.Location = new System.Drawing.Point(51, 19);
            this.textBoxScX.Name = "textBoxScX";
            this.textBoxScX.Size = new System.Drawing.Size(42, 20);
            this.textBoxScX.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(99, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "By Oy";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "By Ox";
            // 
            // groupBoxTranslation
            // 
            this.groupBoxTranslation.BackColor = System.Drawing.Color.White;
            this.groupBoxTranslation.Controls.Add(this.buttonTranslate);
            this.groupBoxTranslation.Controls.Add(this.textBoxTrY);
            this.groupBoxTranslation.Controls.Add(this.textBoxTrX);
            this.groupBoxTranslation.Controls.Add(this.label3);
            this.groupBoxTranslation.Controls.Add(this.label2);
            this.groupBoxTranslation.Location = new System.Drawing.Point(12, 378);
            this.groupBoxTranslation.Name = "groupBoxTranslation";
            this.groupBoxTranslation.Size = new System.Drawing.Size(200, 75);
            this.groupBoxTranslation.TabIndex = 2;
            this.groupBoxTranslation.TabStop = false;
            this.groupBoxTranslation.Text = "Translation";
            // 
            // buttonTranslate
            // 
            this.buttonTranslate.Location = new System.Drawing.Point(11, 42);
            this.buttonTranslate.Name = "buttonTranslate";
            this.buttonTranslate.Size = new System.Drawing.Size(75, 23);
            this.buttonTranslate.TabIndex = 4;
            this.buttonTranslate.Text = "Translate";
            this.buttonTranslate.UseVisualStyleBackColor = true;
            this.buttonTranslate.Click += new System.EventHandler(this.buttonTranslate_Click);
            // 
            // textBoxTrY
            // 
            this.textBoxTrY.Location = new System.Drawing.Point(145, 16);
            this.textBoxTrY.Name = "textBoxTrY";
            this.textBoxTrY.Size = new System.Drawing.Size(38, 20);
            this.textBoxTrY.TabIndex = 3;
            // 
            // textBoxTrX
            // 
            this.textBoxTrX.Location = new System.Drawing.Point(48, 16);
            this.textBoxTrX.Name = "textBoxTrX";
            this.textBoxTrX.Size = new System.Drawing.Size(40, 20);
            this.textBoxTrX.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(100, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "By Oy";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "By Ox";
            // 
            // groupBoxRotate
            // 
            this.groupBoxRotate.BackColor = System.Drawing.Color.White;
            this.groupBoxRotate.Controls.Add(this.label6);
            this.groupBoxRotate.Controls.Add(this.pointAboutBox);
            this.groupBoxRotate.Controls.Add(this.buttonRotate);
            this.groupBoxRotate.Controls.Add(this.labelAngle);
            this.groupBoxRotate.Controls.Add(this.trackBar1);
            this.groupBoxRotate.Controls.Add(this.label1);
            this.groupBoxRotate.Location = new System.Drawing.Point(12, 281);
            this.groupBoxRotate.Name = "groupBoxRotate";
            this.groupBoxRotate.Size = new System.Drawing.Size(200, 91);
            this.groupBoxRotate.TabIndex = 1;
            this.groupBoxRotate.TabStop = false;
            this.groupBoxRotate.Text = "Rotation";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Choose point:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // pointAboutBox
            // 
            this.pointAboutBox.FormattingEnabled = true;
            this.pointAboutBox.Location = new System.Drawing.Point(7, 62);
            this.pointAboutBox.Name = "pointAboutBox";
            this.pointAboutBox.Size = new System.Drawing.Size(65, 21);
            this.pointAboutBox.TabIndex = 5;
            // 
            // buttonRotate
            // 
            this.buttonRotate.Location = new System.Drawing.Point(119, 62);
            this.buttonRotate.Name = "buttonRotate";
            this.buttonRotate.Size = new System.Drawing.Size(75, 23);
            this.buttonRotate.TabIndex = 2;
            this.buttonRotate.Text = "Rotate";
            this.buttonRotate.UseVisualStyleBackColor = true;
            this.buttonRotate.Click += new System.EventHandler(this.buttonRotate_Click);
            // 
            // labelAngle
            // 
            this.labelAngle.AutoSize = true;
            this.labelAngle.Location = new System.Drawing.Point(46, 18);
            this.labelAngle.Name = "labelAngle";
            this.labelAngle.Size = new System.Drawing.Size(13, 13);
            this.labelAngle.TabIndex = 4;
            this.labelAngle.Text = "0";
            // 
            // trackBar1
            // 
            this.trackBar1.AutoSize = false;
            this.trackBar1.Location = new System.Drawing.Point(59, 18);
            this.trackBar1.Maximum = 360;
            this.trackBar1.Minimum = -360;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(135, 28);
            this.trackBar1.TabIndex = 1;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Angle:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(639, 663);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 669);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Affine transformation";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxEdge.ResumeLayout(false);
            this.groupBoxEdge.PerformLayout();
            this.groupBoxPoint.ResumeLayout(false);
            this.groupBoxPoint.PerformLayout();
            this.groupBoxScaling.ResumeLayout(false);
            this.groupBoxScaling.PerformLayout();
            this.groupBoxTranslation.ResumeLayout(false);
            this.groupBoxTranslation.PerformLayout();
            this.groupBoxRotate.ResumeLayout(false);
            this.groupBoxRotate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBoxEdge;
        private System.Windows.Forms.Button buttonAddEdge;
        private System.Windows.Forms.Button buttonDeleteEdge;
        private System.Windows.Forms.GroupBox groupBoxPoint;
        private System.Windows.Forms.Button buttonAddPoint;
        private System.Windows.Forms.ComboBox comboBoxPPoint;
        private System.Windows.Forms.Button buttonDeletePoint;
        private System.Windows.Forms.GroupBox groupBoxScaling;
        private System.Windows.Forms.Button buttonScale;
        private System.Windows.Forms.TextBox textBoxScY;
        private System.Windows.Forms.TextBox textBoxScX;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBoxTranslation;
        private System.Windows.Forms.Button buttonTranslate;
        private System.Windows.Forms.TextBox textBoxTrY;
        private System.Windows.Forms.TextBox textBoxTrX;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBoxRotate;
        private System.Windows.Forms.Button buttonRotate;
        private System.Windows.Forms.Label labelAngle;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBoxEPoint2;
        private System.Windows.Forms.ComboBox comboBoxEPoint1;
        private System.Windows.Forms.ComboBox comboBoxEdges;
        private System.Windows.Forms.Label labelCoordinates;
        private System.Windows.Forms.Button buttonEditPoint;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox pointAboutBox;
        private System.Windows.Forms.Button EdgeCenterRotation;
        private System.Windows.Forms.Label intersectionLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button findIntersection;
        private System.Windows.Forms.ComboBox intersectionBox2;
        private System.Windows.Forms.ComboBox intersectionBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button belongsToRect;
        private System.Windows.Forms.Label pointInRect;
        private System.Windows.Forms.Button pointPositionButton;
        private System.Windows.Forms.Label pointPosition;
        private System.Windows.Forms.ComboBox edgePositionBox;
        private System.Windows.Forms.ComboBox pointPositionBox;
    }
}

