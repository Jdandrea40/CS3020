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
        DataTable sortedTable = new DataTable();

        CerealLoader cl = new CerealLoader();
        public Form1()
        {
            InitializeComponent();
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        
            cl.ReadCSV();
            DataTable table = new DataTable();

            #region FULL CEREAL LIST COLUMNS
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
            #endregion

            #region SORTED TABLE COLUMNS
            //  Creates the Columns fir the Sort Grid View
            sortedTable.Columns.Add(cl.identifiers[0], typeof(string));
            sortedTable.Columns.Add(cl.identifiers[1], typeof(char));
            sortedTable.Columns.Add(cl.identifiers[2], typeof(char));
            sortedTable.Columns.Add(cl.identifiers[3], typeof(int));
            sortedTable.Columns.Add(cl.identifiers[4], typeof(int));
            sortedTable.Columns.Add(cl.identifiers[5], typeof(int));
            sortedTable.Columns.Add(cl.identifiers[6], typeof(int));
            sortedTable.Columns.Add(cl.identifiers[7], typeof(float));
            sortedTable.Columns.Add(cl.identifiers[8], typeof(float));
            sortedTable.Columns.Add(cl.identifiers[9], typeof(int));
            sortedTable.Columns.Add(cl.identifiers[10], typeof(int));
            sortedTable.Columns.Add(cl.identifiers[11], typeof(int));
            sortedTable.Columns.Add(cl.identifiers[12], typeof(int));
            sortedTable.Columns.Add(cl.identifiers[13], typeof(float));
            sortedTable.Columns.Add(cl.identifiers[14], typeof(float));
            sortedTable.Columns.Add(cl.identifiers[15], typeof(double));
            #endregion

            // Populates the rows with the appropriate cereal and all its data
            for (int i = 0; i < cl.allCereals.Count; i++)
            {              
                table.Rows.Add(cl.allCereals[i].name, cl.allCereals[i].mfr, cl.allCereals[i].type, cl.allCereals[i].calories,
                    cl.allCereals[i].protein, cl.allCereals[i].fat, cl.allCereals[i].sodium, cl.allCereals[i].fiber,
                    cl.allCereals[i].carbs, cl.allCereals[i].sugars, cl.allCereals[i].potassium, cl.allCereals[i].vitamins,
                    cl.allCereals[i].shelfLife, cl.allCereals[i].weight, cl.allCereals[i].cups,
                    cl.allCereals[i].rating);
            }

            // Sets this as the source data
            CerealGridView.DataSource = table;
        }

        private void SortButton_Click(object sender, EventArgs e)
        {
            SortButton.Click += SortButton_Listener;
            Controls.Add(SortButton);
        }

        private void SortButton_Listener(object sender, EventArgs e)
        {
            sortedTable.Clear();
            RefineSearch();
        }

        void RefineSearch()
        {
            var sortedCereals =
                from cereals in cl.allCereals
                where (CheckCals.Checked ? cereals.calories <= (int)CaloriesUpDown.Value : cereals.calories >= CaloriesUpDown.Minimum)
                where (CheckProtein.Checked ? cereals.protein >= (int)ProteinUpDown.Value : cereals.protein >= ProteinUpDown.Minimum)
                where (CheckFat.Checked ? cereals.fat <= (int)FatUpDown.Value : cereals.fat >= FatUpDown.Minimum)
                where (CheckSodium.Checked ? cereals.sodium <= (int)SodiumUpDown.Value : cereals.sodium >= SodiumUpDown.Minimum)
                where (CheckFiber.Checked ? cereals.fiber >= (float)FiberUpDown.Value : cereals.fiber >= (float)FiberUpDown.Minimum)
                where (CheckCarbs.Checked ? cereals.carbs <= (float)CarbUpDown.Value : cereals.carbs >= (float)CarbUpDown.Minimum)
                where (CheckSugar.Checked ? cereals.sugars <= (int)SugarUpDown.Value : cereals.sugars >= SugarUpDown.Minimum )
                where (CheckPotass.Checked ? cereals.potassium >= (int)PotassUpDown.Value : cereals.potassium >= PotassUpDown.Minimum)
                where (CheckVits.Checked ? cereals.vitamins >= (int)VitaminUpDown.Value : cereals.vitamins >= VitaminUpDown.Minimum)
                where (CheckLife.Checked ? cereals.shelfLife >= (int)ShelfLifeUpDown.Value : cereals.shelfLife >= ShelfLifeUpDown.Minimum)
                where (CheckServings.Checked ? cereals.cups <= (float)ServingsUpDown.Value : cereals.cups >= (float)ServingsUpDown.Minimum)
                where (CheckRating.Checked ? cereals.rating >= (double)RatingUpDown.Value : cereals.rating >= (double)RatingUpDown.Minimum)
                where (CheckCold.Checked && cereals.type == 'C')
                where (CheckHot.Checked && cereals.type == 'H')
                select cereals;

            foreach (var c in sortedCereals)
            {
                sortedTable.Rows.Add(c.name, c.mfr, c.type, c.calories,
                    c.protein, c.fat, c.sodium, c.fiber, c.carbs, c.sugars,
                    c.potassium, c.vitamins, c.shelfLife, c.weight, c.cups, c.rating);
            }

            SortedCerealList.DataSource = sortedTable;
        }
        // updates the serving style to sort by
        private void ServingStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (ServingStyleComboBox.SelectedIndex == 1)
            //{
            //    sortType = 'H';
            //    checkType = true;
            //}
            //else if (ServingStyleComboBox.SelectedIndex == 2)
            //{
            //    sortType = 'C';
            //    checkType = true;
            //}
            //else
            //{
            //    sortType = ' ';
            //    checkType = false;
            //}
        }
        // Updates the calories to sort by
    }
}
