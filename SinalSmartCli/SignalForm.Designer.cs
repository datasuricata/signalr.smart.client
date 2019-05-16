namespace SinalSmartCli {
    partial class SignalForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignalForm));
            this.JoinMethods = new System.Windows.Forms.Button();
            this.JoinGroup = new System.Windows.Forms.Button();
            this.txtMethods = new System.Windows.Forms.TextBox();
            this.txtGroup = new System.Windows.Forms.TextBox();
            this.txtHost = new System.Windows.Forms.TextBox();
            this.MessageConsole = new System.Windows.Forms.TextBox();
            this.Clipboard = new System.Windows.Forms.Button();
            this.OpenTool = new System.Windows.Forms.Button();
            this.Disconnect = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // JoinMethods
            // 
            this.JoinMethods.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.JoinMethods.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.JoinMethods.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange;
            this.JoinMethods.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.JoinMethods.ForeColor = System.Drawing.Color.SteelBlue;
            this.JoinMethods.Location = new System.Drawing.Point(12, 12);
            this.JoinMethods.Name = "JoinMethods";
            this.JoinMethods.Size = new System.Drawing.Size(142, 25);
            this.JoinMethods.TabIndex = 0;
            this.JoinMethods.Text = "< methods >";
            this.toolTip1.SetToolTip(this.JoinMethods, "Conectar no(s) metodo(s)");
            this.JoinMethods.UseVisualStyleBackColor = true;
            this.JoinMethods.Click += new System.EventHandler(this.JoinMethods_Click);
            // 
            // JoinGroup
            // 
            this.JoinGroup.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.JoinGroup.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.JoinGroup.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange;
            this.JoinGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.JoinGroup.ForeColor = System.Drawing.Color.SteelBlue;
            this.JoinGroup.Location = new System.Drawing.Point(155, 12);
            this.JoinGroup.Name = "JoinGroup";
            this.JoinGroup.Size = new System.Drawing.Size(142, 25);
            this.JoinGroup.TabIndex = 1;
            this.JoinGroup.Text = "< join group >";
            this.toolTip1.SetToolTip(this.JoinGroup, "Entrar no grupo");
            this.JoinGroup.UseVisualStyleBackColor = true;
            this.JoinGroup.Click += new System.EventHandler(this.JoinGroup_Click);
            // 
            // txtMethods
            // 
            this.txtMethods.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtMethods.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtMethods.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMethods.ForeColor = System.Drawing.Color.DarkOrange;
            this.txtMethods.Location = new System.Drawing.Point(12, 38);
            this.txtMethods.Multiline = true;
            this.txtMethods.Name = "txtMethods";
            this.txtMethods.Size = new System.Drawing.Size(142, 25);
            this.txtMethods.TabIndex = 1;
            this.txtMethods.Text = "read, wait_message";
            this.txtMethods.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtGroup
            // 
            this.txtGroup.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtGroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtGroup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGroup.ForeColor = System.Drawing.Color.DarkOrange;
            this.txtGroup.Location = new System.Drawing.Point(155, 38);
            this.txtGroup.Multiline = true;
            this.txtGroup.Name = "txtGroup";
            this.txtGroup.Size = new System.Drawing.Size(142, 25);
            this.txtGroup.TabIndex = 2;
            this.txtGroup.Text = "314";
            this.txtGroup.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtHost
            // 
            this.txtHost.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtHost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtHost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHost.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtHost.Location = new System.Drawing.Point(12, 64);
            this.txtHost.Multiline = true;
            this.txtHost.Name = "txtHost";
            this.txtHost.Size = new System.Drawing.Size(285, 25);
            this.txtHost.TabIndex = 3;
            this.txtHost.Text = "http://localhost:50888/Notify";
            this.txtHost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MessageConsole
            // 
            this.MessageConsole.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.MessageConsole.BackColor = System.Drawing.SystemColors.InfoText;
            this.MessageConsole.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MessageConsole.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MessageConsole.ForeColor = System.Drawing.Color.DarkOrange;
            this.MessageConsole.Location = new System.Drawing.Point(12, 90);
            this.MessageConsole.Multiline = true;
            this.MessageConsole.Name = "MessageConsole";
            this.MessageConsole.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.MessageConsole.Size = new System.Drawing.Size(285, 85);
            this.MessageConsole.TabIndex = 4;
            // 
            // Clipboard
            // 
            this.Clipboard.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Clipboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Clipboard.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.Clipboard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange;
            this.Clipboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Clipboard.ForeColor = System.Drawing.Color.Gold;
            this.Clipboard.Location = new System.Drawing.Point(56, 176);
            this.Clipboard.Name = "Clipboard";
            this.Clipboard.Size = new System.Drawing.Size(197, 28);
            this.Clipboard.TabIndex = 5;
            this.Clipboard.Text = "copy 📎";
            this.toolTip1.SetToolTip(this.Clipboard, "Copiar");
            this.Clipboard.UseVisualStyleBackColor = true;
            this.Clipboard.Click += new System.EventHandler(this.Clipboard_Click);
            // 
            // OpenTool
            // 
            this.OpenTool.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.OpenTool.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.OpenTool.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange;
            this.OpenTool.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenTool.ForeColor = System.Drawing.Color.SteelBlue;
            this.OpenTool.Location = new System.Drawing.Point(254, 176);
            this.OpenTool.Name = "OpenTool";
            this.OpenTool.Size = new System.Drawing.Size(43, 28);
            this.OpenTool.TabIndex = 6;
            this.OpenTool.Text = "⤵";
            this.toolTip1.SetToolTip(this.OpenTool, "Ajustar Janela");
            this.OpenTool.UseVisualStyleBackColor = true;
            this.OpenTool.Click += new System.EventHandler(this.OpenTool_Click);
            // 
            // Disconnect
            // 
            this.Disconnect.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Disconnect.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.Disconnect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange;
            this.Disconnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Disconnect.ForeColor = System.Drawing.Color.OrangeRed;
            this.Disconnect.Location = new System.Drawing.Point(12, 176);
            this.Disconnect.Name = "Disconnect";
            this.Disconnect.Size = new System.Drawing.Size(43, 28);
            this.Disconnect.TabIndex = 7;
            this.Disconnect.Text = "✕";
            this.toolTip1.SetToolTip(this.Disconnect, "Desconectar");
            this.Disconnect.UseVisualStyleBackColor = true;
            this.Disconnect.Click += new System.EventHandler(this.Disconnect_Click);
            // 
            // SignalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(309, 216);
            this.Controls.Add(this.Disconnect);
            this.Controls.Add(this.OpenTool);
            this.Controls.Add(this.Clipboard);
            this.Controls.Add(this.MessageConsole);
            this.Controls.Add(this.txtHost);
            this.Controls.Add(this.txtGroup);
            this.Controls.Add(this.txtMethods);
            this.Controls.Add(this.JoinGroup);
            this.Controls.Add(this.JoinMethods);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SignalForm";
            this.Text = "SignalR Smart Client - (Lucas Rocha de Moraes)";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtMethods;
        private System.Windows.Forms.Button JoinGroup;
        private System.Windows.Forms.Button JoinMethods;
        private System.Windows.Forms.TextBox txtGroup;
        private System.Windows.Forms.TextBox txtHost;
        private System.Windows.Forms.TextBox MessageConsole;
        private System.Windows.Forms.Button Clipboard;
        private System.Windows.Forms.Button OpenTool;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button Disconnect;
    }
}

