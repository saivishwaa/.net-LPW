using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace AndroidDataViewer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void loadDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void loadDataToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            DeviceInfoForm DeviceInfoForm = new DeviceInfoForm();
            DeviceInfoForm.MdiParent = this; // for MDI layout
            DeviceInfoForm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CreateDatabase();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ContactsForm contactsForm = new ContactsForm();
            contactsForm.MdiParent = this; // for MDI layout
            contactsForm.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            // Instantiate the form correctly
            b messagesForm = new b();  // 'b' is the form class you're trying to open
            messagesForm.MdiParent = this;  // For MDI layout, set the parent form
            messagesForm.Show();  // Show the form
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            AppListForm AppListForm = new AppListForm();
            AppListForm.MdiParent = this; // for MDI layout
            AppListForm.Show();
        }
        private void CreateDatabase()
        {
            string dbPath = "androiddata.db"; // Path to the SQLite database file

            // Check if the database file exists
            if (!File.Exists(dbPath))
            {
                // Create a new SQLite database if it doesn't exist
                SQLiteConnection.CreateFile(dbPath); // Create the SQLite database file

                // Create the tables inside the SQLite database
                using (var conn = new SQLiteConnection($"Data Source={dbPath};Version=3;"))
                {
                    conn.Open();

                    // Create ContactsTable
                    string createContactsTable = @"
                CREATE TABLE IF NOT EXISTS ContactsTable (
                    ID INTEGER PRIMARY KEY AUTOINCREMENT,
                    Name TEXT,
                    PhoneNumber TEXT,
                    Email TEXT
                );";
                    new SQLiteCommand(createContactsTable, conn).ExecuteNonQuery();

                    // Create MessagesTable
                    string createMessagesTable = @"
                CREATE TABLE IF NOT EXISTS MessagesTable (
                    ID INTEGER PRIMARY KEY AUTOINCREMENT,
                    Sender TEXT,
                    Message TEXT,
                    Timestamp TEXT
                );";
                    new SQLiteCommand(createMessagesTable, conn).ExecuteNonQuery();

                    // Create CallLogsTable
                    string createCallLogsTable = @"
                CREATE TABLE IF NOT EXISTS CallLogsTable (
                    ID INTEGER PRIMARY KEY AUTOINCREMENT,
                    Number TEXT,
                    CallType TEXT,
                    Duration INTEGER
                );";
                    new SQLiteCommand(createCallLogsTable, conn).ExecuteNonQuery();

                    // Create DeviceInfoTable
                    string createDeviceInfoTable = @"
                CREATE TABLE IF NOT EXISTS DeviceInfoTable (
                    ID INTEGER PRIMARY KEY AUTOINCREMENT,
                    CPUInfo TEXT,
                    MemoryInfo TEXT
                );";
                    new SQLiteCommand(createDeviceInfoTable, conn).ExecuteNonQuery();

                    // Create LoginAccountsTable
                    string createLoginAccountsTable = @"
                CREATE TABLE IF NOT EXISTS LoginAccountsTable (
                    ID INTEGER PRIMARY KEY AUTOINCREMENT,
                    AccountName TEXT,
                    EmailAddress TEXT
                );";
                    new SQLiteCommand(createLoginAccountsTable, conn).ExecuteNonQuery();
                }

                MessageBox.Show("Database and tables created successfully.");
            }
            else
            {
                MessageBox.Show("Database already exists.");
            }
        }

    }
}
