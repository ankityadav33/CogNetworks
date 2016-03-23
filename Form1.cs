using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Data.SqlClient;
using Microsoft.VisualBasic.PowerPacks;

namespace CogNetworks
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<LinkTable> listtbl = new List<LinkTable>();

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<LinkTable> Get()
        {
            using (var db = new dbCogEntities())
            {
                return (from tbl in db.tblLinks
                        orderby tbl.id
                        select new LinkTable()
                        {
                            id = tbl.id,
                            startNode = (int)tbl.startNode,
                            endNode = (int)tbl.endNode,
                            linkWeight = (int)tbl.linkWeight
                        }).ToList();
            }
        }

        int current, prev, next, source, destination;
        int counter = 0;


        private void Form1_Load(object sender, EventArgs e)
        {
            reset();


        }

        void reset()
        {
            try
            {
                foreach (Control control in this.Controls)
                {
                    if (control.GetType() == typeof(Button))
                    {
                        Button btn = (Button)control;

                        if (btn.Name.Contains("node"))
                        {
                            btn.BackColor = Color.Lime;
                            btn.Click += new EventHandler(this.Button_Click);

                        }
                    }
                }

                foreach (Object control in this.shapeContainer1.Shapes)
                {
                    if (control.GetType() == typeof(LineShape))
                    {
                        LineShape line = (LineShape)control;
                        
                            line.BorderColor = Color.Black;
                       

                    }

                }
                counter = 0;
                lblCounter.Text = counter.ToString();
                listtbl.Clear();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            
                if (clickedButton.BackColor == Color.Gray)
                    clickedButton.BackColor = Color.Lime;
                else
                    clickedButton.BackColor = Color.Gray;
           
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // source = Convert.ToInt32(txtSource.Text.ToString()) ;
            //destination = Convert.ToInt32(txtDestination.Text.ToString()) ;
             reset();
            listtbl = Get();
            prev = -1;
            next = -1;

            string[] path = txtPath.Text.Split(',');
            int total = 0;

            foreach (string item in path)
            {

                current = Convert.ToInt32(item);
                int weight = 0;
                int link = 0;
                foreach (LinkTable objtbl in listtbl)
                {
                    if ((objtbl.startNode == prev && objtbl.endNode == current) || (objtbl.endNode == prev && objtbl.startNode == current))
                    {
                        weight = objtbl.linkWeight;
                        link = objtbl.id;
                        total = weight + total;
                    }
                }
                DateTime start = DateTime.Now;
                while (DateTime.Now.Subtract(start).Seconds < weight)
                {
                    counter = DateTime.Now.Subtract(start).Seconds + 1;
                    lblCounter.Text = counter.ToString();
                    Application.DoEvents();
                }
                foreach (Control control in this.Controls)
                {
                    if (control.GetType() == typeof(Button))
                    {
                        Button btn = (Button)control;
                        if (btn.Text.Contains(item.ToString()))
                        {
                            btn.BackColor = Color.Red;
                        }

                    }
                    
                }

                foreach (Object control in this.shapeContainer1.Shapes)
                {
                    if (control.GetType() == typeof(LineShape))
                    {
                        LineShape line = (LineShape)control;
                        if (line.Name.Equals("link" + link.ToString()))
                        {
                            line.BorderColor = Color.Red;
                        }

                    }

                }
                prev = current;

            }
            MessageBox.Show("Reached in " + total + " seconds");
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            reset();

        }
    }

    public class LinkTable
    {
        public int id { get; set; }
        public int startNode { get; set; }
        public int endNode { get; set; }
        public int linkWeight { get; set; }
    }

}