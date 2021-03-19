using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BattleshipGame
{
    public partial class SettingsPanel : Form
    {
        public string carriers, battleships, destroyers, submarines, patrol, color, size;
        private int totalAmountOfShips=0;
        private bool errorOccured=false;
        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public List<string> saveList = new List<string>();
        public List<string> currentSettings = new List<string>();
        public SettingsPanel()
        {
            InitializeComponent();
            LoadSettings();
        }

        private void colorsButton_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK) {
                mapColor.BackColor = cd.Color;
            }
        }
        private void saveButton_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(mapSize.Text) < 5) {
                MessageBox.Show("Map cannot be smaller than 5!!!", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorOccured = true;
            }
            totalAmountOfShips = Convert.ToInt32(carriersAmount.Text) + Convert.ToInt32(battleshipsAmount.Text) +
                Convert.ToInt32(destroyersAmount.Text) + Convert.ToInt32(submarinesAmount.Text) + Convert.ToInt32(patrolAmount.Text);
            if (totalAmountOfShips == 0) {
                MessageBox.Show("You cannot play without ships!!!", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorOccured = true;
            }
            if (!errorOccured)
            {
                carriers = carriersAmount.Text;
                battleships = battleshipsAmount.Text;
                destroyers = destroyersAmount.Text;
                submarines = submarinesAmount.Text;
                patrol = patrolAmount.Text;
                color = mapColor.BackColor.ToArgb().ToString();
                size = mapSize.Text;
                saveList.Add(carriers);
                saveList.Add(battleships);
                saveList.Add(destroyers);
                saveList.Add(submarines);
                saveList.Add(patrol);
                saveList.Add(color);
                saveList.Add(size);

                string strFilePath = "settings.csv";
                string strSeperator = ";";
                StringBuilder sbOutput = new StringBuilder();

                int ilength = saveList.Count(); ;
                for (int i = 0; i < ilength; i++)
                    sbOutput.AppendLine(string.Join(strSeperator, saveList[i]));

                File.WriteAllText(strFilePath, sbOutput.ToString());
            }
            errorOccured = false;
            //LoadSettings();
        }
        private void LoadSettings() {
            string[] lines = System.IO.File.ReadAllLines("settings.csv");
            string singleLine;
            foreach (string line in lines)
            {
                singleLine = line.TrimEnd(';');
                currentSettings.Add(singleLine);
            }
            carriersAmount.Text=currentSettings[0];
            battleshipsAmount.Text = currentSettings[1];
            destroyersAmount.Text = currentSettings[2];
            submarinesAmount.Text = currentSettings[3];
            patrolAmount.Text = currentSettings[4];
            mapColor.BackColor = Color.FromArgb(Convert.ToInt32(currentSettings[5]));
            mapSize.Text = currentSettings[6];

            carriers = carriersAmount.Text;
            battleships = battleshipsAmount.Text;
            destroyers = destroyersAmount.Text;
            submarines = submarinesAmount.Text;
            patrol = patrolAmount.Text;
            color = mapColor.BackColor.ToArgb().ToString();
            size = mapSize.Text;
        }
    }
}
