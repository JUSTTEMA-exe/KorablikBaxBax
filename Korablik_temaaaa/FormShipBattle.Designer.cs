namespace Korablik_temaaaa
{
    partial class FormShipBattle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormShipBattle));
            this.pictureBoxCanon = new System.Windows.Forms.PictureBox();
            this.pictureBoxBoom = new System.Windows.Forms.PictureBox();
            this.pictureBoxBall = new System.Windows.Forms.PictureBox();
            this.pictureBoxShip = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCanon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShip)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxCanon
            // 
            this.pictureBoxCanon.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCanon.Image")));
            this.pictureBoxCanon.Location = new System.Drawing.Point(287, 438);
            this.pictureBoxCanon.Name = "pictureBoxCanon";
            this.pictureBoxCanon.Size = new System.Drawing.Size(129, 104);
            this.pictureBoxCanon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCanon.TabIndex = 0;
            this.pictureBoxCanon.TabStop = false;
            // 
            // pictureBoxBoom
            // 
            this.pictureBoxBoom.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxBoom.Image")));
            this.pictureBoxBoom.Location = new System.Drawing.Point(575, 0);
            this.pictureBoxBoom.Name = "pictureBoxBoom";
            this.pictureBoxBoom.Size = new System.Drawing.Size(166, 108);
            this.pictureBoxBoom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBoom.TabIndex = 1;
            this.pictureBoxBoom.TabStop = false;
            this.pictureBoxBoom.Visible = false;
            // 
            // pictureBoxBall
            // 
            this.pictureBoxBall.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxBall.Image")));
            this.pictureBoxBall.Location = new System.Drawing.Point(333, 412);
            this.pictureBoxBall.Name = "pictureBoxBall";
            this.pictureBoxBall.Size = new System.Drawing.Size(38, 38);
            this.pictureBoxBall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBall.TabIndex = 2;
            this.pictureBoxBall.TabStop = false;
            // 
            // pictureBoxShip
            // 
            this.pictureBoxShip.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxShip.Image")));
            this.pictureBoxShip.Location = new System.Drawing.Point(598, 22);
            this.pictureBoxShip.Name = "pictureBoxShip";
            this.pictureBoxShip.Size = new System.Drawing.Size(122, 65);
            this.pictureBoxShip.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxShip.TabIndex = 3;
            this.pictureBoxShip.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Magneto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(572, 528);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Стрелять на пробел";
            // 
            // FormShipBattle
            // 
            this.ClientSize = new System.Drawing.Size(742, 554);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxShip);
            this.Controls.Add(this.pictureBoxBall);
            this.Controls.Add(this.pictureBoxBoom);
            this.Controls.Add(this.pictureBoxCanon);
            this.Name = "FormShipBattle";
            this.Text = "Korablik";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCanon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShip)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxCanon;
        private System.Windows.Forms.PictureBox pictureBoxBoom;
        private System.Windows.Forms.PictureBox pictureBoxBall;
        private System.Windows.Forms.PictureBox pictureBoxShip;
        private System.Windows.Forms.Label label1;
    }
}

