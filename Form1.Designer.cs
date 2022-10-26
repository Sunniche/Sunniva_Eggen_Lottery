namespace Sunniva_Eggen_Appolonia
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
            this.btnDraw = new System.Windows.Forms.Button();
            this.btnPrice = new System.Windows.Forms.Button();
            this.btnInvoice = new System.Windows.Forms.Button();
            this.btnStatistics = new System.Windows.Forms.Button();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtNumberOfTickets = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblNumberOfTickets = new System.Windows.Forms.Label();
            this.txtStatistics = new System.Windows.Forms.TextBox();
            this.txtDraw = new System.Windows.Forms.TextBox();
            this.txtPrices = new System.Windows.Forms.TextBox();
            this.formsPlot1 = new ScottPlot.FormsPlot();
            this.txtInvoiceNumber = new System.Windows.Forms.TextBox();
            this.lblInvoiceNumber = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDraw
            // 
            this.btnDraw.Location = new System.Drawing.Point(74, 39);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(112, 34);
            this.btnDraw.TabIndex = 0;
            this.btnDraw.Text = "Draw";
            this.btnDraw.UseVisualStyleBackColor = true;
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // btnPrice
            // 
            this.btnPrice.Location = new System.Drawing.Point(74, 352);
            this.btnPrice.Name = "btnPrice";
            this.btnPrice.Size = new System.Drawing.Size(184, 34);
            this.btnPrice.TabIndex = 1;
            this.btnPrice.Text = "Check Prices";
            this.btnPrice.UseVisualStyleBackColor = true;
            this.btnPrice.Click += new System.EventHandler(this.btnPrice_Click);
            // 
            // btnInvoice
            // 
            this.btnInvoice.Location = new System.Drawing.Point(74, 95);
            this.btnInvoice.Name = "btnInvoice";
            this.btnInvoice.Size = new System.Drawing.Size(180, 34);
            this.btnInvoice.TabIndex = 2;
            this.btnInvoice.Text = "Create Invoice";
            this.btnInvoice.UseVisualStyleBackColor = true;
            this.btnInvoice.Click += new System.EventHandler(this.btnInvoice_Click);
            // 
            // btnStatistics
            // 
            this.btnStatistics.Location = new System.Drawing.Point(1045, 64);
            this.btnStatistics.Name = "btnStatistics";
            this.btnStatistics.Size = new System.Drawing.Size(184, 34);
            this.btnStatistics.TabIndex = 3;
            this.btnStatistics.Text = "Show Statistics";
            this.btnStatistics.UseVisualStyleBackColor = true;
            this.btnStatistics.Click += new System.EventHandler(this.btnStatistics_Click);
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(265, 145);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(150, 31);
            this.txtFirstName.TabIndex = 4;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(265, 184);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(150, 31);
            this.txtLastName.TabIndex = 5;
            // 
            // txtNumberOfTickets
            // 
            this.txtNumberOfTickets.Location = new System.Drawing.Point(265, 221);
            this.txtNumberOfTickets.Name = "txtNumberOfTickets";
            this.txtNumberOfTickets.Size = new System.Drawing.Size(150, 31);
            this.txtNumberOfTickets.TabIndex = 6;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(74, 148);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(101, 25);
            this.lblFirstName.TabIndex = 7;
            this.lblFirstName.Text = "First Name:";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(74, 190);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(99, 25);
            this.lblLastName.TabIndex = 8;
            this.lblLastName.Text = "Last Name:";
            // 
            // lblNumberOfTickets
            // 
            this.lblNumberOfTickets.AutoSize = true;
            this.lblNumberOfTickets.Location = new System.Drawing.Point(74, 227);
            this.lblNumberOfTickets.Name = "lblNumberOfTickets";
            this.lblNumberOfTickets.Size = new System.Drawing.Size(161, 25);
            this.lblNumberOfTickets.TabIndex = 9;
            this.lblNumberOfTickets.Text = "Number of Tickets:";
            // 
            // txtStatistics
            // 
            this.txtStatistics.Location = new System.Drawing.Point(1045, 161);
            this.txtStatistics.Multiline = true;
            this.txtStatistics.Name = "txtStatistics";
            this.txtStatistics.Size = new System.Drawing.Size(254, 537);
            this.txtStatistics.TabIndex = 10;
            // 
            // txtDraw
            // 
            this.txtDraw.Location = new System.Drawing.Point(208, 39);
            this.txtDraw.Name = "txtDraw";
            this.txtDraw.Size = new System.Drawing.Size(716, 31);
            this.txtDraw.TabIndex = 11;
            // 
            // txtPrices
            // 
            this.txtPrices.Location = new System.Drawing.Point(74, 392);
            this.txtPrices.Multiline = true;
            this.txtPrices.Name = "txtPrices";
            this.txtPrices.Size = new System.Drawing.Size(426, 205);
            this.txtPrices.TabIndex = 12;
            // 
            // formsPlot1
            // 
            this.formsPlot1.Location = new System.Drawing.Point(509, 184);
            this.formsPlot1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.formsPlot1.Name = "formsPlot1";
            this.formsPlot1.Size = new System.Drawing.Size(527, 539);
            this.formsPlot1.TabIndex = 13;
            // 
            // txtInvoiceNumber
            // 
            this.txtInvoiceNumber.Location = new System.Drawing.Point(265, 258);
            this.txtInvoiceNumber.Name = "txtInvoiceNumber";
            this.txtInvoiceNumber.Size = new System.Drawing.Size(150, 31);
            this.txtInvoiceNumber.TabIndex = 14;
            // 
            // lblInvoiceNumber
            // 
            this.lblInvoiceNumber.AutoSize = true;
            this.lblInvoiceNumber.Location = new System.Drawing.Point(74, 264);
            this.lblInvoiceNumber.Name = "lblInvoiceNumber";
            this.lblInvoiceNumber.Size = new System.Drawing.Size(101, 25);
            this.lblInvoiceNumber.TabIndex = 15;
            this.lblInvoiceNumber.Text = "Invoice No:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1329, 727);
            this.Controls.Add(this.lblInvoiceNumber);
            this.Controls.Add(this.txtInvoiceNumber);
            this.Controls.Add(this.formsPlot1);
            this.Controls.Add(this.txtPrices);
            this.Controls.Add(this.txtDraw);
            this.Controls.Add(this.txtStatistics);
            this.Controls.Add(this.lblNumberOfTickets);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.txtNumberOfTickets);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.btnStatistics);
            this.Controls.Add(this.btnInvoice);
            this.Controls.Add(this.btnPrice);
            this.Controls.Add(this.btnDraw);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnDraw;
        private Button btnPrice;
        private Button btnInvoice;
        private Button btnStatistics;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtNumberOfTickets;
        private Label lblFirstName;
        private Label lblLastName;
        private Label lblNumberOfTickets;
        private TextBox txtStatistics;
        private TextBox txtDraw;
        private TextBox txtPrices;
        private ScottPlot.FormsPlot formsPlot1;
        private TextBox txtInvoiceNumber;
        private Label lblInvoiceNumber;
    }
}