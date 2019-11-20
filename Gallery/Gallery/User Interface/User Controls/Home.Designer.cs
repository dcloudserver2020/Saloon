namespace Gallery.User_Interface.User_Controls
{
    partial class Home
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.P_Home = new System.Windows.Forms.Panel();
            this.L_Admin = new System.Windows.Forms.Label();
            this.L_Output = new System.Windows.Forms.Label();
            this.L_Audit = new System.Windows.Forms.Label();
            this.L_Process = new System.Windows.Forms.Label();
            this.L_Analysis = new System.Windows.Forms.Label();
            this.L_Input = new System.Windows.Forms.Label();
            this.P_Home.SuspendLayout();
            this.SuspendLayout();
            // 
            // P_Home
            // 
            this.P_Home.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.P_Home.BackgroundImage = global::Gallery.Properties.Resources.Home_UI_Update;
            this.P_Home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.P_Home.Controls.Add(this.L_Admin);
            this.P_Home.Controls.Add(this.L_Output);
            this.P_Home.Controls.Add(this.L_Audit);
            this.P_Home.Controls.Add(this.L_Process);
            this.P_Home.Controls.Add(this.L_Analysis);
            this.P_Home.Controls.Add(this.L_Input);
            this.P_Home.Location = new System.Drawing.Point(120, 0);
            this.P_Home.Name = "P_Home";
            this.P_Home.Size = new System.Drawing.Size(1272, 650);
            this.P_Home.TabIndex = 0;
            // 
            // L_Admin
            // 
            this.L_Admin.BackColor = System.Drawing.Color.Transparent;
            this.L_Admin.Location = new System.Drawing.Point(532, 77);
            this.L_Admin.Name = "L_Admin";
            this.L_Admin.Size = new System.Drawing.Size(202, 137);
            this.L_Admin.TabIndex = 5;
            // 
            // L_Output
            // 
            this.L_Output.BackColor = System.Drawing.Color.Transparent;
            this.L_Output.Location = new System.Drawing.Point(855, 58);
            this.L_Output.Name = "L_Output";
            this.L_Output.Size = new System.Drawing.Size(174, 175);
            this.L_Output.TabIndex = 4;
            // 
            // L_Audit
            // 
            this.L_Audit.BackColor = System.Drawing.Color.Transparent;
            this.L_Audit.Location = new System.Drawing.Point(755, 262);
            this.L_Audit.Name = "L_Audit";
            this.L_Audit.Size = new System.Drawing.Size(174, 175);
            this.L_Audit.TabIndex = 3;
            // 
            // L_Process
            // 
            this.L_Process.BackColor = System.Drawing.Color.Transparent;
            this.L_Process.Location = new System.Drawing.Point(548, 338);
            this.L_Process.Name = "L_Process";
            this.L_Process.Size = new System.Drawing.Size(174, 175);
            this.L_Process.TabIndex = 2;
            // 
            // L_Analysis
            // 
            this.L_Analysis.BackColor = System.Drawing.Color.Transparent;
            this.L_Analysis.Location = new System.Drawing.Point(332, 256);
            this.L_Analysis.Name = "L_Analysis";
            this.L_Analysis.Size = new System.Drawing.Size(174, 175);
            this.L_Analysis.TabIndex = 1;
            // 
            // L_Input
            // 
            this.L_Input.BackColor = System.Drawing.Color.Transparent;
            this.L_Input.Location = new System.Drawing.Point(246, 49);
            this.L_Input.Name = "L_Input";
            this.L_Input.Size = new System.Drawing.Size(174, 175);
            this.L_Input.TabIndex = 0;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.P_Home);
            this.DoubleBuffered = true;
            this.Name = "Home";
            this.Size = new System.Drawing.Size(1550, 650);
            this.P_Home.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel P_Home;
        private System.Windows.Forms.Label L_Admin;
        private System.Windows.Forms.Label L_Output;
        private System.Windows.Forms.Label L_Audit;
        private System.Windows.Forms.Label L_Process;
        private System.Windows.Forms.Label L_Analysis;
        private System.Windows.Forms.Label L_Input;
    }
}
