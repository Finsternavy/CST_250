using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HeroMaker
{
    public partial class SuperHeroesListForm : Form
    {
        public SuperHeroesListForm()
        {
            InitializeComponent();
        }
        

        private void SuperHeroesListForm_Shown(object sender, EventArgs e)
        {
            /*heroesListBox.DataSource = SuperHeroList.listOfHeroes;
            heroesListBox.Update();*/

            foreach(SuperHero hero in SuperHeroList.listOfHeroes)
            {
                heroesListBox.Items.Add(hero.name);
            }

            
        }

        private void selectButton_Click(object sender, EventArgs e)
        {
            profileTextBox.Text = SuperHeroList.listOfHeroes[heroesListBox.SelectedIndex].toString();
            Update();
        }
    }
}
