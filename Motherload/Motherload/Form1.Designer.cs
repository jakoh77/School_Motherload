namespace Motherload
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
            this.load_refuel = new System.Windows.Forms.Button();
            this.load_bank = new System.Windows.Forms.Button();
            this.load_store = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // load_refuel
            // 
            this.load_refuel.Location = new System.Drawing.Point(262, 234);
            this.load_refuel.Name = "load_refuel";
            this.load_refuel.Size = new System.Drawing.Size(101, 44);
            this.load_refuel.TabIndex = 0;
            this.load_refuel.Text = "Load Refuel";
            this.load_refuel.UseVisualStyleBackColor = true;
            this.load_refuel.Click += new System.EventHandler(this.load_refuel_Click);
            // 
            // load_bank
            // 
            this.load_bank.Location = new System.Drawing.Point(78, 234);
            this.load_bank.Name = "load_bank";
            this.load_bank.Size = new System.Drawing.Size(101, 44);
            this.load_bank.TabIndex = 1;
            this.load_bank.Text = "Load Bank";
            this.load_bank.UseVisualStyleBackColor = true;
            this.load_bank.Click += new System.EventHandler(this.load_bank_Click);
            // 
            // load_store
            // 
            this.load_store.Location = new System.Drawing.Point(168, 307);
            this.load_store.Name = "load_store";
            this.load_store.Size = new System.Drawing.Size(101, 44);
            this.load_store.TabIndex = 2;
            this.load_store.Text = "Load Store";
            this.load_store.UseVisualStyleBackColor = true;
            this.load_store.Click += new System.EventHandler(this.load_store_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 373);
            this.Controls.Add(this.load_store);
            this.Controls.Add(this.load_bank);
            this.Controls.Add(this.load_refuel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button load_refuel;
        private System.Windows.Forms.Button load_bank;
        private System.Windows.Forms.Button load_store;
    }
}

