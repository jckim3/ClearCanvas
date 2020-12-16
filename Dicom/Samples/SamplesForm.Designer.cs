#region License

// Copyright (c) 2006-2007, ClearCanvas Inc.
// All rights reserved.
//
// Redistribution and use in source and binary forms, with or without modification, 
// are permitted provided that the following conditions are met:
//
//    * Redistributions of source code must retain the above copyright notice, 
//      this list of conditions and the following disclaimer.
//    * Redistributions in binary form must reproduce the above copyright notice, 
//      this list of conditions and the following disclaimer in the documentation 
//      and/or other materials provided with the distribution.
//    * Neither the name of ClearCanvas Inc. nor the names of its contributors 
//      may be used to endorse or promote products derived from this software without 
//      specific prior written permission.
//
// THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" 
// AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, 
// THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR 
// PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT OWNER OR 
// CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, 
// OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE 
// GOODS OR SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) 
// HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, 
// STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN 
// ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY 
// OF SUCH DAMAGE.

#endregion

namespace ClearCanvas.Dicom.Samples
{
    partial class SamplesForm
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
            this.SamplesSplitContainer = new System.Windows.Forms.SplitContainer();
            this.SamplesTabs = new System.Windows.Forms.TabControl();
            this.StorageScuTab = new System.Windows.Forms.TabPage();
            this._buttonStorageScuClearFiles = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this._textBoxStorageScuLocalAe = new System.Windows.Forms.TextBox();
            this._buttonStorageScuVerify = new System.Windows.Forms.Button();
            this._buttonStorageScuSelectDirectory = new System.Windows.Forms.Button();
            this._buttonStorageScuConnect = new System.Windows.Forms.Button();
            this.buttonStorageScuSelectFiles = new System.Windows.Forms.Button();
            this._textBoxStorageScuRemotePort = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this._textBoxStorageScuRemoteHost = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this._textBoxStorageScuRemoteAe = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.StorageScpTab = new System.Windows.Forms.TabPage();
            this._checkBoxStorageScpList = new System.Windows.Forms.CheckBox();
            this._checkBoxStorageScpRLE = new System.Windows.Forms.CheckBox();
            this._checkBoxStorageScpJ2KLossy = new System.Windows.Forms.CheckBox();
            this._checkBoxStorageScpJ2KLossless = new System.Windows.Forms.CheckBox();
            this._checkBoxStorageScpJpegLossy = new System.Windows.Forms.CheckBox();
            this._checkBoxStorageScpJpegLossless = new System.Windows.Forms.CheckBox();
            this._checkBoxStorageScpBitbucket = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this._textBoxStorageScpAeTitle = new System.Windows.Forms.TextBox();
            this._buttonStorageScuSelectStorageLocation = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this._textBoxStorageScpStorageLocation = new System.Windows.Forms.TextBox();
            this._buttonStorageScpStartStop = new System.Windows.Forms.Button();
            this._textBoxStorageScpPort = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CompressionTab = new System.Windows.Forms.TabPage();
            this._savePixelsButton = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this._sourceTransferSyntaxCombo = new System.Windows.Forms.ComboBox();
            this._destinationSyntaxCombo = new System.Windows.Forms.ComboBox();
            this._destinationPathTextBox = new System.Windows.Forms.TextBox();
            this._sourcePathTextBox = new System.Windows.Forms.TextBox();
            this._saveFileButton = new System.Windows.Forms.Button();
            this._openFileButton = new System.Windows.Forms.Button();
            this.queryScuTab = new System.Windows.Forms.TabPage();
            this.label18 = new System.Windows.Forms.Label();
            this.comboBoxQueryScuQueryLevel = new System.Windows.Forms.ComboBox();
            this.textBoxQueryScuMaxResults = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.comboBoxQueryScuQueryType = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxQueryScuLocalAe = new System.Windows.Forms.TextBox();
            this.textBoxQueryScuRemotePort = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxQueryScuRemoteHost = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBoxQueryScuRemoteAe = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBoxQueryMessage = new System.Windows.Forms.TextBox();
            this.buttonQueryScuSearch = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonSendDicomdir = new System.Windows.Forms.Button();
            this._textBoxDicomdirRemotePort = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this._textBoxDicomdirRemoteHost = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this._textBoxDicomdirRemoteAe = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this._buttonOpenDicomdir = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this._textBoxDicomdir = new System.Windows.Forms.TextBox();
            this.moveScuTab = new System.Windows.Forms.TabPage();
            this.label23 = new System.Windows.Forms.Label();
            this.comboBoxMoveScuQueryLevel = new System.Windows.Forms.ComboBox();
            this.textBoxMoveScuMoveDestination = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.comboBoxMoveScuQueryType = new System.Windows.Forms.ComboBox();
            this.label26 = new System.Windows.Forms.Label();
            this.textBoxMoveScuLocalAe = new System.Windows.Forms.TextBox();
            this.textBoxMoveScuRemotePort = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.textBoxMoveScuRemoteHost = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.textBoxMoveScuRemoteAe = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.textBoxMoveMessage = new System.Windows.Forms.TextBox();
            this.buttonMoveScuMove = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this._editSopTextBox = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this._editSopDestinationPathTextBox = new System.Windows.Forms.TextBox();
            this._editSopSourcePathTextBox = new System.Windows.Forms.TextBox();
            this._editSopSaveFileButton = new System.Windows.Forms.Button();
            this._editSopOpenFileButton = new System.Windows.Forms.Button();
            this._buttonOutputClearLog = new System.Windows.Forms.Button();
            this.OutputTextBox = new System.Windows.Forms.TextBox();
            this.openFileDialogStorageScu = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialogStorageScp = new System.Windows.Forms.FolderBrowserDialog();
            this.folderBrowserDialogStorageScu = new System.Windows.Forms.FolderBrowserDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.SamplesSplitContainer)).BeginInit();
            this.SamplesSplitContainer.Panel1.SuspendLayout();
            this.SamplesSplitContainer.Panel2.SuspendLayout();
            this.SamplesSplitContainer.SuspendLayout();
            this.SamplesTabs.SuspendLayout();
            this.StorageScuTab.SuspendLayout();
            this.StorageScpTab.SuspendLayout();
            this.CompressionTab.SuspendLayout();
            this.queryScuTab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.moveScuTab.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // SamplesSplitContainer
            // 
            this.SamplesSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SamplesSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.SamplesSplitContainer.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.SamplesSplitContainer.Name = "SamplesSplitContainer";
            this.SamplesSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // SamplesSplitContainer.Panel1
            // 
            this.SamplesSplitContainer.Panel1.Controls.Add(this.SamplesTabs);
            this.SamplesSplitContainer.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // SamplesSplitContainer.Panel2
            // 
            this.SamplesSplitContainer.Panel2.Controls.Add(this._buttonOutputClearLog);
            this.SamplesSplitContainer.Panel2.Controls.Add(this.OutputTextBox);
            this.SamplesSplitContainer.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SamplesSplitContainer.Size = new System.Drawing.Size(1848, 1135);
            this.SamplesSplitContainer.SplitterDistance = 298;
            this.SamplesSplitContainer.SplitterWidth = 8;
            this.SamplesSplitContainer.TabIndex = 0;
            // 
            // SamplesTabs
            // 
            this.SamplesTabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SamplesTabs.Controls.Add(this.StorageScuTab);
            this.SamplesTabs.Controls.Add(this.StorageScpTab);
            this.SamplesTabs.Controls.Add(this.CompressionTab);
            this.SamplesTabs.Controls.Add(this.queryScuTab);
            this.SamplesTabs.Controls.Add(this.tabPage1);
            this.SamplesTabs.Controls.Add(this.moveScuTab);
            this.SamplesTabs.Controls.Add(this.tabPage2);
            this.SamplesTabs.Location = new System.Drawing.Point(6, 0);
            this.SamplesTabs.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.SamplesTabs.Name = "SamplesTabs";
            this.SamplesTabs.SelectedIndex = 0;
            this.SamplesTabs.Size = new System.Drawing.Size(1836, 292);
            this.SamplesTabs.TabIndex = 0;
            // 
            // StorageScuTab
            // 
            this.StorageScuTab.Controls.Add(this._buttonStorageScuClearFiles);
            this.StorageScuTab.Controls.Add(this.label7);
            this.StorageScuTab.Controls.Add(this._textBoxStorageScuLocalAe);
            this.StorageScuTab.Controls.Add(this._buttonStorageScuVerify);
            this.StorageScuTab.Controls.Add(this._buttonStorageScuSelectDirectory);
            this.StorageScuTab.Controls.Add(this._buttonStorageScuConnect);
            this.StorageScuTab.Controls.Add(this.buttonStorageScuSelectFiles);
            this.StorageScuTab.Controls.Add(this._textBoxStorageScuRemotePort);
            this.StorageScuTab.Controls.Add(this.label3);
            this.StorageScuTab.Controls.Add(this._textBoxStorageScuRemoteHost);
            this.StorageScuTab.Controls.Add(this.label2);
            this.StorageScuTab.Controls.Add(this._textBoxStorageScuRemoteAe);
            this.StorageScuTab.Controls.Add(this.label1);
            this.StorageScuTab.Location = new System.Drawing.Point(8, 39);
            this.StorageScuTab.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.StorageScuTab.Name = "StorageScuTab";
            this.StorageScuTab.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.StorageScuTab.Size = new System.Drawing.Size(1820, 245);
            this.StorageScuTab.TabIndex = 0;
            this.StorageScuTab.Text = "StorageSCU";
            this.StorageScuTab.UseVisualStyleBackColor = true;
            // 
            // _buttonStorageScuClearFiles
            // 
            this._buttonStorageScuClearFiles.Location = new System.Drawing.Point(1104, 156);
            this._buttonStorageScuClearFiles.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this._buttonStorageScuClearFiles.Name = "_buttonStorageScuClearFiles";
            this._buttonStorageScuClearFiles.Size = new System.Drawing.Size(200, 44);
            this._buttonStorageScuClearFiles.TabIndex = 12;
            this._buttonStorageScuClearFiles.Text = "Clear Files";
            this._buttonStorageScuClearFiles.UseVisualStyleBackColor = true;
            this._buttonStorageScuClearFiles.Click += new System.EventHandler(this._buttonStorageScuClearFiles_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 33);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 25);
            this.label7.TabIndex = 11;
            this.label7.Text = "Local AE";
            // 
            // _textBoxStorageScuLocalAe
            // 
            this._textBoxStorageScuLocalAe.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::ClearCanvas.Dicom.Samples.Properties.Settings.Default, "ScuLocalAETitle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this._textBoxStorageScuLocalAe.Location = new System.Drawing.Point(18, 65);
            this._textBoxStorageScuLocalAe.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this._textBoxStorageScuLocalAe.Name = "_textBoxStorageScuLocalAe";
            this._textBoxStorageScuLocalAe.Size = new System.Drawing.Size(196, 31);
            this._textBoxStorageScuLocalAe.TabIndex = 10;
            this._textBoxStorageScuLocalAe.Text = global::ClearCanvas.Dicom.Samples.Properties.Settings.Default.ScuLocalAETitle;
            // 
            // _buttonStorageScuVerify
            // 
            this._buttonStorageScuVerify.Location = new System.Drawing.Point(826, 156);
            this._buttonStorageScuVerify.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this._buttonStorageScuVerify.Name = "_buttonStorageScuVerify";
            this._buttonStorageScuVerify.Size = new System.Drawing.Size(200, 44);
            this._buttonStorageScuVerify.TabIndex = 9;
            this._buttonStorageScuVerify.Text = "Verify";
            this._buttonStorageScuVerify.UseVisualStyleBackColor = true;
            this._buttonStorageScuVerify.Click += new System.EventHandler(this._buttonStorageScuVerify_Click);
            // 
            // _buttonStorageScuSelectDirectory
            // 
            this._buttonStorageScuSelectDirectory.Location = new System.Drawing.Point(18, 156);
            this._buttonStorageScuSelectDirectory.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this._buttonStorageScuSelectDirectory.Name = "_buttonStorageScuSelectDirectory";
            this._buttonStorageScuSelectDirectory.Size = new System.Drawing.Size(200, 44);
            this._buttonStorageScuSelectDirectory.TabIndex = 8;
            this._buttonStorageScuSelectDirectory.Text = "Select Directory";
            this._buttonStorageScuSelectDirectory.UseVisualStyleBackColor = true;
            this._buttonStorageScuSelectDirectory.Click += new System.EventHandler(this.buttonStorageScuSelectDirectory_Click);
            // 
            // _buttonStorageScuConnect
            // 
            this._buttonStorageScuConnect.Location = new System.Drawing.Point(548, 156);
            this._buttonStorageScuConnect.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this._buttonStorageScuConnect.Name = "_buttonStorageScuConnect";
            this._buttonStorageScuConnect.Size = new System.Drawing.Size(200, 44);
            this._buttonStorageScuConnect.TabIndex = 7;
            this._buttonStorageScuConnect.Text = "Connect";
            this._buttonStorageScuConnect.UseVisualStyleBackColor = true;
            this._buttonStorageScuConnect.Click += new System.EventHandler(this.ButtonStorageScuConnectClick);
            // 
            // buttonStorageScuSelectFiles
            // 
            this.buttonStorageScuSelectFiles.Location = new System.Drawing.Point(280, 156);
            this.buttonStorageScuSelectFiles.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.buttonStorageScuSelectFiles.Name = "buttonStorageScuSelectFiles";
            this.buttonStorageScuSelectFiles.Size = new System.Drawing.Size(200, 44);
            this.buttonStorageScuSelectFiles.TabIndex = 6;
            this.buttonStorageScuSelectFiles.Text = "Select Files";
            this.buttonStorageScuSelectFiles.UseVisualStyleBackColor = true;
            this.buttonStorageScuSelectFiles.Click += new System.EventHandler(this.ButtonStorageScuSelectFilesClick);
            // 
            // _textBoxStorageScuRemotePort
            // 
            this._textBoxStorageScuRemotePort.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::ClearCanvas.Dicom.Samples.Properties.Settings.Default, "ScuRemotePort", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this._textBoxStorageScuRemotePort.Location = new System.Drawing.Point(826, 67);
            this._textBoxStorageScuRemotePort.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this._textBoxStorageScuRemotePort.Name = "_textBoxStorageScuRemotePort";
            this._textBoxStorageScuRemotePort.Size = new System.Drawing.Size(196, 31);
            this._textBoxStorageScuRemotePort.TabIndex = 5;
            this._textBoxStorageScuRemotePort.Text = global::ClearCanvas.Dicom.Samples.Properties.Settings.Default.ScuRemotePort;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(820, 35);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Remote Port";
            // 
            // _textBoxStorageScuRemoteHost
            // 
            this._textBoxStorageScuRemoteHost.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::ClearCanvas.Dicom.Samples.Properties.Settings.Default, "ScuRemoteHost", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this._textBoxStorageScuRemoteHost.Location = new System.Drawing.Point(548, 67);
            this._textBoxStorageScuRemoteHost.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this._textBoxStorageScuRemoteHost.Name = "_textBoxStorageScuRemoteHost";
            this._textBoxStorageScuRemoteHost.Size = new System.Drawing.Size(196, 31);
            this._textBoxStorageScuRemoteHost.TabIndex = 3;
            this._textBoxStorageScuRemoteHost.Text = global::ClearCanvas.Dicom.Samples.Properties.Settings.Default.ScuRemoteHost;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(542, 35);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Remote Host";
            // 
            // _textBoxStorageScuRemoteAe
            // 
            this._textBoxStorageScuRemoteAe.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::ClearCanvas.Dicom.Samples.Properties.Settings.Default, "ScuRemoteAETitle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this._textBoxStorageScuRemoteAe.Location = new System.Drawing.Point(280, 67);
            this._textBoxStorageScuRemoteAe.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this._textBoxStorageScuRemoteAe.Name = "_textBoxStorageScuRemoteAe";
            this._textBoxStorageScuRemoteAe.Size = new System.Drawing.Size(196, 31);
            this._textBoxStorageScuRemoteAe.TabIndex = 1;
            this._textBoxStorageScuRemoteAe.Text = global::ClearCanvas.Dicom.Samples.Properties.Settings.Default.ScuRemoteAETitle;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(274, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Remote AE";
            // 
            // StorageScpTab
            // 
            this.StorageScpTab.Controls.Add(this._checkBoxStorageScpList);
            this.StorageScpTab.Controls.Add(this._checkBoxStorageScpRLE);
            this.StorageScpTab.Controls.Add(this._checkBoxStorageScpJ2KLossy);
            this.StorageScpTab.Controls.Add(this._checkBoxStorageScpJ2KLossless);
            this.StorageScpTab.Controls.Add(this._checkBoxStorageScpJpegLossy);
            this.StorageScpTab.Controls.Add(this._checkBoxStorageScpJpegLossless);
            this.StorageScpTab.Controls.Add(this._checkBoxStorageScpBitbucket);
            this.StorageScpTab.Controls.Add(this.label6);
            this.StorageScpTab.Controls.Add(this._textBoxStorageScpAeTitle);
            this.StorageScpTab.Controls.Add(this._buttonStorageScuSelectStorageLocation);
            this.StorageScpTab.Controls.Add(this.label5);
            this.StorageScpTab.Controls.Add(this._textBoxStorageScpStorageLocation);
            this.StorageScpTab.Controls.Add(this._buttonStorageScpStartStop);
            this.StorageScpTab.Controls.Add(this._textBoxStorageScpPort);
            this.StorageScpTab.Controls.Add(this.label4);
            this.StorageScpTab.Location = new System.Drawing.Point(8, 39);
            this.StorageScpTab.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.StorageScpTab.Name = "StorageScpTab";
            this.StorageScpTab.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.StorageScpTab.Size = new System.Drawing.Size(1820, 245);
            this.StorageScpTab.TabIndex = 1;
            this.StorageScpTab.Text = "StorageSCP";
            this.StorageScpTab.UseVisualStyleBackColor = true;
            // 
            // _checkBoxStorageScpList
            // 
            this._checkBoxStorageScpList.AutoSize = true;
            this._checkBoxStorageScpList.Location = new System.Drawing.Point(1080, 154);
            this._checkBoxStorageScpList.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this._checkBoxStorageScpList.Name = "_checkBoxStorageScpList";
            this._checkBoxStorageScpList.Size = new System.Drawing.Size(78, 29);
            this._checkBoxStorageScpList.TabIndex = 14;
            this._checkBoxStorageScpList.Text = "List";
            this._checkBoxStorageScpList.UseVisualStyleBackColor = true;
            // 
            // _checkBoxStorageScpRLE
            // 
            this._checkBoxStorageScpRLE.AutoSize = true;
            this._checkBoxStorageScpRLE.Location = new System.Drawing.Point(1542, 192);
            this._checkBoxStorageScpRLE.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this._checkBoxStorageScpRLE.Name = "_checkBoxStorageScpRLE";
            this._checkBoxStorageScpRLE.Size = new System.Drawing.Size(85, 29);
            this._checkBoxStorageScpRLE.TabIndex = 13;
            this._checkBoxStorageScpRLE.Text = "RLE";
            this._checkBoxStorageScpRLE.UseVisualStyleBackColor = true;
            // 
            // _checkBoxStorageScpJ2KLossy
            // 
            this._checkBoxStorageScpJ2KLossy.AutoSize = true;
            this._checkBoxStorageScpJ2KLossy.Location = new System.Drawing.Point(1542, 148);
            this._checkBoxStorageScpJ2KLossy.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this._checkBoxStorageScpJ2KLossy.Name = "_checkBoxStorageScpJ2KLossy";
            this._checkBoxStorageScpJ2KLossy.Size = new System.Drawing.Size(216, 29);
            this._checkBoxStorageScpJ2KLossy.TabIndex = 12;
            this._checkBoxStorageScpJ2KLossy.Text = "JPEG 2000 Lossy";
            this._checkBoxStorageScpJ2KLossy.UseVisualStyleBackColor = true;
            // 
            // _checkBoxStorageScpJ2KLossless
            // 
            this._checkBoxStorageScpJ2KLossless.AutoSize = true;
            this._checkBoxStorageScpJ2KLossless.Location = new System.Drawing.Point(1542, 106);
            this._checkBoxStorageScpJ2KLossless.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this._checkBoxStorageScpJ2KLossless.Name = "_checkBoxStorageScpJ2KLossless";
            this._checkBoxStorageScpJ2KLossless.Size = new System.Drawing.Size(244, 29);
            this._checkBoxStorageScpJ2KLossless.TabIndex = 11;
            this._checkBoxStorageScpJ2KLossless.Text = "JPEG 2000 Lossless";
            this._checkBoxStorageScpJ2KLossless.UseVisualStyleBackColor = true;
            // 
            // _checkBoxStorageScpJpegLossy
            // 
            this._checkBoxStorageScpJpegLossy.AutoSize = true;
            this._checkBoxStorageScpJpegLossy.Location = new System.Drawing.Point(1542, 62);
            this._checkBoxStorageScpJpegLossy.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this._checkBoxStorageScpJpegLossy.Name = "_checkBoxStorageScpJpegLossy";
            this._checkBoxStorageScpJpegLossy.Size = new System.Drawing.Size(162, 29);
            this._checkBoxStorageScpJpegLossy.TabIndex = 10;
            this._checkBoxStorageScpJpegLossy.Text = "JPEG Lossy";
            this._checkBoxStorageScpJpegLossy.UseVisualStyleBackColor = true;
            // 
            // _checkBoxStorageScpJpegLossless
            // 
            this._checkBoxStorageScpJpegLossless.AutoSize = true;
            this._checkBoxStorageScpJpegLossless.Location = new System.Drawing.Point(1542, 17);
            this._checkBoxStorageScpJpegLossless.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this._checkBoxStorageScpJpegLossless.Name = "_checkBoxStorageScpJpegLossless";
            this._checkBoxStorageScpJpegLossless.Size = new System.Drawing.Size(190, 29);
            this._checkBoxStorageScpJpegLossless.TabIndex = 9;
            this._checkBoxStorageScpJpegLossless.Text = "JPEG Lossless";
            this._checkBoxStorageScpJpegLossless.UseVisualStyleBackColor = true;
            // 
            // _checkBoxStorageScpBitbucket
            // 
            this._checkBoxStorageScpBitbucket.AutoSize = true;
            this._checkBoxStorageScpBitbucket.Location = new System.Drawing.Point(880, 154);
            this._checkBoxStorageScpBitbucket.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this._checkBoxStorageScpBitbucket.Name = "_checkBoxStorageScpBitbucket";
            this._checkBoxStorageScpBitbucket.Size = new System.Drawing.Size(133, 29);
            this._checkBoxStorageScpBitbucket.TabIndex = 8;
            this._checkBoxStorageScpBitbucket.Text = "Bitbucket";
            this._checkBoxStorageScpBitbucket.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(236, 37);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 25);
            this.label6.TabIndex = 7;
            this.label6.Text = "AE Title";
            // 
            // _textBoxStorageScpAeTitle
            // 
            this._textBoxStorageScpAeTitle.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::ClearCanvas.Dicom.Samples.Properties.Settings.Default, "ScpAETitle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this._textBoxStorageScpAeTitle.Location = new System.Drawing.Point(236, 71);
            this._textBoxStorageScpAeTitle.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this._textBoxStorageScpAeTitle.Name = "_textBoxStorageScpAeTitle";
            this._textBoxStorageScpAeTitle.Size = new System.Drawing.Size(244, 31);
            this._textBoxStorageScpAeTitle.TabIndex = 6;
            this._textBoxStorageScpAeTitle.Text = global::ClearCanvas.Dicom.Samples.Properties.Settings.Default.ScpAETitle;
            // 
            // _buttonStorageScuSelectStorageLocation
            // 
            this._buttonStorageScuSelectStorageLocation.Location = new System.Drawing.Point(1288, 67);
            this._buttonStorageScuSelectStorageLocation.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this._buttonStorageScuSelectStorageLocation.Name = "_buttonStorageScuSelectStorageLocation";
            this._buttonStorageScuSelectStorageLocation.Size = new System.Drawing.Size(150, 44);
            this._buttonStorageScuSelectStorageLocation.TabIndex = 5;
            this._buttonStorageScuSelectStorageLocation.Text = "Select...";
            this._buttonStorageScuSelectStorageLocation.UseVisualStyleBackColor = true;
            this._buttonStorageScuSelectStorageLocation.Click += new System.EventHandler(this._buttonStorageScuSelectStorageLocation_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(880, 37);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Storage Location";
            // 
            // _textBoxStorageScpStorageLocation
            // 
            this._textBoxStorageScpStorageLocation.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::ClearCanvas.Dicom.Samples.Properties.Settings.Default, "ScpStorageFolder", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this._textBoxStorageScpStorageLocation.Location = new System.Drawing.Point(880, 71);
            this._textBoxStorageScpStorageLocation.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this._textBoxStorageScpStorageLocation.Name = "_textBoxStorageScpStorageLocation";
            this._textBoxStorageScpStorageLocation.Size = new System.Drawing.Size(392, 31);
            this._textBoxStorageScpStorageLocation.TabIndex = 3;
            this._textBoxStorageScpStorageLocation.Text = global::ClearCanvas.Dicom.Samples.Properties.Settings.Default.ScpStorageFolder;
            // 
            // _buttonStorageScpStartStop
            // 
            this._buttonStorageScpStartStop.Location = new System.Drawing.Point(12, 65);
            this._buttonStorageScpStartStop.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this._buttonStorageScpStartStop.Name = "_buttonStorageScpStartStop";
            this._buttonStorageScpStartStop.Size = new System.Drawing.Size(150, 44);
            this._buttonStorageScpStartStop.TabIndex = 2;
            this._buttonStorageScpStartStop.Text = "Start";
            this._buttonStorageScpStartStop.UseVisualStyleBackColor = true;
            this._buttonStorageScpStartStop.Click += new System.EventHandler(this.ButtonStorageScpStartStopClick);
            // 
            // _textBoxStorageScpPort
            // 
            this._textBoxStorageScpPort.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::ClearCanvas.Dicom.Samples.Properties.Settings.Default, "ScpPort", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this._textBoxStorageScpPort.Location = new System.Drawing.Point(582, 71);
            this._textBoxStorageScpPort.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this._textBoxStorageScpPort.Name = "_textBoxStorageScpPort";
            this._textBoxStorageScpPort.Size = new System.Drawing.Size(196, 31);
            this._textBoxStorageScpPort.TabIndex = 1;
            this._textBoxStorageScpPort.Text = global::ClearCanvas.Dicom.Samples.Properties.Settings.Default.ScpPort;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(576, 38);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Port";
            // 
            // CompressionTab
            // 
            this.CompressionTab.Controls.Add(this._savePixelsButton);
            this.CompressionTab.Controls.Add(this.label11);
            this.CompressionTab.Controls.Add(this.label10);
            this.CompressionTab.Controls.Add(this.label9);
            this.CompressionTab.Controls.Add(this.label8);
            this.CompressionTab.Controls.Add(this._sourceTransferSyntaxCombo);
            this.CompressionTab.Controls.Add(this._destinationSyntaxCombo);
            this.CompressionTab.Controls.Add(this._destinationPathTextBox);
            this.CompressionTab.Controls.Add(this._sourcePathTextBox);
            this.CompressionTab.Controls.Add(this._saveFileButton);
            this.CompressionTab.Controls.Add(this._openFileButton);
            this.CompressionTab.Location = new System.Drawing.Point(8, 39);
            this.CompressionTab.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.CompressionTab.Name = "CompressionTab";
            this.CompressionTab.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.CompressionTab.Size = new System.Drawing.Size(1820, 245);
            this.CompressionTab.TabIndex = 2;
            this.CompressionTab.Text = "Compression";
            this.CompressionTab.UseVisualStyleBackColor = true;
            // 
            // _savePixelsButton
            // 
            this._savePixelsButton.Location = new System.Drawing.Point(1484, 138);
            this._savePixelsButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this._savePixelsButton.Name = "_savePixelsButton";
            this._savePixelsButton.Size = new System.Drawing.Size(196, 44);
            this._savePixelsButton.TabIndex = 10;
            this._savePixelsButton.Text = "Save Pixels";
            this._savePixelsButton.UseVisualStyleBackColor = true;
            this._savePixelsButton.Click += new System.EventHandler(this.SavePixelsButtonClick);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1034, 112);
            this.label11.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(278, 25);
            this.label11.TabIndex = 9;
            this.label11.Text = "Destination Transfer Syntax";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1028, 25);
            this.label10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(238, 25);
            this.label10.TabIndex = 8;
            this.label10.Text = "Source Transfer Syntax";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 27);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(171, 25);
            this.label9.TabIndex = 7;
            this.label9.Text = "Source File Path";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 113);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(211, 25);
            this.label8.TabIndex = 6;
            this.label8.Text = "Destination File Path";
            // 
            // _sourceTransferSyntaxCombo
            // 
            this._sourceTransferSyntaxCombo.FormattingEnabled = true;
            this._sourceTransferSyntaxCombo.Location = new System.Drawing.Point(1028, 58);
            this._sourceTransferSyntaxCombo.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this._sourceTransferSyntaxCombo.Name = "_sourceTransferSyntaxCombo";
            this._sourceTransferSyntaxCombo.Size = new System.Drawing.Size(360, 33);
            this._sourceTransferSyntaxCombo.TabIndex = 5;
            // 
            // _destinationSyntaxCombo
            // 
            this._destinationSyntaxCombo.FormattingEnabled = true;
            this._destinationSyntaxCombo.Location = new System.Drawing.Point(1028, 140);
            this._destinationSyntaxCombo.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this._destinationSyntaxCombo.Name = "_destinationSyntaxCombo";
            this._destinationSyntaxCombo.Size = new System.Drawing.Size(360, 33);
            this._destinationSyntaxCombo.TabIndex = 4;
            // 
            // _destinationPathTextBox
            // 
            this._destinationPathTextBox.Location = new System.Drawing.Point(18, 144);
            this._destinationPathTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this._destinationPathTextBox.Name = "_destinationPathTextBox";
            this._destinationPathTextBox.ReadOnly = true;
            this._destinationPathTextBox.Size = new System.Drawing.Size(712, 31);
            this._destinationPathTextBox.TabIndex = 3;
            // 
            // _sourcePathTextBox
            // 
            this._sourcePathTextBox.Location = new System.Drawing.Point(18, 58);
            this._sourcePathTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this._sourcePathTextBox.Name = "_sourcePathTextBox";
            this._sourcePathTextBox.ReadOnly = true;
            this._sourcePathTextBox.Size = new System.Drawing.Size(712, 31);
            this._sourcePathTextBox.TabIndex = 2;
            // 
            // _saveFileButton
            // 
            this._saveFileButton.Location = new System.Drawing.Point(746, 140);
            this._saveFileButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this._saveFileButton.Name = "_saveFileButton";
            this._saveFileButton.Size = new System.Drawing.Size(150, 44);
            this._saveFileButton.TabIndex = 1;
            this._saveFileButton.Text = "Save File";
            this._saveFileButton.UseVisualStyleBackColor = true;
            this._saveFileButton.Click += new System.EventHandler(this.SaveFileButtonClick);
            // 
            // _openFileButton
            // 
            this._openFileButton.Location = new System.Drawing.Point(746, 54);
            this._openFileButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this._openFileButton.Name = "_openFileButton";
            this._openFileButton.Size = new System.Drawing.Size(150, 44);
            this._openFileButton.TabIndex = 0;
            this._openFileButton.Text = "Open File";
            this._openFileButton.UseVisualStyleBackColor = true;
            this._openFileButton.Click += new System.EventHandler(this.OpenFileButtonClick);
            // 
            // queryScuTab
            // 
            this.queryScuTab.Controls.Add(this.label18);
            this.queryScuTab.Controls.Add(this.comboBoxQueryScuQueryLevel);
            this.queryScuTab.Controls.Add(this.textBoxQueryScuMaxResults);
            this.queryScuTab.Controls.Add(this.label17);
            this.queryScuTab.Controls.Add(this.label16);
            this.queryScuTab.Controls.Add(this.comboBoxQueryScuQueryType);
            this.queryScuTab.Controls.Add(this.label12);
            this.queryScuTab.Controls.Add(this.textBoxQueryScuLocalAe);
            this.queryScuTab.Controls.Add(this.textBoxQueryScuRemotePort);
            this.queryScuTab.Controls.Add(this.label13);
            this.queryScuTab.Controls.Add(this.textBoxQueryScuRemoteHost);
            this.queryScuTab.Controls.Add(this.label14);
            this.queryScuTab.Controls.Add(this.textBoxQueryScuRemoteAe);
            this.queryScuTab.Controls.Add(this.label15);
            this.queryScuTab.Controls.Add(this.textBoxQueryMessage);
            this.queryScuTab.Controls.Add(this.buttonQueryScuSearch);
            this.queryScuTab.Location = new System.Drawing.Point(8, 39);
            this.queryScuTab.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.queryScuTab.Name = "queryScuTab";
            this.queryScuTab.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.queryScuTab.Size = new System.Drawing.Size(1820, 245);
            this.queryScuTab.TabIndex = 3;
            this.queryScuTab.Text = "QuerySCU";
            this.queryScuTab.UseVisualStyleBackColor = true;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(308, 135);
            this.label18.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(64, 25);
            this.label18.TabIndex = 25;
            this.label18.Text = "Level";
            // 
            // comboBoxQueryScuQueryLevel
            // 
            this.comboBoxQueryScuQueryLevel.FormattingEnabled = true;
            this.comboBoxQueryScuQueryLevel.Items.AddRange(new object[] {
            "PATIENT",
            "STUDY",
            "SERIES",
            "IMAGE"});
            this.comboBoxQueryScuQueryLevel.Location = new System.Drawing.Point(308, 167);
            this.comboBoxQueryScuQueryLevel.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.comboBoxQueryScuQueryLevel.Name = "comboBoxQueryScuQueryLevel";
            this.comboBoxQueryScuQueryLevel.Size = new System.Drawing.Size(196, 33);
            this.comboBoxQueryScuQueryLevel.TabIndex = 24;
            this.comboBoxQueryScuQueryLevel.Text = "STUDY";
            this.comboBoxQueryScuQueryLevel.SelectedIndexChanged += new System.EventHandler(this.ComboBoxQueryScuQueryLevelSelectedIndexChanged);
            // 
            // textBoxQueryScuMaxResults
            // 
            this.textBoxQueryScuMaxResults.Location = new System.Drawing.Point(576, 167);
            this.textBoxQueryScuMaxResults.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBoxQueryScuMaxResults.Name = "textBoxQueryScuMaxResults";
            this.textBoxQueryScuMaxResults.Size = new System.Drawing.Size(196, 31);
            this.textBoxQueryScuMaxResults.TabIndex = 23;
            this.textBoxQueryScuMaxResults.Text = "-1";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(570, 137);
            this.label17.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(280, 25);
            this.label17.TabIndex = 22;
            this.label17.Text = "Max Results (-1 = unlimited)";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(46, 137);
            this.label16.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(124, 25);
            this.label16.TabIndex = 21;
            this.label16.Text = "Query Type";
            // 
            // comboBoxQueryScuQueryType
            // 
            this.comboBoxQueryScuQueryType.FormattingEnabled = true;
            this.comboBoxQueryScuQueryType.Items.AddRange(new object[] {
            "Study Root",
            "Patient Root"});
            this.comboBoxQueryScuQueryType.Location = new System.Drawing.Point(46, 167);
            this.comboBoxQueryScuQueryType.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.comboBoxQueryScuQueryType.Name = "comboBoxQueryScuQueryType";
            this.comboBoxQueryScuQueryType.Size = new System.Drawing.Size(238, 33);
            this.comboBoxQueryScuQueryType.TabIndex = 20;
            this.comboBoxQueryScuQueryType.Text = "Study Root";
            this.comboBoxQueryScuQueryType.SelectedIndexChanged += new System.EventHandler(this.ComboBoxQueryScuQueryTypeSelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(46, 27);
            this.label12.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(98, 25);
            this.label12.TabIndex = 19;
            this.label12.Text = "Local AE";
            // 
            // textBoxQueryScuLocalAe
            // 
            this.textBoxQueryScuLocalAe.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::ClearCanvas.Dicom.Samples.Properties.Settings.Default, "ScuLocalAETitle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBoxQueryScuLocalAe.Location = new System.Drawing.Point(46, 60);
            this.textBoxQueryScuLocalAe.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBoxQueryScuLocalAe.Name = "textBoxQueryScuLocalAe";
            this.textBoxQueryScuLocalAe.Size = new System.Drawing.Size(196, 31);
            this.textBoxQueryScuLocalAe.TabIndex = 18;
            this.textBoxQueryScuLocalAe.Text = global::ClearCanvas.Dicom.Samples.Properties.Settings.Default.ScuLocalAETitle;
            // 
            // textBoxQueryScuRemotePort
            // 
            this.textBoxQueryScuRemotePort.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::ClearCanvas.Dicom.Samples.Properties.Settings.Default, "ScuRemotePort", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBoxQueryScuRemotePort.Location = new System.Drawing.Point(854, 62);
            this.textBoxQueryScuRemotePort.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBoxQueryScuRemotePort.Name = "textBoxQueryScuRemotePort";
            this.textBoxQueryScuRemotePort.Size = new System.Drawing.Size(196, 31);
            this.textBoxQueryScuRemotePort.TabIndex = 17;
            this.textBoxQueryScuRemotePort.Text = global::ClearCanvas.Dicom.Samples.Properties.Settings.Default.ScuRemotePort;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(848, 29);
            this.label13.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(131, 25);
            this.label13.TabIndex = 16;
            this.label13.Text = "Remote Port";
            // 
            // textBoxQueryScuRemoteHost
            // 
            this.textBoxQueryScuRemoteHost.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::ClearCanvas.Dicom.Samples.Properties.Settings.Default, "ScuRemoteHost", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBoxQueryScuRemoteHost.Location = new System.Drawing.Point(576, 62);
            this.textBoxQueryScuRemoteHost.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBoxQueryScuRemoteHost.Name = "textBoxQueryScuRemoteHost";
            this.textBoxQueryScuRemoteHost.Size = new System.Drawing.Size(196, 31);
            this.textBoxQueryScuRemoteHost.TabIndex = 15;
            this.textBoxQueryScuRemoteHost.Text = global::ClearCanvas.Dicom.Samples.Properties.Settings.Default.ScuRemoteHost;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(570, 29);
            this.label14.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(136, 25);
            this.label14.TabIndex = 14;
            this.label14.Text = "Remote Host";
            // 
            // textBoxQueryScuRemoteAe
            // 
            this.textBoxQueryScuRemoteAe.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::ClearCanvas.Dicom.Samples.Properties.Settings.Default, "ScuRemoteAETitle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBoxQueryScuRemoteAe.Location = new System.Drawing.Point(308, 62);
            this.textBoxQueryScuRemoteAe.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBoxQueryScuRemoteAe.Name = "textBoxQueryScuRemoteAe";
            this.textBoxQueryScuRemoteAe.Size = new System.Drawing.Size(196, 31);
            this.textBoxQueryScuRemoteAe.TabIndex = 13;
            this.textBoxQueryScuRemoteAe.Text = global::ClearCanvas.Dicom.Samples.Properties.Settings.Default.ScuRemoteAETitle;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(302, 29);
            this.label15.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(120, 25);
            this.label15.TabIndex = 12;
            this.label15.Text = "Remote AE";
            // 
            // textBoxQueryMessage
            // 
            this.textBoxQueryMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxQueryMessage.Location = new System.Drawing.Point(1112, 12);
            this.textBoxQueryMessage.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBoxQueryMessage.Multiline = true;
            this.textBoxQueryMessage.Name = "textBoxQueryMessage";
            this.textBoxQueryMessage.Size = new System.Drawing.Size(676, 175);
            this.textBoxQueryMessage.TabIndex = 1;
            // 
            // buttonQueryScuSearch
            // 
            this.buttonQueryScuSearch.Location = new System.Drawing.Point(904, 167);
            this.buttonQueryScuSearch.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.buttonQueryScuSearch.Name = "buttonQueryScuSearch";
            this.buttonQueryScuSearch.Size = new System.Drawing.Size(150, 44);
            this.buttonQueryScuSearch.TabIndex = 0;
            this.buttonQueryScuSearch.Text = "Search";
            this.buttonQueryScuSearch.UseVisualStyleBackColor = true;
            this.buttonQueryScuSearch.Click += new System.EventHandler(this.buttonQueryScuSearch_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonSendDicomdir);
            this.tabPage1.Controls.Add(this._textBoxDicomdirRemotePort);
            this.tabPage1.Controls.Add(this.label20);
            this.tabPage1.Controls.Add(this._textBoxDicomdirRemoteHost);
            this.tabPage1.Controls.Add(this.label21);
            this.tabPage1.Controls.Add(this._textBoxDicomdirRemoteAe);
            this.tabPage1.Controls.Add(this.label22);
            this.tabPage1.Controls.Add(this._buttonOpenDicomdir);
            this.tabPage1.Controls.Add(this.label19);
            this.tabPage1.Controls.Add(this._textBoxDicomdir);
            this.tabPage1.Location = new System.Drawing.Point(8, 39);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabPage1.Size = new System.Drawing.Size(1820, 245);
            this.tabPage1.TabIndex = 4;
            this.tabPage1.Text = "DICOMDIR Reader";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonSendDicomdir
            // 
            this.buttonSendDicomdir.Location = new System.Drawing.Point(852, 148);
            this.buttonSendDicomdir.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.buttonSendDicomdir.Name = "buttonSendDicomdir";
            this.buttonSendDicomdir.Size = new System.Drawing.Size(300, 44);
            this.buttonSendDicomdir.TabIndex = 12;
            this.buttonSendDicomdir.Text = "Send DICOMDIR Files";
            this.buttonSendDicomdir.UseVisualStyleBackColor = true;
            this.buttonSendDicomdir.Click += new System.EventHandler(this.ButtonSendDicomdirClick);
            // 
            // _textBoxDicomdirRemotePort
            // 
            this._textBoxDicomdirRemotePort.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::ClearCanvas.Dicom.Samples.Properties.Settings.Default, "ScuRemotePort", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this._textBoxDicomdirRemotePort.Location = new System.Drawing.Point(564, 154);
            this._textBoxDicomdirRemotePort.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this._textBoxDicomdirRemotePort.Name = "_textBoxDicomdirRemotePort";
            this._textBoxDicomdirRemotePort.Size = new System.Drawing.Size(196, 31);
            this._textBoxDicomdirRemotePort.TabIndex = 11;
            this._textBoxDicomdirRemotePort.Text = global::ClearCanvas.Dicom.Samples.Properties.Settings.Default.ScuRemotePort;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(558, 121);
            this.label20.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(131, 25);
            this.label20.TabIndex = 10;
            this.label20.Text = "Remote Port";
            // 
            // _textBoxDicomdirRemoteHost
            // 
            this._textBoxDicomdirRemoteHost.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::ClearCanvas.Dicom.Samples.Properties.Settings.Default, "ScuRemoteHost", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this._textBoxDicomdirRemoteHost.Location = new System.Drawing.Point(286, 154);
            this._textBoxDicomdirRemoteHost.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this._textBoxDicomdirRemoteHost.Name = "_textBoxDicomdirRemoteHost";
            this._textBoxDicomdirRemoteHost.Size = new System.Drawing.Size(196, 31);
            this._textBoxDicomdirRemoteHost.TabIndex = 9;
            this._textBoxDicomdirRemoteHost.Text = global::ClearCanvas.Dicom.Samples.Properties.Settings.Default.ScuRemoteHost;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(280, 121);
            this.label21.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(136, 25);
            this.label21.TabIndex = 8;
            this.label21.Text = "Remote Host";
            // 
            // _textBoxDicomdirRemoteAe
            // 
            this._textBoxDicomdirRemoteAe.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::ClearCanvas.Dicom.Samples.Properties.Settings.Default, "ScuRemoteAETitle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this._textBoxDicomdirRemoteAe.Location = new System.Drawing.Point(18, 154);
            this._textBoxDicomdirRemoteAe.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this._textBoxDicomdirRemoteAe.Name = "_textBoxDicomdirRemoteAe";
            this._textBoxDicomdirRemoteAe.Size = new System.Drawing.Size(196, 31);
            this._textBoxDicomdirRemoteAe.TabIndex = 7;
            this._textBoxDicomdirRemoteAe.Text = global::ClearCanvas.Dicom.Samples.Properties.Settings.Default.ScuRemoteAETitle;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(12, 121);
            this.label22.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(120, 25);
            this.label22.TabIndex = 6;
            this.label22.Text = "Remote AE";
            // 
            // _buttonOpenDicomdir
            // 
            this._buttonOpenDicomdir.Location = new System.Drawing.Point(1048, 44);
            this._buttonOpenDicomdir.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this._buttonOpenDicomdir.Name = "_buttonOpenDicomdir";
            this._buttonOpenDicomdir.Size = new System.Drawing.Size(246, 44);
            this._buttonOpenDicomdir.TabIndex = 2;
            this._buttonOpenDicomdir.Text = "Open DICOMDIR";
            this._buttonOpenDicomdir.UseVisualStyleBackColor = true;
            this._buttonOpenDicomdir.Click += new System.EventHandler(this.ButtonOpenDicomdirClick);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(18, 13);
            this.label19.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(157, 25);
            this.label19.TabIndex = 1;
            this.label19.Text = "DICOMDIR File";
            // 
            // _textBoxDicomdir
            // 
            this._textBoxDicomdir.Location = new System.Drawing.Point(18, 44);
            this._textBoxDicomdir.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this._textBoxDicomdir.Name = "_textBoxDicomdir";
            this._textBoxDicomdir.ReadOnly = true;
            this._textBoxDicomdir.Size = new System.Drawing.Size(1014, 31);
            this._textBoxDicomdir.TabIndex = 0;
            // 
            // moveScuTab
            // 
            this.moveScuTab.Controls.Add(this.label23);
            this.moveScuTab.Controls.Add(this.comboBoxMoveScuQueryLevel);
            this.moveScuTab.Controls.Add(this.textBoxMoveScuMoveDestination);
            this.moveScuTab.Controls.Add(this.label24);
            this.moveScuTab.Controls.Add(this.label25);
            this.moveScuTab.Controls.Add(this.comboBoxMoveScuQueryType);
            this.moveScuTab.Controls.Add(this.label26);
            this.moveScuTab.Controls.Add(this.textBoxMoveScuLocalAe);
            this.moveScuTab.Controls.Add(this.textBoxMoveScuRemotePort);
            this.moveScuTab.Controls.Add(this.label27);
            this.moveScuTab.Controls.Add(this.textBoxMoveScuRemoteHost);
            this.moveScuTab.Controls.Add(this.label28);
            this.moveScuTab.Controls.Add(this.textBoxMoveScuRemoteAe);
            this.moveScuTab.Controls.Add(this.label29);
            this.moveScuTab.Controls.Add(this.textBoxMoveMessage);
            this.moveScuTab.Controls.Add(this.buttonMoveScuMove);
            this.moveScuTab.Location = new System.Drawing.Point(8, 39);
            this.moveScuTab.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.moveScuTab.Name = "moveScuTab";
            this.moveScuTab.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.moveScuTab.Size = new System.Drawing.Size(1820, 245);
            this.moveScuTab.TabIndex = 5;
            this.moveScuTab.Text = "MoveSCU";
            this.moveScuTab.UseVisualStyleBackColor = true;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(296, 135);
            this.label23.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(64, 25);
            this.label23.TabIndex = 41;
            this.label23.Text = "Level";
            // 
            // comboBoxMoveScuQueryLevel
            // 
            this.comboBoxMoveScuQueryLevel.FormattingEnabled = true;
            this.comboBoxMoveScuQueryLevel.Items.AddRange(new object[] {
            "PATIENT",
            "STUDY",
            "SERIES",
            "IMAGE"});
            this.comboBoxMoveScuQueryLevel.Location = new System.Drawing.Point(296, 167);
            this.comboBoxMoveScuQueryLevel.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.comboBoxMoveScuQueryLevel.Name = "comboBoxMoveScuQueryLevel";
            this.comboBoxMoveScuQueryLevel.Size = new System.Drawing.Size(196, 33);
            this.comboBoxMoveScuQueryLevel.TabIndex = 40;
            this.comboBoxMoveScuQueryLevel.Text = "STUDY";
            this.comboBoxMoveScuQueryLevel.SelectedIndexChanged += new System.EventHandler(this.ComboBoxMoveScuQueryLevelSelectedIndexChanged);
            // 
            // textBoxMoveScuMoveDestination
            // 
            this.textBoxMoveScuMoveDestination.Location = new System.Drawing.Point(564, 167);
            this.textBoxMoveScuMoveDestination.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBoxMoveScuMoveDestination.Name = "textBoxMoveScuMoveDestination";
            this.textBoxMoveScuMoveDestination.Size = new System.Drawing.Size(196, 31);
            this.textBoxMoveScuMoveDestination.TabIndex = 39;
            this.textBoxMoveScuMoveDestination.Text = "StorageSCP";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(558, 137);
            this.label24.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(179, 25);
            this.label24.TabIndex = 38;
            this.label24.Text = "Move Destination";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(34, 137);
            this.label25.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(124, 25);
            this.label25.TabIndex = 37;
            this.label25.Text = "Query Type";
            // 
            // comboBoxMoveScuQueryType
            // 
            this.comboBoxMoveScuQueryType.FormattingEnabled = true;
            this.comboBoxMoveScuQueryType.Items.AddRange(new object[] {
            "Study Root",
            "Patient Root"});
            this.comboBoxMoveScuQueryType.Location = new System.Drawing.Point(34, 167);
            this.comboBoxMoveScuQueryType.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.comboBoxMoveScuQueryType.Name = "comboBoxMoveScuQueryType";
            this.comboBoxMoveScuQueryType.Size = new System.Drawing.Size(238, 33);
            this.comboBoxMoveScuQueryType.TabIndex = 36;
            this.comboBoxMoveScuQueryType.Text = "Study Root";
            this.comboBoxMoveScuQueryType.SelectedIndexChanged += new System.EventHandler(this.ComboBoxMoveScuQueryTypeSelectedIndexChanged);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(34, 27);
            this.label26.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(98, 25);
            this.label26.TabIndex = 35;
            this.label26.Text = "Local AE";
            // 
            // textBoxMoveScuLocalAe
            // 
            this.textBoxMoveScuLocalAe.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::ClearCanvas.Dicom.Samples.Properties.Settings.Default, "ScuLocalAETitle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBoxMoveScuLocalAe.Location = new System.Drawing.Point(34, 60);
            this.textBoxMoveScuLocalAe.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBoxMoveScuLocalAe.Name = "textBoxMoveScuLocalAe";
            this.textBoxMoveScuLocalAe.Size = new System.Drawing.Size(196, 31);
            this.textBoxMoveScuLocalAe.TabIndex = 34;
            this.textBoxMoveScuLocalAe.Text = global::ClearCanvas.Dicom.Samples.Properties.Settings.Default.ScuLocalAETitle;
            // 
            // textBoxMoveScuRemotePort
            // 
            this.textBoxMoveScuRemotePort.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::ClearCanvas.Dicom.Samples.Properties.Settings.Default, "ScuRemotePort", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBoxMoveScuRemotePort.Location = new System.Drawing.Point(842, 62);
            this.textBoxMoveScuRemotePort.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBoxMoveScuRemotePort.Name = "textBoxMoveScuRemotePort";
            this.textBoxMoveScuRemotePort.Size = new System.Drawing.Size(196, 31);
            this.textBoxMoveScuRemotePort.TabIndex = 33;
            this.textBoxMoveScuRemotePort.Text = global::ClearCanvas.Dicom.Samples.Properties.Settings.Default.ScuRemotePort;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(836, 29);
            this.label27.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(131, 25);
            this.label27.TabIndex = 32;
            this.label27.Text = "Remote Port";
            // 
            // textBoxMoveScuRemoteHost
            // 
            this.textBoxMoveScuRemoteHost.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::ClearCanvas.Dicom.Samples.Properties.Settings.Default, "ScuRemoteHost", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBoxMoveScuRemoteHost.Location = new System.Drawing.Point(564, 62);
            this.textBoxMoveScuRemoteHost.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBoxMoveScuRemoteHost.Name = "textBoxMoveScuRemoteHost";
            this.textBoxMoveScuRemoteHost.Size = new System.Drawing.Size(196, 31);
            this.textBoxMoveScuRemoteHost.TabIndex = 31;
            this.textBoxMoveScuRemoteHost.Text = global::ClearCanvas.Dicom.Samples.Properties.Settings.Default.ScuRemoteHost;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(558, 29);
            this.label28.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(136, 25);
            this.label28.TabIndex = 30;
            this.label28.Text = "Remote Host";
            // 
            // textBoxMoveScuRemoteAe
            // 
            this.textBoxMoveScuRemoteAe.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::ClearCanvas.Dicom.Samples.Properties.Settings.Default, "ScuRemoteAETitle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBoxMoveScuRemoteAe.Location = new System.Drawing.Point(296, 62);
            this.textBoxMoveScuRemoteAe.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBoxMoveScuRemoteAe.Name = "textBoxMoveScuRemoteAe";
            this.textBoxMoveScuRemoteAe.Size = new System.Drawing.Size(196, 31);
            this.textBoxMoveScuRemoteAe.TabIndex = 29;
            this.textBoxMoveScuRemoteAe.Text = global::ClearCanvas.Dicom.Samples.Properties.Settings.Default.ScuRemoteAETitle;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(290, 29);
            this.label29.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(120, 25);
            this.label29.TabIndex = 28;
            this.label29.Text = "Remote AE";
            // 
            // textBoxMoveMessage
            // 
            this.textBoxMoveMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxMoveMessage.Location = new System.Drawing.Point(1100, 12);
            this.textBoxMoveMessage.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBoxMoveMessage.Multiline = true;
            this.textBoxMoveMessage.Name = "textBoxMoveMessage";
            this.textBoxMoveMessage.Size = new System.Drawing.Size(676, 175);
            this.textBoxMoveMessage.TabIndex = 27;
            // 
            // buttonMoveScuMove
            // 
            this.buttonMoveScuMove.Location = new System.Drawing.Point(892, 167);
            this.buttonMoveScuMove.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.buttonMoveScuMove.Name = "buttonMoveScuMove";
            this.buttonMoveScuMove.Size = new System.Drawing.Size(150, 44);
            this.buttonMoveScuMove.TabIndex = 26;
            this.buttonMoveScuMove.Text = "Move";
            this.buttonMoveScuMove.UseVisualStyleBackColor = true;
            this.buttonMoveScuMove.Click += new System.EventHandler(this.buttonMoveScuMove_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this._editSopTextBox);
            this.tabPage2.Controls.Add(this.label30);
            this.tabPage2.Controls.Add(this.label31);
            this.tabPage2.Controls.Add(this._editSopDestinationPathTextBox);
            this.tabPage2.Controls.Add(this._editSopSourcePathTextBox);
            this.tabPage2.Controls.Add(this._editSopSaveFileButton);
            this.tabPage2.Controls.Add(this._editSopOpenFileButton);
            this.tabPage2.Location = new System.Drawing.Point(8, 39);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabPage2.Size = new System.Drawing.Size(1820, 245);
            this.tabPage2.TabIndex = 6;
            this.tabPage2.Text = "Edit SOP";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // _editSopTextBox
            // 
            this._editSopTextBox.Dock = System.Windows.Forms.DockStyle.Right;
            this._editSopTextBox.Location = new System.Drawing.Point(918, 6);
            this._editSopTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this._editSopTextBox.Multiline = true;
            this._editSopTextBox.Name = "_editSopTextBox";
            this._editSopTextBox.Size = new System.Drawing.Size(896, 233);
            this._editSopTextBox.TabIndex = 14;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(12, 15);
            this.label30.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(171, 25);
            this.label30.TabIndex = 13;
            this.label30.Text = "Source File Path";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(12, 102);
            this.label31.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(211, 25);
            this.label31.TabIndex = 12;
            this.label31.Text = "Destination File Path";
            // 
            // _editSopDestinationPathTextBox
            // 
            this._editSopDestinationPathTextBox.Location = new System.Drawing.Point(18, 133);
            this._editSopDestinationPathTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this._editSopDestinationPathTextBox.Name = "_editSopDestinationPathTextBox";
            this._editSopDestinationPathTextBox.ReadOnly = true;
            this._editSopDestinationPathTextBox.Size = new System.Drawing.Size(712, 31);
            this._editSopDestinationPathTextBox.TabIndex = 11;
            // 
            // _editSopSourcePathTextBox
            // 
            this._editSopSourcePathTextBox.Location = new System.Drawing.Point(18, 46);
            this._editSopSourcePathTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this._editSopSourcePathTextBox.Name = "_editSopSourcePathTextBox";
            this._editSopSourcePathTextBox.ReadOnly = true;
            this._editSopSourcePathTextBox.Size = new System.Drawing.Size(712, 31);
            this._editSopSourcePathTextBox.TabIndex = 10;
            // 
            // _editSopSaveFileButton
            // 
            this._editSopSaveFileButton.Location = new System.Drawing.Point(746, 129);
            this._editSopSaveFileButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this._editSopSaveFileButton.Name = "_editSopSaveFileButton";
            this._editSopSaveFileButton.Size = new System.Drawing.Size(150, 44);
            this._editSopSaveFileButton.TabIndex = 9;
            this._editSopSaveFileButton.Text = "Save File";
            this._editSopSaveFileButton.UseVisualStyleBackColor = true;
            this._editSopSaveFileButton.Click += new System.EventHandler(this._editSopSaveFileButton_Click);
            // 
            // _editSopOpenFileButton
            // 
            this._editSopOpenFileButton.Location = new System.Drawing.Point(746, 42);
            this._editSopOpenFileButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this._editSopOpenFileButton.Name = "_editSopOpenFileButton";
            this._editSopOpenFileButton.Size = new System.Drawing.Size(150, 44);
            this._editSopOpenFileButton.TabIndex = 8;
            this._editSopOpenFileButton.Text = "Open File";
            this._editSopOpenFileButton.UseVisualStyleBackColor = true;
            this._editSopOpenFileButton.Click += new System.EventHandler(this._editSopOpenFileButton_Click);
            // 
            // _buttonOutputClearLog
            // 
            this._buttonOutputClearLog.Location = new System.Drawing.Point(32, 6);
            this._buttonOutputClearLog.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this._buttonOutputClearLog.Name = "_buttonOutputClearLog";
            this._buttonOutputClearLog.Size = new System.Drawing.Size(150, 44);
            this._buttonOutputClearLog.TabIndex = 1;
            this._buttonOutputClearLog.Text = "Clear Log";
            this._buttonOutputClearLog.UseVisualStyleBackColor = true;
            this._buttonOutputClearLog.Click += new System.EventHandler(this._buttonOutputClearLog_Click);
            // 
            // OutputTextBox
            // 
            this.OutputTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OutputTextBox.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputTextBox.Location = new System.Drawing.Point(6, 58);
            this.OutputTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.OutputTextBox.MaxLength = 65536;
            this.OutputTextBox.Multiline = true;
            this.OutputTextBox.Name = "OutputTextBox";
            this.OutputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.OutputTextBox.Size = new System.Drawing.Size(1838, 767);
            this.OutputTextBox.TabIndex = 0;
            this.OutputTextBox.WordWrap = false;
            // 
            // openFileDialogStorageScu
            // 
            this.openFileDialogStorageScu.FileName = "openFileDialogStorageScu";
            this.openFileDialogStorageScu.Filter = "DICOM files|*.dcm|All files|*.*";
            this.openFileDialogStorageScu.Title = "Open DICOM File";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "dcm";
            this.saveFileDialog.Title = "Save DICOM File";
            // 
            // SamplesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1848, 1135);
            this.Controls.Add(this.SamplesSplitContainer);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "SamplesForm";
            this.Text = "ClearCanvas.Dicom.Samples(with JRXDiagnostics.LLC)";
            this.SamplesSplitContainer.Panel1.ResumeLayout(false);
            this.SamplesSplitContainer.Panel2.ResumeLayout(false);
            this.SamplesSplitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SamplesSplitContainer)).EndInit();
            this.SamplesSplitContainer.ResumeLayout(false);
            this.SamplesTabs.ResumeLayout(false);
            this.StorageScuTab.ResumeLayout(false);
            this.StorageScuTab.PerformLayout();
            this.StorageScpTab.ResumeLayout(false);
            this.StorageScpTab.PerformLayout();
            this.CompressionTab.ResumeLayout(false);
            this.CompressionTab.PerformLayout();
            this.queryScuTab.ResumeLayout(false);
            this.queryScuTab.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.moveScuTab.ResumeLayout(false);
            this.moveScuTab.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer SamplesSplitContainer;
        private System.Windows.Forms.TabControl SamplesTabs;
        private System.Windows.Forms.TabPage StorageScuTab;
        private System.Windows.Forms.TabPage StorageScpTab;
        private System.Windows.Forms.TextBox OutputTextBox;
        private System.Windows.Forms.Button _buttonStorageScuConnect;
        private System.Windows.Forms.Button buttonStorageScuSelectFiles;
        private System.Windows.Forms.TextBox _textBoxStorageScuRemotePort;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox _textBoxStorageScuRemoteHost;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox _textBoxStorageScuRemoteAe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button _buttonStorageScuSelectDirectory;
        private System.Windows.Forms.OpenFileDialog openFileDialogStorageScu;
        private System.Windows.Forms.Button _buttonStorageScpStartStop;
        private System.Windows.Forms.TextBox _textBoxStorageScpPort;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox _textBoxStorageScpStorageLocation;
        private System.Windows.Forms.Button _buttonStorageScuSelectStorageLocation;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogStorageScp;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogStorageScu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox _textBoxStorageScpAeTitle;
        private System.Windows.Forms.Button _buttonStorageScuVerify;
        private System.Windows.Forms.Button _buttonOutputClearLog;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox _textBoxStorageScuLocalAe;
        private System.Windows.Forms.Button _buttonStorageScuClearFiles;
		private System.Windows.Forms.TabPage CompressionTab;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.ComboBox _sourceTransferSyntaxCombo;
		private System.Windows.Forms.ComboBox _destinationSyntaxCombo;
		private System.Windows.Forms.TextBox _destinationPathTextBox;
		private System.Windows.Forms.TextBox _sourcePathTextBox;
		private System.Windows.Forms.Button _saveFileButton;
		private System.Windows.Forms.Button _openFileButton;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.SaveFileDialog saveFileDialog;
		private System.Windows.Forms.Button _savePixelsButton;
		private System.Windows.Forms.TabPage queryScuTab;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.TextBox textBoxQueryScuLocalAe;
		private System.Windows.Forms.TextBox textBoxQueryScuRemotePort;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.TextBox textBoxQueryScuRemoteHost;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.TextBox textBoxQueryScuRemoteAe;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.TextBox textBoxQueryMessage;
		private System.Windows.Forms.Button buttonQueryScuSearch;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.ComboBox comboBoxQueryScuQueryType;
		private System.Windows.Forms.TextBox textBoxQueryScuMaxResults;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.ComboBox comboBoxQueryScuQueryLevel;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.TextBox _textBoxDicomdir;
		private System.Windows.Forms.Button _buttonOpenDicomdir;
		private System.Windows.Forms.Button buttonSendDicomdir;
		private System.Windows.Forms.TextBox _textBoxDicomdirRemotePort;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.TextBox _textBoxDicomdirRemoteHost;
		private System.Windows.Forms.Label label21;
		private System.Windows.Forms.TextBox _textBoxDicomdirRemoteAe;
		private System.Windows.Forms.Label label22;
        private System.Windows.Forms.CheckBox _checkBoxStorageScpBitbucket;
        private System.Windows.Forms.TabPage moveScuTab;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.ComboBox comboBoxMoveScuQueryLevel;
        private System.Windows.Forms.TextBox textBoxMoveScuMoveDestination;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.ComboBox comboBoxMoveScuQueryType;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox textBoxMoveScuLocalAe;
        private System.Windows.Forms.TextBox textBoxMoveScuRemotePort;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox textBoxMoveScuRemoteHost;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox textBoxMoveScuRemoteAe;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox textBoxMoveMessage;
        private System.Windows.Forms.Button buttonMoveScuMove;
        private System.Windows.Forms.CheckBox _checkBoxStorageScpRLE;
        private System.Windows.Forms.CheckBox _checkBoxStorageScpJ2KLossy;
        private System.Windows.Forms.CheckBox _checkBoxStorageScpJ2KLossless;
        private System.Windows.Forms.CheckBox _checkBoxStorageScpJpegLossy;
        private System.Windows.Forms.CheckBox _checkBoxStorageScpJpegLossless;
        private System.Windows.Forms.CheckBox _checkBoxStorageScpList;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.TextBox _editSopDestinationPathTextBox;
        private System.Windows.Forms.TextBox _editSopSourcePathTextBox;
        private System.Windows.Forms.Button _editSopSaveFileButton;
        private System.Windows.Forms.Button _editSopOpenFileButton;
        private System.Windows.Forms.TextBox _editSopTextBox;
    }
}

