namespace Binary
{
    partial class calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(calculator));
            this.background_overlay = new System.Windows.Forms.PictureBox();
            this.control_panel = new System.Windows.Forms.PictureBox();
            this.generate_code = new System.Windows.Forms.Button();
            this.binary_label = new System.Windows.Forms.Label();
            this.hex_label = new System.Windows.Forms.Label();
            this.decimal_code = new System.Windows.Forms.Label();
            this.binary_code = new System.Windows.Forms.Label();
            this.hex_code = new System.Windows.Forms.Label();
            this.binary_answer = new System.Windows.Forms.TextBox();
            this.hex_answer = new System.Windows.Forms.TextBox();
            this.verify_code = new System.Windows.Forms.Button();
            this.status = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.background_overlay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.control_panel)).BeginInit();
            this.SuspendLayout();
            // 
            // background_overlay
            // 
            this.background_overlay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.background_overlay.BackColor = System.Drawing.SystemColors.Control;
            this.background_overlay.BackgroundImage = global::Binary.Properties.Resources.background;
            this.background_overlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.background_overlay.Location = new System.Drawing.Point(0, 0);
            this.background_overlay.Name = "background_overlay";
            this.background_overlay.Size = new System.Drawing.Size(975, 695);
            this.background_overlay.TabIndex = 0;
            this.background_overlay.TabStop = false;
            this.background_overlay.Click += new System.EventHandler(this.background_overlay_Click);
            // 
            // control_panel
            // 
            this.control_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.control_panel.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.control_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.control_panel.Location = new System.Drawing.Point(0, 400);
            this.control_panel.Name = "control_panel";
            this.control_panel.Size = new System.Drawing.Size(975, 295);
            this.control_panel.TabIndex = 1;
            this.control_panel.TabStop = false;
            // 
            // generate_code
            // 
            this.generate_code.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.generate_code.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generate_code.ForeColor = System.Drawing.Color.White;
            this.generate_code.Location = new System.Drawing.Point(20, 420);
            this.generate_code.Name = "generate_code";
            this.generate_code.Size = new System.Drawing.Size(200, 50);
            this.generate_code.TabIndex = 2;
            this.generate_code.Text = "Generate Code";
            this.generate_code.UseVisualStyleBackColor = false;
            this.generate_code.Click += new System.EventHandler(this.generate_code_Click);
            // 
            // binary_label
            // 
            this.binary_label.AutoSize = true;
            this.binary_label.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.binary_label.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.binary_label.ForeColor = System.Drawing.Color.White;
            this.binary_label.Location = new System.Drawing.Point(20, 520);
            this.binary_label.Name = "binary_label";
            this.binary_label.Size = new System.Drawing.Size(94, 21);
            this.binary_label.TabIndex = 3;
            this.binary_label.Text = "Binary Code";
            // 
            // hex_label
            // 
            this.hex_label.AutoSize = true;
            this.hex_label.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.hex_label.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hex_label.ForeColor = System.Drawing.Color.White;
            this.hex_label.Location = new System.Drawing.Point(20, 590);
            this.hex_label.Name = "hex_label";
            this.hex_label.Size = new System.Drawing.Size(76, 21);
            this.hex_label.TabIndex = 4;
            this.hex_label.Text = "Hex Code";
            // 
            // decimal_code
            // 
            this.decimal_code.AutoSize = true;
            this.decimal_code.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.decimal_code.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decimal_code.ForeColor = System.Drawing.Color.White;
            this.decimal_code.Location = new System.Drawing.Point(260, 435);
            this.decimal_code.Name = "decimal_code";
            this.decimal_code.Size = new System.Drawing.Size(36, 19);
            this.decimal_code.TabIndex = 5;
            this.decimal_code.Text = "---";
            // 
            // binary_code
            // 
            this.binary_code.AutoSize = true;
            this.binary_code.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.binary_code.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.binary_code.ForeColor = System.Drawing.Color.White;
            this.binary_code.Location = new System.Drawing.Point(200, 520);
            this.binary_code.Name = "binary_code";
            this.binary_code.Size = new System.Drawing.Size(36, 19);
            this.binary_code.TabIndex = 6;
            this.binary_code.Text = "---";
            // 
            // hex_code
            // 
            this.hex_code.AutoSize = true;
            this.hex_code.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.hex_code.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hex_code.ForeColor = System.Drawing.Color.White;
            this.hex_code.Location = new System.Drawing.Point(200, 590);
            this.hex_code.Name = "hex_code";
            this.hex_code.Size = new System.Drawing.Size(36, 19);
            this.hex_code.TabIndex = 7;
            this.hex_code.Text = "---";
            // 
            // binary_answer
            // 
            this.binary_answer.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.binary_answer.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.binary_answer.ForeColor = System.Drawing.Color.White;
            this.binary_answer.Location = new System.Drawing.Point(320, 517);
            this.binary_answer.Name = "binary_answer";
            this.binary_answer.Size = new System.Drawing.Size(150, 26);
            this.binary_answer.TabIndex = 8;
            // 
            // hex_answer
            // 
            this.hex_answer.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.hex_answer.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hex_answer.ForeColor = System.Drawing.Color.White;
            this.hex_answer.Location = new System.Drawing.Point(320, 587);
            this.hex_answer.Name = "hex_answer";
            this.hex_answer.Size = new System.Drawing.Size(150, 26);
            this.hex_answer.TabIndex = 9;
            // 
            // verify_code
            // 
            this.verify_code.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.verify_code.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verify_code.ForeColor = System.Drawing.Color.White;
            this.verify_code.Location = new System.Drawing.Point(320, 640);
            this.verify_code.Name = "verify_code";
            this.verify_code.Size = new System.Drawing.Size(150, 36);
            this.verify_code.TabIndex = 10;
            this.verify_code.Text = "Verify";
            this.verify_code.UseVisualStyleBackColor = false;
            this.verify_code.Click += new System.EventHandler(this.verify_code_Click);
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.status.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status.ForeColor = System.Drawing.Color.Red;
            this.status.Location = new System.Drawing.Point(750, 435);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(116, 21);
            this.status.TabIndex = 11;
            this.status.Text = "X INCOMPLETE";
            // 
            // calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(978, 694);
            this.Controls.Add(this.status);
            this.Controls.Add(this.verify_code);
            this.Controls.Add(this.hex_answer);
            this.Controls.Add(this.binary_answer);
            this.Controls.Add(this.hex_code);
            this.Controls.Add(this.binary_code);
            this.Controls.Add(this.decimal_code);
            this.Controls.Add(this.hex_label);
            this.Controls.Add(this.binary_label);
            this.Controls.Add(this.generate_code);
            this.Controls.Add(this.control_panel);
            this.Controls.Add(this.background_overlay);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "calculator";
            this.Text = "Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.background_overlay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.control_panel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox background_overlay;
        private System.Windows.Forms.PictureBox control_panel;
        private System.Windows.Forms.Button generate_code;
        private System.Windows.Forms.Label binary_label;
        private System.Windows.Forms.Label hex_label;
        private System.Windows.Forms.Label decimal_code;
        private System.Windows.Forms.Label binary_code;
        private System.Windows.Forms.Label hex_code;
        private System.Windows.Forms.TextBox binary_answer;
        private System.Windows.Forms.TextBox hex_answer;
        private System.Windows.Forms.Button verify_code;
        private System.Windows.Forms.Label status;
    }
}

