namespace CS311_FinalProject_AAD
{
    partial class Form1
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
            this.lblAmountToBeConverted = new System.Windows.Forms.Label();
            this.lblMeasureType = new System.Windows.Forms.Label();
            this.rtfDirections = new System.Windows.Forms.RichTextBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.lblConversionOutput = new System.Windows.Forms.Label();
            this.txtAmountToBeConverted = new System.Windows.Forms.TextBox();
            this.cboWhatMeasure = new System.Windows.Forms.ComboBox();
            this.lblFrom = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblAmountToBeConverted
            // 
            this.lblAmountToBeConverted.AutoSize = true;
            this.lblAmountToBeConverted.Location = new System.Drawing.Point(37, 143);
            this.lblAmountToBeConverted.Name = "lblAmountToBeConverted";
            this.lblAmountToBeConverted.Size = new System.Drawing.Size(208, 25);
            this.lblAmountToBeConverted.TabIndex = 0;
            this.lblAmountToBeConverted.Text = "Amount to be converted";
         
            // 
            // lblMeasureType
            // 
            this.lblMeasureType.AutoSize = true;
            this.lblMeasureType.Location = new System.Drawing.Point(37, 194);
            this.lblMeasureType.Name = "lblMeasureType";
            this.lblMeasureType.Size = new System.Drawing.Size(228, 25);
            this.lblMeasureType.TabIndex = 1;
            this.lblMeasureType.Text = "What type of measure is it?";
            // 
            // rtfDirections
            // 
            this.rtfDirections.Location = new System.Drawing.Point(81, -4);
            this.rtfDirections.Name = "rtfDirections";
            this.rtfDirections.Size = new System.Drawing.Size(622, 129);
            this.rtfDirections.TabIndex = 11;
            this.rtfDirections.Text = "Type the amount and unit you want to convert and then from the drop down menu cho" +
    "ose the measure of unit it is.";
           
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(143, 404);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(112, 34);
            this.btnConvert.TabIndex = 12;
            this.btnConvert.Text = "Convertor";
            this.btnConvert.UseVisualStyleBackColor = true;
            // 
            // lblConversionOutput
            // 
            this.lblConversionOutput.AutoSize = true;
            this.lblConversionOutput.Location = new System.Drawing.Point(336, 404);
            this.lblConversionOutput.Name = "lblConversionOutput";
            this.lblConversionOutput.Size = new System.Drawing.Size(73, 25);
            this.lblConversionOutput.TabIndex = 13;
            this.lblConversionOutput.Text = "Output:";
            // 
            // txtAmountToBeConverted
            // 
            this.txtAmountToBeConverted.Location = new System.Drawing.Point(284, 143);
            this.txtAmountToBeConverted.Name = "txtAmountToBeConverted";
            this.txtAmountToBeConverted.Size = new System.Drawing.Size(150, 31);
            this.txtAmountToBeConverted.TabIndex = 14;
            // 
            // cboWhatMeasure
            // 
            this.cboWhatMeasure.FormattingEnabled = true;
            this.cboWhatMeasure.Items.AddRange(new object[] {
            "Temperature",
            "Weight",
            "Length"});
            this.cboWhatMeasure.Location = new System.Drawing.Point(271, 194);
            this.cboWhatMeasure.Name = "cboWhatMeasure";
            this.cboWhatMeasure.Size = new System.Drawing.Size(182, 33);
            this.cboWhatMeasure.TabIndex = 15;
            this.cboWhatMeasure.SelectedIndexChanged += new System.EventHandler(this.cboWhatMeasure_SelectedIndexChanged);
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Location = new System.Drawing.Point(-4, 239);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(0, 25);
            this.lblFrom.TabIndex = 28;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1288, 450);
            this.Controls.Add(this.lblFrom);
            this.Controls.Add(this.cboWhatMeasure);
            this.Controls.Add(this.txtAmountToBeConverted);
            this.Controls.Add(this.lblConversionOutput);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.rtfDirections);
            this.Controls.Add(this.lblMeasureType);
            this.Controls.Add(this.lblAmountToBeConverted);
            this.Name = "Form1";
            this.Text = "Convertor";
         //   this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblAmountToBeConverted;
        private Label lblMeasureType;
        private RichTextBox rtfDirections;
        private Button btnConvert;
        private Label lblConversionOutput;
        private TextBox txtAmountToBeConverted;
        private ComboBox cboWhatMeasure;
        private Label lblFrom;
    }
}