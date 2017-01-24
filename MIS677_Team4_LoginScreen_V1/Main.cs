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
        private bool isLogged;

        //Constructor
        public Main()
        {
            InitializeComponent();
            userDict = new Dictionary<string, Pword>();
            populateUDict();
            isLogged = false;
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

        /// <summary>
        /// Attempts to log in using the entered username and password, using the Pword class function 'Check Password'
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void loginLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Pword passReturn = null;
            if (userDict.TryGetValue(unameTB.Text, out passReturn))
            {
                if (passReturn.checkPassword(pwordTB.Text, unameTB.Text))
                {
                    logoutLink.Enabled = true;
                    isLogged = true;
                    unameTB.Text = pwordTB.Text = "";
                }
            }
            else
                MessageBox.Show("Username Not Found!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }

        /// <summary>
        /// Simply checks to see if the user is logged in and displays a messagebox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void accessButton_Click(object sender, EventArgs e)
        {
            if (isLogged)
                MessageBox.Show("You have access!");
            else
                MessageBox.Show("Please login for access.");
        }

        /// <summary>
        /// Logs the user out and disales the logged out link, sends the user a message stating that they have logged out.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void logoutLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            isLogged = false;
            logoutLink.Enabled = false;
            MessageBox.Show("Logged out!");
        }
    }

    class Pword
    {
        private string pass;
        private int failAttempts;
        private bool locked;
        private DateTime lTime;

        /// <summary>
        /// Gets/sets the password value
        /// </summary>
        public string password
        {
            get { return pass; }
            set { pass = value; }
        }

        /// <summary>
        /// Checks to see if the Pword value is locked
        /// </summary>
        public Boolean isLocked
        {
            get { return locked; }
        }

        /// <summary>
        /// If the Pword class is locked, states the time that it was locked out.
        /// </summary>
        public DateTime lockoutTime
        {
            get { return lTime; }
        }

        /// <summary>
        /// Basic constructor
        /// </summary>
        public Pword()
        {
            pass = null;
            failAttempts = 0;
            locked = false;
            lTime = System.DateTime.Now;
        }

        /// <summary>
        /// Constructor that allows for the initial setting of the password value
        /// </summary>
        /// <param name="p">The value to set the password to</param>
        public Pword(string p)
        {
            pass = p;
            failAttempts = 0;
            locked = false;
            lTime = System.DateTime.Now;
        }

        /// <summary>
        /// Checks passed password against the saved one. If there is a match, informs the user and passes a 'true' bool back. If there is not, informs the user, 
        /// Increments the fail counter. If there is three failed attempts without a successful login, sets isLocked to true and prevents further login attempts
        /// for two hours.
        /// </summary>
        /// <param name="p">The password attempt to be checked</param>
        /// <param name="u">The username associated with that password</param>
        /// <returns></returns>
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
                    MessageBox.Show("Login for " + u + " is locked until:" + lTime.AddHours(2).ToLongTimeString(), "Failure", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            if (p == pass && !locked)
            {
                failAttempts = 0;
                MessageBox.Show("User " + u + " is now logged in.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            else
            {
                if (failAttempts++ == 3)
                {
                    locked = true;
                    lTime = System.DateTime.Now;
                    MessageBox.Show("Login for user " + u + " is locked until:" + lTime.AddHours(2).ToLongTimeString(), "Failure", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                MessageBox.Show("Incorret password for user " + u, "Failure", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }
    }
}
