
namespace WinFormsEntryApp.UseCaseDemos.GenericForms
{
    partial class ConsumerFeedback
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
            this.messageBodyTextBox = new System.Windows.Forms.TextBox();
            this.ackButton = new System.Windows.Forms.Button();
            this.requeueCheckBox = new System.Windows.Forms.CheckBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.propertyGridHeaders = new System.Windows.Forms.PropertyGrid();
            this.nackButton = new System.Windows.Forms.Button();
            this.rejectButton = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // messageBodyTextBox
            // 
            this.messageBodyTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.messageBodyTextBox.Location = new System.Drawing.Point(3, 3);
            this.messageBodyTextBox.Multiline = true;
            this.messageBodyTextBox.Name = "messageBodyTextBox";
            this.messageBodyTextBox.Size = new System.Drawing.Size(1124, 474);
            this.messageBodyTextBox.TabIndex = 0;
            // 
            // ackButton
            // 
            this.ackButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ackButton.Location = new System.Drawing.Point(12, 526);
            this.ackButton.Name = "ackButton";
            this.ackButton.Size = new System.Drawing.Size(75, 23);
            this.ackButton.TabIndex = 1;
            this.ackButton.Text = "Ack";
            this.ackButton.UseVisualStyleBackColor = true;
            this.ackButton.Click += new System.EventHandler(this.ackButton_Click);
            // 
            // requeueCheckBox
            // 
            this.requeueCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.requeueCheckBox.AutoSize = true;
            this.requeueCheckBox.Checked = true;
            this.requeueCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.requeueCheckBox.Location = new System.Drawing.Point(100, 530);
            this.requeueCheckBox.Name = "requeueCheckBox";
            this.requeueCheckBox.Size = new System.Drawing.Size(72, 19);
            this.requeueCheckBox.TabIndex = 2;
            this.requeueCheckBox.Text = "Requeue";
            this.requeueCheckBox.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1138, 508);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.messageBodyTextBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1130, 480);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Message Body";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.propertyGridHeaders);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1130, 480);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Headers";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // propertyGridHeaders
            // 
            this.propertyGridHeaders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertyGridHeaders.Location = new System.Drawing.Point(3, 3);
            this.propertyGridHeaders.Name = "propertyGridHeaders";
            this.propertyGridHeaders.Size = new System.Drawing.Size(1124, 474);
            this.propertyGridHeaders.TabIndex = 0;
            // 
            // nackButton
            // 
            this.nackButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.nackButton.Location = new System.Drawing.Point(178, 530);
            this.nackButton.Name = "nackButton";
            this.nackButton.Size = new System.Drawing.Size(75, 23);
            this.nackButton.TabIndex = 4;
            this.nackButton.Text = "Nack";
            this.nackButton.UseVisualStyleBackColor = true;
            this.nackButton.Click += new System.EventHandler(this.nackButton_Click);
            // 
            // rejectButton
            // 
            this.rejectButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rejectButton.Location = new System.Drawing.Point(259, 530);
            this.rejectButton.Name = "rejectButton";
            this.rejectButton.Size = new System.Drawing.Size(75, 23);
            this.rejectButton.TabIndex = 5;
            this.rejectButton.Text = "Reject";
            this.rejectButton.UseVisualStyleBackColor = true;
            this.rejectButton.Click += new System.EventHandler(this.rejectButton_Click);
            // 
            // ConsumerFeedback
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 561);
            this.Controls.Add(this.rejectButton);
            this.Controls.Add(this.nackButton);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.requeueCheckBox);
            this.Controls.Add(this.ackButton);
            this.Name = "ConsumerFeedback";
            this.Text = "Reject";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ConsumerFeedback_FormClosing);
            this.Load += new System.EventHandler(this.ConsumerFeedback_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox messageBodyTextBox;
        private System.Windows.Forms.Button ackButton;
        private System.Windows.Forms.CheckBox requeueCheckBox;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.PropertyGrid propertyGridHeaders;
        private System.Windows.Forms.Button nackButton;
        private System.Windows.Forms.Button rejectButton;
    }
}