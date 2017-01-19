using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Primary namespace
namespace MIS677_Team4_LoginScreen_V1
{
    //Main form runtime class
    public partial class Main : Form
    {
        //Dictionary for the hard-coded user/password diagram
        private Dictionary<string, Pword> userDict;

        //Constructor
        public Main()
        {
            InitializeComponent();
            userDict = new Dictionary<string, Pword>();
            populateUDict();
        }

        //Populate the dictionary. Keys are usernames, password and login information is saved within the 'Pword' class.
        //Initialize a new instance of the Pword class for each new username.
        private void populateUDict()
        {
            Pword two = new Pword("password2");
            Pword three = new Pword("password3");
            Pword four = new Pword("password4");
            Pword five = new Pword("password5");
            userDict.Add("imarshall", new Pword("password1"));
            userDict.Add("acook", two);
            userDict.Add("pnguyen", three);
            userDict.Add("mwethington", four);
            userDict.Add("oalmedaihesh", five);
        }

        private bool login()
        {
            Pword p;
            try
            {  
               userDict.TryGetValue(tb1.Text, p
               
            }
           
        }
    }

    class Pword
    {
        private string pass;
        private int failAttempts;
        private bool locked;
        private DateTime lTime;

        public string password
        {
            get { return pass; }
            set { pass = value; }
        }

        public Boolean isLocked
        {
            get { return locked; }
        }

        public DateTime lockoutTime
        {
            get { return lTime; }
        }


        public Pword()
        {
            pass = null;
            failAttempts = 0;
            locked = false;
            lTime = System.DateTime.Now;
        }

        public Pword(string p)
        {
            pass = p;
            failAttempts = 0;
            locked = false;
            lTime = System.DateTime.Now;
        }

        public bool checkPassword(string p, string u)
        {
            if (locked)
            {
                if (System.DateTime.Now > lTime.AddHours(2))
                {
                    failAttempts = 0;
                    locked = false;
                }
                else
                {
                    MessageBox.Show("Failure", "Login for " + u + " is locked until:" + lTime.AddHours(2).ToLongTimeString(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            if (p == pass && !locked)
            {
                failAttempts = 0;
                MessageBox.Show("Success", "User " + u + " is now logged in.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            else
            {
                if (failAttempts++ == 3)
                {
                    locked = true;
                    lTime = System.DateTime.Now;
                    MessageBox.Show("Failure", "Login for user " + u + " is locked until:" + lTime.AddHours(2).ToLongTimeString(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                MessageBox.Show("Failure", "Incorret password for user " + u, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }
    }
}
