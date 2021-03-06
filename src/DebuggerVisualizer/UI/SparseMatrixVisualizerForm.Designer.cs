﻿namespace MathNet.MatrixDebuggerVisualizer.UI
{
    partial class SparseMatrixVisualizerForm
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
            this.tabControl = new MathNet.MatrixDebuggerVisualizer.UI.CustomTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.storageView = new MathNet.MatrixDebuggerVisualizer.UI.Views.SparseStorageView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.infoView = new MathNet.MatrixDebuggerVisualizer.UI.Views.SparseInfoView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.spyView = new MathNet.MatrixDebuggerVisualizer.UI.Views.SparseSpyView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.denseView = new MathNet.MatrixDebuggerVisualizer.UI.Views.SparseSubMatrixView();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Controls.Add(this.tabPage4);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.Padding = new System.Drawing.Point(10, 5);
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(692, 523);
            this.tabControl.TabIndex = 0;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.TabControl_TabIndexChanged);
            this.tabControl.TabIndexChanged += new System.EventHandler(this.TabControl_TabIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(57)))), ((int)(((byte)(85)))));
            this.tabPage1.Controls.Add(this.storageView);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(684, 490);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Values";
            // 
            // storageView
            // 
            this.storageView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.storageView.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storageView.Location = new System.Drawing.Point(0, 0);
            this.storageView.Name = "storageView";
            this.storageView.Size = new System.Drawing.Size(684, 490);
            this.storageView.StorageAdapter = null;
            this.storageView.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(57)))), ((int)(((byte)(85)))));
            this.tabPage2.Controls.Add(this.infoView);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(684, 490);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Info";
            // 
            // infoView
            // 
            this.infoView.BackColor = System.Drawing.Color.WhiteSmoke;
            this.infoView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.infoView.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoView.ForeColor = System.Drawing.Color.White;
            this.infoView.Location = new System.Drawing.Point(0, 0);
            this.infoView.Name = "infoView";
            this.infoView.Size = new System.Drawing.Size(684, 490);
            this.infoView.StorageAdapter = null;
            this.infoView.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(57)))), ((int)(((byte)(85)))));
            this.tabPage3.Controls.Add(this.spyView);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(684, 490);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Spy";
            // 
            // spyView
            // 
            this.spyView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spyView.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spyView.Location = new System.Drawing.Point(0, 0);
            this.spyView.Name = "spyView";
            this.spyView.Size = new System.Drawing.Size(684, 490);
            this.spyView.StorageAdapter = null;
            this.spyView.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(57)))), ((int)(((byte)(85)))));
            this.tabPage4.Controls.Add(this.denseView);
            this.tabPage4.Location = new System.Drawing.Point(4, 29);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(684, 490);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Dense";
            // 
            // denseView
            // 
            this.denseView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.denseView.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.denseView.Location = new System.Drawing.Point(3, 3);
            this.denseView.Name = "denseView";
            this.denseView.Size = new System.Drawing.Size(678, 484);
            this.denseView.StorageAdapter = null;
            this.denseView.TabIndex = 0;
            // 
            // SparseMatrixVisualizerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 523);
            this.Controls.Add(this.tabControl);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(600, 500);
            this.Name = "SparseMatrixVisualizerForm";
            this.ShowIcon = false;
            this.Text = "SparseMatrix Visualizer";
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CustomTabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private Views.SparseInfoView infoView;
        private Views.SparseStorageView storageView;
        private Views.SparseSpyView spyView;
        private System.Windows.Forms.TabPage tabPage4;
        private Views.SparseSubMatrixView denseView;
    }
}