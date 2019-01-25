namespace WindowsFormsApp
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
            this.label_Cpu = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label_User = new System.Windows.Forms.Label();
            this.label_Cpu_Name = new System.Windows.Forms.Label();
            this.label_User_Name = new System.Windows.Forms.Label();
            this.label_Cpu_Help = new System.Windows.Forms.TextBox();
            this.label_User_Help = new System.Windows.Forms.TextBox();
            this.label_Id = new System.Windows.Forms.Label();
            this.label_Id_Name = new System.Windows.Forms.Label();
            this.label_Id_Help = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label_Cpu
            // 
            this.label_Cpu.AutoSize = true;
            this.label_Cpu.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_Cpu.Location = new System.Drawing.Point(64, 9);
            this.label_Cpu.Name = "label_Cpu";
            this.label_Cpu.Size = new System.Drawing.Size(91, 17);
            this.label_Cpu.TabIndex = 0;
            this.label_Cpu.Text = "CPU 사용률 : ";
            // 
            // label_User
            // 
            this.label_User.AutoSize = true;
            this.label_User.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_User.Location = new System.Drawing.Point(64, 177);
            this.label_User.Name = "label_User";
            this.label_User.Size = new System.Drawing.Size(91, 17);
            this.label_User.TabIndex = 1;
            this.label_User.Text = "CPU 사용률 : ";
            // 
            // label_Cpu_Name
            // 
            this.label_Cpu_Name.AutoSize = true;
            this.label_Cpu_Name.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_Cpu_Name.Location = new System.Drawing.Point(64, 26);
            this.label_Cpu_Name.Name = "label_Cpu_Name";
            this.label_Cpu_Name.Size = new System.Drawing.Size(91, 17);
            this.label_Cpu_Name.TabIndex = 2;
            this.label_Cpu_Name.Text = "카운터 이름 : ";
            // 
            // label_User_Name
            // 
            this.label_User_Name.AutoSize = true;
            this.label_User_Name.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_User_Name.Location = new System.Drawing.Point(64, 194);
            this.label_User_Name.Name = "label_User_Name";
            this.label_User_Name.Size = new System.Drawing.Size(91, 17);
            this.label_User_Name.TabIndex = 3;
            this.label_User_Name.Text = "카운트 이름 : ";
            // 
            // label_Cpu_Help
            // 
            this.label_Cpu_Help.Location = new System.Drawing.Point(65, 214);
            this.label_Cpu_Help.Multiline = true;
            this.label_Cpu_Help.Name = "label_Cpu_Help";
            this.label_Cpu_Help.Size = new System.Drawing.Size(342, 115);
            this.label_Cpu_Help.TabIndex = 4;
            // 
            // label_User_Help
            // 
            this.label_User_Help.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_User_Help.Location = new System.Drawing.Point(65, 46);
            this.label_User_Help.Multiline = true;
            this.label_User_Help.Name = "label_User_Help";
            this.label_User_Help.Size = new System.Drawing.Size(342, 115);
            this.label_User_Help.TabIndex = 5;
            // 
            // label_Id
            // 
            this.label_Id.AutoSize = true;
            this.label_Id.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_Id.Location = new System.Drawing.Point(64, 357);
            this.label_Id.Name = "label_Id";
            this.label_Id.Size = new System.Drawing.Size(91, 17);
            this.label_Id.TabIndex = 6;
            this.label_Id.Text = "CPU 사용률 : ";
            // 
            // label_Id_Name
            // 
            this.label_Id_Name.AutoSize = true;
            this.label_Id_Name.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_Id_Name.Location = new System.Drawing.Point(64, 374);
            this.label_Id_Name.Name = "label_Id_Name";
            this.label_Id_Name.Size = new System.Drawing.Size(91, 17);
            this.label_Id_Name.TabIndex = 7;
            this.label_Id_Name.Text = "카운트 이름 : ";
            // 
            // label_Id_Help
            // 
            this.label_Id_Help.Location = new System.Drawing.Point(65, 394);
            this.label_Id_Help.Multiline = true;
            this.label_Id_Help.Name = "label_Id_Help";
            this.label_Id_Help.Size = new System.Drawing.Size(342, 115);
            this.label_Id_Help.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 734);
            this.Controls.Add(this.label_Id_Help);
            this.Controls.Add(this.label_Id_Name);
            this.Controls.Add(this.label_Id);
            this.Controls.Add(this.label_User_Help);
            this.Controls.Add(this.label_Cpu_Help);
            this.Controls.Add(this.label_User_Name);
            this.Controls.Add(this.label_Cpu_Name);
            this.Controls.Add(this.label_User);
            this.Controls.Add(this.label_Cpu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Cpu;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label_User;
        private System.Windows.Forms.Label label_Cpu_Name;
        private System.Windows.Forms.Label label_User_Name;
        private System.Windows.Forms.TextBox label_Cpu_Help;
        private System.Windows.Forms.TextBox label_User_Help;
        private System.Windows.Forms.Label label_Id;
        private System.Windows.Forms.Label label_Id_Name;
        private System.Windows.Forms.TextBox label_Id_Help;
    }
}

