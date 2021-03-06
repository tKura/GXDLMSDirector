//
// --------------------------------------------------------------------------
//  Gurux Ltd
// 
//
//
// Filename:        $HeadURL: svn://utopia/projects/GXDLMSDirector/Development/ManufacturersForm.Designer.cs $
//
// Version:         $Revision: 5861 $,
//                  $Date: 2012-12-03 11:23:25 +0200 (ma, 03 joulu 2012) $
//                  $Author: kurumi $
//
// Copyright (c) Gurux Ltd
//
//---------------------------------------------------------------------------
//
//  DESCRIPTION
//
// This file is a part of Gurux Device Framework.
//
// Gurux Device Framework is Open Source software; you can redistribute it
// and/or modify it under the terms of the GNU General Public License 
// as published by the Free Software Foundation; version 2 of the License.
// Gurux Device Framework is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of 
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. 
// See the GNU General Public License for more details.
//
// More information of Gurux DLMS/COSEM Director: http://www.gurux.org/GXDLMSDirector
//
// This code is licensed under the GNU General Public License v2. 
// Full text may be retrieved at http://www.gnu.org/licenses/gpl-2.0.txt
//---------------------------------------------------------------------------

namespace GXDLMSDirector
{
    partial class ManufacturersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManufacturersForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.OKBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.ManufacturersList = new System.Windows.Forms.ListView();
            this.NameCH = new System.Windows.Forms.ColumnHeader();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panel2 = new System.Windows.Forms.Panel();
            this.InactivityModeTB = new System.Windows.Forms.TextBox();
            this.InactivityModeLbl = new System.Windows.Forms.Label();
            this.StartProtocolTB = new System.Windows.Forms.TextBox();
            this.StartProtocolLbl = new System.Windows.Forms.Label();
            this.EditBtn = new System.Windows.Forms.Button();
            this.UseIEC47CB = new System.Windows.Forms.CheckBox();
            this.RemoveBtn = new System.Windows.Forms.Button();
            this.NewBtn = new System.Windows.Forms.Button();
            this.UseLNCB = new System.Windows.Forms.CheckBox();
            this.ManufacturerIdTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NameTB = new System.Windows.Forms.TextBox();
            this.NameLbl = new System.Windows.Forms.Label();
            this.DownloadLatestBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.DownloadLatestBtn);
            this.panel1.Controls.Add(this.OKBtn);
            this.panel1.Controls.Add(this.CancelBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 316);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(445, 46);
            this.panel1.TabIndex = 4;
            // 
            // OKBtn
            // 
            this.OKBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OKBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OKBtn.Location = new System.Drawing.Point(277, 11);
            this.OKBtn.Name = "OKBtn";
            this.OKBtn.Size = new System.Drawing.Size(75, 23);
            this.OKBtn.TabIndex = 7;
            this.OKBtn.Text = "&OK";
            this.OKBtn.UseVisualStyleBackColor = true;
            this.OKBtn.Click += new System.EventHandler(this.OKBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelBtn.Location = new System.Drawing.Point(358, 11);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelBtn.TabIndex = 8;
            this.CancelBtn.Text = "&Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            // 
            // ManufacturersList
            // 
            this.ManufacturersList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NameCH});
            this.ManufacturersList.Dock = System.Windows.Forms.DockStyle.Left;
            this.ManufacturersList.FullRowSelect = true;
            this.ManufacturersList.HideSelection = false;
            this.ManufacturersList.Location = new System.Drawing.Point(0, 0);
            this.ManufacturersList.MultiSelect = false;
            this.ManufacturersList.Name = "ManufacturersList";
            this.ManufacturersList.Size = new System.Drawing.Size(185, 316);
            this.ManufacturersList.TabIndex = 0;
            this.ManufacturersList.UseCompatibleStateImageBehavior = false;
            this.ManufacturersList.View = System.Windows.Forms.View.Details;
            this.ManufacturersList.SelectedIndexChanged += new System.EventHandler(this.ManufacturersList_SelectedIndexChanged);
            // 
            // NameCH
            // 
            this.NameCH.Text = "Name";
            this.NameCH.Width = 181;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(185, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 316);
            this.splitter1.TabIndex = 5;
            this.splitter1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.InactivityModeTB);
            this.panel2.Controls.Add(this.InactivityModeLbl);
            this.panel2.Controls.Add(this.StartProtocolTB);
            this.panel2.Controls.Add(this.StartProtocolLbl);
            this.panel2.Controls.Add(this.EditBtn);
            this.panel2.Controls.Add(this.UseIEC47CB);
            this.panel2.Controls.Add(this.RemoveBtn);
            this.panel2.Controls.Add(this.NewBtn);
            this.panel2.Controls.Add(this.UseLNCB);
            this.panel2.Controls.Add(this.ManufacturerIdTB);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.NameTB);
            this.panel2.Controls.Add(this.NameLbl);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(188, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(257, 316);
            this.panel2.TabIndex = 14;
            // 
            // InactivityModeTB
            // 
            this.InactivityModeTB.Location = new System.Drawing.Point(116, 117);
            this.InactivityModeTB.Name = "InactivityModeTB";
            this.InactivityModeTB.Size = new System.Drawing.Size(129, 20);
            this.InactivityModeTB.TabIndex = 25;
            // 
            // InactivityModeLbl
            // 
            this.InactivityModeLbl.AutoSize = true;
            this.InactivityModeLbl.Location = new System.Drawing.Point(10, 121);
            this.InactivityModeLbl.Name = "InactivityModeLbl";
            this.InactivityModeLbl.Size = new System.Drawing.Size(82, 13);
            this.InactivityModeLbl.TabIndex = 24;
            this.InactivityModeLbl.Text = "Inactivity Mode:";
            // 
            // StartProtocolTB
            // 
            this.StartProtocolTB.Location = new System.Drawing.Point(116, 143);
            this.StartProtocolTB.Name = "StartProtocolTB";
            this.StartProtocolTB.Size = new System.Drawing.Size(129, 20);
            this.StartProtocolTB.TabIndex = 22;
            // 
            // StartProtocolLbl
            // 
            this.StartProtocolLbl.AutoSize = true;
            this.StartProtocolLbl.Location = new System.Drawing.Point(10, 147);
            this.StartProtocolLbl.Name = "StartProtocolLbl";
            this.StartProtocolLbl.Size = new System.Drawing.Size(74, 13);
            this.StartProtocolLbl.TabIndex = 21;
            this.StartProtocolLbl.Text = "Start Protocol:";
            // 
            // EditBtn
            // 
            this.EditBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.EditBtn.Location = new System.Drawing.Point(91, 287);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(75, 23);
            this.EditBtn.TabIndex = 2;
            this.EditBtn.Text = "Edit";
            this.EditBtn.UseVisualStyleBackColor = true;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // UseIEC47CB
            // 
            this.UseIEC47CB.AutoSize = true;
            this.UseIEC47CB.Location = new System.Drawing.Point(10, 98);
            this.UseIEC47CB.Name = "UseIEC47CB";
            this.UseIEC47CB.Size = new System.Drawing.Size(113, 17);
            this.UseIEC47CB.TabIndex = 14;
            this.UseIEC47CB.Text = "Use IEC 62056-47";
            this.UseIEC47CB.UseVisualStyleBackColor = true;
            // 
            // RemoveBtn
            // 
            this.RemoveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RemoveBtn.Location = new System.Drawing.Point(170, 287);
            this.RemoveBtn.Name = "RemoveBtn";
            this.RemoveBtn.Size = new System.Drawing.Size(75, 23);
            this.RemoveBtn.TabIndex = 3;
            this.RemoveBtn.Text = "Remove";
            this.RemoveBtn.UseVisualStyleBackColor = true;
            this.RemoveBtn.Click += new System.EventHandler(this.RemoveBtn_Click);
            // 
            // NewBtn
            // 
            this.NewBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.NewBtn.Location = new System.Drawing.Point(10, 287);
            this.NewBtn.Name = "NewBtn";
            this.NewBtn.Size = new System.Drawing.Size(75, 23);
            this.NewBtn.TabIndex = 1;
            this.NewBtn.Text = "New";
            this.NewBtn.UseVisualStyleBackColor = true;
            this.NewBtn.Click += new System.EventHandler(this.NewBtn_Click);
            // 
            // UseLNCB
            // 
            this.UseLNCB.AutoSize = true;
            this.UseLNCB.Location = new System.Drawing.Point(10, 80);
            this.UseLNCB.Name = "UseLNCB";
            this.UseLNCB.Size = new System.Drawing.Size(167, 17);
            this.UseLNCB.TabIndex = 13;
            this.UseLNCB.Text = "Use Logical name referencing";
            this.UseLNCB.UseVisualStyleBackColor = true;
            // 
            // ManufacturerIdTB
            // 
            this.ManufacturerIdTB.Location = new System.Drawing.Point(116, 50);
            this.ManufacturerIdTB.Name = "ManufacturerIdTB";
            this.ManufacturerIdTB.Size = new System.Drawing.Size(129, 20);
            this.ManufacturerIdTB.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Manufacturer ID:";
            // 
            // NameTB
            // 
            this.NameTB.Location = new System.Drawing.Point(7, 25);
            this.NameTB.Name = "NameTB";
            this.NameTB.Size = new System.Drawing.Size(238, 20);
            this.NameTB.TabIndex = 11;
            // 
            // NameLbl
            // 
            this.NameLbl.AutoSize = true;
            this.NameLbl.Location = new System.Drawing.Point(7, 9);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(104, 13);
            this.NameLbl.TabIndex = 15;
            this.NameLbl.Text = "Manufacturer Name:";
            // 
            // DownloadLatestBtn
            // 
            this.DownloadLatestBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DownloadLatestBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.DownloadLatestBtn.Location = new System.Drawing.Point(12, 11);
            this.DownloadLatestBtn.Name = "DownloadLatestBtn";
            this.DownloadLatestBtn.Size = new System.Drawing.Size(113, 23);
            this.DownloadLatestBtn.TabIndex = 9;
            this.DownloadLatestBtn.Text = "Update Online...";
            this.DownloadLatestBtn.UseVisualStyleBackColor = true;
            this.DownloadLatestBtn.Click += new System.EventHandler(this.DownloadLatestBtn_Click);
            // 
            // ManufacturersForm
            // 
            this.AcceptButton = this.OKBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelBtn;
            this.ClientSize = new System.Drawing.Size(445, 362);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.ManufacturersList);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ManufacturersForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Manufacturers";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button OKBtn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.ListView ManufacturersList;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.CheckBox UseIEC47CB;
        private System.Windows.Forms.Button RemoveBtn;
        private System.Windows.Forms.Button NewBtn;
        private System.Windows.Forms.CheckBox UseLNCB;
        private System.Windows.Forms.TextBox ManufacturerIdTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NameTB;
        private System.Windows.Forms.Label NameLbl;
        private System.Windows.Forms.ColumnHeader NameCH;
        private System.Windows.Forms.TextBox StartProtocolTB;
        private System.Windows.Forms.Label StartProtocolLbl;
        private System.Windows.Forms.TextBox InactivityModeTB;
        private System.Windows.Forms.Label InactivityModeLbl;
        private System.Windows.Forms.Button DownloadLatestBtn;

    }
}