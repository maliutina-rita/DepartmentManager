namespace DepartmentManager.Forms
{
    partial class Employee
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
            this.components = new System.ComponentModel.Container();
            this.EmployeeGroupBox = new System.Windows.Forms.GroupBox();
            this.SurNameTextBox = new System.Windows.Forms.TextBox();
            this.DateOfBirthTimePicker = new System.Windows.Forms.DateTimePicker();
            this.DepartmentComboBox = new System.Windows.Forms.ComboBox();
            this.DepartmentLabel = new System.Windows.Forms.Label();
            this.PositionTextBox = new System.Windows.Forms.TextBox();
            this.DocNumberTextBox = new System.Windows.Forms.TextBox();
            this.DocSeriesTextBox = new System.Windows.Forms.TextBox();
            this.PatronymicTextBox = new System.Windows.Forms.TextBox();
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.PatronymicLabel = new System.Windows.Forms.Label();
            this.DateOfBirthLabel = new System.Windows.Forms.Label();
            this.DocSeriesLabel = new System.Windows.Forms.Label();
            this.DocNumberLabel = new System.Windows.Forms.Label();
            this.PositionLabel = new System.Windows.Forms.Label();
            this.SurNameLabel = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.SurNameErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.FirstNameErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.PatronymicErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.DateErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.DocSeriesErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.DocNumberErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.PositionErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.EmployeeGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SurNameErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FirstNameErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PatronymicErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DocSeriesErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DocNumberErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PositionErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // EmployeeGroupBox
            // 
            this.EmployeeGroupBox.Controls.Add(this.SurNameTextBox);
            this.EmployeeGroupBox.Controls.Add(this.DateOfBirthTimePicker);
            this.EmployeeGroupBox.Controls.Add(this.DepartmentComboBox);
            this.EmployeeGroupBox.Controls.Add(this.DepartmentLabel);
            this.EmployeeGroupBox.Controls.Add(this.PositionTextBox);
            this.EmployeeGroupBox.Controls.Add(this.DocNumberTextBox);
            this.EmployeeGroupBox.Controls.Add(this.DocSeriesTextBox);
            this.EmployeeGroupBox.Controls.Add(this.PatronymicTextBox);
            this.EmployeeGroupBox.Controls.Add(this.FirstNameTextBox);
            this.EmployeeGroupBox.Controls.Add(this.FirstNameLabel);
            this.EmployeeGroupBox.Controls.Add(this.PatronymicLabel);
            this.EmployeeGroupBox.Controls.Add(this.DateOfBirthLabel);
            this.EmployeeGroupBox.Controls.Add(this.DocSeriesLabel);
            this.EmployeeGroupBox.Controls.Add(this.DocNumberLabel);
            this.EmployeeGroupBox.Controls.Add(this.PositionLabel);
            this.EmployeeGroupBox.Controls.Add(this.SurNameLabel);
            this.EmployeeGroupBox.Location = new System.Drawing.Point(26, 12);
            this.EmployeeGroupBox.Name = "EmployeeGroupBox";
            this.EmployeeGroupBox.Size = new System.Drawing.Size(428, 287);
            this.EmployeeGroupBox.TabIndex = 0;
            this.EmployeeGroupBox.TabStop = false;
            this.EmployeeGroupBox.Text = "Registration";
            // 
            // SurNameTextBox
            // 
            this.SurNameTextBox.Location = new System.Drawing.Point(77, 30);
            this.SurNameTextBox.Name = "SurNameTextBox";
            this.SurNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.SurNameTextBox.TabIndex = 20;
            this.SurNameTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.SurNameTextBox_Validating);
            // 
            // DateOfBirthTimePicker
            // 
            this.DateOfBirthTimePicker.Location = new System.Drawing.Point(77, 138);
            this.DateOfBirthTimePicker.Name = "DateOfBirthTimePicker";
            this.DateOfBirthTimePicker.Size = new System.Drawing.Size(142, 20);
            this.DateOfBirthTimePicker.TabIndex = 19;
            this.DateOfBirthTimePicker.Validating += new System.ComponentModel.CancelEventHandler(this.DateOfBirthTimePicker_Validating);
            // 
            // DepartmentComboBox
            // 
            this.DepartmentComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DepartmentComboBox.FormattingEnabled = true;
            this.DepartmentComboBox.Location = new System.Drawing.Point(284, 30);
            this.DepartmentComboBox.Name = "DepartmentComboBox";
            this.DepartmentComboBox.Size = new System.Drawing.Size(121, 21);
            this.DepartmentComboBox.TabIndex = 18;
            // 
            // DepartmentLabel
            // 
            this.DepartmentLabel.AutoSize = true;
            this.DepartmentLabel.Location = new System.Drawing.Point(213, 33);
            this.DepartmentLabel.Name = "DepartmentLabel";
            this.DepartmentLabel.Size = new System.Drawing.Size(62, 13);
            this.DepartmentLabel.TabIndex = 16;
            this.DepartmentLabel.Text = "Department";
            // 
            // PositionTextBox
            // 
            this.PositionTextBox.Location = new System.Drawing.Point(77, 249);
            this.PositionTextBox.Name = "PositionTextBox";
            this.PositionTextBox.Size = new System.Drawing.Size(100, 20);
            this.PositionTextBox.TabIndex = 15;
            this.PositionTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.PositionTextBox_Validating);
            // 
            // DocNumberTextBox
            // 
            this.DocNumberTextBox.Location = new System.Drawing.Point(77, 213);
            this.DocNumberTextBox.Name = "DocNumberTextBox";
            this.DocNumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.DocNumberTextBox.TabIndex = 14;
            this.DocNumberTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.DocNumberTextBox_Validating);
            // 
            // DocSeriesTextBox
            // 
            this.DocSeriesTextBox.Location = new System.Drawing.Point(77, 178);
            this.DocSeriesTextBox.Name = "DocSeriesTextBox";
            this.DocSeriesTextBox.Size = new System.Drawing.Size(100, 20);
            this.DocSeriesTextBox.TabIndex = 13;
            this.DocSeriesTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.DocSeriesTextBox_Validating);
            // 
            // PatronymicTextBox
            // 
            this.PatronymicTextBox.Location = new System.Drawing.Point(77, 103);
            this.PatronymicTextBox.Name = "PatronymicTextBox";
            this.PatronymicTextBox.Size = new System.Drawing.Size(100, 20);
            this.PatronymicTextBox.TabIndex = 11;
            this.PatronymicTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.PatronymicTextBox_Validating);
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.Location = new System.Drawing.Point(77, 66);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.FirstNameTextBox.TabIndex = 10;
            this.FirstNameTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.FirstNameTextBox_Validating);
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Location = new System.Drawing.Point(6, 69);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(54, 13);
            this.FirstNameLabel.TabIndex = 8;
            this.FirstNameLabel.Text = "FirstName";
            // 
            // PatronymicLabel
            // 
            this.PatronymicLabel.AutoSize = true;
            this.PatronymicLabel.Location = new System.Drawing.Point(6, 106);
            this.PatronymicLabel.Name = "PatronymicLabel";
            this.PatronymicLabel.Size = new System.Drawing.Size(59, 13);
            this.PatronymicLabel.TabIndex = 7;
            this.PatronymicLabel.Text = "Patronymic";
            // 
            // DateOfBirthLabel
            // 
            this.DateOfBirthLabel.AutoSize = true;
            this.DateOfBirthLabel.Location = new System.Drawing.Point(6, 144);
            this.DateOfBirthLabel.Name = "DateOfBirthLabel";
            this.DateOfBirthLabel.Size = new System.Drawing.Size(65, 13);
            this.DateOfBirthLabel.TabIndex = 6;
            this.DateOfBirthLabel.Text = "Date of birth";
            // 
            // DocSeriesLabel
            // 
            this.DocSeriesLabel.AutoSize = true;
            this.DocSeriesLabel.Location = new System.Drawing.Point(6, 181);
            this.DocSeriesLabel.Name = "DocSeriesLabel";
            this.DocSeriesLabel.Size = new System.Drawing.Size(56, 13);
            this.DocSeriesLabel.TabIndex = 5;
            this.DocSeriesLabel.Text = "DocSeries";
            // 
            // DocNumberLabel
            // 
            this.DocNumberLabel.AutoSize = true;
            this.DocNumberLabel.Location = new System.Drawing.Point(6, 216);
            this.DocNumberLabel.Name = "DocNumberLabel";
            this.DocNumberLabel.Size = new System.Drawing.Size(64, 13);
            this.DocNumberLabel.TabIndex = 4;
            this.DocNumberLabel.Text = "DocNumber";
            // 
            // PositionLabel
            // 
            this.PositionLabel.AutoSize = true;
            this.PositionLabel.Location = new System.Drawing.Point(6, 252);
            this.PositionLabel.Name = "PositionLabel";
            this.PositionLabel.Size = new System.Drawing.Size(44, 13);
            this.PositionLabel.TabIndex = 3;
            this.PositionLabel.Text = "Position";
            // 
            // SurNameLabel
            // 
            this.SurNameLabel.AutoSize = true;
            this.SurNameLabel.Location = new System.Drawing.Point(6, 33);
            this.SurNameLabel.Name = "SurNameLabel";
            this.SurNameLabel.Size = new System.Drawing.Size(51, 13);
            this.SurNameLabel.TabIndex = 1;
            this.SurNameLabel.Text = "SurName";
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(338, 318);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(93, 37);
            this.SaveButton.TabIndex = 20;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // SurNameErrorProvider
            // 
            this.SurNameErrorProvider.ContainerControl = this;
            // 
            // FirstNameErrorProvider
            // 
            this.FirstNameErrorProvider.ContainerControl = this;
            // 
            // PatronymicErrorProvider
            // 
            this.PatronymicErrorProvider.ContainerControl = this;
            // 
            // DateErrorProvider
            // 
            this.DateErrorProvider.ContainerControl = this;
            // 
            // DocSeriesErrorProvider
            // 
            this.DocSeriesErrorProvider.ContainerControl = this;
            // 
            // DocNumberErrorProvider
            // 
            this.DocNumberErrorProvider.ContainerControl = this;
            // 
            // PositionErrorProvider
            // 
            this.PositionErrorProvider.ContainerControl = this;
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 367);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.EmployeeGroupBox);
            this.Name = "Employee";
            this.Text = "NewEmployeeRegistration";
            this.EmployeeGroupBox.ResumeLayout(false);
            this.EmployeeGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SurNameErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FirstNameErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PatronymicErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DocSeriesErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DocNumberErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PositionErrorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox EmployeeGroupBox;
        private System.Windows.Forms.ComboBox DepartmentComboBox;
        private System.Windows.Forms.Label DepartmentLabel;
        private System.Windows.Forms.TextBox PositionTextBox;
        private System.Windows.Forms.TextBox DocNumberTextBox;
        private System.Windows.Forms.TextBox DocSeriesTextBox;
        private System.Windows.Forms.TextBox PatronymicTextBox;
        private System.Windows.Forms.TextBox FirstNameTextBox;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.Label PatronymicLabel;
        private System.Windows.Forms.Label DateOfBirthLabel;
        private System.Windows.Forms.Label DocSeriesLabel;
        private System.Windows.Forms.Label DocNumberLabel;
        private System.Windows.Forms.Label PositionLabel;
        private System.Windows.Forms.Label SurNameLabel;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.DateTimePicker DateOfBirthTimePicker;
        private System.Windows.Forms.TextBox SurNameTextBox;
        private System.Windows.Forms.ErrorProvider SurNameErrorProvider;
        private System.Windows.Forms.ErrorProvider FirstNameErrorProvider;
        private System.Windows.Forms.ErrorProvider PatronymicErrorProvider;
        private System.Windows.Forms.ErrorProvider DateErrorProvider;
        private System.Windows.Forms.ErrorProvider DocSeriesErrorProvider;
        private System.Windows.Forms.ErrorProvider DocNumberErrorProvider;
        private System.Windows.Forms.ErrorProvider PositionErrorProvider;
    }
}