using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using SD = System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlX.XDevAPI.Relational;
using System.Diagnostics.Metrics;
using System.Xml.Linq;

namespace CLD
{
    public partial class Form1 : Form
    {
        Conector conector = new Conector();
        Getter get = new Getter();
       


        public Form1()
        {
            InitializeComponent();
            TableBox.Items.AddRange(new string[] { "Нагрузка", "Группа", "Студенты", "Преподаватели", "Дисциплины", "Учебный план" });
            ModeBox.Items.AddRange(new string[] {"Search","Search where", "Update", "Removal","Search 2 tables","Insert" });
            HelpSearchBox.Items.AddRange(new string[] { "Нагрузка", "Группа", "Студенты", "Преподаватели", "Дисциплины", "Учебный план" });
        }

        private void Form1_Load(object sender, EventArgs e)
        {   
                //conector.OpenConnection();
                //MessageBox.Show("CONECT!");
                //conector.CloseConnection();            
        }
        private string _GiveDataFromUser()
        {
            CellsBox.Items.Clear();
            CellsBox2.Items.Clear();
            string table_name = null;
            if (TableBox.Text == "Нагрузка")
            {
                CellsBox.Items.AddRange(new string[] { "idload", "idteacher", "groop_key_groop", "discipline_iddiscipline", "normal", "summ_clock", "deviation_clock", "year" });
                CellsBox2.Items.AddRange(new string[] { "idload", "idteacher", "groop_key_groop", "discipline_iddiscipline", "normal", "summ_clock", "deviation_clock", "year" });
                table_name = "chair_load.load_";
            }
            else if (TableBox.Text == "Группа")
            {
                CellsBox.Items.AddRange(new string[] { "key_group", "level", "idsyllabus" });
                CellsBox2.Items.AddRange(new string[] { "key_group", "level", "idsyllabus" });
                table_name = "chair_load.group";
            }
            else if (TableBox.Text == "Студенты")
            {
                CellsBox.Items.AddRange(new string[] { "idstudent", "key_group", "name", "surname", "lastname", "info" });
                CellsBox2.Items.AddRange(new string[] { "idstudent", "key_group", "name", "surname", "lastname", "info" });
                table_name = "chair_load.student";
            }
            else if (TableBox.Text == "Преподаватели")
            {
                CellsBox.Items.AddRange(new string[] { "idteacher",  "name", "surname", "lastname", "info", "kaf" });
                CellsBox2.Items.AddRange(new string[] { "idteacher",  "name", "surname", "lastname", "info", "kaf" });
                table_name = "chair_load.teacher";
            }
            else if (TableBox.Text == "Дисциплины")
            {
                CellsBox.Items.AddRange(new string[] { "iddiscipline", "idsyllabus", "bows_cl", "practice_cl", "consult_cl", "form_control" });
                CellsBox2.Items.AddRange(new string[] { "iddiscipline", "idsyllabus", "bows_cl", "practice_cl", "consult_cl", "form_control" });
                table_name = "chair_load.discipline";
            }
            else if (TableBox.Text == "Учебный план")
            {
                CellsBox.Items.AddRange(new string[] { "idsyllabus", "profile", "start_year", "form_edc" });
                CellsBox2.Items.AddRange(new string[] { "idsyllabus", "profile", "start_year", "form_edc" });
                table_name = "chair_load.syllabus";
            }
            return table_name;
        }
        private void update()
        {
            label1.Text = "";
            label2.Text = "";
            label3.Text = "=";
            label4.Text = "=";
            testlabel.Text = "";
            Bufer.table_name = _GiveDataFromUser();
            if (ModeBox.Text== "")
            {
                ModeBox.Text = "Search";
            }

            Bufer.table_Cells = CellsBox.Text;
            Bufer.table_Cells2 = CellsBox2.Text;

            Bufer.condition = InputData.Text;
            Bufer.condition2 = ConditionBox.Text;
            if (ModeBox.Text == "Search where")
            {
                label1.Text = "WHERE";
            }
            else if (ModeBox.Text == "Update")
            {
                label1.Text = "WHERE";
                label2.Text = "SET";
            }
            else if (ModeBox.Text == "Insert")
            {
                label1.Text = "INSERT INTO";
                label2.Text = "INSERT INTO";
                label3.Text = "VALUES";
                label4.Text = "VALUES";
            }
            else if (ModeBox.Text == "Removal")
            {
                label1.Text = "WHERE";
            }
            else if (ModeBox.Text == "Search 2 tables")
            {
                label1.Text = "WHERE";
                label2.Text = "WHERE";
                label3.Text = "=";
                label4.Text = "=";
                Bufer.table_name2 = crutch();
                Bufer.helper = HelpBox.Text;

            }
            
        }

        
        
        private void zapros_Click(object sender, EventArgs e)
        {   

            update();
            
            try
            {
                conector.OpenConnection();
                get._Sql(ModeBox.Text);
                testlabel.Text = Bufer.sqlcomand;
                string command = Bufer.sqlcomand;
                MySqlDataAdapter ms_data = new MySqlDataAdapter(command, conector._Uid());
                
                SD.DataTable table = new SD.DataTable();
                ms_data.Fill(table);
                DGV.DataSource = table;
                conector.CloseConnection();
                Bufer.sqlcomand = "";
            }
            catch
            {
                MessageBox.Show("ERR");
            }


        }

        private void Update_btn_Click(object sender, EventArgs e)
        {
            
            update();
        }
        private string crutch()
        {
            string table_name2 = null;
            CellsBox2.Items.Clear();
            HelpBox.Items.Clear();

            if (HelpSearchBox.Text == "Нагрузка")
            {
                CellsBox2.Items.AddRange(new string[] { "idload", "idteacher", "groop_key_groop", "discipline_iddiscipline", "normal", "summ_clock", "deviation_clock", "year" });
                HelpBox.Items.AddRange(new string[] { "idload", "idteacher", "groop_key_groop", "discipline_iddiscipline", "normal", "summ_clock", "deviation_clock", "year" });
                table_name2 = "chair_load.load_";
            }
            else if (HelpSearchBox.Text == "Группа")
            {
                CellsBox2.Items.AddRange(new string[] { "key_group", "level", "idsyllabus" });
                HelpBox.Items.AddRange(new string[] { "key_group", "level", "idsyllabus" });
                table_name2 = "chair_load.group";
            }
            else if (HelpSearchBox.Text == "Студенты")
            {
                CellsBox2.Items.AddRange(new string[] { "idstudent", "key_group", "name", "surname", "lastname", "info" });
                HelpBox.Items.AddRange(new string[] { "idstudent", "key_group", "name", "surname", "lastname", "info" });
                table_name2 = "chair_load.student";
            }
            else if (HelpSearchBox.Text == "Преподаватели")
            {
                CellsBox2.Items.AddRange(new string[] { "idteacher", "name", "surname", "lastname", "info", "kaf" });
                HelpBox.Items.AddRange(new string[] { "idteacher", "name", "surname", "lastname", "info", "kaf" });
                table_name2 = "chair_load.teacher";
            }
            else if (   HelpSearchBox.Text == "Дисциплины")
            {
                CellsBox2.Items.AddRange(new string[] { "iddiscipline", "idsyllabus", "bows_cl", "practice_cl", "consult_cl", "form_control" });
                HelpBox.Items.AddRange(new string[] { "iddiscipline", "idsyllabus", "bows_cl", "practice_cl", "consult_cl", "form_control" });
                table_name2 = "chair_load.discipline";
            }
            else if (HelpSearchBox.Text == "Учебный план")
            {
                CellsBox2.Items.AddRange(new string[] { "idsyllabus", "profile", "start_year", "form_edc" });
                HelpBox.Items.AddRange(new string[] { "idsyllabus", "profile", "start_year", "form_edc" });
                table_name2 = "chair_load.syllabus";
            }
            return table_name2;
        }
    }
}
