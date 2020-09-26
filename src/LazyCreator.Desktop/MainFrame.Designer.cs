namespace LazyCreator.Desktop
{
    partial class MainFrame
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Node = new System.Windows.Forms.RadioButton();
            this.Symfony = new System.Windows.Forms.RadioButton();
            this.API = new System.Windows.Forms.RadioButton();
            this.ASPMVC = new System.Windows.Forms.RadioButton();
            this.dotnetCLI = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.PathBox = new System.Windows.Forms.TextBox();
            this.Create = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.PathBox);
            this.splitContainer1.Panel2.Controls.Add(this.Create);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 266;
            this.splitContainer1.TabIndex = 0;
            this.splitContainer1.Text = "splitContainer1";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox1.Controls.Add(this.Node);
            this.groupBox1.Controls.Add(this.Symfony);
            this.groupBox1.Controls.Add(this.API);
            this.groupBox1.Controls.Add(this.ASPMVC);
            this.groupBox1.Controls.Add(this.dotnetCLI);
            this.groupBox1.Location = new System.Drawing.Point(8, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 436);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Available projects";
            // 
            // Node
            // 
            this.Node.AutoSize = true;
            this.Node.Enabled = false;
            this.Node.Location = new System.Drawing.Point(6, 170);
            this.Node.Name = "Node";
            this.Node.Size = new System.Drawing.Size(91, 24);
            this.Node.TabIndex = 0;
            this.Node.TabStop = true;
            this.Node.Text = "NodeExp";
            this.Node.UseVisualStyleBackColor = true;
            this.Node.CheckedChanged += new System.EventHandler(this.Node_CheckedChanged);
            // 
            // Symfony
            // 
            this.Symfony.AutoSize = true;
            this.Symfony.Location = new System.Drawing.Point(6, 140);
            this.Symfony.Name = "Symfony";
            this.Symfony.Size = new System.Drawing.Size(87, 24);
            this.Symfony.TabIndex = 0;
            this.Symfony.TabStop = true;
            this.Symfony.Text = "Symfony";
            this.Symfony.UseVisualStyleBackColor = true;
            this.Symfony.CheckedChanged += new System.EventHandler(this.Symfony_CheckedChanged);
            // 
            // API
            // 
            this.API.AutoSize = true;
            this.API.Location = new System.Drawing.Point(6, 110);
            this.API.Name = "API";
            this.API.Size = new System.Drawing.Size(112, 24);
            this.API.TabIndex = 0;
            this.API.TabStop = true;
            this.API.Text = "ASP.NET API";
            this.API.UseVisualStyleBackColor = true;
            this.API.CheckedChanged += new System.EventHandler(this.API_CheckedChanged);
            // 
            // ASPMVC
            // 
            this.ASPMVC.AutoSize = true;
            this.ASPMVC.Location = new System.Drawing.Point(6, 80);
            this.ASPMVC.Name = "ASPMVC";
            this.ASPMVC.Size = new System.Drawing.Size(156, 24);
            this.ASPMVC.TabIndex = 0;
            this.ASPMVC.TabStop = true;
            this.ASPMVC.Text = "ASP.NET Core MVC";
            this.ASPMVC.UseVisualStyleBackColor = true;
            this.ASPMVC.CheckedChanged += new System.EventHandler(this.ASPMVC_CheckedChanged);
            // 
            // dotnetCLI
            // 
            this.dotnetCLI.AutoSize = true;
            this.dotnetCLI.Location = new System.Drawing.Point(6, 50);
            this.dotnetCLI.Name = "dotnetCLI";
            this.dotnetCLI.Size = new System.Drawing.Size(146, 24);
            this.dotnetCLI.TabIndex = 0;
            this.dotnetCLI.TabStop = true;
            this.dotnetCLI.Text = ".Net Console App";
            this.dotnetCLI.UseVisualStyleBackColor = true;
            this.dotnetCLI.CheckedChanged += new System.EventHandler(this.dotnetCLI_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Path Field";
            // 
            // PathBox
            // 
            this.PathBox.Enabled = false;
            this.PathBox.Location = new System.Drawing.Point(35, 187);
            this.PathBox.Name = "PathBox";
            this.PathBox.Size = new System.Drawing.Size(447, 27);
            this.PathBox.TabIndex = 1;
            // 
            // Create
            // 
            this.Create.Location = new System.Drawing.Point(76, 409);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(94, 29);
            this.Create.TabIndex = 1;
            this.Create.Text = "Create";
            this.Create.UseVisualStyleBackColor = true;
            this.Create.Click += new System.EventHandler(this.Create_Click);
            // 
            // MainFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "MainFrame";
            this.Text = "MainFrame";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton dotnetCLI;
        private System.Windows.Forms.Button Create;
        private System.Windows.Forms.RadioButton Node;
        private System.Windows.Forms.RadioButton Symfony;
        private System.Windows.Forms.RadioButton API;
        private System.Windows.Forms.RadioButton ASPMVC;
        private System.Windows.Forms.TextBox PathBox;
        private System.Windows.Forms.Label label1;
    }
}