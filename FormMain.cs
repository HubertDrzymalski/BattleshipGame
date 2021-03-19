using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace BattleshipGame
{
    public partial class FormMain : Form
    {
        SettingsPanel sp= new SettingsPanel();
        public Random random = new Random();
        string[] files, path;


        public FormMain()
        {
            InitializeComponent();
        }

        private void singlePlay_Click(object sender, EventArgs e)
        {
            ButtonsBoard buttonsBoard = new ButtonsBoard(sp.carriers,sp.battleships,sp.destroyers,sp.submarines,sp.patrol,sp.color,sp.size);
            GamePanel gp = new GamePanel(buttonsBoard);
            gp.Show();
            // zaciagnij ustawienia z pliku i zrob panel w konstruktorze
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            try
            {
                sp.Show();
            }
            catch (Exception ex) { 
            
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
                Application.Exit();
        }

        private void findMusicButton_Click(object sender, EventArgs e)
        {

            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
                files = openFileDialog1.SafeFileNames;
                path = openFileDialog1.FileNames;
                for (int i = 0; i < files.Length; i++){
                    musicList.Items.Add(files[i]);
                }
            }
        }
        private void musicList_SelectedIndexChanged(object sender, EventArgs e){
            Player.URL = path[musicList.SelectedIndex];
        }
    }
    }
