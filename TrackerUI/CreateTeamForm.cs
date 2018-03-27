using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.Models;

namespace TrackerUI
{
    public partial class CreateTeamForm : Form
    {
        int memberCheck = 0;
        private List<PersonModel> availableTeamMembers = GlobalConfig.Connection.GetPerson_All();
        private List<PersonModel> selectedTeamMembers = new List<PersonModel>();
        private ITeamRequester callingForm;

        public CreateTeamForm(ITeamRequester caller)
        {
            InitializeComponent();

            callingForm = caller;
            

            WireUpLists();
        }

     

        private void WireUpLists()
        {
            selectTeamMemberDropDown.DataSource = null;

            selectTeamMemberDropDown.DataSource = availableTeamMembers;
            selectTeamMemberDropDown.DisplayMember = "FullName";

            teamMembersListBox.DataSource = null;

            teamMembersListBox.DataSource = selectedTeamMembers;
            teamMembersListBox.DisplayMember = "FullName";

            
        }

        private void createMemberButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                PersonModel p = new PersonModel();

                p.FirstName = firstNameValue.Text;
                p.LastName = lastNameValue.Text;
                p.EmailAddress = emailValue.Text;
                p.CellphoneNumber = cellphoneValue.Text;

                GlobalConfig.Connection.CreatePerson(p);

                selectedTeamMembers.Add(p);

                WireUpLists();

                firstNameValue.Text = "";
                lastNameValue.Text = "";
                emailValue.Text = "";
                cellphoneValue.Text = "";
                memberCheck++;
            }
            else
            {
                MessageBox.Show("You need to fill in all of the fields.");
            }
        }

        private bool ValidateForm()
        {
            if (firstNameValue.Text.Length == 0)
            {
                return false;
            }

            if (lastNameValue.Text.Length == 0)
            {
                return false;
            }

            if (emailValue.Text.Length == 0)
            {
                return false;
            }

            if (cellphoneValue.Text.Length == 0)
            {
                return false;
            }
           

            return true;
        }

        private void addMemberButton_Click(object sender, EventArgs e)
        {
            PersonModel p = (PersonModel)selectTeamMemberDropDown.SelectedItem;

            if (p != null)
            {
                availableTeamMembers.Remove(p);
                selectedTeamMembers.Add(p);
                memberCheck++;
                WireUpLists(); 
            }
        }

        private void removeSelectedMemberButton_Click(object sender, EventArgs e)
        {
            PersonModel p = (PersonModel)teamMembersListBox.SelectedItem;

            if (p != null)
            {
                selectedTeamMembers.Remove(p);
                availableTeamMembers.Add(p);
                memberCheck--;
                if (memberCheck < 0)
                {
                    memberCheck = 0;
                }
                WireUpLists(); 
            }
        }

        private void createTeamButton_Click(object sender, EventArgs e)
        {
            if (ValidateFormAll() == 0)
            {
                TeamModel t = new TeamModel();

                t.TeamName = teamNameValue.Text;
                t.TeamMembers = selectedTeamMembers;

                GlobalConfig.Connection.CreateTeam(t);

                callingForm.TeamComplete(t);

                this.Close();
            }
            else
            {
                if (ValidateFormAll() == 1)
                {
                    MessageBox.Show("Team Name is required!");
                }
                if (ValidateFormAll() == 2)
                {
                    MessageBox.Show("There should be at least one member to compete!");
                }
            }
        }

        private int ValidateFormAll()
        {
            if (teamNameValue.Text.Length == 0)
            {
                return 1;
            }
            if (memberCheck == 0)
            {
                return 2;
            }
            return 0;
        }

        private void teamNameValue_TextChanged(object sender, EventArgs e)
        {

        }

        private void CreateTeamForm_Load(object sender, EventArgs e)
        {

        }
    }
}
