using Npgsql;
using System.Data;

namespace arayuz
{
    public partial class Form1 : Form
    {
        private string connectionString = "Host=localhost;Username=postgres;Password=121004;Database=otobus";
        public Form1()
        {

            InitializeComponent();
        }
        private void LoadData()
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                dataGridView1.AutoGenerateColumns = true;

                connection.Open();
                string query = "SELECT * FROM otobus";
                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(query, connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void buttonekle_Click(object sender, EventArgs e)
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO Otobus (otobus_id, firma_id, kapasite, model) VALUES (@id, @firma, @kapasite, @model)";
                using (var cmd = new NpgsqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@id", int.Parse(otobusidTb.Text));
                    cmd.Parameters.AddWithValue("@firma", int.Parse(firmaidTb.Text));
                    cmd.Parameters.AddWithValue("@kapasite", int.Parse(kapasiteTb.Text));
                    cmd.Parameters.AddWithValue("@model", modelTb.Text);
                    
                    cmd.ExecuteNonQuery();
                }
            }
            LoadData();

        }

        private void buttonguncelle_Click(object sender, EventArgs e)
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE Otobus SET firma_id = @firma, kapasite = @kapasite, model = @model WHERE otobus_id = @id";
                using (var cmd = new NpgsqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@id", int.Parse(otobusidTb.Text));
                    cmd.Parameters.AddWithValue("@firma", int.Parse(firmaidTb.Text));
                    cmd.Parameters.AddWithValue("@kapasite", int.Parse(kapasiteTb.Text));
                    cmd.Parameters.AddWithValue("@model", modelTb.Text);
                    
                    cmd.ExecuteNonQuery();
                }
            }
            LoadData();
        }

        private void buttonsil_Click(object sender, EventArgs e)
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                string query = "DELETE FROM Otobus WHERE otobus_id = @id";
                using (var cmd = new NpgsqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@id", int.Parse(otobusidTb.Text));
                    cmd.ExecuteNonQuery();
                }
            }
            LoadData();
        }

        private void buttonara_Click(object sender, EventArgs e)
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Otobus WHERE firma_id = @id";
                using (var cmd = new NpgsqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@id", int.Parse(firmaidTb.Text));
                    NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
        }
    }
}
