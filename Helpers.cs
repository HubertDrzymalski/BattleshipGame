using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BattleshipGame
{
    public class Helpers
    {
        public GamePanel gPanel;
        public FormMain fm;
        public bool rowContains(Button[,] tab, int row, int size, Button button, Button previousButton)
        {

            for (int j = 1; j < size - 1; j++)
            {
                if ((tab[row, j] == button || tab[row, size - 1] == button || tab[row, 0] == button) && (tab[row, j - 1] == previousButton || tab[row, j + 1] == previousButton || tab[row, size - 1] == previousButton) && button.BackgroundImage == null)
                {
                    return true;
                }
            }
            return false;
        }

        public bool columnContains(Button[,] tab, int column, int size, Button button, Button previousButton)
        {
            for (int j = 1; j < size - 1; j++)
            {
                if ((tab[j, column] == button || tab[size - 1, column] == button || tab[0, column] == button) && (tab[j - 1, column] == previousButton || tab[j + 1, column] == previousButton || tab[size - 1, column] == previousButton) && button.BackgroundImage == null)
                {
                    return true;
                }
            }
            return false;
        }
        public bool checkWinner(int score, int maxPoints)
        {
            if (score == maxPoints) return true;
            return false;
        }
        public void actualizeGamePanel(int pScore,int aScore) {
              if (gPanel == null) {
                foreach (Form form in Application.OpenForms)
                {
                    if (form.GetType() == typeof(GamePanel))
                    {
                        gPanel = (GamePanel) form;
                    }
                }
            }
            gPanel.playerScoreTextbox.Text = pScore.ToString();
            gPanel.aiScoreTextbox.Text = aScore.ToString();
            gPanel.historyTextBox.SelectionStart = gPanel.historyTextBox.Text.Length;
            gPanel.historyTextBox.ScrollToCaret();
        }
        public void EndGame(ButtonsBoard btns)
        {

            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(FormMain))
                {
                    fm = (FormMain)form;
                }
            }
            if (btns.roundEnded)
            {
                MessageBox.Show("Winner is " + btns.winner, "Round Ended",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                btns.roundEnded = false;
                if (btns.winner == "AI") fm.aiScoreLabel.Text = (Convert.ToInt32(fm.aiScoreLabel.Text) + 1).ToString();
                if (btns.winner == "Player") fm.humanScoreLabel.Text = (Convert.ToInt32(fm.humanScoreLabel.Text) + 1).ToString();
                gPanel.Close();
            }
        }
    }
}
