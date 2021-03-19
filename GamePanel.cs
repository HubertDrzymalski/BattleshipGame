using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BattleshipGame
{
    public partial class GamePanel : Form
    {
        public ButtonsBoard btns;
        public FormMain fm;
        public Helpers help;
        
        public GamePanel()
        {
            InitializeComponent();
        }
        public GamePanel(ButtonsBoard buttonsBoard)
        {
            InitializeComponent();
            btns = buttonsBoard;
            this.Controls.Add(buttonsBoard.panel1);
            this.leaderboardPanel.Location= new Point(buttonsBoard.panel1.Width + 20, 0);
            this.Controls.Add(buttonsBoard.panel2);
            this.Size = new System.Drawing.Size(buttonsBoard.panel1.Width*2+200,buttonsBoard.panel1.Height+50);
            this.BackColor = buttonsBoard.color;
            historyTextBox.Size = new Size(100, buttonsBoard.panel1.Height/4);
            this.ResumeLayout(false);
        }
    }
}
