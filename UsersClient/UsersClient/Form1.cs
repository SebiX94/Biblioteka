using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestSharp;
using UsersClient.Models;

namespace UsersClient
{
    public partial class Form1 : Form
    {
        private List<Users> ListOfUsers = new List<Users>();
        private List<Books> ListOfBooks = new List<Books>();
        private List<Loans> ListOfLoans = new List<Loans>();
        public int EditUserId;
        public int EditBookId;
        public int EditLoansId;
        
        public Form1()
        {
            InitializeComponent();
            Table();
            Loading();
            LoadingBooks();
            LoadLoans();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RestClient client = new RestClient("https://localhost:5001/api/");
            RestRequest request = new RestRequest("Users", DataFormat.Json);

            var response = client.Get<IEnumerable<Users>>(request);

            string user = "";
            foreach (var users in response.Data)
            {
                user += "\n" + users.FirstName + " " + users.LastName;
            }

            MessageBox.Show(user);


        }

        private void Loading()
        {
            ListOfUsers.Clear();
            RestClient client = new RestClient("https://localhost:5001/api/");
            RestRequest request = new RestRequest("Users", DataFormat.Json);

            var response = client.Get<IEnumerable<Users>>(request);
            List<Users> tolist = response.Data.ToList().Where(e => e.Album == 0).ToList();
            var list = new BindingList<Users>(tolist);
           
            var source = new BindingSource(list, null);



            ListOfUsers = response.Data.ToList();
            

            UsersDataGrid.ColumnHeadersVisible = true;
            UsersDataGrid.AllowUserToDeleteRows = false;

            UsersDataGrid.DataSource = source;
        }

        private void LoadingBooks()
        {
            ListOfBooks.Clear();
            RestClient client = new RestClient("https://localhost:5001/api/");
            RestRequest request = new RestRequest("Books", DataFormat.Json);

            var response = client.Get<IEnumerable<Books>>(request);

            var list = new BindingList<Books>(response.Data.ToList());
            var source = new BindingSource(list, null);



            ListOfBooks = response.Data.ToList();

            BooksGrid.ColumnHeadersVisible = true;
            BooksGrid.AllowUserToAddRows = false;
            BooksGrid.AllowUserToDeleteRows = false;

            BooksGrid.DataSource = source;
        }

        private void LoadList_Click(object sender, EventArgs e)
        {

            
            
        }

        private void UserBinding_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void UsersDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            EditUserId = ListOfUsers[e.RowIndex].Id;
            NameBox.Text = ListOfUsers[e.RowIndex].FirstName;
            LastNameBox.Text = ListOfUsers[e.RowIndex].LastName;
            //AlbumBox.Text = ListOfUsers[e.RowIndex].Album.ToString();
            BirthDay.Value= ListOfUsers[e.RowIndex].BirthDate;
            
        }

        private void UsersDataGrid_DoubleClick(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var response = MessageBox.Show("Nie zapisane dane zostaną uracone", "Czyszczenie formularza", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        
            if (response == DialogResult.Yes)
            {
                EditUserId = 0;
                NameBox.Text ="";
                LastNameBox.Text ="";
                //AlbumBox.Text = "";
                BirthDay.Value = DateTime.Now;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            RestClient client = new RestClient("https://localhost:5001/api/");
            RestRequest request;
            Users ob;
            if (EditUserId == 0)
            {
                
                request = new RestRequest("Users", DataFormat.Json);
                request.Method = Method.POST;
                ob = new Users { FirstName = NameBox.Text, LastName = LastNameBox.Text, BirthDate = BirthDay.Value };
            }
            else
            {
                
                request = new RestRequest("Users/"+EditUserId, DataFormat.Json);
                request.Method = Method.PUT;
                ob = new Users { Id=EditUserId, FirstName = NameBox.Text, LastName = LastNameBox.Text, BirthDate = BirthDay.Value };
            } 
            
                request.AddJsonBody(ob);
                var resp = client.Execute(request);
                string code = resp.StatusCode.ToString();
                if (code == "Created")
                {
                    MessageBox.Show("Dodano");

                }
                else if(code == "NoContent")
                {
                    MessageBox.Show("Zaktualizowano" + code);
                }
                else 
                {
                    MessageBox.Show(code);
                }

            Loading();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Nie zapisane dane zostaną uracone", "Czyszczenie formularza", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                EditBookId = 0;
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RestClient client = new RestClient("https://localhost:5001/api/");
            RestRequest request;
            Books ob;
            if (EditBookId == 0)
            {

                request = new RestRequest("Books", DataFormat.Json);
                request.Method = Method.POST;
                ob = new Books { Name = textBox1.Text,Author = textBox2.Text,Category = textBox3.Text };
            }
            else
            {

                request = new RestRequest("Books/" + EditUserId, DataFormat.Json);
                request.Method = Method.PUT;
                ob = new Books { Id = EditBookId, Name = textBox2.Text,Author = textBox2.Text,Category = textBox3.Text};
            }

            request.AddJsonBody(ob);
            var resp = client.Execute(request);
            string code = resp.StatusCode.ToString();
            if (code == "Created")
            {
                MessageBox.Show("Dodano");

            }
            else if (code == "NoContent")
            {
                MessageBox.Show("Zaktualizowano" + code);
            }
            else
            {
                MessageBox.Show(code);
            }

            LoadingBooks();
            LoadLoans();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            RestClient client = new RestClient("https://localhost:5001/api/");    
            
            RestRequest request = new RestRequest("Books/" + EditUserId, DataFormat.Json);
            request.Method = Method.DELETE;
            Books ob = new Books { Id = EditBookId};
            request.AddJsonBody(ob);
            client.Execute(request);

            LoadingBooks();
        }

        private void BooksGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            EditBookId = ListOfBooks[e.RowIndex].Id;
            textBox1.Text = ListOfBooks[e.RowIndex].Name;
            textBox2.Text = ListOfBooks[e.RowIndex].Author;
            textBox3.Text = ListOfBooks[e.RowIndex].Category;
        }
        private void LoadLoans()
        {
            ListOfLoans.Clear();
            RestClient client = new RestClient("https://localhost:5001/api/");
            RestRequest request = new RestRequest("Loans", DataFormat.Json);

            var response = client.Get<IEnumerable<Loans>>(request);

            var list = new BindingList<Loans>(response.Data.ToList());
            var source = new BindingSource(list, null);



            ListOfLoans = response.Data.ToList();

            foreach(var item in ListOfLoans)
            {
                item.BookName = ListOfBooks.Find(w => w.Id == item.IdBooks).Name;
                var tempuser = ListOfUsers.Find(e => e.Id == item.IdUsers);
                item.UserName = tempuser.FirstName + " " + tempuser.LastName;
            }

            
            LoanGrid.DataSource = source;

          

            comboBox1.Items.Clear();
            foreach (Users Item in ListOfUsers)
            {
                if(Item.Album == 0)
                {
                    comboBox1.Items.Add(Item.FirstName + " " + Item.LastName);
                }
               
            }
            comboBox2.Items.Clear();
            foreach (Books Item in ListOfBooks)
            {
                comboBox2.Items.Add(Item.Name);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (EditLoansId == 0)
            {
                int IdBook;
                int IdUser;

                IdBook = comboBox2.SelectedIndex;
                IdUser = comboBox1.SelectedIndex;

                RestClient client = new RestClient("https://localhost:5001/api/");
                RestRequest request;
                Loans lo;
                if (EditLoansId <= 0)
                {

                    request = new RestRequest("Loans", DataFormat.Json);
                    request.Method = Method.POST;
                    lo = new Loans { IdUsers = ListOfUsers[IdUser].Id, IdBooks = ListOfBooks[IdBook].Id, DateOfLoan = DateTime.Now };
                }
                else
                {

                    request = new RestRequest("Loans/" + EditLoansId, DataFormat.Json);
                    request.Method = Method.PUT;
                    lo = new Loans { Id = EditLoansId, IdUsers = ListOfUsers[IdUser].Id, IdBooks = ListOfBooks[IdBook].Id, DateOfLoan = DateTime.Now };
                }


                request.AddJsonBody(lo);
                var resp = client.Execute(request);
                string code = resp.StatusCode.ToString();
                if (code == "OK")
                {
                    MessageBox.Show("Książka jest już wypożyczona");
                }
                else
                {
                    if (code == "Created")
                    {
                        MessageBox.Show("Dodano");

                    }
                    else if (code == "NoContent")
                    {
                        MessageBox.Show("Zaktualizowano" + code);
                    }
                    else
                    {
                        MessageBox.Show(code);
                    }

                    LoadLoans();
                }
            }
            else
            {
                MessageBox.Show("Jestes w trybie edycji, masz wybrane jedno wypożyczenie!");
            }
        }

        private void LoanGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            EditLoansId = e.RowIndex;
        }        
        private void button7_Click(object sender, EventArgs e)
        {
                Loans Item = new Loans
                {
                    Id = ListOfLoans[EditLoansId].Id,
                    IdUsers = ListOfLoans[EditLoansId].IdUsers,
                    IdBooks = ListOfLoans[EditLoansId].IdBooks,
                    DateOfLoan = ListOfLoans[EditLoansId].DateOfLoan,
                    DateOfReturn = DateTime.Now
                };

                RestClient client = new RestClient("https://localhost:5001/api/");
                RestRequest request = new RestRequest("Loans/" + Item.Id, DataFormat.Json);

                request.Method = Method.PUT;
                request.AddJsonBody(Item);
                var response = client.Execute(request);

                if (response.StatusCode == System.Net.HttpStatusCode.NoContent)
                {
                    MessageBox.Show("Książka zwrócona");
                }
            LoadLoans();
        }

        private void LoansTab_Click(object sender, EventArgs e)
        {

        }

        public void Table()
        {
            LoanGrid.AutoGenerateColumns = false;
            LoanGrid.ColumnCount = 4;
            LoanGrid.ColumnHeadersVisible = true;
            LoanGrid.Columns[0].HeaderText = "Książka";
            LoanGrid.Columns[0].DataPropertyName = "BookName";
            LoanGrid.Columns[1].HeaderText = "Czytelnik";
            LoanGrid.Columns[1].DataPropertyName = "UserName";
            LoanGrid.Columns[2].HeaderText = "Data wypożyczenia";
            LoanGrid.Columns[2].DataPropertyName = "DateOfLoan";
            LoanGrid.Columns[3].HeaderText = "Data zwrócenia";
            LoanGrid.Columns[3].DataPropertyName = "DateOfReturn";


            
            BooksGrid.AllowUserToAddRows = false;
            BooksGrid.AutoGenerateColumns = false;
            BooksGrid.ColumnCount = 3;
            BooksGrid.Columns[0].HeaderText = "Nazwa książki";
            BooksGrid.Columns[0].DataPropertyName = "Name";
            BooksGrid.Columns[1].HeaderText = "Autor ksiązki";
            BooksGrid.Columns[1].DataPropertyName = "Author";
            BooksGrid.Columns[2].HeaderText = "Kategoria";
            BooksGrid.Columns[2].DataPropertyName = "Category";


            UsersDataGrid.AllowUserToAddRows = false;
            UsersDataGrid.AutoGenerateColumns = false;
            UsersDataGrid.ColumnCount = 3;
            UsersDataGrid.Columns[0].HeaderText = "Imię";
            UsersDataGrid.Columns[0].DataPropertyName = "Firstname";
            UsersDataGrid.Columns[1].HeaderText = "Nazwisko";
            UsersDataGrid.Columns[1].DataPropertyName = "LastName";
            UsersDataGrid.Columns[2].HeaderText = "Data urodzenia";
            UsersDataGrid.Columns[2].DataPropertyName = "BirthDate";

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            if(MessageBox.Show("Czy chcesz stworzyć nowe wypożyczenie??", "Utworzenie nowego wypożyczenia", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                EditLoansId = 0;


            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
           
            if(EditUserId >0 && MessageBox.Show("Czy na pewno chcesz usunąć użytkownika", "Usuwanie uzytkownika", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {

                RestClient client = new RestClient("https://localhost:5001/api/");
                RestRequest request = new RestRequest("Users/" +EditUserId, DataFormat.Json);

                request.Method = Method.PUT;
                ListOfUsers.First(w => w.Id == EditUserId).Album = 1;
                request.AddJsonBody(ListOfUsers.First(w=>w.Id == EditUserId));


                var response = client.Execute(request);
                
                if (response.StatusCode == System.Net.HttpStatusCode.NoContent)
                {
                    MessageBox.Show("Usunięto");
                }
               Loading();
            }
        }
    }
}
