namespace WTJoystickCurves
{
    partial class MainForm
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
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.checkPitch = new System.Windows.Forms.CheckBox();
            this.checkRoll = new System.Windows.Forms.CheckBox();
            this.checkYaw = new System.Windows.Forms.CheckBox();
            this.curveYaw = new WTJoystickCurves.Curve();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.curveRoll = new WTJoystickCurves.Curve();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.curvePitch = new WTJoystickCurves.Curve();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.curveYaw.SuspendLayout();
            this.curveRoll.SuspendLayout();
            this.curvePitch.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(13, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Pitch";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(13, 160);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Roll";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(13, 311);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(31, 13);
            this.label13.TabIndex = 5;
            this.label13.Text = "Yaw";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(184, 2);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(46, 21);
            this.button1.TabIndex = 6;
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(184, 156);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(46, 21);
            this.button2.TabIndex = 6;
            this.button2.Text = "Reset";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(184, 307);
            this.button3.Margin = new System.Windows.Forms.Padding(0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(46, 21);
            this.button3.TabIndex = 6;
            this.button3.Text = "Reset";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(96, 459);
            this.button4.Margin = new System.Windows.Forms.Padding(0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(46, 21);
            this.button4.TabIndex = 6;
            this.button4.Text = "Save";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // checkPitch
            // 
            this.checkPitch.AutoSize = true;
            this.checkPitch.Location = new System.Drawing.Point(55, 5);
            this.checkPitch.Name = "checkPitch";
            this.checkPitch.Size = new System.Drawing.Size(77, 17);
            this.checkPitch.TabIndex = 7;
            this.checkPitch.Text = "Use sliders";
            this.checkPitch.UseVisualStyleBackColor = true;
            // 
            // checkRoll
            // 
            this.checkRoll.AutoSize = true;
            this.checkRoll.Location = new System.Drawing.Point(55, 159);
            this.checkRoll.Name = "checkRoll";
            this.checkRoll.Size = new System.Drawing.Size(77, 17);
            this.checkRoll.TabIndex = 8;
            this.checkRoll.Text = "Use sliders";
            this.checkRoll.UseVisualStyleBackColor = true;
            // 
            // checkYaw
            // 
            this.checkYaw.AutoSize = true;
            this.checkYaw.Location = new System.Drawing.Point(50, 310);
            this.checkYaw.Name = "checkYaw";
            this.checkYaw.Size = new System.Drawing.Size(77, 17);
            this.checkYaw.TabIndex = 8;
            this.checkYaw.Text = "Use sliders";
            this.checkYaw.UseVisualStyleBackColor = true;
            // 
            // curveYaw
            // 
            this.curveYaw.BackColor = System.Drawing.Color.White;
            this.curveYaw.Controls.Add(this.label15);
            this.curveYaw.Controls.Add(this.label16);
            this.curveYaw.Controls.Add(this.label17);
            this.curveYaw.Controls.Add(this.label18);
            this.curveYaw.Controls.Add(this.label20);
            this.curveYaw.Controls.Add(this.label21);
            this.curveYaw.LeftOffset = 25;
            this.curveYaw.Location = new System.Drawing.Point(13, 329);
            this.curveYaw.Name = "curveYaw";
            this.curveYaw.Points = new System.Drawing.Point[] {
        new System.Drawing.Point(0, 0),
        new System.Drawing.Point(0, 0),
        new System.Drawing.Point(0, 0),
        new System.Drawing.Point(0, 0),
        new System.Drawing.Point(0, 0),
        new System.Drawing.Point(0, 0),
        new System.Drawing.Point(0, 0),
        new System.Drawing.Point(0, 0),
        new System.Drawing.Point(0, 0),
        new System.Drawing.Point(0, 0)};
            this.curveYaw.Size = new System.Drawing.Size(217, 123);
            this.curveYaw.TabIndex = 0;
            this.curveYaw.TopOffset = 10;
            this.curveYaw.XStep = 20;
            this.curveYaw.YPoints = null;
            this.curveYaw.YScale = 100;
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(2, 103);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(20, 13);
            this.label15.TabIndex = 0;
            this.label15.Text = "0";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.Location = new System.Drawing.Point(2, 84);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(20, 9);
            this.label16.TabIndex = 0;
            this.label16.Text = "20";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label17
            // 
            this.label17.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label17.Location = new System.Drawing.Point(2, 6);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(20, 9);
            this.label17.TabIndex = 0;
            this.label17.Text = "100";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label18
            // 
            this.label18.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label18.Location = new System.Drawing.Point(2, 25);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(20, 9);
            this.label18.TabIndex = 0;
            this.label18.Text = "80";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label20
            // 
            this.label20.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label20.Location = new System.Drawing.Point(2, 45);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(20, 9);
            this.label20.TabIndex = 0;
            this.label20.Text = "60";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label21
            // 
            this.label21.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label21.Location = new System.Drawing.Point(2, 65);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(20, 9);
            this.label21.TabIndex = 0;
            this.label21.Text = "40";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // curveRoll
            // 
            this.curveRoll.BackColor = System.Drawing.Color.White;
            this.curveRoll.Controls.Add(this.label8);
            this.curveRoll.Controls.Add(this.label9);
            this.curveRoll.Controls.Add(this.label10);
            this.curveRoll.Controls.Add(this.label11);
            this.curveRoll.Controls.Add(this.label12);
            this.curveRoll.Controls.Add(this.label14);
            this.curveRoll.LeftOffset = 25;
            this.curveRoll.Location = new System.Drawing.Point(13, 178);
            this.curveRoll.Name = "curveRoll";
            this.curveRoll.Points = new System.Drawing.Point[] {
        new System.Drawing.Point(0, 0),
        new System.Drawing.Point(0, 0),
        new System.Drawing.Point(0, 0),
        new System.Drawing.Point(0, 0),
        new System.Drawing.Point(0, 0),
        new System.Drawing.Point(0, 0),
        new System.Drawing.Point(0, 0),
        new System.Drawing.Point(0, 0),
        new System.Drawing.Point(0, 0),
        new System.Drawing.Point(0, 0)};
            this.curveRoll.Size = new System.Drawing.Size(217, 123);
            this.curveRoll.TabIndex = 0;
            this.curveRoll.TopOffset = 10;
            this.curveRoll.XStep = 20;
            this.curveRoll.YPoints = null;
            this.curveRoll.YScale = 100;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(2, 103);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "0";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(2, 84);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(20, 9);
            this.label9.TabIndex = 0;
            this.label9.Text = "20";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(2, 6);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(20, 9);
            this.label10.TabIndex = 0;
            this.label10.Text = "100";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(2, 25);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(20, 9);
            this.label11.TabIndex = 0;
            this.label11.Text = "80";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(2, 45);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(20, 9);
            this.label12.TabIndex = 0;
            this.label12.Text = "60";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(2, 65);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(20, 9);
            this.label14.TabIndex = 0;
            this.label14.Text = "40";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // curvePitch
            // 
            this.curvePitch.BackColor = System.Drawing.Color.White;
            this.curvePitch.Controls.Add(this.label2);
            this.curvePitch.Controls.Add(this.label3);
            this.curvePitch.Controls.Add(this.label19);
            this.curvePitch.Controls.Add(this.label5);
            this.curvePitch.Controls.Add(this.label4);
            this.curvePitch.Controls.Add(this.label1);
            this.curvePitch.LeftOffset = 25;
            this.curvePitch.Location = new System.Drawing.Point(13, 24);
            this.curvePitch.Name = "curvePitch";
            this.curvePitch.Points = new System.Drawing.Point[] {
        new System.Drawing.Point(0, 0),
        new System.Drawing.Point(0, 0),
        new System.Drawing.Point(0, 0),
        new System.Drawing.Point(0, 0),
        new System.Drawing.Point(0, 0),
        new System.Drawing.Point(0, 0),
        new System.Drawing.Point(0, 0),
        new System.Drawing.Point(0, 0),
        new System.Drawing.Point(0, 0),
        new System.Drawing.Point(0, 0)};
            this.curvePitch.Size = new System.Drawing.Size(217, 123);
            this.curvePitch.TabIndex = 0;
            this.curvePitch.TopOffset = 10;
            this.curvePitch.XStep = 20;
            this.curvePitch.YPoints = null;
            this.curvePitch.YScale = 100;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(2, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "0";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(2, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 9);
            this.label3.TabIndex = 0;
            this.label3.Text = "20";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label19
            // 
            this.label19.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label19.Location = new System.Drawing.Point(2, 6);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(20, 9);
            this.label19.TabIndex = 0;
            this.label19.Text = "100";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(2, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 9);
            this.label5.TabIndex = 0;
            this.label5.Text = "80";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(2, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 9);
            this.label4.TabIndex = 0;
            this.label4.Text = "60";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(2, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 9);
            this.label1.TabIndex = 0;
            this.label1.Text = "40";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(245, 485);
            this.Controls.Add(this.checkYaw);
            this.Controls.Add(this.checkRoll);
            this.Controls.Add(this.checkPitch);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.curveYaw);
            this.Controls.Add(this.curveRoll);
            this.Controls.Add(this.curvePitch);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Curve Editor - War Thunder";
            this.curveYaw.ResumeLayout(false);
            this.curveRoll.ResumeLayout(false);
            this.curvePitch.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Curve curvePitch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.CheckBox checkPitch;
        private System.Windows.Forms.CheckBox checkRoll;
        private System.Windows.Forms.CheckBox checkYaw;
        private System.Windows.Forms.Label label19;
        private Curve curveRoll;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private Curve curveYaw;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;

    }
}

