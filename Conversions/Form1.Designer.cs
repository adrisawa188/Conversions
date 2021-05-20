
namespace Conversions
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
            this.title = new System.Windows.Forms.Label();
            this.conversion1 = new System.Windows.Forms.Label();
            this.conversion2 = new System.Windows.Forms.Label();
            this.conversion3 = new System.Windows.Forms.Label();
            this.conversion4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.choiceInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.inputValue = new System.Windows.Forms.TextBox();
            this.convertButton = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(12, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(379, 70);
            this.title.TabIndex = 0;
            this.title.Text = "Linear Conversion";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // conversion1
            // 
            this.conversion1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conversion1.Location = new System.Drawing.Point(12, 97);
            this.conversion1.Name = "conversion1";
            this.conversion1.Size = new System.Drawing.Size(238, 23);
            this.conversion1.TabIndex = 1;
            this.conversion1.Text = "1. Inches to Centimeteres";
            // 
            // conversion2
            // 
            this.conversion2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conversion2.Location = new System.Drawing.Point(12, 120);
            this.conversion2.Name = "conversion2";
            this.conversion2.Size = new System.Drawing.Size(238, 23);
            this.conversion2.TabIndex = 2;
            this.conversion2.Text = "2. Feet to Centimeteres";
            // 
            // conversion3
            // 
            this.conversion3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conversion3.Location = new System.Drawing.Point(12, 143);
            this.conversion3.Name = "conversion3";
            this.conversion3.Size = new System.Drawing.Size(238, 23);
            this.conversion3.TabIndex = 3;
            this.conversion3.Text = "3. Yards to Metres";
            // 
            // conversion4
            // 
            this.conversion4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conversion4.Location = new System.Drawing.Point(12, 166);
            this.conversion4.Name = "conversion4";
            this.conversion4.Size = new System.Drawing.Size(238, 23);
            this.conversion4.TabIndex = 4;
            this.conversion4.Text = "4. Miles to Kilometres";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 249);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Enter conversion choice (1-4):";
            // 
            // choiceInput
            // 
            this.choiceInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.choiceInput.Location = new System.Drawing.Point(238, 246);
            this.choiceInput.Name = "choiceInput";
            this.choiceInput.Size = new System.Drawing.Size(100, 26);
            this.choiceInput.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 301);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "Enter value to be converted:";
            // 
            // inputValue
            // 
            this.inputValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputValue.Location = new System.Drawing.Point(238, 298);
            this.inputValue.Name = "inputValue";
            this.inputValue.Size = new System.Drawing.Size(100, 26);
            this.inputValue.TabIndex = 8;
            // 
            // convertButton
            // 
            this.convertButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.convertButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.convertButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convertButton.Location = new System.Drawing.Point(48, 340);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(300, 33);
            this.convertButton.TabIndex = 9;
            this.convertButton.Text = "Convert";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.Location = new System.Drawing.Point(83, 392);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(238, 49);
            this.outputLabel.TabIndex = 10;
            this.outputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 450);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.inputValue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.choiceInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.conversion4);
            this.Controls.Add(this.conversion3);
            this.Controls.Add(this.conversion2);
            this.Controls.Add(this.conversion1);
            this.Controls.Add(this.title);
            this.Name = "Form1";
            this.Text = "Conversions";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label conversion1;
        private System.Windows.Forms.Label conversion2;
        private System.Windows.Forms.Label conversion3;
        private System.Windows.Forms.Label conversion4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox choiceInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inputValue;
        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.Label outputLabel;
    }
}

