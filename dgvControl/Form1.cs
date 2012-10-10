using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace dgvControl
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
            //var dgv = this.dataGridView1;

            //dgv.CellEnter += new DataGridViewCellEventHandler(dgv_CellEnter);
            //_currentColumn = new DataGridViewColumn();
            //this.OnColumnFocus(0);

        }

        //void dgv_CellEnter(object sender, DataGridViewCellEventArgs e)
        //{
        //    this.OnColumnFocus(e.ColumnIndex);        
        //}


        //void OnColumnFocus(int ColumnIndex)
        //{
        //    var dgv = this.dataGridView1;

        //    if (ColumnIndex != _currentColumn.Index)
        //    {
        //        Font selectedFont = new Font(dgv.Font, FontStyle.Bold);
        //        var newColumn = dgv.Columns[ColumnIndex];
        //        newColumn.HeaderCell.Style.Font = selectedFont;
        //        _currentColumn.HeaderCell.Style.Font = dgv.Font;
        //        _currentColumn = newColumn; 
        //    }

        //}



    }
}
