namespace ShowKeyboard
{
    partial class frmMain
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.tmrLoop = new System.Windows.Forms.Timer(this.components);
            this.picRightDown = new System.Windows.Forms.PictureBox();
            this.picLeftDown = new System.Windows.Forms.PictureBox();
            this.picRightTop = new System.Windows.Forms.PictureBox();
            this.picCenter = new System.Windows.Forms.PictureBox();
            this.picLeftTop = new System.Windows.Forms.PictureBox();
            this.picOffRightDown = new System.Windows.Forms.PictureBox();
            this.picOffLeftDown = new System.Windows.Forms.PictureBox();
            this.picOffRightTop = new System.Windows.Forms.PictureBox();
            this.picOffCenter = new System.Windows.Forms.PictureBox();
            this.picOffLeftTop = new System.Windows.Forms.PictureBox();
            this.lblKeysPerMinute = new System.Windows.Forms.Label();
            this.tmrSecond = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picRightDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLeftDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRightTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCenter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLeftTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOffRightDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOffLeftDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOffRightTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOffCenter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOffLeftTop)).BeginInit();
            this.SuspendLayout();
            // 
            // tmrLoop
            // 
            this.tmrLoop.Enabled = true;
            this.tmrLoop.Interval = 1;
            this.tmrLoop.Tick += new System.EventHandler(this.tmrLoop_Tick);
            // 
            // picRightDown
            // 
            this.picRightDown.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.picRightDown.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picRightDown.BackgroundImage")));
            this.picRightDown.Location = new System.Drawing.Point(345, 155);
            this.picRightDown.Name = "picRightDown";
            this.picRightDown.Size = new System.Drawing.Size(55, 56);
            this.picRightDown.TabIndex = 9;
            this.picRightDown.TabStop = false;
            // 
            // picLeftDown
            // 
            this.picLeftDown.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.picLeftDown.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picLeftDown.BackgroundImage")));
            this.picLeftDown.Location = new System.Drawing.Point(223, 155);
            this.picLeftDown.Name = "picLeftDown";
            this.picLeftDown.Size = new System.Drawing.Size(55, 56);
            this.picLeftDown.TabIndex = 8;
            this.picLeftDown.TabStop = false;
            // 
            // picRightTop
            // 
            this.picRightTop.BackColor = System.Drawing.Color.OrangeRed;
            this.picRightTop.Image = ((System.Drawing.Image)(resources.GetObject("picRightTop.Image")));
            this.picRightTop.Location = new System.Drawing.Point(345, 31);
            this.picRightTop.Name = "picRightTop";
            this.picRightTop.Size = new System.Drawing.Size(55, 56);
            this.picRightTop.TabIndex = 7;
            this.picRightTop.TabStop = false;
            // 
            // picCenter
            // 
            this.picCenter.BackColor = System.Drawing.Color.Gold;
            this.picCenter.Image = ((System.Drawing.Image)(resources.GetObject("picCenter.Image")));
            this.picCenter.Location = new System.Drawing.Point(284, 93);
            this.picCenter.Name = "picCenter";
            this.picCenter.Size = new System.Drawing.Size(55, 56);
            this.picCenter.TabIndex = 6;
            this.picCenter.TabStop = false;
            // 
            // picLeftTop
            // 
            this.picLeftTop.BackColor = System.Drawing.Color.OrangeRed;
            this.picLeftTop.Image = ((System.Drawing.Image)(resources.GetObject("picLeftTop.Image")));
            this.picLeftTop.Location = new System.Drawing.Point(223, 31);
            this.picLeftTop.Name = "picLeftTop";
            this.picLeftTop.Size = new System.Drawing.Size(55, 56);
            this.picLeftTop.TabIndex = 5;
            this.picLeftTop.TabStop = false;
            // 
            // picOffRightDown
            // 
            this.picOffRightDown.Image = global::ShowYourKeys.Properties.Resources.off_rightdown;
            this.picOffRightDown.Location = new System.Drawing.Point(128, 145);
            this.picOffRightDown.Name = "picOffRightDown";
            this.picOffRightDown.Size = new System.Drawing.Size(55, 56);
            this.picOffRightDown.TabIndex = 4;
            this.picOffRightDown.TabStop = false;
            // 
            // picOffLeftDown
            // 
            this.picOffLeftDown.Image = global::ShowYourKeys.Properties.Resources.off_leftdown;
            this.picOffLeftDown.Location = new System.Drawing.Point(6, 145);
            this.picOffLeftDown.Name = "picOffLeftDown";
            this.picOffLeftDown.Size = new System.Drawing.Size(55, 56);
            this.picOffLeftDown.TabIndex = 3;
            this.picOffLeftDown.TabStop = false;
            // 
            // picOffRightTop
            // 
            this.picOffRightTop.Image = global::ShowYourKeys.Properties.Resources.off_rightup;
            this.picOffRightTop.Location = new System.Drawing.Point(128, 21);
            this.picOffRightTop.Name = "picOffRightTop";
            this.picOffRightTop.Size = new System.Drawing.Size(55, 56);
            this.picOffRightTop.TabIndex = 2;
            this.picOffRightTop.TabStop = false;
            // 
            // picOffCenter
            // 
            this.picOffCenter.Image = global::ShowYourKeys.Properties.Resources.off_center;
            this.picOffCenter.Location = new System.Drawing.Point(67, 83);
            this.picOffCenter.Name = "picOffCenter";
            this.picOffCenter.Size = new System.Drawing.Size(55, 56);
            this.picOffCenter.TabIndex = 1;
            this.picOffCenter.TabStop = false;
            // 
            // picOffLeftTop
            // 
            this.picOffLeftTop.BackColor = System.Drawing.Color.Transparent;
            this.picOffLeftTop.Image = global::ShowYourKeys.Properties.Resources.off_leftup;
            this.picOffLeftTop.Location = new System.Drawing.Point(6, 21);
            this.picOffLeftTop.Name = "picOffLeftTop";
            this.picOffLeftTop.Size = new System.Drawing.Size(55, 56);
            this.picOffLeftTop.TabIndex = 0;
            this.picOffLeftTop.TabStop = false;
            // 
            // lblKeysPerMinute
            // 
            this.lblKeysPerMinute.AutoSize = true;
            this.lblKeysPerMinute.Location = new System.Drawing.Point(3, 3);
            this.lblKeysPerMinute.Name = "lblKeysPerMinute";
            this.lblKeysPerMinute.Size = new System.Drawing.Size(82, 13);
            this.lblKeysPerMinute.TabIndex = 10;
            this.lblKeysPerMinute.Text = "Keys per Sec: 0";
            // 
            // tmrSecond
            // 
            this.tmrSecond.Enabled = true;
            this.tmrSecond.Interval = 1000;
            this.tmrSecond.Tick += new System.EventHandler(this.tmrSecond_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(189, 208);
            this.Controls.Add(this.lblKeysPerMinute);
            this.Controls.Add(this.picRightDown);
            this.Controls.Add(this.picLeftDown);
            this.Controls.Add(this.picRightTop);
            this.Controls.Add(this.picCenter);
            this.Controls.Add(this.picLeftTop);
            this.Controls.Add(this.picOffRightDown);
            this.Controls.Add(this.picOffLeftDown);
            this.Controls.Add(this.picOffRightTop);
            this.Controls.Add(this.picOffCenter);
            this.Controls.Add(this.picOffLeftTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmMain";
            this.Text = "Keyboard";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picRightDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLeftDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRightTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCenter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLeftTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOffRightDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOffLeftDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOffRightTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOffCenter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOffLeftTop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picOffLeftTop;
        private System.Windows.Forms.PictureBox picOffCenter;
        private System.Windows.Forms.PictureBox picOffRightTop;
        private System.Windows.Forms.PictureBox picOffLeftDown;
        private System.Windows.Forms.PictureBox picOffRightDown;
        private System.Windows.Forms.PictureBox picRightDown;
        private System.Windows.Forms.PictureBox picLeftDown;
        private System.Windows.Forms.PictureBox picRightTop;
        private System.Windows.Forms.PictureBox picCenter;
        private System.Windows.Forms.PictureBox picLeftTop;
        private System.Windows.Forms.Timer tmrLoop;
        private System.Windows.Forms.Label lblKeysPerMinute;
        private System.Windows.Forms.Timer tmrSecond;
    }
}

