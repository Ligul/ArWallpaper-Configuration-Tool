namespace ArWallpaper_Configuration_Tool
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.drawWireframe = new System.Windows.Forms.CheckBox();
            this.faceCascadePath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.videoCaptureDevice = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.resetButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cameraNear = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.cameraFar = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.modelPath = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cameraRatio = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ppcm = new System.Windows.Forms.TextBox();
            this.eyesGap = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.minFaceSize = new System.Windows.Forms.NumericUpDown();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lockZ = new System.Windows.Forms.CheckBox();
            this.projectionMode = new System.Windows.Forms.CheckBox();
            this.faceDistance = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.videoCaptureDevice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cameraNear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cameraFar)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minFaceSize)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.faceDistance)).BeginInit();
            this.SuspendLayout();
            // 
            // drawWireframe
            // 
            this.drawWireframe.AutoSize = true;
            this.drawWireframe.Location = new System.Drawing.Point(6, 21);
            this.drawWireframe.Name = "drawWireframe";
            this.drawWireframe.Size = new System.Drawing.Size(127, 21);
            this.drawWireframe.TabIndex = 0;
            this.drawWireframe.Text = "Draw wireframe";
            this.drawWireframe.UseVisualStyleBackColor = true;
            // 
            // faceCascadePath
            // 
            this.faceCascadePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.faceCascadePath.Location = new System.Drawing.Point(6, 92);
            this.faceCascadePath.Name = "faceCascadePath";
            this.faceCascadePath.Size = new System.Drawing.Size(336, 22);
            this.faceCascadePath.TabIndex = 2;
            this.faceCascadePath.Text = "data/haarcascade_frontalface_alt.xml";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Video capture device";
            // 
            // videoCaptureDevice
            // 
            this.videoCaptureDevice.Location = new System.Drawing.Point(6, 38);
            this.videoCaptureDevice.Name = "videoCaptureDevice";
            this.videoCaptureDevice.Size = new System.Drawing.Size(174, 22);
            this.videoCaptureDevice.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(183, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Near";
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(10, 366);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(133, 37);
            this.resetButton.TabIndex = 9;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.saveButton.Location = new System.Drawing.Point(149, 366);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(218, 37);
            this.saveButton.TabIndex = 10;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(237, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Far";
            // 
            // cameraNear
            // 
            this.cameraNear.Location = new System.Drawing.Point(186, 38);
            this.cameraNear.Name = "cameraNear";
            this.cameraNear.Size = new System.Drawing.Size(48, 22);
            this.cameraNear.TabIndex = 12;
            this.cameraNear.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(292, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Ratio";
            // 
            // cameraFar
            // 
            this.cameraFar.Location = new System.Drawing.Point(240, 38);
            this.cameraFar.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.cameraFar.Name = "cameraFar";
            this.cameraFar.Size = new System.Drawing.Size(48, 22);
            this.cameraFar.TabIndex = 14;
            this.cameraFar.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Face cascade path";
            // 
            // modelPath
            // 
            this.modelPath.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.modelPath.Location = new System.Drawing.Point(6, 21);
            this.modelPath.Name = "modelPath";
            this.modelPath.Size = new System.Drawing.Size(336, 22);
            this.modelPath.TabIndex = 16;
            this.modelPath.Text = "data/models/minecraft_1.obj";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.cameraRatio);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.videoCaptureDevice);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cameraNear);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cameraFar);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(10, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(356, 73);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Camera settings";
            // 
            // cameraRatio
            // 
            this.cameraRatio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cameraRatio.Location = new System.Drawing.Point(294, 38);
            this.cameraRatio.MaxLength = 10;
            this.cameraRatio.Name = "cameraRatio";
            this.cameraRatio.Size = new System.Drawing.Size(48, 22);
            this.cameraRatio.TabIndex = 15;
            this.cameraRatio.Text = "0.3";
            this.cameraRatio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cameraRatio_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.ppcm);
            this.groupBox2.Controls.Add(this.eyesGap);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.minFaceSize);
            this.groupBox2.Location = new System.Drawing.Point(10, 152);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(356, 77);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Face tracking settings";
            // 
            // ppcm
            // 
            this.ppcm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ppcm.Location = new System.Drawing.Point(268, 38);
            this.ppcm.Name = "ppcm";
            this.ppcm.Size = new System.Drawing.Size(74, 22);
            this.ppcm.TabIndex = 24;
            this.ppcm.Text = "10";
            this.ppcm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ppcm_KeyPress);
            // 
            // eyesGap
            // 
            this.eyesGap.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.eyesGap.Location = new System.Drawing.Point(186, 38);
            this.eyesGap.Name = "eyesGap";
            this.eyesGap.Size = new System.Drawing.Size(76, 22);
            this.eyesGap.TabIndex = 16;
            this.eyesGap.Text = "7";
            this.eyesGap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.eyesGap_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(265, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 17);
            this.label8.TabIndex = 23;
            this.label8.Text = "Pixels/Cm";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(183, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 17);
            this.label7.TabIndex = 21;
            this.label7.Text = "Eyes gap";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Minimum face size";
            // 
            // minFaceSize
            // 
            this.minFaceSize.Location = new System.Drawing.Point(6, 38);
            this.minFaceSize.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.minFaceSize.Name = "minFaceSize";
            this.minFaceSize.Size = new System.Drawing.Size(174, 22);
            this.minFaceSize.TabIndex = 18;
            this.minFaceSize.Value = new decimal(new int[] {
            80,
            0,
            0,
            0});
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.modelPath);
            this.groupBox3.Location = new System.Drawing.Point(10, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(356, 55);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Model path";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.faceDistance);
            this.groupBox4.Controls.Add(this.lockZ);
            this.groupBox4.Controls.Add(this.projectionMode);
            this.groupBox4.Controls.Add(this.drawWireframe);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.faceCascadePath);
            this.groupBox4.Location = new System.Drawing.Point(10, 235);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(356, 125);
            this.groupBox4.TabIndex = 21;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Advanced settings";
            // 
            // lockZ
            // 
            this.lockZ.AutoSize = true;
            this.lockZ.Location = new System.Drawing.Point(6, 48);
            this.lockZ.Name = "lockZ";
            this.lockZ.Size = new System.Drawing.Size(102, 21);
            this.lockZ.TabIndex = 2;
            this.lockZ.Text = "Lock Z Axis";
            this.lockZ.UseVisualStyleBackColor = true;
            this.lockZ.Click += new System.EventHandler(this.lockZ_Click);
            // 
            // projectionMode
            // 
            this.projectionMode.AutoSize = true;
            this.projectionMode.Checked = true;
            this.projectionMode.CheckState = System.Windows.Forms.CheckState.Checked;
            this.projectionMode.Location = new System.Drawing.Point(134, 21);
            this.projectionMode.Name = "projectionMode";
            this.projectionMode.Size = new System.Drawing.Size(132, 21);
            this.projectionMode.TabIndex = 1;
            this.projectionMode.Text = "Projection mode";
            this.projectionMode.UseVisualStyleBackColor = true;
            // 
            // faceDistance
            // 
            this.faceDistance.Enabled = false;
            this.faceDistance.Location = new System.Drawing.Point(114, 48);
            this.faceDistance.Name = "faceDistance";
            this.faceDistance.Size = new System.Drawing.Size(48, 22);
            this.faceDistance.TabIndex = 16;
            this.faceDistance.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 413);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.resetButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "ArWallpaper Configuration Tool";
            ((System.ComponentModel.ISupportInitialize)(this.videoCaptureDevice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cameraNear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cameraFar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minFaceSize)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.faceDistance)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox drawWireframe;
        private System.Windows.Forms.TextBox faceCascadePath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown videoCaptureDevice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown cameraNear;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown cameraFar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox modelPath;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown minFaceSize;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox lockZ;
        private System.Windows.Forms.CheckBox projectionMode;
        private System.Windows.Forms.TextBox cameraRatio;
        private System.Windows.Forms.TextBox ppcm;
        private System.Windows.Forms.TextBox eyesGap;
        private System.Windows.Forms.NumericUpDown faceDistance;
    }
}

