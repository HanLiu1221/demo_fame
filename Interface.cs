using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.IO;

namespace FameBase
{
	public partial class Interface : Form
	{
		public Interface()
		{
			InitializeComponent();
            this.glViewer.Init();
		}

        /*********Var**********/
        private void reloadViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.glViewer.reloadView();
            this.glViewer.Refresh();
        }

        private void saveViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "MAT file (*.mat)|*.mat;|All Files(*.*)|*.*";
            if (dialog.ShowDialog(this) == DialogResult.OK)
            {
                string filename = dialog.FileName;
                this.glViewer.writeModelViewMatrix(filename);
            }
        }

        private void loadViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "MAT file (*.mat)|*.mat;|All Files(*.*)|*.*";
            dialog.CheckFileExists = true;
            if (dialog.ShowDialog(this) == DialogResult.OK)
            {
                string filename = dialog.FileName;
                this.glViewer.readModelModelViewMatrix(filename);
            }
        }

        private void saveAs3D_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "3D model (*.obj; *.off; *.ply)|*.obj; *.off; *.ply|All Files(*.*)|*.*";
            if (dialog.ShowDialog(this) == DialogResult.OK)
            {
                this.glViewer.saveObj(null, dialog.FileName, GLDrawer.MeshColor);
            }
        }

        private void screenCaptureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.glViewer.captureScreen(0);
        }

		private void renderToolStripMenuItem_Click(object sender, EventArgs e)
		{
			SaveFileDialog dialog = new SaveFileDialog();
			dialog.Filter = "image file (*.png)|*.png|All Files(*.*)|*.*";
			if (dialog.ShowDialog(this) == DialogResult.OK)
			{
				string filename = dialog.FileName;
				this.glViewer.renderToImage(filename);
				this.glViewer.Refresh();
			}
		}

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            //adjustImageView();
        }

        public void updateStats()
        {
            // empty use
        }

        public ContextMenuStrip getRightButtonMenu()
        {
            // empty use
            return null;
        }

        public void writeToConsole(string s)
        {
            Console.WriteLine(s);
        }

        private void set_1_Click(object sender, EventArgs e)
        {
            string folderName = @"C:\scratch\HLiu\Fame\data_sets\mix_4";
            //string folderName = @"E:\Projects\fame\data_sets\mix_4";
            List<ModelViewer> _modelViews = this.glViewer.loadPartBasedModels(folderName);
            layoutModelSet(_modelViews, true);
        }

        private void set_2_Click(object sender, EventArgs e)
        {
            //string folderName = @"C:\scratch\HLiu\Fame\data_sets\mix_4";
            string folderName = @"E:\Projects\fame\data_sets\mix_4";
            List<ModelViewer> _modelViews = this.glViewer.loadPartBasedModels(folderName);
            layoutModelSet(_modelViews, true);
        }

        private void run_Click(object sender, EventArgs e)
        {
            List<ModelViewer> modelViews = this.glViewer.autoGenerate();
            if (modelViews != null)
            {
                // clear previous results
                this.clearPreviousResuts();
                layoutModelSet(modelViews, false);
                MessageBox.Show("Please click your preferred shapes and RUN again until you feel good enouth :)");
            }
        }

        private void clearPreviousResuts()
        {
            int np = this.glViewer.getParentModelNum();
            int rn = this.modelViewLayoutPanel.Controls.Count - np;
            for (int i = 0; i < rn; ++i)
            {
                this.modelViewLayoutPanel.Controls.RemoveAt(np);
            }
        }

        private void layoutModelSet(List<ModelViewer> modelViews, bool isParent)
        {
            if (modelViews == null) return;
            int w = 200;
            int h = 200;
            int i = 0;
            if (isParent)
            {
                this.modelViewLayoutPanel.Controls.Clear();
            }
            // always keep parents in the first generation
            foreach (ModelViewer mv in modelViews)
            {
                mv.SetBounds(i * w, 0, w, h);
                mv.BorderStyle = BorderStyle.FixedSingle;
                Color bk = this.getBackgroundColor(mv._GEN);
                mv.setBackColor(bk);
                this.modelViewLayoutPanel.Controls.Add(mv);
                this.Refresh();
            }
            this.updateStats();
        }// layoutModelSet

        private Color getBackgroundColor(int gen)
        {
            Color c = Color.White;
            switch (gen)
            {
                case 1:
                    c = GLDrawer.SelectedBackgroundColor;
                    break;
                case 0:
                    c = GLDrawer.ParentViewBackgroundColor;
                    break;
                default:
                    c = Color.White;
                    break;
            }
            return c;
        }
	}// Interface
}// namespace
