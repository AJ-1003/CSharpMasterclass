using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace ZooManager
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["ZooManager.Properties.Settings.ZooManagerDBConnectionString"].ConnectionString;
        private readonly SqlConnection conn;

        public MainWindow()
        {
            InitializeComponent();
            conn = new SqlConnection(connectionString);
            ShowZoos();
            ShowAnimals();
        }

        public void ShowZoos()
        {
            try
            {
                var query = "SELECT * FROM Zoo";
                SqlDataAdapter sqlData = new SqlDataAdapter(query, connectionString);

                using (sqlData)
                {
                    DataTable zooDt = new DataTable();
                    sqlData.Fill(zooDt);
                    ZooList.DisplayMemberPath = "Location";
                    ZooList.SelectedValuePath = "Id";
                    ZooList.ItemsSource = zooDt.DefaultView;
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }
        }

        public void ShowAssociatedAnimals()
        {
            // Fix issue where 
            try
            {
                var query = "SELECT * FROM Animal a INNER JOIN ZooAnimal za ON a.Id = za.AnimalId " +
                    "WHERE za.ZooId = @ZooId";

                SqlCommand cmd = new SqlCommand(query, conn);

                SqlDataAdapter sqlData = new SqlDataAdapter(cmd);

                using (sqlData)
                {
                    cmd.Parameters.AddWithValue("@ZooId", ZooList.SelectedValue);
                    DataTable assAnimalDt = new DataTable();
                    sqlData.Fill(assAnimalDt);
                    AssociatedAnimalsList.DisplayMemberPath = "Name";
                    AssociatedAnimalsList.SelectedValuePath = "Id";
                    AssociatedAnimalsList.ItemsSource = assAnimalDt.DefaultView;
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }
        }

        public void ShowAnimals()
        {
            try
            {
                var query = "SELECT * FROM Animal";
                SqlDataAdapter sqlData = new SqlDataAdapter(query, connectionString);

                using (sqlData)
                {
                    DataTable animalDt = new DataTable();
                    sqlData.Fill(animalDt);
                    AnimalsList.DisplayMemberPath = "Name";
                    AnimalsList.SelectedValuePath = "Id";
                    AnimalsList.ItemsSource = animalDt.DefaultView;
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }
        }

        private void ZooList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ShowAssociatedAnimals();
            ShowSelectedZoo();
        }

        private void AnimalsList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ShowSelectedAnimal();
        }

        private void ShowSelectedZoo()
        {
            try
            {
                string query = "SELECT Location FROM Zoo WHERE Id = @ZooId";

                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter zooData = new SqlDataAdapter(cmd);

                using (zooData)
                {
                    cmd.Parameters.AddWithValue("@ZooId", ZooList.SelectedValue);
                    DataTable zooDt = new DataTable();
                    zooData.Fill(zooDt);

                    ZooManager_TextBox.Text = zooDt.Rows[0]["Location"].ToString();
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        private void ShowSelectedAnimal()
        {
            try
            {
                string query = "SELECT Name FROM Animal WHERE Id = @AnimalId";

                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter animalData = new SqlDataAdapter(cmd);

                using (animalData)
                {
                    cmd.Parameters.AddWithValue("@AnimalId", AnimalsList.SelectedValue);
                    DataTable animalDt = new DataTable();
                    animalData.Fill(animalDt);

                    ZooManager_TextBox.Text = animalDt.Rows[0]["Name"].ToString();
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        private void AddZoo_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var query = "INSERT INTO Zoo VALUES (@Location)";

                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                cmd.Parameters.AddWithValue("@Location", ZooManager_TextBox.Text);
                cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }
            finally
            {
                conn.Close();
                ShowZoos();
            }
        }

        private void AddAnimal_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var query = "INSERT INTO Animal VALUES (@Name)";

                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                cmd.Parameters.AddWithValue("@Name", ZooManager_TextBox.Text);
                cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }
            finally
            {
                conn.Close();
                ShowAnimals();
            }
        }

        private void AddAnimalToZoo_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var query = "INSERT INTO ZooAnimal VALUES (@ZooId, @AnimalId)";

                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                cmd.Parameters.AddWithValue("@ZooId", ZooList.SelectedValue);
                cmd.Parameters.AddWithValue("@AnimalId", AnimalsList.SelectedValue);
                cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }
            finally
            {
                conn.Close();
                ShowAssociatedAnimals();
                ShowZoos();
            }
        }

        private void DeleteZoo_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var query = "DELETE FROM Zoo WHERE Id = @ZooId";

                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                cmd.Parameters.AddWithValue("@ZooId", ZooList.SelectedValue);
                cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }
            finally
            {
                conn.Close();
                ShowZoos();
            }
        }

        private void DeleteAnimal_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var query = "DELETE FROM Animal WHERE Id = @AnimalId";

                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                cmd.Parameters.AddWithValue("@AnimalId", AnimalsList.SelectedValue);
                cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }
            finally
            {
                conn.Close();
                ShowAnimals();
            }
        }

        private void RemoveAnimal_Click(object sender, RoutedEventArgs e)
        {

        }

        private void UpdateZoo_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string query = "UPDATE Zoo SET Location = @Location WHERE Id = @ZooId";

                SqlCommand cmd = new SqlCommand(query, conn);

                conn.Open();
                cmd.Parameters.AddWithValue("@ZooId", ZooList.SelectedValue);
                cmd.Parameters.AddWithValue("@Location", ZooManager_TextBox.Text);
                cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
                ShowZoos();
            }
        }

        private void UpdateAnimal_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string query = "UPDATE Animal SET Name = @Name WHERE Id = @AnimalId";

                SqlCommand cmd = new SqlCommand(query, conn);

                conn.Open();
                cmd.Parameters.AddWithValue("@AnimalId", AnimalsList.SelectedValue);
                cmd.Parameters.AddWithValue("@Name", ZooManager_TextBox.Text);
                cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
                ShowAnimals();
                ShowAssociatedAnimals();
            }
        }
    }
}
