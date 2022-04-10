
namespace Puzzle
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.timeLbl = new System.Windows.Forms.Label();
            this.shuffleBtn = new System.Windows.Forms.Button();
            this.QuitBtn = new System.Windows.Forms.Button();
            this.PauseBtn = new System.Windows.Forms.Button();
            this.movesLbl = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.frame9 = new System.Windows.Forms.PictureBox();
            this.frame8 = new System.Windows.Forms.PictureBox();
            this.frame7 = new System.Windows.Forms.PictureBox();
            this.frame6 = new System.Windows.Forms.PictureBox();
            this.frame5 = new System.Windows.Forms.PictureBox();
            this.frame4 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.frame3 = new System.Windows.Forms.PictureBox();
            this.frame2 = new System.Windows.Forms.PictureBox();
            this.frame1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.frame9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frame8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frame7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frame6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frame5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frame4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frame3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frame2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frame1)).BeginInit();
            this.SuspendLayout();
            // 
            // timeLbl
            // 
            this.timeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timeLbl.Location = new System.Drawing.Point(472, 329);
            this.timeLbl.Name = "timeLbl";
            this.timeLbl.Size = new System.Drawing.Size(300, 65);
            this.timeLbl.TabIndex = 2;
            this.timeLbl.Text = "01:00";
            this.timeLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // shuffleBtn
            // 
            this.shuffleBtn.BackColor = System.Drawing.Color.Black;
            this.shuffleBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.shuffleBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.shuffleBtn.Location = new System.Drawing.Point(458, 423);
            this.shuffleBtn.Name = "shuffleBtn";
            this.shuffleBtn.Size = new System.Drawing.Size(90, 45);
            this.shuffleBtn.TabIndex = 3;
            this.shuffleBtn.Text = "Shuffle";
            this.shuffleBtn.UseVisualStyleBackColor = false;
            this.shuffleBtn.Click += new System.EventHandler(this.shuffleBtn_Click);
            // 
            // QuitBtn
            // 
            this.QuitBtn.BackColor = System.Drawing.Color.Black;
            this.QuitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.QuitBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.QuitBtn.Location = new System.Drawing.Point(693, 423);
            this.QuitBtn.Name = "QuitBtn";
            this.QuitBtn.Size = new System.Drawing.Size(90, 45);
            this.QuitBtn.TabIndex = 3;
            this.QuitBtn.Text = "Quit";
            this.QuitBtn.UseVisualStyleBackColor = false;
            this.QuitBtn.Click += new System.EventHandler(this.QuitBtn_Click);
            // 
            // PauseBtn
            // 
            this.PauseBtn.BackColor = System.Drawing.Color.Black;
            this.PauseBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PauseBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.PauseBtn.Location = new System.Drawing.Point(578, 423);
            this.PauseBtn.Name = "PauseBtn";
            this.PauseBtn.Size = new System.Drawing.Size(90, 45);
            this.PauseBtn.TabIndex = 3;
            this.PauseBtn.Text = "Pause";
            this.PauseBtn.UseVisualStyleBackColor = false;
            this.PauseBtn.Click += new System.EventHandler(this.PauseBtn_Click);
            // 
            // movesLbl
            // 
            this.movesLbl.AutoSize = true;
            this.movesLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.movesLbl.Location = new System.Drawing.Point(12, 442);
            this.movesLbl.Name = "movesLbl";
            this.movesLbl.Size = new System.Drawing.Size(174, 26);
            this.movesLbl.TabIndex = 4;
            this.movesLbl.Text = "Moves made: 0";
            // 
            // gameTimer
            // 
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // frame9
            // 
            this.frame9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.frame9.Image = global::Puzzle.Properties.Resources.black_square;
            this.frame9.Location = new System.Drawing.Point(284, 284);
            this.frame9.Name = "frame9";
            this.frame9.Size = new System.Drawing.Size(130, 130);
            this.frame9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.frame9.TabIndex = 1;
            this.frame9.TabStop = false;
            this.frame9.Click += new System.EventHandler(this.frame9_Click);
            // 
            // frame8
            // 
            this.frame8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.frame8.Image = global::Puzzle.Properties.Resources.image_part_0081;
            this.frame8.Location = new System.Drawing.Point(148, 284);
            this.frame8.Name = "frame8";
            this.frame8.Size = new System.Drawing.Size(130, 130);
            this.frame8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.frame8.TabIndex = 1;
            this.frame8.TabStop = false;
            this.frame8.Click += new System.EventHandler(this.frame8_Click);
            // 
            // frame7
            // 
            this.frame7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.frame7.Image = global::Puzzle.Properties.Resources.image_part_0071;
            this.frame7.Location = new System.Drawing.Point(12, 284);
            this.frame7.Name = "frame7";
            this.frame7.Size = new System.Drawing.Size(130, 130);
            this.frame7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.frame7.TabIndex = 1;
            this.frame7.TabStop = false;
            this.frame7.Click += new System.EventHandler(this.frame7_Click);
            // 
            // frame6
            // 
            this.frame6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.frame6.Image = global::Puzzle.Properties.Resources.image_part_0061;
            this.frame6.Location = new System.Drawing.Point(284, 148);
            this.frame6.Name = "frame6";
            this.frame6.Size = new System.Drawing.Size(130, 130);
            this.frame6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.frame6.TabIndex = 1;
            this.frame6.TabStop = false;
            this.frame6.Click += new System.EventHandler(this.frame6_Click);
            // 
            // frame5
            // 
            this.frame5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.frame5.Image = global::Puzzle.Properties.Resources.image_part_0051;
            this.frame5.Location = new System.Drawing.Point(148, 148);
            this.frame5.Name = "frame5";
            this.frame5.Size = new System.Drawing.Size(130, 130);
            this.frame5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.frame5.TabIndex = 1;
            this.frame5.TabStop = false;
            this.frame5.Click += new System.EventHandler(this.frame5_Click);
            // 
            // frame4
            // 
            this.frame4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.frame4.Image = global::Puzzle.Properties.Resources.image_part_0041;
            this.frame4.Location = new System.Drawing.Point(12, 148);
            this.frame4.Name = "frame4";
            this.frame4.Size = new System.Drawing.Size(130, 130);
            this.frame4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.frame4.TabIndex = 1;
            this.frame4.TabStop = false;
            this.frame4.Click += new System.EventHandler(this.frame4_Click);
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = global::Puzzle.Properties.Resources.sf;
            this.pictureBox10.Location = new System.Drawing.Point(472, 12);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(300, 300);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox10.TabIndex = 1;
            this.pictureBox10.TabStop = false;
            // 
            // frame3
            // 
            this.frame3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.frame3.Image = global::Puzzle.Properties.Resources.image_part_0031;
            this.frame3.Location = new System.Drawing.Point(284, 12);
            this.frame3.Name = "frame3";
            this.frame3.Size = new System.Drawing.Size(130, 130);
            this.frame3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.frame3.TabIndex = 1;
            this.frame3.TabStop = false;
            this.frame3.Click += new System.EventHandler(this.frame3_Click);
            // 
            // frame2
            // 
            this.frame2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.frame2.Image = global::Puzzle.Properties.Resources.image_part_0021;
            this.frame2.Location = new System.Drawing.Point(148, 12);
            this.frame2.Name = "frame2";
            this.frame2.Size = new System.Drawing.Size(130, 130);
            this.frame2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.frame2.TabIndex = 1;
            this.frame2.TabStop = false;
            this.frame2.Click += new System.EventHandler(this.frame2_Click);
            // 
            // frame1
            // 
            this.frame1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.frame1.Image = global::Puzzle.Properties.Resources.image_part_0011;
            this.frame1.Location = new System.Drawing.Point(12, 12);
            this.frame1.Name = "frame1";
            this.frame1.Size = new System.Drawing.Size(130, 130);
            this.frame1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.frame1.TabIndex = 1;
            this.frame1.TabStop = false;
            this.frame1.Click += new System.EventHandler(this.frame1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(803, 496);
            this.Controls.Add(this.movesLbl);
            this.Controls.Add(this.PauseBtn);
            this.Controls.Add(this.QuitBtn);
            this.Controls.Add(this.shuffleBtn);
            this.Controls.Add(this.timeLbl);
            this.Controls.Add(this.frame9);
            this.Controls.Add(this.frame8);
            this.Controls.Add(this.frame7);
            this.Controls.Add(this.frame6);
            this.Controls.Add(this.frame5);
            this.Controls.Add(this.frame4);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.frame3);
            this.Controls.Add(this.frame2);
            this.Controls.Add(this.frame1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            ((System.ComponentModel.ISupportInitialize)(this.frame9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frame8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frame7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frame6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frame5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frame4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frame3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frame2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frame1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox frame1;
        private System.Windows.Forms.PictureBox frame4;
        private System.Windows.Forms.PictureBox frame7;
        private System.Windows.Forms.PictureBox frame2;
        private System.Windows.Forms.PictureBox frame5;
        private System.Windows.Forms.PictureBox frame8;
        private System.Windows.Forms.PictureBox frame3;
        private System.Windows.Forms.PictureBox frame6;
        private System.Windows.Forms.PictureBox frame9;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.Label timeLbl;
        private System.Windows.Forms.Button shuffleBtn;
        private System.Windows.Forms.Button QuitBtn;
        private System.Windows.Forms.Button PauseBtn;
        private System.Windows.Forms.Label movesLbl;
        private System.Windows.Forms.Timer gameTimer;
    }
}

