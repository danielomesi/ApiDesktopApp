using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppLogic;


namespace AppGUI
{
    partial class MainForm
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
            this.comboBoxFlightHolder = new System.Windows.Forms.ComboBox();
            this.textBoxSearchParam = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelParam = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.buttonFetchData = new System.Windows.Forms.Button();
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            this.labelWhichFlights = new System.Windows.Forms.Label();
            this.comboBoxWhichFlights = new System.Windows.Forms.ComboBox();
            this.comboBoxAirport = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // comboBoxFlightHolder
            // 
            this.comboBoxFlightHolder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFlightHolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comboBoxFlightHolder.FormattingEnabled = true;
            this.comboBoxFlightHolder.Items.AddRange(new object[] {
            "Airport",
            "Aircraft"});
            this.comboBoxFlightHolder.Location = new System.Drawing.Point(12, 53);
            this.comboBoxFlightHolder.Name = "comboBoxFlightHolder";
            this.comboBoxFlightHolder.Size = new System.Drawing.Size(121, 33);
            this.comboBoxFlightHolder.TabIndex = 0;
            this.comboBoxFlightHolder.SelectedIndexChanged += new System.EventHandler(this.comboBoxFlightHolder_SelectedIndexChanged);
            // 
            // textBoxSearchParam
            // 
            this.textBoxSearchParam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxSearchParam.Location = new System.Drawing.Point(176, 53);
            this.textBoxSearchParam.MaxLength = 6;
            this.textBoxSearchParam.Name = "textBoxSearchParam";
            this.textBoxSearchParam.Size = new System.Drawing.Size(133, 30);
            this.textBoxSearchParam.TabIndex = 1;
            this.textBoxSearchParam.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(32, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Choose";
            // 
            // labelParam
            // 
            this.labelParam.AutoSize = true;
            this.labelParam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelParam.Location = new System.Drawing.Point(207, 9);
            this.labelParam.Name = "labelParam";
            this.labelParam.Size = new System.Drawing.Size(0, 25);
            this.labelParam.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(337, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Show Flights From";
            // 
            // dateTimePickerStart
            // 
            this.dateTimePickerStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dateTimePickerStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerStart.Location = new System.Drawing.Point(342, 53);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.Size = new System.Drawing.Size(168, 30);
            this.dateTimePickerStart.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(600, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "To";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dateTimePickerEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerEnd.Location = new System.Drawing.Point(545, 53);
            this.dateTimePickerEnd.MaxDate = new System.DateTime(2030, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerEnd.MinDate = new System.DateTime(1970, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.Size = new System.Drawing.Size(164, 30);
            this.dateTimePickerEnd.TabIndex = 8;
            this.dateTimePickerEnd.Value = new System.DateTime(2023, 7, 15, 18, 14, 48, 179);
            // 
            // buttonFetchData
            // 
            this.buttonFetchData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonFetchData.Location = new System.Drawing.Point(894, 50);
            this.buttonFetchData.Name = "buttonFetchData";
            this.buttonFetchData.Size = new System.Drawing.Size(129, 33);
            this.buttonFetchData.TabIndex = 9;
            this.buttonFetchData.Text = "Fetch Data";
            this.buttonFetchData.UseVisualStyleBackColor = true;
            this.buttonFetchData.Click += new System.EventHandler(this.buttonFetchData_Click);
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.textBoxOutput.Location = new System.Drawing.Point(18, 108);
            this.textBoxOutput.Multiline = true;
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.ReadOnly = true;
            this.textBoxOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxOutput.Size = new System.Drawing.Size(982, 490);
            this.textBoxOutput.TabIndex = 10;
            // 
            // labelWhichFlights
            // 
            this.labelWhichFlights.AutoSize = true;
            this.labelWhichFlights.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelWhichFlights.Location = new System.Drawing.Point(741, 9);
            this.labelWhichFlights.Name = "labelWhichFlights";
            this.labelWhichFlights.Size = new System.Drawing.Size(141, 25);
            this.labelWhichFlights.TabIndex = 11;
            this.labelWhichFlights.Text = "Which Flights?";
            this.labelWhichFlights.Visible = false;
            // 
            // comboBoxWhichFlights
            // 
            this.comboBoxWhichFlights.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxWhichFlights.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comboBoxWhichFlights.FormattingEnabled = true;
            this.comboBoxWhichFlights.Items.AddRange(new object[] {
            "Arrivals",
            "Departures"});
            this.comboBoxWhichFlights.Location = new System.Drawing.Point(746, 50);
            this.comboBoxWhichFlights.Name = "comboBoxWhichFlights";
            this.comboBoxWhichFlights.Size = new System.Drawing.Size(121, 33);
            this.comboBoxWhichFlights.TabIndex = 12;
            this.comboBoxWhichFlights.Visible = false;
            // 
            // comboBoxAirport
            // 
            this.comboBoxAirport.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxAirport.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxAirport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxAirport.FormattingEnabled = true;
            this.comboBoxAirport.Location = new System.Drawing.Point(148, 56);
            this.comboBoxAirport.Name = "comboBoxAirport";
            this.comboBoxAirport.Size = new System.Drawing.Size(178, 33);
            this.comboBoxAirport.TabIndex = 13;
            this.comboBoxAirport.Visible = false;
            // 
            // MainForm
            // 
            this.AcceptButton = this.buttonFetchData;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 610);
            this.Controls.Add(this.comboBoxAirport);
            this.Controls.Add(this.comboBoxWhichFlights);
            this.Controls.Add(this.labelWhichFlights);
            this.Controls.Add(this.textBoxOutput);
            this.Controls.Add(this.buttonFetchData);
            this.Controls.Add(this.dateTimePickerEnd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePickerStart);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelParam);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxSearchParam);
            this.Controls.Add(this.comboBoxFlightHolder);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Flights Data";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxFlightHolder;
        private System.Windows.Forms.TextBox textBoxSearchParam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelParam;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePickerStart;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePickerEnd;
        private System.Windows.Forms.Button buttonFetchData;
        private System.Windows.Forms.TextBox textBoxOutput;
        private System.Windows.Forms.Label labelWhichFlights;
        private System.Windows.Forms.ComboBox comboBoxWhichFlights;
        private System.Windows.Forms.ComboBox comboBoxAirport;
        private Dictionary<string, string> m_Airports;
    }
}