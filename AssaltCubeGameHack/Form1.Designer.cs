namespace AssaltCubeGameHack
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.TitleLBL = new System.Windows.Forms.Label();
            this.HealthBT = new System.Windows.Forms.Button();
            this.AmmoBT = new System.Windows.Forms.Button();
            this.ExitBT = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.PlayerDataBox = new System.Windows.Forms.GroupBox();
            this.AngleLBL = new System.Windows.Forms.Label();
            this.PositionLBL = new System.Windows.Forms.Label();
            this.BulletProofLBL = new System.Windows.Forms.Label();
            this.AmmoLBL = new System.Windows.Forms.Label();
            this.HealthLBL = new System.Windows.Forms.Label();
            this.SelectProcessLBL = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.HealthHLBL = new System.Windows.Forms.Label();
            this.ammoHLBL = new System.Windows.Forms.Label();
            this.WallHackCHB = new System.Windows.Forms.CheckBox();
            this.PlayerDataBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // TitleLBL
            // 
            this.TitleLBL.AutoSize = true;
            this.TitleLBL.Font = new System.Drawing.Font("맑은 고딕", 36F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.TitleLBL.Location = new System.Drawing.Point(88, 9);
            this.TitleLBL.Name = "TitleLBL";
            this.TitleLBL.Size = new System.Drawing.Size(569, 65);
            this.TitleLBL.TabIndex = 0;
            this.TitleLBL.Text = "AssaultCube GameHack";
            // 
            // HealthBT
            // 
            this.HealthBT.Location = new System.Drawing.Point(67, 164);
            this.HealthBT.Name = "HealthBT";
            this.HealthBT.Size = new System.Drawing.Size(139, 23);
            this.HealthBT.TabIndex = 1;
            this.HealthBT.Text = "Health Hack";
            this.HealthBT.UseVisualStyleBackColor = true;
            this.HealthBT.Click += new System.EventHandler(this.HealthBT_Click);
            // 
            // AmmoBT
            // 
            this.AmmoBT.Location = new System.Drawing.Point(67, 193);
            this.AmmoBT.Name = "AmmoBT";
            this.AmmoBT.Size = new System.Drawing.Size(138, 23);
            this.AmmoBT.TabIndex = 1;
            this.AmmoBT.Text = "Ammo Hack";
            this.AmmoBT.UseVisualStyleBackColor = true;
            this.AmmoBT.Click += new System.EventHandler(this.AmmoBT_Click);
            // 
            // ExitBT
            // 
            this.ExitBT.Location = new System.Drawing.Point(849, 243);
            this.ExitBT.Name = "ExitBT";
            this.ExitBT.Size = new System.Drawing.Size(75, 23);
            this.ExitBT.TabIndex = 1;
            this.ExitBT.Text = "닫기";
            this.ExitBT.UseVisualStyleBackColor = true;
            this.ExitBT.Click += new System.EventHandler(this.ExitBT_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(67, 118);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(252, 20);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.Click += new System.EventHandler(this.comboBox1_Click);
            // 
            // PlayerDataBox
            // 
            this.PlayerDataBox.Controls.Add(this.AngleLBL);
            this.PlayerDataBox.Controls.Add(this.PositionLBL);
            this.PlayerDataBox.Controls.Add(this.BulletProofLBL);
            this.PlayerDataBox.Controls.Add(this.AmmoLBL);
            this.PlayerDataBox.Controls.Add(this.HealthLBL);
            this.PlayerDataBox.Location = new System.Drawing.Point(384, 98);
            this.PlayerDataBox.Name = "PlayerDataBox";
            this.PlayerDataBox.Size = new System.Drawing.Size(540, 128);
            this.PlayerDataBox.TabIndex = 3;
            this.PlayerDataBox.TabStop = false;
            this.PlayerDataBox.Text = "Player Data";
            this.PlayerDataBox.Enter += new System.EventHandler(this.PlayerDataBox_Enter);
            // 
            // AngleLBL
            // 
            this.AngleLBL.AutoSize = true;
            this.AngleLBL.Location = new System.Drawing.Point(139, 20);
            this.AngleLBL.Name = "AngleLBL";
            this.AngleLBL.Size = new System.Drawing.Size(41, 12);
            this.AngleLBL.TabIndex = 0;
            this.AngleLBL.Text = "Angle:";
            // 
            // PositionLBL
            // 
            this.PositionLBL.AutoSize = true;
            this.PositionLBL.Location = new System.Drawing.Point(139, 53);
            this.PositionLBL.Name = "PositionLBL";
            this.PositionLBL.Size = new System.Drawing.Size(35, 12);
            this.PositionLBL.TabIndex = 0;
            this.PositionLBL.Text = "Pos: ";
            // 
            // BulletProofLBL
            // 
            this.BulletProofLBL.AutoSize = true;
            this.BulletProofLBL.Location = new System.Drawing.Point(18, 95);
            this.BulletProofLBL.Name = "BulletProofLBL";
            this.BulletProofLBL.Size = new System.Drawing.Size(69, 12);
            this.BulletProofLBL.TabIndex = 0;
            this.BulletProofLBL.Text = "BulletProof:";
            // 
            // AmmoLBL
            // 
            this.AmmoLBL.AutoSize = true;
            this.AmmoLBL.Location = new System.Drawing.Point(18, 53);
            this.AmmoLBL.Name = "AmmoLBL";
            this.AmmoLBL.Size = new System.Drawing.Size(50, 12);
            this.AmmoLBL.TabIndex = 0;
            this.AmmoLBL.Text = "Ammo: ";
            // 
            // HealthLBL
            // 
            this.HealthLBL.AutoSize = true;
            this.HealthLBL.Location = new System.Drawing.Point(18, 20);
            this.HealthLBL.Name = "HealthLBL";
            this.HealthLBL.Size = new System.Drawing.Size(48, 12);
            this.HealthLBL.TabIndex = 0;
            this.HealthLBL.Text = "Health: ";
            // 
            // SelectProcessLBL
            // 
            this.SelectProcessLBL.AutoSize = true;
            this.SelectProcessLBL.Location = new System.Drawing.Point(65, 98);
            this.SelectProcessLBL.Name = "SelectProcessLBL";
            this.SelectProcessLBL.Size = new System.Drawing.Size(145, 12);
            this.SelectProcessLBL.TabIndex = 4;
            this.SelectProcessLBL.Text = "프로세스를 선택해주세요.";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // HealthHLBL
            // 
            this.HealthHLBL.AutoSize = true;
            this.HealthHLBL.Location = new System.Drawing.Point(230, 169);
            this.HealthHLBL.Name = "HealthHLBL";
            this.HealthHLBL.Size = new System.Drawing.Size(57, 12);
            this.HealthHLBL.TabIndex = 5;
            this.HealthHLBL.Text = "동작 안함";
            // 
            // ammoHLBL
            // 
            this.ammoHLBL.AutoSize = true;
            this.ammoHLBL.Location = new System.Drawing.Point(230, 198);
            this.ammoHLBL.Name = "ammoHLBL";
            this.ammoHLBL.Size = new System.Drawing.Size(57, 12);
            this.ammoHLBL.TabIndex = 5;
            this.ammoHLBL.Text = "동작 안함";
            // 
            // WallHackCHB
            // 
            this.WallHackCHB.AutoSize = true;
            this.WallHackCHB.Location = new System.Drawing.Point(67, 231);
            this.WallHackCHB.Name = "WallHackCHB";
            this.WallHackCHB.Size = new System.Drawing.Size(79, 16);
            this.WallHackCHB.TabIndex = 7;
            this.WallHackCHB.Text = "Wall Hack";
            this.WallHackCHB.UseVisualStyleBackColor = true;
            this.WallHackCHB.CheckedChanged += new System.EventHandler(this.WallHackCHB_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 301);
            this.Controls.Add(this.WallHackCHB);
            this.Controls.Add(this.ammoHLBL);
            this.Controls.Add(this.HealthHLBL);
            this.Controls.Add(this.SelectProcessLBL);
            this.Controls.Add(this.PlayerDataBox);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.ExitBT);
            this.Controls.Add(this.AmmoBT);
            this.Controls.Add(this.HealthBT);
            this.Controls.Add(this.TitleLBL);
            this.Name = "Form1";
            this.Text = "AssaultCube GameHack";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.PlayerDataBox.ResumeLayout(false);
            this.PlayerDataBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLBL;
        private System.Windows.Forms.Button HealthBT;
        private System.Windows.Forms.Button AmmoBT;
        private System.Windows.Forms.Button ExitBT;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox PlayerDataBox;
        private System.Windows.Forms.Label AngleLBL;
        private System.Windows.Forms.Label PositionLBL;
        private System.Windows.Forms.Label BulletProofLBL;
        private System.Windows.Forms.Label AmmoLBL;
        private System.Windows.Forms.Label HealthLBL;
        private System.Windows.Forms.Label SelectProcessLBL;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label HealthHLBL;
        private System.Windows.Forms.Label ammoHLBL;
        private System.Windows.Forms.CheckBox WallHackCHB;
    }
}

