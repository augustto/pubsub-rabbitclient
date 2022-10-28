
namespace WinFormsEntryApp.UseCaseDemos.Basic
{
    partial class RabbitMQBasicsDemo
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
            this.virtualHostComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.createVirtualHostButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.exchangeInspectorControl = new WinFormsEntryApp.UseCaseDemos.Basic.ObjectInspectorControl();
            this.queueInspectorControl = new WinFormsEntryApp.UseCaseDemos.Basic.ObjectInspectorControl();
            this.publishButton = new System.Windows.Forms.Button();
            this.consumeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // virtualHostComboBox
            // 
            this.virtualHostComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.virtualHostComboBox.FormattingEnabled = true;
            this.virtualHostComboBox.Location = new System.Drawing.Point(92, 6);
            this.virtualHostComboBox.Name = "virtualHostComboBox";
            this.virtualHostComboBox.Size = new System.Drawing.Size(196, 23);
            this.virtualHostComboBox.TabIndex = 0;
            this.virtualHostComboBox.SelectedIndexChanged += new System.EventHandler(this.virtualHostComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Virtual Hosts";
            // 
            // createVirtualHostButton
            // 
            this.createVirtualHostButton.Location = new System.Drawing.Point(294, 5);
            this.createVirtualHostButton.Name = "createVirtualHostButton";
            this.createVirtualHostButton.Size = new System.Drawing.Size(75, 24);
            this.createVirtualHostButton.TabIndex = 2;
            this.createVirtualHostButton.Text = "Criar Virtual Host";
            this.createVirtualHostButton.UseVisualStyleBackColor = true;
            this.createVirtualHostButton.Click += new System.EventHandler(this.createVirtualHostButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(375, 5);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(75, 24);
            this.refreshButton.TabIndex = 3;
            this.refreshButton.Text = "Atualizar";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.RabbitMQBasicsDemo_Load);
            // 
            // exchangeInspectorControl
            // 
            this.exchangeInspectorControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.exchangeInspectorControl.GetListFunc = null;
            this.exchangeInspectorControl.ListDisplayMember = "Name";
            this.exchangeInspectorControl.Location = new System.Drawing.Point(5, 80);
            this.exchangeInspectorControl.Name = "exchangeInspectorControl";
            this.exchangeInspectorControl.Size = new System.Drawing.Size(400, 585);
            this.exchangeInspectorControl.TabIndex = 4;
            this.exchangeInspectorControl.Title = "Exchanges";
            // 
            // queueInspectorControl
            // 
            this.queueInspectorControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.queueInspectorControl.GetListFunc = null;
            this.queueInspectorControl.ListDisplayMember = "Name";
            this.queueInspectorControl.Location = new System.Drawing.Point(420, 80);
            this.queueInspectorControl.Name = "queueInspectorControl";
            this.queueInspectorControl.Size = new System.Drawing.Size(400, 585);
            this.queueInspectorControl.TabIndex = 5;
            this.queueInspectorControl.Title = "Queues";
            // 
            // publishButton
            // 
            this.publishButton.Location = new System.Drawing.Point(5, 41);
            this.publishButton.Name = "publishButton";
            this.publishButton.Size = new System.Drawing.Size(400, 23);
            this.publishButton.TabIndex = 6;
            this.publishButton.Text = "Publicar";
            this.publishButton.UseVisualStyleBackColor = true;
            this.publishButton.Click += new System.EventHandler(this.publishButton_Click);
            // 
            // consumeButton
            // 
            this.consumeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.consumeButton.Location = new System.Drawing.Point(420, 41);
            this.consumeButton.Name = "consumeButton";
            this.consumeButton.Size = new System.Drawing.Size(400, 23);
            this.consumeButton.TabIndex = 7;
            this.consumeButton.Text = "Consumir";
            this.consumeButton.UseVisualStyleBackColor = true;
            this.consumeButton.Click += new System.EventHandler(this.consumeButton_Click);
            // 
            // RabbitMQBasicsDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 677);
            this.Controls.Add(this.consumeButton);
            this.Controls.Add(this.publishButton);
            this.Controls.Add(this.queueInspectorControl);
            this.Controls.Add(this.exchangeInspectorControl);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.createVirtualHostButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.virtualHostComboBox);
            this.MinimumSize = new System.Drawing.Size(848, 39);
            this.Name = "RabbitMQBasicsDemo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Fundamentals";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RabbitMQBasicsDemo_FormClosed);
            this.Load += new System.EventHandler(this.RabbitMQBasicsDemo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox virtualHostComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button createVirtualHostButton;
        private System.Windows.Forms.Button refreshButton;
        private ObjectInspectorControl exchangeInspectorControl;
        private ObjectInspectorControl queueInspectorControl;
        private System.Windows.Forms.Button publishButton;
        private System.Windows.Forms.Button consumeButton;
    }
}