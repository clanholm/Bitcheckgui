
namespace Bitcheckgui
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
            System.Windows.Forms.Label lblEnterNumber;
            this.txtEnterNumber = new System.Windows.Forms.TextBox();
            this.lblBinary = new System.Windows.Forms.Label();
            this.txtBit = new System.Windows.Forms.TextBox();
            this.lblBinaryOutput = new System.Windows.Forms.Label();
            this.lblWhichBit = new System.Windows.Forms.Label();
            this.btnSetBit = new System.Windows.Forms.Button();
            this.btnUnsetBit = new System.Windows.Forms.Button();
            this.btnToggleBit = new System.Windows.Forms.Button();
            this.lblBitState = new System.Windows.Forms.Label();
            lblEnterNumber = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblEnterNumber
            // 
            lblEnterNumber.AutoSize = true;
            lblEnterNumber.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblEnterNumber.Location = new System.Drawing.Point(6, 6);
            lblEnterNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblEnterNumber.Name = "lblEnterNumber";
            lblEnterNumber.Size = new System.Drawing.Size(110, 19);
            lblEnterNumber.TabIndex = 1;
            lblEnterNumber.Text = "Enter Number:";
            lblEnterNumber.Click += new System.EventHandler(this.lblEnterNumber);
            // 
            // txtEnterNumber
            // 
            this.txtEnterNumber.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnterNumber.Location = new System.Drawing.Point(130, 6);
            this.txtEnterNumber.Margin = new System.Windows.Forms.Padding(2);
            this.txtEnterNumber.Name = "txtEnterNumber";
            this.txtEnterNumber.Size = new System.Drawing.Size(263, 27);
            this.txtEnterNumber.TabIndex = 0;
            this.txtEnterNumber.Text = "0";
            this.txtEnterNumber.TextChanged += new System.EventHandler(this.txtEnterNumber_TextChanged);
            // 
            // lblBinary
            // 
            this.lblBinary.AutoSize = true;
            this.lblBinary.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBinary.Location = new System.Drawing.Point(59, 54);
            this.lblBinary.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBinary.Name = "lblBinary";
            this.lblBinary.Size = new System.Drawing.Size(57, 19);
            this.lblBinary.TabIndex = 2;
            this.lblBinary.Text = "Binary:";
            // 
            // txtBit
            // 
            this.txtBit.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBit.Location = new System.Drawing.Point(130, 95);
            this.txtBit.Margin = new System.Windows.Forms.Padding(2);
            this.txtBit.Name = "txtBit";
            this.txtBit.Size = new System.Drawing.Size(55, 27);
            this.txtBit.TabIndex = 3;
            this.txtBit.Text = "0";
            this.txtBit.TextChanged += new System.EventHandler(this.txtBit_TextChanged);
            // 
            // lblBinaryOutput
            // 
            this.lblBinaryOutput.AutoSize = true;
            this.lblBinaryOutput.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBinaryOutput.Location = new System.Drawing.Point(126, 54);
            this.lblBinaryOutput.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBinaryOutput.Name = "lblBinaryOutput";
            this.lblBinaryOutput.Size = new System.Drawing.Size(17, 19);
            this.lblBinaryOutput.TabIndex = 4;
            this.lblBinaryOutput.Text = "0";
            // 
            // lblWhichBit
            // 
            this.lblWhichBit.AutoSize = true;
            this.lblWhichBit.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWhichBit.Location = new System.Drawing.Point(7, 95);
            this.lblWhichBit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWhichBit.Name = "lblWhichBit";
            this.lblWhichBit.Size = new System.Drawing.Size(123, 19);
            this.lblWhichBit.TabIndex = 5;
            this.lblWhichBit.Text = "Which Bit (0-31):";
            // 
            // btnSetBit
            // 
            this.btnSetBit.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetBit.Location = new System.Drawing.Point(10, 203);
            this.btnSetBit.Margin = new System.Windows.Forms.Padding(2);
            this.btnSetBit.Name = "btnSetBit";
            this.btnSetBit.Size = new System.Drawing.Size(110, 34);
            this.btnSetBit.TabIndex = 7;
            this.btnSetBit.Text = "Set Bit";
            this.btnSetBit.UseVisualStyleBackColor = true;
            this.btnSetBit.Click += new System.EventHandler(this.btnSetBit_Click);
            // 
            // btnUnsetBit
            // 
            this.btnUnsetBit.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnsetBit.Location = new System.Drawing.Point(144, 203);
            this.btnUnsetBit.Margin = new System.Windows.Forms.Padding(2);
            this.btnUnsetBit.Name = "btnUnsetBit";
            this.btnUnsetBit.Size = new System.Drawing.Size(110, 34);
            this.btnUnsetBit.TabIndex = 8;
            this.btnUnsetBit.Text = "Unset Bit";
            this.btnUnsetBit.UseVisualStyleBackColor = true;
            this.btnUnsetBit.Click += new System.EventHandler(this.btnUnsetBit_Click);
            // 
            // btnToggleBit
            // 
            this.btnToggleBit.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToggleBit.Location = new System.Drawing.Point(281, 203);
            this.btnToggleBit.Margin = new System.Windows.Forms.Padding(2);
            this.btnToggleBit.Name = "btnToggleBit";
            this.btnToggleBit.Size = new System.Drawing.Size(110, 34);
            this.btnToggleBit.TabIndex = 9;
            this.btnToggleBit.Text = "Toggle Bit";
            this.btnToggleBit.UseVisualStyleBackColor = true;
            this.btnToggleBit.Click += new System.EventHandler(this.btnToggleBit_Click);
            // 
            // lblBitState
            // 
            this.lblBitState.AutoSize = true;
            this.lblBitState.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBitState.Location = new System.Drawing.Point(216, 98);
            this.lblBitState.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBitState.Name = "lblBitState";
            this.lblBitState.Size = new System.Drawing.Size(98, 19);
            this.lblBitState.TabIndex = 10;
            this.lblBitState.Text = "Bit Is Not Set";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 263);
            this.Controls.Add(this.lblBitState);
            this.Controls.Add(this.btnToggleBit);
            this.Controls.Add(this.btnUnsetBit);
            this.Controls.Add(this.btnSetBit);
            this.Controls.Add(this.lblWhichBit);
            this.Controls.Add(this.lblBinaryOutput);
            this.Controls.Add(this.txtBit);
            this.Controls.Add(this.lblBinary);
            this.Controls.Add(lblEnterNumber);
            this.Controls.Add(this.txtEnterNumber);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bit Manipulation";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEnterNumber;
        private System.Windows.Forms.Label lblBinary;
        private System.Windows.Forms.TextBox txtBit;
        private System.Windows.Forms.Label lblBinaryOutput;
        private System.Windows.Forms.Label lblWhichBit;
        private System.Windows.Forms.Button btnSetBit;
        private System.Windows.Forms.Button btnUnsetBit;
        private System.Windows.Forms.Button btnToggleBit;
        private System.Windows.Forms.Label lblBitState;
    }
}

