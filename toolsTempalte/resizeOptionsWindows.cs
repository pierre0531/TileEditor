using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace toolsTempalte
{
    public partial class resizeOptionsWindows : Form
    {
        public event EventHandler buttonAdjust;

        public resizeOptionsWindows()
        {
            InitializeComponent();
        }

        public resizeOptionsWindows(int _mapX, int _mapY, int _tileX, int _tileY, int _tileSetW, int _tileSetH)
        {
            InitializeComponent();

            numericUpDownMapX.Value = _mapX;
            numericUpDownMapY.Value = _mapY;

            numericUpDownTileX.Value = _tileX;
            numericUpDownTileY.Value = _tileY;

            numericUpDownTileSetW.Value = _tileSetW;
            numericUpDownTileSetH.Value = _tileSetH;
        }
        public int ToolsMapX
        {
            get { return (int)numericUpDownMapX.Value; }
            set { numericUpDownMapX.Value = value; }
        }
        public int ToolsMapY
        {
            get { return (int)numericUpDownMapY.Value; }
            set { numericUpDownMapY.Value = value; }
        }

        //tile size setting
        public int ToolsTileX
        {
            get { return (int)numericUpDownTileX.Value; }
            set { numericUpDownTileX.Value = value; }
        }
        public int ToolsTileY
        {
            get { return (int)numericUpDownTileY.Value; }
            set { numericUpDownTileY.Value = value; }
        }

        //tile set size setting
        public int ToolsTileSetW
        {
            get { return (int)numericUpDownTileSetW.Value; }
            set { numericUpDownTileSetW.Value = value; }
        }
        public int ToolsTileSetH
        {
            get { return (int)numericUpDownTileSetH.Value; }
            set { numericUpDownTileSetH.Value = value; }
        }

   

        private void button1_Click(object sender, EventArgs e)
        {
            if (buttonAdjust != null)
            {
                //trigger the event
                buttonAdjust(this, EventArgs.Empty);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {

        }
    }
}
