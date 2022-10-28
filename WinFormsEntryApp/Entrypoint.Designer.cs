
namespace WinFormsEntryApp
{
    partial class Entrypoint
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.log = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Reset = new System.Windows.Forms.Button();
            this.openLogButtom = new System.Windows.Forms.Button();
            this.useCasesDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.useCasesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // log
            // 
            this.log.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.log.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.log.Location = new System.Drawing.Point(12, 381);
            this.log.Multiline = true;
            this.log.Name = "log";
            this.log.ReadOnly = true;
            this.log.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.log.Size = new System.Drawing.Size(1217, 364);
            this.log.TabIndex = 1;
            this.log.WordWrap = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 363);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Log";
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(12, 12);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(111, 23);
            this.Reset.TabIndex = 3;
            this.Reset.Text = "Reset / Prepare";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_ClickAsync);
            // 
            // openLogButtom
            // 
            this.openLogButtom.Location = new System.Drawing.Point(45, 361);
            this.openLogButtom.Name = "openLogButtom";
            this.openLogButtom.Size = new System.Drawing.Size(29, 19);
            this.openLogButtom.TabIndex = 4;
            this.openLogButtom.Text = "...";
            this.openLogButtom.UseVisualStyleBackColor = true;
            this.openLogButtom.Click += new System.EventHandler(this.OpenLogButtom_Click);
            // 
            // useCasesDataGridView
            // 
            this.useCasesDataGridView.AllowUserToAddRows = false;
            this.useCasesDataGridView.AllowUserToDeleteRows = false;
            this.useCasesDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.useCasesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.useCasesDataGridView.Location = new System.Drawing.Point(12, 41);
            this.useCasesDataGridView.Name = "useCasesDataGridView";
            this.useCasesDataGridView.ReadOnly = true;
            this.useCasesDataGridView.RowTemplate.Height = 25;
            this.useCasesDataGridView.Size = new System.Drawing.Size(1217, 314);
            this.useCasesDataGridView.TabIndex = 8;
            this.useCasesDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UseCasesDataGridView_CellDoubleClick);
            // 
            // Entrypoint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1241, 757);
            this.Controls.Add(this.useCasesDataGridView);
            this.Controls.Add(this.openLogButtom);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.log);
            this.MinimumSize = new System.Drawing.Size(610, 450);
            this.Name = "Entrypoint";
            this.Text = "Entrypoint";
            this.Load += new System.EventHandler(this.Entrypoint_Load);
            ((System.ComponentModel.ISupportInitialize)(this.useCasesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox log;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Button openLogButtom;
        private System.Windows.Forms.DataGridView useCasesDataGridView;
    }
}

