using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Receipts
{
    public partial class AddPartOfFood : Form
    {
        public AddPartOfFood()
        {
            InitializeComponent();

            //List<string> fields = new List<string>(){"int", "int", "string", "string", "int"};
            DbHandler dbh = new DbHandler();
            List<List<string>> result = dbh.read((int)DbHandler.TableNames.MeasurementUnits);
            foreach (List<string> list in result)
            {
                comboBox1.Items.Add(list[0]);
            }
        }
    }
}

// Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\db\receipts.accdb