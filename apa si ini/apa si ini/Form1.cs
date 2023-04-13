using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace apa_si_ini
{
    public partial class Form1 : Form
    {
        MySqlConnection conn;
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        string connectionString;
        string sqlQuery;
        DataTable dtpemain = new DataTable();
        DataTable dtnationality = new DataTable();
        DataTable dtteam = new DataTable();
        DataTable dtplayerteam = new DataTable();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connectionString = "server=localhost;uid=root;pwd=;database=premier_league";
            conn = new MySqlConnection(connectionString);
            conn.Open(); // ketika kalian menggunakan DML
            //sqlQuery = "select * from player;";
            //cmd = new MySqlCommand(sqlQuery, conn);
            //adapter = new MySqlDataAdapter(cmd);
            //adapter.Fill(dtpemain);
            //dgv_pemain.DataSource = dtpemain;
            //// 
            //sqlQuery = "Select abv as 'Abrevation', nation as 'Nation' " + "FROM nationality;";
            //cmd = new MySqlCommand(sqlQuery, conn);
            //adapter = new MySqlDataAdapter(cmd);
            //adapter.Fill(dtnationality);
            //combobox_nationality.DataSource = dtnationality;
            //combobox_nationality.ValueMember = "Abrevation";
            //combobox_nationality.DisplayMember = "Nation";
            ////
            sqlQuery = "SELECT team_name as 'Team Name',team_id as 'Team ID' FROM team t;";
            cmd = new MySqlCommand(sqlQuery, conn);
            adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(dtteam);
            comboboxteam.DataSource = dtteam;
            comboboxteam.ValueMember = "Team ID";
            comboboxteam.DisplayMember = "Team Name";
            sqlQuery = "SELECT player_id , player_name , height , team_name FROM player INNER JOIN team ON player.team_id = team.team_id";
            cmd = new MySqlCommand(sqlQuery, conn);
            adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(dtplayerteam);
            dgv_pemain.DataSource = dtplayerteam;
            
        }

        private void combobox_nationality_SelectedValueChanged(object sender, EventArgs e)
        {
            lbltext.Text = combobox_nationality.SelectedValue.ToString();
        }

        private void comboboxteam_SelectedValueChanged(object sender, EventArgs e)
        {
            dtplayerteam.Clear();
            dgv_pemain.DataSource = null;

            sqlQuery = $"SELECT player_id , player_name , height , team_name FROM player INNER JOIN team ON player.team_id = team.team_id WHERE player.team_id = '{comboboxteam.SelectedValue.ToString()}'";
            cmd = new MySqlCommand(sqlQuery, conn);
            adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(dtplayerteam);
            dgv_pemain.DataSource = dtplayerteam;
        }
    }
}
