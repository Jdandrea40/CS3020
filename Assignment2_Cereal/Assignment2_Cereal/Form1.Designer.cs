﻿namespace Assignment2_Cereal
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
            this.SortButton = new System.Windows.Forms.Button();
            this.CerealGridView = new System.Windows.Forms.DataGridView();
            this.SortedCerealList = new System.Windows.Forms.DataGridView();
            this.CaloriesUpDown = new System.Windows.Forms.NumericUpDown();
            this.CaloriesLabel = new System.Windows.Forms.Label();
            this.ProteinLabel = new System.Windows.Forms.Label();
            this.ProteinUpDown = new System.Windows.Forms.NumericUpDown();
            this.RefineLayouPanel = new System.Windows.Forms.TableLayoutPanel();
            this.FatLabel = new System.Windows.Forms.Label();
            this.FatUpDown = new System.Windows.Forms.NumericUpDown();
            this.SodiumLabel = new System.Windows.Forms.Label();
            this.SodiumUpDown = new System.Windows.Forms.NumericUpDown();
            this.CheckCals = new System.Windows.Forms.CheckBox();
            this.CheckProtein = new System.Windows.Forms.CheckBox();
            this.CheckFat = new System.Windows.Forms.CheckBox();
            this.CheckSodium = new System.Windows.Forms.CheckBox();
            this.FiberLabel = new System.Windows.Forms.Label();
            this.FiberUpDown = new System.Windows.Forms.NumericUpDown();
            this.CheckFiber = new System.Windows.Forms.CheckBox();
            this.CarbLabel = new System.Windows.Forms.Label();
            this.CarbUpDown = new System.Windows.Forms.NumericUpDown();
            this.CheckCarbs = new System.Windows.Forms.CheckBox();
            this.SugarsLabel = new System.Windows.Forms.Label();
            this.SugarUpDown = new System.Windows.Forms.NumericUpDown();
            this.CheckSugar = new System.Windows.Forms.CheckBox();
            this.PotassLabel = new System.Windows.Forms.Label();
            this.PotassUpDown = new System.Windows.Forms.NumericUpDown();
            this.CheckPotass = new System.Windows.Forms.CheckBox();
            this.VitaminLabel = new System.Windows.Forms.Label();
            this.VitaminUpDown = new System.Windows.Forms.NumericUpDown();
            this.CheckVits = new System.Windows.Forms.CheckBox();
            this.ShelfLifeLabel = new System.Windows.Forms.Label();
            this.ShelfLifeUpDown = new System.Windows.Forms.NumericUpDown();
            this.CheckLife = new System.Windows.Forms.CheckBox();
            this.ServeSizeLabel = new System.Windows.Forms.Label();
            this.ServingsUpDown = new System.Windows.Forms.NumericUpDown();
            this.CheckServings = new System.Windows.Forms.CheckBox();
            this.RatingLabel = new System.Windows.Forms.Label();
            this.CheckRating = new System.Windows.Forms.CheckBox();
            this.RatingUpDown = new System.Windows.Forms.NumericUpDown();
            this.HotColdLabel = new System.Windows.Forms.Label();
            this.CheckHot = new System.Windows.Forms.CheckBox();
            this.CheckCold = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.CerealGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SortedCerealList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CaloriesUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProteinUpDown)).BeginInit();
            this.RefineLayouPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FatUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SodiumUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FiberUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarbUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SugarUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PotassUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VitaminUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShelfLifeUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ServingsUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RatingUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // SortButton
            // 
            this.SortButton.Location = new System.Drawing.Point(66, 763);
            this.SortButton.Name = "SortButton";
            this.SortButton.Size = new System.Drawing.Size(166, 56);
            this.SortButton.TabIndex = 0;
            this.SortButton.Text = "Sort";
            this.SortButton.UseVisualStyleBackColor = true;
            this.SortButton.Click += new System.EventHandler(this.SortButton_Click);
            // 
            // CerealGridView
            // 
            this.CerealGridView.AllowUserToOrderColumns = true;
            this.CerealGridView.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.CerealGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CerealGridView.Location = new System.Drawing.Point(12, 12);
            this.CerealGridView.Name = "CerealGridView";
            this.CerealGridView.RowHeadersWidth = 51;
            this.CerealGridView.Size = new System.Drawing.Size(1199, 350);
            this.CerealGridView.TabIndex = 1;
            // 
            // SortedCerealList
            // 
            this.SortedCerealList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SortedCerealList.Location = new System.Drawing.Point(314, 368);
            this.SortedCerealList.Name = "SortedCerealList";
            this.SortedCerealList.RowHeadersWidth = 51;
            this.SortedCerealList.Size = new System.Drawing.Size(897, 389);
            this.SortedCerealList.TabIndex = 5;
            // 
            // CaloriesUpDown
            // 
            this.CaloriesUpDown.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.CaloriesUpDown.Location = new System.Drawing.Point(80, 6);
            this.CaloriesUpDown.Maximum = new decimal(new int[] {
            160,
            0,
            0,
            0});
            this.CaloriesUpDown.Name = "CaloriesUpDown";
            this.CaloriesUpDown.Size = new System.Drawing.Size(48, 20);
            this.CaloriesUpDown.TabIndex = 3;
            // 
            // CaloriesLabel
            // 
            this.CaloriesLabel.AutoSize = true;
            this.CaloriesLabel.Location = new System.Drawing.Point(6, 3);
            this.CaloriesLabel.Name = "CaloriesLabel";
            this.CaloriesLabel.Size = new System.Drawing.Size(47, 13);
            this.CaloriesLabel.TabIndex = 7;
            this.CaloriesLabel.Text = "MaxCals";
            // 
            // ProteinLabel
            // 
            this.ProteinLabel.AutoSize = true;
            this.ProteinLabel.Location = new System.Drawing.Point(6, 32);
            this.ProteinLabel.Name = "ProteinLabel";
            this.ProteinLabel.Size = new System.Drawing.Size(40, 13);
            this.ProteinLabel.TabIndex = 8;
            this.ProteinLabel.Text = "MinPro";
            // 
            // ProteinUpDown
            // 
            this.ProteinUpDown.Location = new System.Drawing.Point(80, 35);
            this.ProteinUpDown.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.ProteinUpDown.Name = "ProteinUpDown";
            this.ProteinUpDown.Size = new System.Drawing.Size(48, 20);
            this.ProteinUpDown.TabIndex = 9;
            // 
            // RefineLayouPanel
            // 
            this.RefineLayouPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.RefineLayouPanel.ColumnCount = 3;
            this.RefineLayouPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.RefineLayouPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.RefineLayouPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.RefineLayouPanel.Controls.Add(this.ProteinUpDown, 1, 1);
            this.RefineLayouPanel.Controls.Add(this.ProteinLabel, 0, 1);
            this.RefineLayouPanel.Controls.Add(this.CaloriesLabel, 0, 0);
            this.RefineLayouPanel.Controls.Add(this.CaloriesUpDown, 1, 0);
            this.RefineLayouPanel.Controls.Add(this.FatLabel, 0, 2);
            this.RefineLayouPanel.Controls.Add(this.FatUpDown, 1, 2);
            this.RefineLayouPanel.Controls.Add(this.SodiumLabel, 0, 4);
            this.RefineLayouPanel.Controls.Add(this.SodiumUpDown, 1, 4);
            this.RefineLayouPanel.Controls.Add(this.CheckCals, 2, 0);
            this.RefineLayouPanel.Controls.Add(this.CheckProtein, 2, 1);
            this.RefineLayouPanel.Controls.Add(this.CheckFat, 2, 2);
            this.RefineLayouPanel.Controls.Add(this.CheckSodium, 2, 4);
            this.RefineLayouPanel.Controls.Add(this.FiberLabel, 0, 5);
            this.RefineLayouPanel.Controls.Add(this.FiberUpDown, 1, 5);
            this.RefineLayouPanel.Controls.Add(this.CheckFiber, 2, 5);
            this.RefineLayouPanel.Controls.Add(this.CarbLabel, 0, 6);
            this.RefineLayouPanel.Controls.Add(this.CarbUpDown, 1, 6);
            this.RefineLayouPanel.Controls.Add(this.CheckCarbs, 2, 6);
            this.RefineLayouPanel.Controls.Add(this.SugarsLabel, 0, 7);
            this.RefineLayouPanel.Controls.Add(this.SugarUpDown, 1, 7);
            this.RefineLayouPanel.Controls.Add(this.CheckSugar, 2, 7);
            this.RefineLayouPanel.Controls.Add(this.PotassLabel, 0, 8);
            this.RefineLayouPanel.Controls.Add(this.CheckPotass, 2, 8);
            this.RefineLayouPanel.Controls.Add(this.VitaminLabel, 0, 9);
            this.RefineLayouPanel.Controls.Add(this.VitaminUpDown, 1, 9);
            this.RefineLayouPanel.Controls.Add(this.CheckVits, 2, 9);
            this.RefineLayouPanel.Controls.Add(this.ShelfLifeLabel, 0, 10);
            this.RefineLayouPanel.Controls.Add(this.ShelfLifeUpDown, 1, 10);
            this.RefineLayouPanel.Controls.Add(this.CheckLife, 2, 10);
            this.RefineLayouPanel.Controls.Add(this.ServeSizeLabel, 0, 11);
            this.RefineLayouPanel.Controls.Add(this.ServingsUpDown, 1, 11);
            this.RefineLayouPanel.Controls.Add(this.CheckServings, 2, 11);
            this.RefineLayouPanel.Controls.Add(this.RatingLabel, 0, 12);
            this.RefineLayouPanel.Controls.Add(this.CheckRating, 2, 12);
            this.RefineLayouPanel.Controls.Add(this.RatingUpDown, 1, 12);
            this.RefineLayouPanel.Controls.Add(this.HotColdLabel, 0, 13);
            this.RefineLayouPanel.Controls.Add(this.CheckHot, 1, 13);
            this.RefineLayouPanel.Controls.Add(this.CheckCold, 2, 13);
            this.RefineLayouPanel.Controls.Add(this.PotassUpDown, 1, 8);
            this.RefineLayouPanel.Location = new System.Drawing.Point(12, 368);
            this.RefineLayouPanel.Name = "RefineLayouPanel";
            this.RefineLayouPanel.RowCount = 14;
            this.RefineLayouPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.RefineLayouPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.RefineLayouPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.RefineLayouPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.RefineLayouPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.RefineLayouPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.RefineLayouPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.RefineLayouPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.RefineLayouPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.RefineLayouPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.RefineLayouPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.RefineLayouPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.RefineLayouPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.RefineLayouPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.RefineLayouPanel.Size = new System.Drawing.Size(296, 389);
            this.RefineLayouPanel.TabIndex = 10;
            // 
            // FatLabel
            // 
            this.FatLabel.AutoSize = true;
            this.FatLabel.Location = new System.Drawing.Point(6, 61);
            this.FatLabel.Name = "FatLabel";
            this.FatLabel.Size = new System.Drawing.Size(42, 13);
            this.FatLabel.TabIndex = 10;
            this.FatLabel.Text = "MaxFat";
            // 
            // FatUpDown
            // 
            this.FatUpDown.Location = new System.Drawing.Point(80, 64);
            this.FatUpDown.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.FatUpDown.Name = "FatUpDown";
            this.FatUpDown.Size = new System.Drawing.Size(48, 20);
            this.FatUpDown.TabIndex = 11;
            // 
            // SodiumLabel
            // 
            this.SodiumLabel.AutoSize = true;
            this.SodiumLabel.Location = new System.Drawing.Point(6, 93);
            this.SodiumLabel.Name = "SodiumLabel";
            this.SodiumLabel.Size = new System.Drawing.Size(46, 13);
            this.SodiumLabel.TabIndex = 12;
            this.SodiumLabel.Text = "MaxSod";
            // 
            // SodiumUpDown
            // 
            this.SodiumUpDown.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.SodiumUpDown.Location = new System.Drawing.Point(80, 96);
            this.SodiumUpDown.Maximum = new decimal(new int[] {
            320,
            0,
            0,
            0});
            this.SodiumUpDown.Name = "SodiumUpDown";
            this.SodiumUpDown.Size = new System.Drawing.Size(48, 20);
            this.SodiumUpDown.TabIndex = 13;
            // 
            // CheckCals
            // 
            this.CheckCals.AutoSize = true;
            this.CheckCals.Checked = true;
            this.CheckCals.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckCals.Location = new System.Drawing.Point(166, 6);
            this.CheckCals.Name = "CheckCals";
            this.CheckCals.Size = new System.Drawing.Size(15, 14);
            this.CheckCals.TabIndex = 14;
            this.CheckCals.UseVisualStyleBackColor = true;
            // 
            // CheckProtein
            // 
            this.CheckProtein.AutoSize = true;
            this.CheckProtein.Checked = true;
            this.CheckProtein.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckProtein.Location = new System.Drawing.Point(166, 35);
            this.CheckProtein.Name = "CheckProtein";
            this.CheckProtein.Size = new System.Drawing.Size(15, 14);
            this.CheckProtein.TabIndex = 15;
            this.CheckProtein.UseVisualStyleBackColor = true;
            // 
            // CheckFat
            // 
            this.CheckFat.AutoSize = true;
            this.CheckFat.Checked = true;
            this.CheckFat.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckFat.Location = new System.Drawing.Point(166, 64);
            this.CheckFat.Name = "CheckFat";
            this.CheckFat.Size = new System.Drawing.Size(15, 14);
            this.CheckFat.TabIndex = 16;
            this.CheckFat.UseVisualStyleBackColor = true;
            // 
            // CheckSodium
            // 
            this.CheckSodium.AutoSize = true;
            this.CheckSodium.Checked = true;
            this.CheckSodium.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckSodium.Location = new System.Drawing.Point(166, 96);
            this.CheckSodium.Name = "CheckSodium";
            this.CheckSodium.Size = new System.Drawing.Size(15, 14);
            this.CheckSodium.TabIndex = 17;
            this.CheckSodium.UseVisualStyleBackColor = true;
            // 
            // FiberLabel
            // 
            this.FiberLabel.AutoSize = true;
            this.FiberLabel.Location = new System.Drawing.Point(6, 122);
            this.FiberLabel.Name = "FiberLabel";
            this.FiberLabel.Size = new System.Drawing.Size(38, 13);
            this.FiberLabel.TabIndex = 18;
            this.FiberLabel.Text = "MinFib";
            // 
            // FiberUpDown
            // 
            this.FiberUpDown.DecimalPlaces = 1;
            this.FiberUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.FiberUpDown.Location = new System.Drawing.Point(80, 125);
            this.FiberUpDown.Maximum = new decimal(new int[] {
            14,
            0,
            0,
            0});
            this.FiberUpDown.Name = "FiberUpDown";
            this.FiberUpDown.Size = new System.Drawing.Size(48, 20);
            this.FiberUpDown.TabIndex = 19;
            // 
            // CheckFiber
            // 
            this.CheckFiber.AutoSize = true;
            this.CheckFiber.Checked = true;
            this.CheckFiber.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckFiber.Location = new System.Drawing.Point(166, 125);
            this.CheckFiber.Name = "CheckFiber";
            this.CheckFiber.Size = new System.Drawing.Size(15, 14);
            this.CheckFiber.TabIndex = 20;
            this.CheckFiber.UseVisualStyleBackColor = true;
            // 
            // CarbLabel
            // 
            this.CarbLabel.AutoSize = true;
            this.CarbLabel.Location = new System.Drawing.Point(6, 151);
            this.CarbLabel.Name = "CarbLabel";
            this.CarbLabel.Size = new System.Drawing.Size(54, 13);
            this.CarbLabel.TabIndex = 21;
            this.CarbLabel.Text = "MaxCarbs";
            // 
            // CarbUpDown
            // 
            this.CarbUpDown.DecimalPlaces = 1;
            this.CarbUpDown.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.CarbUpDown.Location = new System.Drawing.Point(80, 154);
            this.CarbUpDown.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.CarbUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.CarbUpDown.Name = "CarbUpDown";
            this.CarbUpDown.Size = new System.Drawing.Size(48, 20);
            this.CarbUpDown.TabIndex = 22;
            // 
            // CheckCarbs
            // 
            this.CheckCarbs.AutoSize = true;
            this.CheckCarbs.Checked = true;
            this.CheckCarbs.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckCarbs.Location = new System.Drawing.Point(166, 154);
            this.CheckCarbs.Name = "CheckCarbs";
            this.CheckCarbs.Size = new System.Drawing.Size(15, 14);
            this.CheckCarbs.TabIndex = 23;
            this.CheckCarbs.UseVisualStyleBackColor = true;
            // 
            // SugarsLabel
            // 
            this.SugarsLabel.AutoSize = true;
            this.SugarsLabel.Location = new System.Drawing.Point(6, 180);
            this.SugarsLabel.Name = "SugarsLabel";
            this.SugarsLabel.Size = new System.Drawing.Size(46, 13);
            this.SugarsLabel.TabIndex = 24;
            this.SugarsLabel.Text = "MaxSug";
            // 
            // SugarUpDown
            // 
            this.SugarUpDown.Location = new System.Drawing.Point(80, 183);
            this.SugarUpDown.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.SugarUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.SugarUpDown.Name = "SugarUpDown";
            this.SugarUpDown.Size = new System.Drawing.Size(48, 20);
            this.SugarUpDown.TabIndex = 25;
            // 
            // CheckSugar
            // 
            this.CheckSugar.AutoSize = true;
            this.CheckSugar.Checked = true;
            this.CheckSugar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckSugar.Location = new System.Drawing.Point(166, 183);
            this.CheckSugar.Name = "CheckSugar";
            this.CheckSugar.Size = new System.Drawing.Size(15, 14);
            this.CheckSugar.TabIndex = 26;
            this.CheckSugar.UseVisualStyleBackColor = true;
            // 
            // PotassLabel
            // 
            this.PotassLabel.AutoSize = true;
            this.PotassLabel.Location = new System.Drawing.Point(6, 209);
            this.PotassLabel.Name = "PotassLabel";
            this.PotassLabel.Size = new System.Drawing.Size(56, 13);
            this.PotassLabel.TabIndex = 27;
            this.PotassLabel.Text = "MinPotass";
            // 
            // PotassUpDown
            // 
            this.PotassUpDown.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.PotassUpDown.Location = new System.Drawing.Point(80, 212);
            this.PotassUpDown.Maximum = new decimal(new int[] {
            330,
            0,
            0,
            0});
            this.PotassUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.PotassUpDown.Name = "PotassUpDown";
            this.PotassUpDown.Size = new System.Drawing.Size(48, 20);
            this.PotassUpDown.TabIndex = 28;
            // 
            // CheckPotass
            // 
            this.CheckPotass.AutoSize = true;
            this.CheckPotass.Checked = true;
            this.CheckPotass.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckPotass.Location = new System.Drawing.Point(166, 212);
            this.CheckPotass.Name = "CheckPotass";
            this.CheckPotass.Size = new System.Drawing.Size(15, 14);
            this.CheckPotass.TabIndex = 29;
            this.CheckPotass.UseVisualStyleBackColor = true;
            // 
            // VitaminLabel
            // 
            this.VitaminLabel.AutoSize = true;
            this.VitaminLabel.Location = new System.Drawing.Point(6, 238);
            this.VitaminLabel.Name = "VitaminLabel";
            this.VitaminLabel.Size = new System.Drawing.Size(41, 13);
            this.VitaminLabel.TabIndex = 30;
            this.VitaminLabel.Text = "MinVits";
            // 
            // VitaminUpDown
            // 
            this.VitaminUpDown.Increment = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.VitaminUpDown.Location = new System.Drawing.Point(80, 241);
            this.VitaminUpDown.Name = "VitaminUpDown";
            this.VitaminUpDown.Size = new System.Drawing.Size(48, 20);
            this.VitaminUpDown.TabIndex = 31;
            // 
            // CheckVits
            // 
            this.CheckVits.AutoSize = true;
            this.CheckVits.Checked = true;
            this.CheckVits.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckVits.Location = new System.Drawing.Point(166, 241);
            this.CheckVits.Name = "CheckVits";
            this.CheckVits.Size = new System.Drawing.Size(15, 14);
            this.CheckVits.TabIndex = 32;
            this.CheckVits.UseVisualStyleBackColor = true;
            // 
            // ShelfLifeLabel
            // 
            this.ShelfLifeLabel.AutoSize = true;
            this.ShelfLifeLabel.Location = new System.Drawing.Point(6, 267);
            this.ShelfLifeLabel.Name = "ShelfLifeLabel";
            this.ShelfLifeLabel.Size = new System.Drawing.Size(41, 13);
            this.ShelfLifeLabel.TabIndex = 33;
            this.ShelfLifeLabel.Text = "MinLife";
            // 
            // ShelfLifeUpDown
            // 
            this.ShelfLifeUpDown.Location = new System.Drawing.Point(80, 270);
            this.ShelfLifeUpDown.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.ShelfLifeUpDown.Name = "ShelfLifeUpDown";
            this.ShelfLifeUpDown.Size = new System.Drawing.Size(48, 20);
            this.ShelfLifeUpDown.TabIndex = 34;
            // 
            // CheckLife
            // 
            this.CheckLife.AutoSize = true;
            this.CheckLife.Checked = true;
            this.CheckLife.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckLife.Location = new System.Drawing.Point(166, 270);
            this.CheckLife.Name = "CheckLife";
            this.CheckLife.Size = new System.Drawing.Size(15, 14);
            this.CheckLife.TabIndex = 35;
            this.CheckLife.UseVisualStyleBackColor = true;
            // 
            // ServeSizeLabel
            // 
            this.ServeSizeLabel.AutoSize = true;
            this.ServeSizeLabel.Location = new System.Drawing.Point(6, 296);
            this.ServeSizeLabel.Name = "ServeSizeLabel";
            this.ServeSizeLabel.Size = new System.Drawing.Size(65, 13);
            this.ServeSizeLabel.TabIndex = 36;
            this.ServeSizeLabel.Text = "MinServings";
            // 
            // ServingsUpDown
            // 
            this.ServingsUpDown.DecimalPlaces = 2;
            this.ServingsUpDown.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.ServingsUpDown.Location = new System.Drawing.Point(80, 299);
            this.ServingsUpDown.Maximum = new decimal(new int[] {
            125,
            0,
            0,
            131072});
            this.ServingsUpDown.Name = "ServingsUpDown";
            this.ServingsUpDown.Size = new System.Drawing.Size(48, 20);
            this.ServingsUpDown.TabIndex = 37;
            // 
            // CheckServings
            // 
            this.CheckServings.AutoSize = true;
            this.CheckServings.Checked = true;
            this.CheckServings.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckServings.Location = new System.Drawing.Point(166, 299);
            this.CheckServings.Name = "CheckServings";
            this.CheckServings.Size = new System.Drawing.Size(15, 14);
            this.CheckServings.TabIndex = 38;
            this.CheckServings.UseVisualStyleBackColor = true;
            // 
            // RatingLabel
            // 
            this.RatingLabel.AutoSize = true;
            this.RatingLabel.Location = new System.Drawing.Point(6, 325);
            this.RatingLabel.Name = "RatingLabel";
            this.RatingLabel.Size = new System.Drawing.Size(55, 13);
            this.RatingLabel.TabIndex = 39;
            this.RatingLabel.Text = "MinRating";
            // 
            // CheckRating
            // 
            this.CheckRating.AutoSize = true;
            this.CheckRating.Checked = true;
            this.CheckRating.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckRating.Location = new System.Drawing.Point(166, 328);
            this.CheckRating.Name = "CheckRating";
            this.CheckRating.Size = new System.Drawing.Size(15, 14);
            this.CheckRating.TabIndex = 40;
            this.CheckRating.UseVisualStyleBackColor = true;
            // 
            // RatingUpDown
            // 
            this.RatingUpDown.DecimalPlaces = 5;
            this.RatingUpDown.Increment = new decimal(new int[] {
            55,
            0,
            0,
            65536});
            this.RatingUpDown.Location = new System.Drawing.Point(80, 328);
            this.RatingUpDown.Maximum = new decimal(new int[] {
            93,
            0,
            0,
            0});
            this.RatingUpDown.Name = "RatingUpDown";
            this.RatingUpDown.Size = new System.Drawing.Size(67, 20);
            this.RatingUpDown.TabIndex = 41;
            // 
            // HotColdLabel
            // 
            this.HotColdLabel.AutoSize = true;
            this.HotColdLabel.Location = new System.Drawing.Point(6, 354);
            this.HotColdLabel.Name = "HotColdLabel";
            this.HotColdLabel.Size = new System.Drawing.Size(58, 13);
            this.HotColdLabel.TabIndex = 42;
            this.HotColdLabel.Text = "ServeStyle";
            // 
            // CheckHot
            // 
            this.CheckHot.AutoSize = true;
            this.CheckHot.Checked = true;
            this.CheckHot.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckHot.Location = new System.Drawing.Point(80, 357);
            this.CheckHot.Name = "CheckHot";
            this.CheckHot.Size = new System.Drawing.Size(77, 17);
            this.CheckHot.TabIndex = 43;
            this.CheckHot.Text = "ServedHot";
            this.CheckHot.UseVisualStyleBackColor = true;
            // 
            // CheckCold
            // 
            this.CheckCold.AutoSize = true;
            this.CheckCold.Checked = true;
            this.CheckCold.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckCold.Location = new System.Drawing.Point(166, 357);
            this.CheckCold.Name = "CheckCold";
            this.CheckCold.Size = new System.Drawing.Size(81, 17);
            this.CheckCold.TabIndex = 44;
            this.CheckCold.Text = "ServedCold";
            this.CheckCold.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1540, 845);
            this.Controls.Add(this.RefineLayouPanel);
            this.Controls.Add(this.SortedCerealList);
            this.Controls.Add(this.CerealGridView);
            this.Controls.Add(this.SortButton);
            this.Name = "Form1";
            this.Text = "Extreme Cereal Sorter";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CerealGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SortedCerealList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CaloriesUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProteinUpDown)).EndInit();
            this.RefineLayouPanel.ResumeLayout(false);
            this.RefineLayouPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FatUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SodiumUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FiberUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarbUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SugarUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PotassUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VitaminUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShelfLifeUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ServingsUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RatingUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SortButton;
        private System.Windows.Forms.DataGridView CerealGridView;
        private System.Windows.Forms.DataGridView SortedCerealList;
        private System.Windows.Forms.NumericUpDown CaloriesUpDown;
        private System.Windows.Forms.Label CaloriesLabel;
        private System.Windows.Forms.Label ProteinLabel;
        private System.Windows.Forms.NumericUpDown ProteinUpDown;
        private System.Windows.Forms.TableLayoutPanel RefineLayouPanel;
        private System.Windows.Forms.Label FatLabel;
        private System.Windows.Forms.NumericUpDown FatUpDown;
        private System.Windows.Forms.Label SodiumLabel;
        private System.Windows.Forms.NumericUpDown SodiumUpDown;
        private System.Windows.Forms.CheckBox CheckCals;
        private System.Windows.Forms.CheckBox CheckProtein;
        private System.Windows.Forms.CheckBox CheckFat;
        private System.Windows.Forms.CheckBox CheckSodium;
        private System.Windows.Forms.Label FiberLabel;
        private System.Windows.Forms.NumericUpDown FiberUpDown;
        private System.Windows.Forms.CheckBox CheckFiber;
        private System.Windows.Forms.Label CarbLabel;
        private System.Windows.Forms.NumericUpDown CarbUpDown;
        private System.Windows.Forms.CheckBox CheckCarbs;
        private System.Windows.Forms.Label SugarsLabel;
        private System.Windows.Forms.NumericUpDown SugarUpDown;
        private System.Windows.Forms.CheckBox CheckSugar;
        private System.Windows.Forms.Label PotassLabel;
        private System.Windows.Forms.NumericUpDown PotassUpDown;
        private System.Windows.Forms.CheckBox CheckPotass;
        private System.Windows.Forms.Label VitaminLabel;
        private System.Windows.Forms.NumericUpDown VitaminUpDown;
        private System.Windows.Forms.CheckBox CheckVits;
        private System.Windows.Forms.Label ShelfLifeLabel;
        private System.Windows.Forms.NumericUpDown ShelfLifeUpDown;
        private System.Windows.Forms.CheckBox CheckLife;
        private System.Windows.Forms.Label ServeSizeLabel;
        private System.Windows.Forms.NumericUpDown ServingsUpDown;
        private System.Windows.Forms.CheckBox CheckServings;
        private System.Windows.Forms.Label RatingLabel;
        private System.Windows.Forms.CheckBox CheckRating;
        private System.Windows.Forms.NumericUpDown RatingUpDown;
        private System.Windows.Forms.Label HotColdLabel;
        private System.Windows.Forms.CheckBox CheckHot;
        private System.Windows.Forms.CheckBox CheckCold;
    }
}

