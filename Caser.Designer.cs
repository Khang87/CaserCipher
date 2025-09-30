namespace _22_CaserCipher
{
    partial class Caser
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
            this.lbl_Message = new System.Windows.Forms.Label();
            this.txt_Message = new System.Windows.Forms.TextBox();
            this.lbl_Key = new System.Windows.Forms.Label();
            this.NumUpDown_Key = new System.Windows.Forms.NumericUpDown();
            this.lbl_Action = new System.Windows.Forms.Label();
            this.rad_Encrypt = new System.Windows.Forms.RadioButton();
            this.rad_Decrypt = new System.Windows.Forms.RadioButton();
            this.txt_Result = new System.Windows.Forms.TextBox();
            this.lbl_Result = new System.Windows.Forms.Label();
            this.btn_EncryptMessage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDown_Key)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Message
            // 
            this.lbl_Message.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Message.Location = new System.Drawing.Point(113, 58);
            this.lbl_Message.Name = "lbl_Message";
            this.lbl_Message.Size = new System.Drawing.Size(110, 16);
            this.lbl_Message.TabIndex = 0;
            this.lbl_Message.Text = "Message :";
           
            // txt_Message
            // 
            this.txt_Message.Location = new System.Drawing.Point(333, 52);
            this.txt_Message.Name = "txt_Message";
            this.txt_Message.Size = new System.Drawing.Size(392, 22);
            this.txt_Message.TabIndex = 1;
            // 
            // lbl_Key
            // 
            this.lbl_Key.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Key.Location = new System.Drawing.Point(113, 114);
            this.lbl_Key.Name = "lbl_Key";
            this.lbl_Key.Size = new System.Drawing.Size(111, 21);
            this.lbl_Key.TabIndex = 2;
            this.lbl_Key.Text = "Key :";
            // 
            // NumUpDown_Key
            // 
            this.NumUpDown_Key.Location = new System.Drawing.Point(334, 113);
            this.NumUpDown_Key.Name = "NumUpDown_Key";
            this.NumUpDown_Key.Size = new System.Drawing.Size(120, 22);
            this.NumUpDown_Key.TabIndex = 3;
            // 
            // lbl_Action
            // 
            this.lbl_Action.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Action.Location = new System.Drawing.Point(114, 174);
            this.lbl_Action.Name = "lbl_Action";
            this.lbl_Action.Size = new System.Drawing.Size(110, 16);
            this.lbl_Action.TabIndex = 4;
            this.lbl_Action.Text = "Action :";
            // 
            // rad_Encrypt
            // 
            this.rad_Encrypt.AutoSize = true;
            this.rad_Encrypt.Location = new System.Drawing.Point(333, 172);
            this.rad_Encrypt.Name = "rad_Encrypt";
            this.rad_Encrypt.Size = new System.Drawing.Size(73, 20);
            this.rad_Encrypt.TabIndex = 5;
            this.rad_Encrypt.TabStop = true;
            this.rad_Encrypt.Text = "Encrypt";
            this.rad_Encrypt.UseVisualStyleBackColor = true;
            // 
            // rad_Decrypt
            // 
            this.rad_Decrypt.AutoSize = true;
            this.rad_Decrypt.Location = new System.Drawing.Point(526, 174);
            this.rad_Decrypt.Name = "rad_Decrypt";
            this.rad_Decrypt.Size = new System.Drawing.Size(75, 20);
            this.rad_Decrypt.TabIndex = 6;
            this.rad_Decrypt.TabStop = true;
            this.rad_Decrypt.Text = "Decrypt";
            this.rad_Decrypt.UseVisualStyleBackColor = true;
            // 
            // txt_Result
            // 
            this.txt_Result.Location = new System.Drawing.Point(333, 236);
            this.txt_Result.Name = "txt_Result";
            this.txt_Result.Size = new System.Drawing.Size(392, 22);
            this.txt_Result.TabIndex = 8;
            // 
            // lbl_Result
            // 
            this.lbl_Result.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Result.Location = new System.Drawing.Point(113, 242);
            this.lbl_Result.Name = "lbl_Result";
            this.lbl_Result.Size = new System.Drawing.Size(110, 19);
            this.lbl_Result.TabIndex = 7;
            this.lbl_Result.Text = "Result :";
            // 
            // btn_EncryptMessage
            // 
            this.btn_EncryptMessage.Location = new System.Drawing.Point(224, 356);
            this.btn_EncryptMessage.Name = "btn_EncryptMessage";
            this.btn_EncryptMessage.Size = new System.Drawing.Size(387, 48);
            this.btn_EncryptMessage.TabIndex = 9;
            this.btn_EncryptMessage.Text = "Encrypt Message";
            this.btn_EncryptMessage.UseVisualStyleBackColor = true;
            // 
            // Caser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_EncryptMessage);
            this.Controls.Add(this.txt_Result);
            this.Controls.Add(this.lbl_Result);
            this.Controls.Add(this.rad_Decrypt);
            this.Controls.Add(this.rad_Encrypt);
            this.Controls.Add(this.lbl_Action);
            this.Controls.Add(this.NumUpDown_Key);
            this.Controls.Add(this.lbl_Key);
            this.Controls.Add(this.txt_Message);
            this.Controls.Add(this.lbl_Message);
            this.Name = "Caser";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDown_Key)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Message;
        private System.Windows.Forms.TextBox txt_Message;
        private System.Windows.Forms.Label lbl_Key;
        private System.Windows.Forms.NumericUpDown NumUpDown_Key;
        private System.Windows.Forms.Label lbl_Action;
        private System.Windows.Forms.RadioButton rad_Encrypt;
        private System.Windows.Forms.RadioButton rad_Decrypt;
        private System.Windows.Forms.TextBox txt_Result;
        private System.Windows.Forms.Label lbl_Result;
        private System.Windows.Forms.Button btn_EncryptMessage;
    }
}