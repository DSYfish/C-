using System;

namespace _20240411
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label_combo = new System.Windows.Forms.Label();
            this.label_botton = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.button_s = new System.Windows.Forms.Button();
            this.button_r = new System.Windows.Forms.Button();
            this.button_p = new System.Windows.Forms.Button();
            this.label_wl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label_combo
            // 
            this.label_combo.AutoSize = true;
            this.label_combo.Font = new System.Drawing.Font("華康鐵線龍門W3", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_combo.ForeColor = System.Drawing.Color.Red;
            this.label_combo.Location = new System.Drawing.Point(361, 87);
            this.label_combo.Name = "label_combo";
            this.label_combo.Size = new System.Drawing.Size(133, 29);
            this.label_combo.TabIndex = 0;
            this.label_combo.Text = "出拳速度";
            this.label_combo.Click += new System.EventHandler(this.label1_Click);
            // 
            // label_botton
            // 
            this.label_botton.AutoSize = true;
            this.label_botton.Font = new System.Drawing.Font("華康鐵線龍門W3", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_botton.ForeColor = System.Drawing.Color.Red;
            this.label_botton.Location = new System.Drawing.Point(47, 309);
            this.label_botton.Name = "label_botton";
            this.label_botton.Size = new System.Drawing.Size(447, 35);
            this.label_botton.TabIndex = 1;
            this.label_botton.Text = "按下按鈕出拳，放開決定。";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "50",
            "100",
            "500",
            "1000"});
            this.comboBox1.Location = new System.Drawing.Point(366, 119);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 42);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.Text = "100";
            this.comboBox1.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedValueChanged);
            // 
            // button
            // 
            this.button.Font = new System.Drawing.Font("華康鐵線龍門W3", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button.Location = new System.Drawing.Point(46, 356);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(448, 44);
            this.button.TabIndex = 3;
            this.button.Text = "出拳";
            this.button.UseVisualStyleBackColor = true;
            this.button.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button_MouseDown);
            this.button.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button_MouseUp);
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(46, 23);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(276, 267);
            this.pictureBox.TabIndex = 4;
            this.pictureBox.TabStop = false;
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "paper.png");
            this.imageList.Images.SetKeyName(1, "rock.png");
            this.imageList.Images.SetKeyName(2, "scissors.png");
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // button_s
            // 
            this.button_s.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_s.BackgroundImage")));
            this.button_s.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_s.Location = new System.Drawing.Point(46, 419);
            this.button_s.Name = "button_s";
            this.button_s.Size = new System.Drawing.Size(119, 115);
            this.button_s.TabIndex = 5;
            this.button_s.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_s.UseVisualStyleBackColor = true;
            this.button_s.MouseDown += new System.Windows.Forms.MouseEventHandler(this.my_MouseDown);
            this.button_s.MouseUp += new System.Windows.Forms.MouseEventHandler(this.my_MouseUp);
            // 
            // button_r
            // 
            this.button_r.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_r.BackgroundImage")));
            this.button_r.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_r.Location = new System.Drawing.Point(212, 419);
            this.button_r.Name = "button_r";
            this.button_r.Size = new System.Drawing.Size(119, 115);
            this.button_r.TabIndex = 6;
            this.button_r.UseVisualStyleBackColor = true;
            this.button_r.MouseDown += new System.Windows.Forms.MouseEventHandler(this.my_MouseDown);
            this.button_r.MouseUp += new System.Windows.Forms.MouseEventHandler(this.my_MouseUp);
            // 
            // button_p
            // 
            this.button_p.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_p.BackgroundImage")));
            this.button_p.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_p.Location = new System.Drawing.Point(375, 419);
            this.button_p.Name = "button_p";
            this.button_p.Size = new System.Drawing.Size(119, 115);
            this.button_p.TabIndex = 7;
            this.button_p.UseVisualStyleBackColor = true;
            this.button_p.MouseDown += new System.Windows.Forms.MouseEventHandler(this.my_MouseDown);
            this.button_p.MouseUp += new System.Windows.Forms.MouseEventHandler(this.my_MouseUp);
            // 
            // label_wl
            // 
            this.label_wl.AllowDrop = true;
            this.label_wl.AutoSize = true;
            this.label_wl.Font = new System.Drawing.Font("華康鐵線龍門W3", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_wl.Location = new System.Drawing.Point(387, 210);
            this.label_wl.Name = "label_wl";
            this.label_wl.Size = new System.Drawing.Size(0, 24);
            this.label_wl.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 546);
            this.Controls.Add(this.label_wl);
            this.Controls.Add(this.button_p);
            this.Controls.Add(this.button_r);
            this.Controls.Add(this.button_s);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.button);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label_botton);
            this.Controls.Add(this.label_combo);
            this.Name = "Form1";
            this.Text = "猜拳";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label label_combo;
        private System.Windows.Forms.Label label_botton;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button button_s;
        private System.Windows.Forms.Button button_r;
        private System.Windows.Forms.Button button_p;
        private System.Windows.Forms.Label label_wl;
    }
}

