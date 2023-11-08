namespace Denas
{
    partial class frmSegmentation1
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
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.ovalShape2 = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.ovalShape1 = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.rectangleShape2 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rectangleShape3 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rectangleShape4 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rectangleShape5 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rectangleShape6 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.SuspendLayout();
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape6,
            this.rectangleShape5,
            this.rectangleShape4,
            this.rectangleShape3,
            this.rectangleShape2,
            this.rectangleShape1,
            this.ovalShape2,
            this.ovalShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(753, 571);
            this.shapeContainer1.TabIndex = 0;
            this.shapeContainer1.TabStop = false;
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.BorderColor = System.Drawing.Color.DarkGreen;
            this.rectangleShape1.Location = new System.Drawing.Point(587, 428);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(126, 50);
            this.rectangleShape1.Click += new System.EventHandler(this.rectangleShape1_Click);
            // 
            // ovalShape2
            // 
            this.ovalShape2.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.ovalShape2.Location = new System.Drawing.Point(31, 434);
            this.ovalShape2.Name = "ovalShape2";
            this.ovalShape2.Size = new System.Drawing.Size(75, 69);
            this.ovalShape2.Click += new System.EventHandler(this.ovalShape2_Click);
            // 
            // ovalShape1
            // 
            this.ovalShape1.BorderColor = System.Drawing.Color.Coral;
            this.ovalShape1.Location = new System.Drawing.Point(676, 11);
            this.ovalShape1.Name = "ovalShape1";
            this.ovalShape1.Size = new System.Drawing.Size(27, 26);
            this.ovalShape1.Click += new System.EventHandler(this.ovalShape1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(556, 263);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 63);
            this.button1.TabIndex = 1;
            this.button1.Text = "نمایش تصویر";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(363, 328);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 63);
            this.button2.TabIndex = 2;
            this.button2.Text = "مورفولوژی";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(137, 207);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(133, 63);
            this.button3.TabIndex = 3;
            this.button3.Text = "لبه یابی کنی";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(137, 328);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(133, 63);
            this.button4.TabIndex = 4;
            this.button4.Text = "آستانه گذاری";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(363, 207);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(133, 63);
            this.button5.TabIndex = 5;
            this.button5.Text = "خوشه بندی کامینز";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // rectangleShape2
            // 
            this.rectangleShape2.Location = new System.Drawing.Point(442, 505);
            this.rectangleShape2.Name = "rectangleShape2";
            this.rectangleShape2.Size = new System.Drawing.Size(144, 62);
            this.rectangleShape2.Click += new System.EventHandler(this.rectangleShape2_Click);
            // 
            // rectangleShape3
            // 
            this.rectangleShape3.Location = new System.Drawing.Point(585, 506);
            this.rectangleShape3.Name = "rectangleShape3";
            this.rectangleShape3.Size = new System.Drawing.Size(167, 61);
            this.rectangleShape3.Click += new System.EventHandler(this.rectangleShape3_Click);
            // 
            // rectangleShape4
            // 
            this.rectangleShape4.Location = new System.Drawing.Point(157, 507);
            this.rectangleShape4.Name = "rectangleShape4";
            this.rectangleShape4.Size = new System.Drawing.Size(135, 62);
            this.rectangleShape4.Click += new System.EventHandler(this.rectangleShape4_Click);
            // 
            // rectangleShape5
            // 
            this.rectangleShape5.Location = new System.Drawing.Point(292, 507);
            this.rectangleShape5.Name = "rectangleShape5";
            this.rectangleShape5.Size = new System.Drawing.Size(148, 62);
            this.rectangleShape5.Click += new System.EventHandler(this.rectangleShape5_Click);
            // 
            // rectangleShape6
            // 
            this.rectangleShape6.Location = new System.Drawing.Point(0, 506);
            this.rectangleShape6.Name = "rectangleShape6";
            this.rectangleShape6.Size = new System.Drawing.Size(153, 62);
            this.rectangleShape6.Click += new System.EventHandler(this.rectangleShape6_Click);
            // 
            // frmSegmentation1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Denas.Properties.Resources.Segmentation;
            this.ClientSize = new System.Drawing.Size(753, 571);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSegmentation1";
            this.Text = "Segmentation1";
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.OvalShape ovalShape2;
        private Microsoft.VisualBasic.PowerPacks.OvalShape ovalShape1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape6;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape5;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape4;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape3;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape2;
    }
}