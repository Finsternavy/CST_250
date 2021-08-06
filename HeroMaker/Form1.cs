using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeroMaker
{
    public partial class Form1 : Form
    {
        SuperHeroesListForm superHerosListForm;
        public int maxPoint = 100;
        public int currentTotalPoints = 0;
        public Form1(SuperHeroesListForm superHerosListForm)
        {
            this.superHerosListForm = superHerosListForm;
            InitializeComponent();
            AddstrengthScrollEventHandlers();

        }

        
        private string getPreferredTransport()
        {

            if(privateJetRadioButton.Checked == true)
            {
                return privateJetRadioButton.Text;
            }else if(limoRadioButton.Checked == true)
            {
                return limoRadioButton.Text;
            }else if(deathMachineRadioButton.Checked == true)
            {
                return deathMachineRadioButton.Text;
            }
            else
            {
                return skipRadioButton.Text;
            }
        }

        private void createHeroButton_Click(object sender, EventArgs e)
        {
            SuperHero newHero = new SuperHero(
                heroesNameTextBox.Text,
                superStrengthCheckBox.Checked,
                flyCheckBox.Checked,
                xRayCheckBox.Checked,
                invisibilityCheckBox.Checked,
                telepathyCheckBox.Checked,
                shieldsCheckBox.Checked,
                lazerVisionCheckBox.Checked,
                selfHealCheckBox.Checked,
                shootFireballsCheckBox.Checked,
                unlimitedStaminCheckBox.Checked,
                freezeTimeCheckBox.Checked,
                charmCheckBox.Checked,
                locationListBox.SelectedItem.ToString(),
                getPreferredTransport(),
                titleComboBar.SelectedItem.ToString(),
                capeColorButton.BackColor.ToString(),
                corruptedMeterTrackBar.Value,
                birthdateDatePicker.Value,
                powerDiscoveryDatePicker.Value,
                dateJoinedAvengersDatePicker.Value,
                strengthScrollBar.Value,
                manaScrollBar.Value,
                staminaScrollBar.Value);

            SuperHeroList.listOfHeroes.Add(newHero);
            superHerosListForm.Show();
            this.Hide();
        }
        private void AddstrengthScrollEventHandlers()
        {
            strengthScrollBar.Scroll += new ScrollEventHandler(
                this.strengthScrollBar_Scroll);
            strengthScrollBar.ValueChanged += new EventHandler(
                this.strengthScrollBar_ValueChanged);
            manaScrollBar.Scroll += new ScrollEventHandler(
                this.manaScrollBar_Scroll);
            manaScrollBar.ValueChanged += new EventHandler(
                this.manaScrollBar_ValueChanged);
            staminaScrollBar.Scroll += new ScrollEventHandler(
                this.staminaScrollBar_Scroll);
            staminaScrollBar.ValueChanged += new EventHandler(
                this.staminaScrollBar_ValueChanged);
            
        }

        private void strengthScrollBar_ValueChanged(Object sender, EventArgs e)
        {
            strengthValueLabel.Text = strengthScrollBar.Value.ToString();
        }

        private void strengthScrollBar_Scroll(Object sender, ScrollEventArgs e)
        {
            strengthValueLabel.Text = e.NewValue.ToString();
        }

        private void manaScrollBar_ValueChanged(Object sender, EventArgs e)
        {
                manaValueLabel.Text = manaScrollBar.Value.ToString();
            
        }

        private void manaScrollBar_Scroll(Object sender, ScrollEventArgs e)
        {
            manaValueLabel.Text = e.NewValue.ToString();
        }

        private void staminaScrollBar_ValueChanged(Object sender, EventArgs e)
        {
            staminaValueLabel.Text = staminaScrollBar.Value.ToString();
        }

        private void staminaScrollBar_Scroll(Object sender, ScrollEventArgs e)
        {
            staminaValueLabel.Text = e.NewValue.ToString();
        }

        private void updateCurrentPoints()
        {
            currentTotalPoints = strengthScrollBar.Value + manaScrollBar.Value + staminaScrollBar.Value;
        }

        private void capeColorButton_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            capeColorButton.BackColor = colorDialog1.Color;
        }
    }
}
