namespace _3x3_Slot_Machine
{
    partial class Slots3x3
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Slots3x3));
            this.fruitList = new System.Windows.Forms.ImageList(this.components);
            this.pnl_boxes = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_spin = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fruitList
            // 
            this.fruitList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("fruitList.ImageStream")));
            this.fruitList.TransparentColor = System.Drawing.Color.Transparent;
            this.fruitList.Images.SetKeyName(0, "Apple.bmp");
            this.fruitList.Images.SetKeyName(1, "Banana.bmp");
            this.fruitList.Images.SetKeyName(2, "Cherries.bmp");
            this.fruitList.Images.SetKeyName(3, "Grapes.bmp");
            this.fruitList.Images.SetKeyName(4, "Lemon.bmp");
            this.fruitList.Images.SetKeyName(5, "Lime.bmp");
            this.fruitList.Images.SetKeyName(6, "Orange.bmp");
            this.fruitList.Images.SetKeyName(7, "Pear.bmp");
            this.fruitList.Images.SetKeyName(8, "Strawberry.bmp");
            this.fruitList.Images.SetKeyName(9, "Watermelon.bmp");
            // 
            // pnl_boxes
            // 
            this.pnl_boxes.Location = new System.Drawing.Point(0, 0);
            this.pnl_boxes.Name = "pnl_boxes";
            this.pnl_boxes.Size = new System.Drawing.Size(444, 444);
            this.pnl_boxes.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(450, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(170, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Your Money:";
            // 
            // btn_spin
            // 
            this.btn_spin.Location = new System.Drawing.Point(450, 118);
            this.btn_spin.Name = "btn_spin";
            this.btn_spin.Size = new System.Drawing.Size(75, 23);
            this.btn_spin.TabIndex = 3;
            this.btn_spin.Text = "Spin";
            this.btn_spin.UseVisualStyleBackColor = true;
            this.btn_spin.Click += new System.EventHandler(this.btn_spin_Click);
            // 
            // Slots3x3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 417);
            this.Controls.Add(this.btn_spin);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pnl_boxes);
            this.Name = "Slots3x3";
            this.Text = "Slot Machine Fun";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList fruitList;
        private System.Windows.Forms.Panel pnl_boxes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_spin;
    }
}

