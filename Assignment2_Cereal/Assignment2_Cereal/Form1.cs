using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment2_Cereal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CerealLoader cl = new CerealLoader();
            cl.ReadCSV();
            DataTable table = new DataTable();

            // Creates the Column Headers and makes the column typeof what should be displayed
            table.Columns.Add(cl.identifiers[0], typeof(string));
            table.Columns.Add(cl.identifiers[1], typeof(char));
            table.Columns.Add(cl.identifiers[2], typeof(char));
            table.Columns.Add(cl.identifiers[3], typeof(int));
            table.Columns.Add(cl.identifiers[4], typeof(int));
            table.Columns.Add(cl.identifiers[5], typeof(int));
            table.Columns.Add(cl.identifiers[6], typeof(int));
            table.Columns.Add(cl.identifiers[7], typeof(float));
            table.Columns.Add(cl.identifiers[8], typeof(float));
            table.Columns.Add(cl.identifiers[9], typeof(int));
            table.Columns.Add(cl.identifiers[10], typeof(int));
            table.Columns.Add(cl.identifiers[11], typeof(int));
            table.Columns.Add(cl.identifiers[12], typeof(int));
            table.Columns.Add(cl.identifiers[13], typeof(float));
            table.Columns.Add(cl.identifiers[14], typeof(float));
            table.Columns.Add(cl.identifiers[15], typeof(double));

            // Populates the rows with the appropriate cereal and all its data
            for (int j = 0; j < cl.allCereals.Count; j++)
            {              
                table.Rows.Add(cl.allCereals[j].name, cl.allCereals[j].mfr, cl.allCereals[j].type, cl.allCereals[j].calories,
                    cl.allCereals[j].protein, cl.allCereals[j].fat, cl.allCereals[j].sodium, cl.allCereals[j].fiber,
                    cl.allCereals[j].carbs, cl.allCereals[j].sugars, cl.allCereals[j].potassium, cl.allCereals[j].vitamins,
                    cl.allCereals[j].shelfLife, cl.allCereals[j].weight, cl.allCereals[j].cups,
                    cl.allCereals[j].rating);
            }

            // Sets this as the source data
            CerealDataGrid.DataSource = table;

        }

        private void CerealDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
