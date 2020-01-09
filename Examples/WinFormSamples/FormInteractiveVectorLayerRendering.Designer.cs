using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace WinFormSamples
{
    partial class FormLayerListImageGenerator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.tv = new System.Windows.Forms.TreeView();
            this.mapZoomToolStrip1 = new SharpMap.Forms.ToolBar.MapZoomToolStrip(this.components);
            this.mb = new SharpMap.Forms.MapBox();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtImgGeneration = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tv
            // 
            this.tv.CheckBoxes = true;
            this.tv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tv.Location = new System.Drawing.Point(0, 38);
            this.tv.Name = "tv";
            this.tv.Size = new System.Drawing.Size(200, 519);
            this.tv.TabIndex = 0;
            this.tv.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.tv_AfterCheck);
            this.tv.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tv_NodeMouseClick);
            // 
            // mapZoomToolStrip1
            // 
            this.mapZoomToolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.mapZoomToolStrip1.Enabled = false;
            this.mapZoomToolStrip1.Location = new System.Drawing.Point(3, 0);
            this.mapZoomToolStrip1.MapControl = this.mb;
            this.mapZoomToolStrip1.Name = "mapZoomToolStrip1";
            this.mapZoomToolStrip1.Size = new System.Drawing.Size(409, 25);
            this.mapZoomToolStrip1.TabIndex = 4;
            this.mapZoomToolStrip1.Text = "mapZoomToolStrip1";
            // 
            // mb
            // 
            this.mb.ActiveTool = SharpMap.Forms.MapBox.Tools.Pan;
            this.mb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mb.CustomTool = null;
            this.mb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mb.FineZoomFactor = 10D;
            this.mb.Location = new System.Drawing.Point(0, 0);
            this.mb.MapQueryMode = SharpMap.Forms.MapBox.MapQueryType.LayerByIndex;
            this.mb.Name = "mb";
            this.mb.QueryGrowFactor = 5F;
            this.mb.QueryLayerIndex = 0;
            this.mb.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.mb.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.mb.ShowProgressUpdate = false;
            this.mb.Size = new System.Drawing.Size(676, 580);
            this.mb.TabIndex = 6;
            this.mb.Text = "mb";
            this.mb.WheelZoomMagnitude = -2D;
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.mb);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(676, 580);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(200, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(676, 605);
            this.toolStripContainer1.TabIndex = 7;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.mapZoomToolStrip1);
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBox1.Location = new System.Drawing.Point(0, 557);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 48);
            this.textBox1.TabIndex = 8;
            this.textBox1.Text = "NB: Tree view has layer-sensitive context menu to interact with Variable Layers a" +
    "nd Map Point Layers";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tv);
            this.panel1.Controls.Add(this.txtImgGeneration);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 605);
            this.panel1.TabIndex = 9;
            // 
            // txtImgGeneration
            // 
            this.txtImgGeneration.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtImgGeneration.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImgGeneration.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtImgGeneration.Location = new System.Drawing.Point(0, 0);
            this.txtImgGeneration.Multiline = true;
            this.txtImgGeneration.Name = "txtImgGeneration";
            this.txtImgGeneration.Size = new System.Drawing.Size(200, 38);
            this.txtImgGeneration.TabIndex = 9;
            this.txtImgGeneration.Text = "Image generation mode:";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // FormLayerListImageGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 605);
            this.Controls.Add(this.toolStripContainer1);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormLayerListImageGenerator";
            this.Text = "LayerListImageGenerator Validation";
            this.Closing += new System.ComponentModel.CancelEventHandler(this.FormLayerListImageGenerator_Closing);
            this.Load += new System.EventHandler(this.FormLayerListImageGenerator_Load);
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView tv;
        private SharpMap.Forms.ToolBar.MapZoomToolStrip mapZoomToolStrip1;
        private SharpMap.Forms.MapBox mb;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtImgGeneration;
    }
}

