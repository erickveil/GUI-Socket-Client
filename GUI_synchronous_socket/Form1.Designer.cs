namespace GUI_synchronous_socket
{
    partial class Form1
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
            this.bu_send = new System.Windows.Forms.Button();
            this.tb_ip = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_port = new System.Windows.Forms.TextBox();
            this.tb_msg = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bu_send
            // 
            this.bu_send.Location = new System.Drawing.Point(73, 83);
            this.bu_send.Name = "bu_send";
            this.bu_send.Size = new System.Drawing.Size(75, 23);
            this.bu_send.TabIndex = 0;
            this.bu_send.Text = "SEND";
            this.bu_send.UseVisualStyleBackColor = true;
            this.bu_send.Click += new System.EventHandler(this.bu_send_Click);
            // 
            // tb_ip
            // 
            this.tb_ip.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::GUI_synchronous_socket.Properties.Settings.Default, "ip", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tb_ip.Location = new System.Drawing.Point(73, 6);
            this.tb_ip.Name = "tb_ip";
            this.tb_ip.Size = new System.Drawing.Size(166, 20);
            this.tb_ip.TabIndex = 1;
            this.tb_ip.Text = global::GUI_synchronous_socket.Properties.Settings.Default.ip;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "IP Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Port";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Message";
            // 
            // tb_port
            // 
            this.tb_port.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::GUI_synchronous_socket.Properties.Settings.Default, "port", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tb_port.Location = new System.Drawing.Point(73, 31);
            this.tb_port.Name = "tb_port";
            this.tb_port.Size = new System.Drawing.Size(166, 20);
            this.tb_port.TabIndex = 5;
            this.tb_port.Text = global::GUI_synchronous_socket.Properties.Settings.Default.port;
            // 
            // tb_msg
            // 
            this.tb_msg.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::GUI_synchronous_socket.Properties.Settings.Default, "msg", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tb_msg.Location = new System.Drawing.Point(73, 57);
            this.tb_msg.Name = "tb_msg";
            this.tb_msg.Size = new System.Drawing.Size(166, 20);
            this.tb_msg.TabIndex = 6;
            this.tb_msg.Text = global::GUI_synchronous_socket.Properties.Settings.Default.msg;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 116);
            this.Controls.Add(this.tb_msg);
            this.Controls.Add(this.tb_port);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_ip);
            this.Controls.Add(this.bu_send);
            this.Name = "Form1";
            this.Text = "Socket Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bu_send;
        private System.Windows.Forms.TextBox tb_ip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_port;
        private System.Windows.Forms.TextBox tb_msg;
    }
}

