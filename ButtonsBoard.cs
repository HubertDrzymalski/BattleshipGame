using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BattleshipGame
{

    public class ButtonsBoard
    {
        public Helpers help = new Helpers();
        public GamePanel gPanel;
        public Button button;
        public Button previousButton;
        public Button startingButton;
        public Button aiAttackedButton;
        public Panel panel1, panel2;
        int sizex = 60, sizey = 60, x = 0, y = 0;
        public List<Button> tab = new List<Button>();
        List<Button> tabAI = new List<Button>();
        List<Button> usedSpace = new List<Button>();
        List<Button> usedSpacePlayer = new List<Button>();
        public int stage1 = 0, stage2 = 0;
        int currentSize;
        int currentAmount1, currentAmount2 = 0;
        bool fight = false,containsUsedSpace = false;
        public Random random = new Random();
        public int randomX, randomY;


        int carriers, battleships, destroyers, submarines, patrol,size;
        public Color color;
        public Button[,] helpTab;
        public int row = 0, column = 0;
        public int aiScore = 0, playerScore = 0;
        public int maxPoints;
        public int aiAttack;
        public bool aiAttacked = true, playerAttacked = false, roundEnded = false;
        public string winner;
        public ButtonsBoard(string Ccarriers, string Cbattleships, string Cdestroyers, string Csubmarines, string Cpatrol, string Ccolor, string Csize) {
             carriers = Convert.ToInt32(Ccarriers);
             battleships = Convert.ToInt32(Cbattleships);
             destroyers = Convert.ToInt32(Cdestroyers);
             submarines = Convert.ToInt32(Csubmarines);
             patrol = Convert.ToInt32(Cpatrol);
             color = Color.FromArgb(Convert.ToInt32(Ccolor));
             size = Convert.ToInt32(Csize);
            panel1 = new Panel();
            helpTab = new Button[size,size];
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {

                    x = j * sizex;
                    y = i * sizey;
                    button = new Button();
                    button.Click += new System.EventHandler(Button_Click);
                    button.Size = new System.Drawing.Size(sizex, sizey);
                    Point point = new Point(x, y);
                    button.Location = point;
                    this.panel1.Location = new System.Drawing.Point(6, 6);
                    this.panel1.Size = new System.Drawing.Size(size * sizex, size * sizey);
                    button.BackColor = Color.NavajoWhite;
                    panel1.Controls.Add(button);
                    tab.Add(button);
                    helpTab[i,j] = button;
                }
            }
            ///
            panel2 = new Panel();
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {

                    x = j * sizex;
                    y = i * sizey;
                    button = new Button();
                    button.Click += new System.EventHandler(Button_Click);
                    button.Size = new System.Drawing.Size(sizex, sizey);
                    Point point = new Point(x, y);
                    button.Location = point;
                    this.panel2.Location = new System.Drawing.Point(size * sizex +170, 6);
                    this.panel2.Size = new System.Drawing.Size(size * sizex, size * sizey);
                    button.BackColor = Color.NavajoWhite;
                    panel2.Controls.Add(button);
                    tabAI.Add(button);
                }
            }
            ///////////////////////////////////////////AI DEPLOYMENT
            ////////////////////////////////AI DEPLOYING CARRIERS
            while (currentAmount2 < carriers)
            {
                if (random.Next(0, 10) % 2 == 1)
                {
                    randomX = random.Next(0, size);
                    randomY = random.Next(0, size - 4);
                    for (int i = 0; i < 5; i++)
                    {
                        if (i == 0)
                        {
                            for (int j = 0; j < 5; j++)
                            {
                                if (usedSpace.Contains(tabAI[randomX + j * size + randomY * size]))
                                {
                                    containsUsedSpace = true;
                                }
                            }
                        }
                        if (!containsUsedSpace)
                        {
                            usedSpace.Add(tabAI[randomX + i * size + randomY * size]);
                        }
                    }
                }
                else
                {
                    randomX = random.Next(0, size - 4);
                    randomY = random.Next(0, size);

                    for (int i = 0; i < 5; i++)
                    {
                        if (i == 0)
                        {
                            for (int j = 0; j < 5; j++)
                            {
                                if (usedSpace.Contains(tabAI[randomX + j + randomY * size]))
                                {
                                    containsUsedSpace = true;
                                }
                            }
                        }
                        if (!containsUsedSpace)
                        {
                            usedSpace.Add(tabAI[randomX + i + randomY * size]);
                            
                        }
                    }
                };
                if (!containsUsedSpace)
                    currentAmount2++;
                containsUsedSpace = false;
            }
            currentAmount2 = 0;
            //////////////AI DEPLYING BATTLESHIPS
            while (currentAmount2 < battleships)
            {
                if (random.Next(0, 10) % 2 == 1)
                {
                    randomX = random.Next(0, size);
                    randomY = random.Next(0, size - 3);
                    for (int i = 0; i < 4; i++)
                    {
                        if (i == 0){
                        for (int j = 0; j < 4; j++)
                        {
                            if (usedSpace.Contains(tabAI[randomX + j * size + randomY * size])) {
                                containsUsedSpace = true;
                            }
                        }
                    }
                        if (!containsUsedSpace)
                        {

                            usedSpace.Add(tabAI[randomX + i * size + randomY * size]);
                        }
                    }
                }
                else
                {
                    randomX = random.Next(0, size - 3);
                    randomY = random.Next(0, size);

                    for (int i = 0; i < 4; i++)
                    {
                        if (i == 0)
                        {
                            for (int j = 0; j < 4; j++)
                            {
                                if (usedSpace.Contains(tabAI[randomX + j + randomY * size]))
                                {
                                    containsUsedSpace = true;
                                }
                            }
                        }
                        if (!containsUsedSpace)
                        {
                            usedSpace.Add(tabAI[randomX + i + randomY * size]);
                        }
                    }
                };
                if(!containsUsedSpace)
                currentAmount2++;
                containsUsedSpace = false;
            }
            currentAmount2 = 0;
            //////////////AI DEPLYING DESTROYERS
            while (currentAmount2 < destroyers)
            {
                if (random.Next(0, 10) % 2 == 1)
                {
                    randomX = random.Next(0, size);
                    randomY = random.Next(0, size - 2);
                    for (int i = 0; i < 3; i++)
                    {
                        if (i == 0)
                        {
                            for (int j = 0; j < 3; j++)
                            {
                                if (usedSpace.Contains(tabAI[randomX + j * size + randomY * size]))
                                {
                                    containsUsedSpace = true;
                                }
                            }
                        }
                        if (!containsUsedSpace)
                        {
                            usedSpace.Add(tabAI[randomX + i * size + randomY * size]);
                        }
                    }
                }
                else
                {
                    randomX = random.Next(0, size - 2);
                    randomY = random.Next(0, size);
                    for (int i = 0; i < 3; i++)
                    {
                        if (i == 0)
                        {
                            for (int j = 0; j < 3; j++)
                            {
                                if (usedSpace.Contains(tabAI[randomX + j + randomY * size]))
                                {
                                    containsUsedSpace = true;
                                }
                            }
                        }
                        if (!containsUsedSpace)
                        {
                            usedSpace.Add(tabAI[randomX + i + randomY * size]);
                        }
                    }
                };
                if (!containsUsedSpace)
                    currentAmount2++;
                containsUsedSpace = false;
            }
            currentAmount2 = 0;
            //////////////AI DEPLYING SUBMARINES
            while (currentAmount2 < submarines)
            {
                if (random.Next(0, 10) % 2 == 1)
                {
                    randomX = random.Next(0, size);
                    randomY = random.Next(0, size - 1);
                    for (int i = 0; i < 2; i++)
                    {
                        if (i == 0)
                        {
                            for (int j = 0; j < 2; j++)
                            {
                                if (usedSpace.Contains(tabAI[randomX + j * size + randomY * size]))
                                {
                                    containsUsedSpace = true;
                                }
                            }
                        }
                        if (!containsUsedSpace)
                        {

                            usedSpace.Add(tabAI[randomX + i * size + randomY * size]);
                        }
                    }
                }
                else
                {
                    randomX = random.Next(0, size - 1);
                    randomY = random.Next(0, size);
                    for (int i = 0; i < 2; i++)
                    {
                        if (i == 0)
                        {
                            for (int j = 0; j < 2; j++)
                            {
                                if (usedSpace.Contains(tabAI[randomX + j + randomY * size]))
                                {
                                    containsUsedSpace = true;
                                }
                            }
                        }
                        if (!containsUsedSpace)
                        {
                            usedSpace.Add(tabAI[randomX + i + randomY * size]);
                        }
                    }
                };
                if (!containsUsedSpace)
                    currentAmount2++;
                containsUsedSpace = false;
            }
            currentAmount2 = 0;
            //////////////AI DEPLYING PATROLS
            while (currentAmount2 < patrol)
            {
                if (random.Next(0, 10) % 2 == 1)
                {
                    randomX = random.Next(0, size);
                    randomY = random.Next(0, size);
                    for (int i = 0; i < 1; i++)
                    {
                        if (i == 0)
                        {
                            for (int j = 0; j < 1; j++)
                            {
                                if (usedSpace.Contains(tabAI[randomX + j * size + randomY * size]))
                                {
                                    containsUsedSpace = true;
                                }
                            }
                        }
                        if (!containsUsedSpace)
                        {

                            usedSpace.Add(tabAI[randomX + i * size + randomY * size]);
                        }
                    }
                }
                else
                {
                    randomX = random.Next(0, size);
                    randomY = random.Next(0, size);
                    for (int i = 0; i < 1; i++)
                    {
                        if (i == 0)
                        {
                            for (int j = 0; j < 1; j++)
                            {
                                if (usedSpace.Contains(tabAI[randomX + j + randomY * size]))
                                {
                                    containsUsedSpace = true;
                                }
                            }
                        }
                        if (!containsUsedSpace)
                        {
                            usedSpace.Add(tabAI[randomX + i + randomY * size]);
                        }
                    }
                };
                if (!containsUsedSpace)
                    currentAmount2++;
                containsUsedSpace = false;
            }
            currentAmount2 = 0;
            maxPoints = usedSpace.Count();


        }
        public void Button_Click(object sender, EventArgs e)
        {
            if (gPanel == null)
            {
                foreach (Form form in Application.OpenForms)
                {
                    if (form.GetType() == typeof(GamePanel))
                    {
                        gPanel = (GamePanel)form;
                    }
                }
            }
            Button button = (Button)sender;
            if (panel1.Contains(button)&&!fight)
            {
                ///////////////////////////////////////////CARIERY
                if (carriers == 0 && stage1 == 0) stage1++;
                if (stage1 == 0 && carriers > 0)
                {
                    if (currentSize == 0 && button.BackgroundImage == null)
                    {
                        button.BackgroundImage = Image.FromFile(@"img\carBack.jpg");
                        button.BackgroundImageLayout = ImageLayout.Stretch;
                        previousButton = button;
                        startingButton = button;
                        usedSpacePlayer.Add(button);
                        currentSize++;
                        ///
                        for (int i = 0; i < size; i++)
                        {
                            for (int j = 0; j < size; j++)
                            {
                                if (helpTab[i, j] == button)
                                {
                                    row = i;
                                    column = j;
                                }
                            }
                        }
                        ///
                    }
                    else
                    {
                        if (help.rowContains(helpTab, row, size, button, previousButton))
                        {
                            if (tab.IndexOf(previousButton) > tab.IndexOf(button)) previousButton.BackgroundImage.RotateFlip(RotateFlipType.Rotate180FlipY);
                            button.BackgroundImage = Image.FromFile(@"img\carMid.jpg");
                            button.BackgroundImageLayout = ImageLayout.Stretch;

                            button.Refresh();
                            previousButton.Refresh();

                            previousButton = button;
                            usedSpacePlayer.Add(button);
                            currentSize++;
                            if (currentSize == 5)
                            {

                                button.BackgroundImage = Image.FromFile(@"img\carFront.jpg");
                                if (tab.IndexOf(startingButton) > tab.IndexOf(button)) button.BackgroundImage.RotateFlip(RotateFlipType.Rotate180FlipY);
                                button.BackgroundImageLayout = ImageLayout.Stretch;
                            }

                        }
                        if (help.columnContains(helpTab, column, size, button, previousButton))
                        {
                            button.BackgroundImage = Image.FromFile(@"img\carMid.jpg");
                            button.BackgroundImageLayout = ImageLayout.Stretch;
                            button.BackgroundImage.RotateFlip(RotateFlipType.Rotate90FlipY);
                            if (tab.IndexOf(previousButton) < tab.IndexOf(button)) previousButton.BackgroundImage.RotateFlip(RotateFlipType.Rotate180FlipNone);

                            button.Refresh();
                            previousButton.Refresh();
                            previousButton = button;
                            usedSpacePlayer.Add(button);
                            currentSize++;
                            if (currentSize == 5)
                            {

                                button.BackgroundImage = Image.FromFile(@"img\carFront.jpg");
                                if (tab.IndexOf(startingButton) < tab.IndexOf(button))
                                {
                                    button.BackgroundImage.RotateFlip(RotateFlipType.Rotate270FlipY);
                                    startingButton.BackgroundImage.RotateFlip(RotateFlipType.Rotate90FlipY);
                                }
                                else
                                {
                                    button.BackgroundImage.RotateFlip(RotateFlipType.Rotate90FlipY);
                                    startingButton.BackgroundImage.RotateFlip(RotateFlipType.Rotate90FlipY);
                                }
                                button.BackgroundImageLayout = ImageLayout.Stretch;
                            }
                        }
                        startingButton.Refresh();

                    }

                    if (currentSize == 5)
                    {
                        currentSize = 0;
                        currentAmount1++;
                    }
                    if (currentAmount1 == carriers)
                    {
                        stage1++;
                        currentAmount1 = 0;
                    }
                }
                ///////////////////////////////////////////BATTLESHIPS
                if (battleships == 0 && stage1 == 1) stage1++;
                    if (stage1 == 1 && battleships>0)
                    {
                    if (currentSize == 0 && button.BackgroundImage == null)
                    {
                        button.BackgroundImage = Image.FromFile(@"img\batBack.jpg");
                        button.BackgroundImageLayout = ImageLayout.Stretch;
                        previousButton = button;
                        startingButton = button;
                        usedSpacePlayer.Add(button);
                        currentSize++;
                        ///
                        for (int i = 0; i < size; i++)
                        {
                            for (int j = 0; j < size; j++)
                            {
                                if (helpTab[i, j] == button)
                                {
                                    row = i;
                                    column = j;
                                }
                            }
                        }
                        ///
                    }
                    else
                    {
                        if (help.rowContains(helpTab, row, size, button, previousButton))
                        {
                            if (tab.IndexOf(previousButton) > tab.IndexOf(button)) previousButton.BackgroundImage.RotateFlip(RotateFlipType.Rotate180FlipY);
                            button.BackgroundImage = Image.FromFile(@"img\batMid.jpg");
                            button.BackgroundImageLayout = ImageLayout.Stretch;

                            button.Refresh();
                            previousButton.Refresh();

                            previousButton = button;
                            currentSize++;
                            usedSpacePlayer.Add(button);
                            if (currentSize == 4)
                            {

                                button.BackgroundImage = Image.FromFile(@"img\batFront.jpg");
                                if (tab.IndexOf(startingButton) > tab.IndexOf(button)) button.BackgroundImage.RotateFlip(RotateFlipType.Rotate180FlipY);
                                button.BackgroundImageLayout = ImageLayout.Stretch;
                            }

                        }
                        if (help.columnContains(helpTab, column, size, button, previousButton))
                        {
                            button.BackgroundImage = Image.FromFile(@"img\batMid.jpg");
                            button.BackgroundImageLayout = ImageLayout.Stretch;
                            button.BackgroundImage.RotateFlip(RotateFlipType.Rotate90FlipY);
                            if (tab.IndexOf(previousButton) < tab.IndexOf(button)) previousButton.BackgroundImage.RotateFlip(RotateFlipType.Rotate180FlipNone);

                            button.Refresh();
                            previousButton.Refresh();

                            previousButton = button;
                            currentSize++;
                            usedSpacePlayer.Add(button);
                            if (currentSize == 4)
                            {

                                button.BackgroundImage = Image.FromFile(@"img\batFront.jpg");
                                if (tab.IndexOf(startingButton) < tab.IndexOf(button))
                                {
                                    button.BackgroundImage.RotateFlip(RotateFlipType.Rotate270FlipY);
                                    startingButton.BackgroundImage.RotateFlip(RotateFlipType.Rotate90FlipY);
                                }
                                else
                                {
                                    button.BackgroundImage.RotateFlip(RotateFlipType.Rotate90FlipY);
                                    startingButton.BackgroundImage.RotateFlip(RotateFlipType.Rotate90FlipY);
                                }
                                button.BackgroundImageLayout = ImageLayout.Stretch;
                            }
                        }
                        startingButton.Refresh();

                    }
                    if (currentSize == 4)
                        {
                            currentSize = 0;
                            currentAmount1++;
                        }
                        if (currentAmount1 == battleships)
                        {
                            stage1++;
                            currentAmount1 = 0;
                        }
                    }
                //////////////////////////////////////////DESTORYERS
                if (destroyers == 0 && stage1 == 2) stage1++;
                if (stage1 == 2 && destroyers>0)
                    {
                    if (currentSize == 0 && button.BackgroundImage == null)
                    {
                        button.BackgroundImage = Image.FromFile(@"img\desBack.jpg");
                        button.BackgroundImageLayout = ImageLayout.Stretch;
                        previousButton = button;
                        startingButton = button;
                        usedSpacePlayer.Add(button);
                        currentSize++;
                        ///
                        for (int i = 0; i < size; i++)
                        {
                            for (int j = 0; j < size; j++)
                            {
                                if (helpTab[i, j] == button)
                                {
                                    row = i;
                                    column = j;
                                }
                            }
                        }
                        ///
                    }
                    else
                    {
                        if (help.rowContains(helpTab, row, size, button, previousButton))
                        {
                            if (tab.IndexOf(previousButton) > tab.IndexOf(button)) previousButton.BackgroundImage.RotateFlip(RotateFlipType.Rotate180FlipY);
                            button.BackgroundImage = Image.FromFile(@"img\desMid.jpg");
                            button.BackgroundImageLayout = ImageLayout.Stretch;

                            button.Refresh();
                            previousButton.Refresh();

                            previousButton = button;
                            currentSize++;
                            usedSpacePlayer.Add(button);
                            if (currentSize == 3)
                            {

                                button.BackgroundImage = Image.FromFile(@"img\desFront.jpg");
                                if (tab.IndexOf(startingButton) > tab.IndexOf(button)) button.BackgroundImage.RotateFlip(RotateFlipType.Rotate180FlipY);
                                button.BackgroundImageLayout = ImageLayout.Stretch;
                            }

                        }
                        if (help.columnContains(helpTab, column, size, button, previousButton))
                        {
                            button.BackgroundImage = Image.FromFile(@"img\desMid.jpg");
                            button.BackgroundImageLayout = ImageLayout.Stretch;
                            button.BackgroundImage.RotateFlip(RotateFlipType.Rotate90FlipY);
                            if (tab.IndexOf(previousButton) < tab.IndexOf(button)) previousButton.BackgroundImage.RotateFlip(RotateFlipType.Rotate180FlipNone);

                            button.Refresh();
                            previousButton.Refresh();

                            previousButton = button;
                            currentSize++;
                            usedSpacePlayer.Add(button);
                            if (currentSize == 3)
                            {

                                button.BackgroundImage = Image.FromFile(@"img\desFront.jpg");
                                if (tab.IndexOf(startingButton) < tab.IndexOf(button))
                                {
                                    button.BackgroundImage.RotateFlip(RotateFlipType.Rotate270FlipY);
                                    startingButton.BackgroundImage.RotateFlip(RotateFlipType.Rotate90FlipY);
                                }
                                else
                                {
                                    button.BackgroundImage.RotateFlip(RotateFlipType.Rotate90FlipY);
                                    startingButton.BackgroundImage.RotateFlip(RotateFlipType.Rotate90FlipY);
                                }
                                button.BackgroundImageLayout = ImageLayout.Stretch;
                            }
                        }
                        startingButton.Refresh();

                    }
                    if (currentSize == 3)
                        {
                            currentSize = 0;
                            currentAmount1++;
                        }
                        if (currentAmount1 == destroyers)
                        {
                            stage1++;
                            currentAmount1 = 0;
                        }
                    }
                //////////////////////////////////////////SUBMARINES
                if (submarines == 0 && stage1 == 3) stage1++;
                if (stage1 == 3 && submarines>0)
                    {
                    if (currentSize == 0 && button.BackgroundImage == null)
                    {
                        button.BackgroundImage = Image.FromFile(@"img\subBack.jpg");
                        button.BackgroundImageLayout = ImageLayout.Stretch;
                        previousButton = button;
                        startingButton = button;
                        currentSize++;
                        usedSpacePlayer.Add(button);
                        ///
                        for (int i = 0; i < size; i++)
                        {
                            for (int j = 0; j < size; j++)
                            {
                                if (helpTab[i, j] == button)
                                {
                                    row = i;
                                    column = j;
                                }
                            }
                        }
                        ///
                    }
                    else
                    {
                        if (help.rowContains(helpTab, row, size, button, previousButton))
                        {
                            if (tab.IndexOf(previousButton) > tab.IndexOf(button)) previousButton.BackgroundImage.RotateFlip(RotateFlipType.Rotate180FlipY);
                            button.BackgroundImage = Image.FromFile(@"img\subFront.jpg");
                            button.BackgroundImageLayout = ImageLayout.Stretch;

                            button.Refresh();
                            previousButton.Refresh();

                            previousButton = button;
                            currentSize++;
                            usedSpacePlayer.Add(button);
                            if (currentSize == 2)
                            {

                                button.BackgroundImage = Image.FromFile(@"img\subFront.jpg");
                                if (tab.IndexOf(startingButton) > tab.IndexOf(button)) button.BackgroundImage.RotateFlip(RotateFlipType.Rotate180FlipY);
                                button.BackgroundImageLayout = ImageLayout.Stretch;
                            }

                        }
                        if (help.columnContains(helpTab, column, size, button, previousButton))
                        {
                            button.BackgroundImage = Image.FromFile(@"img\subFront.jpg");
                            button.BackgroundImageLayout = ImageLayout.Stretch;
                            button.BackgroundImage.RotateFlip(RotateFlipType.Rotate90FlipY);
                            if (tab.IndexOf(previousButton) < tab.IndexOf(button)) previousButton.BackgroundImage.RotateFlip(RotateFlipType.Rotate180FlipNone);

                            button.Refresh();
                            previousButton.Refresh();

                            previousButton = button;
                            currentSize++;
                            usedSpacePlayer.Add(button);
                            if (currentSize == 2)
                            {

                                button.BackgroundImage = Image.FromFile(@"img\subFront.jpg");
                                if (tab.IndexOf(startingButton) < tab.IndexOf(button))
                                {
                                    button.BackgroundImage.RotateFlip(RotateFlipType.Rotate270FlipY);
                                    startingButton.BackgroundImage.RotateFlip(RotateFlipType.Rotate90FlipY);
                                }
                                else
                                {
                                    button.BackgroundImage.RotateFlip(RotateFlipType.Rotate90FlipY);
                                    startingButton.BackgroundImage.RotateFlip(RotateFlipType.Rotate90FlipY);
                                }
                                button.BackgroundImageLayout = ImageLayout.Stretch;
                            }
                        }

                        startingButton.Refresh();
                    }
                    if (currentSize == 2)
                        {
                            currentSize = 0;
                            currentAmount1++;
                        }
                        if (currentAmount1 == submarines)
                        {
                            stage1++;
                            currentAmount1 = 0;
                        }
                    }
                //////////////////////////////////////////PATROL BOATS
                if (patrol == 0 && stage1 == 4) stage1++;
                if (stage1 == 4 && patrol>0)
                    {
                    if (currentSize == 0 && button.BackgroundImage == null)
                    {
                        button.BackgroundImage = Image.FromFile(@"img\patrol.jpg");
                        button.BackgroundImageLayout = ImageLayout.Stretch;
                        previousButton = button;
                        startingButton = button;
                        currentSize++;
                        ///
                        for (int i = 0; i < size; i++)
                        {
                            for (int j = 0; j < size; j++)
                            {
                                if (helpTab[i, j] == button)
                                {
                                    row = i;
                                    column = j;
                                }
                            }
                        }
                        ///
                    }
                    if (currentSize == 1)
                        {
                            currentSize = 0;
                            currentAmount1++;
                        usedSpacePlayer.Add(button);
                    }
                        if (currentAmount1 == patrol)
                        {
                            stage1++;
                            currentAmount1 = 0;
                        }
                }
                    ////////////////////////////koniec placementu
                    if (stage1 == 5) fight = true;
                ///koniec placementu\
            }
            if (fight && !roundEnded) {
                Console.WriteLine(usedSpace.Count.ToString());
                Console.WriteLine(usedSpacePlayer.Count.ToString());
                if (panel2.Contains(button))
                    {
                        if (usedSpace.Contains(button))
                        {
                            button.BackgroundImage = Image.FromFile(@"img\fire.jpg");
                            button.BackgroundImageLayout = ImageLayout.Stretch;
                            playerScore++;
                            playerAttacked = true;
                            usedSpace.Remove(button);
                        gPanel.historyTextBox.AppendText(Environment.NewLine + "PLA-hit!");
                        }
                        if (button.BackgroundImage == null)
                        {
                            button.BackgroundImage = Image.FromFile(@"img\miss.jpg");
                            button.BackgroundImageLayout = ImageLayout.Stretch;
                        gPanel.historyTextBox.AppendText(Environment.NewLine + "PLA-miss!");
                        playerAttacked = true;
                        }
                    if (!playerAttacked) return;
                    }
                playerAttacked = false;
                ///////////////////////////////////////////////////////
                if (help.checkWinner(playerScore, maxPoints))
                        {
                            roundEnded = true;
                            winner = "Player";
                        }
                ///////////////////////////////////////////////////////
                    while (!aiAttacked && !roundEnded)
                    {
                        aiAttack = random.Next(0, size * size);
                        aiAttackedButton = tab.ElementAt(aiAttack);
                        if (usedSpacePlayer.Contains(aiAttackedButton))
                        {
                            aiAttackedButton.BackgroundImage = Image.FromFile(@"img\fire.jpg");
                            aiScore++;
                            aiAttacked = true;
                            usedSpacePlayer.Remove(aiAttackedButton);
                        gPanel.historyTextBox.AppendText(Environment.NewLine + "AI-hit!");
                    }
                        else {
                            if (aiAttackedButton.BackgroundImage == null)
                            {
                                aiAttackedButton.BackgroundImage = Image.FromFile(@"img\miss.jpg");
                                aiAttacked = true;
                            gPanel.historyTextBox.AppendText(Environment.NewLine + "AI-miss!");
                        }
                        }
                        aiAttackedButton.BackgroundImageLayout = ImageLayout.Stretch;
                    }
                    aiAttacked = false;
                 ///////////////////////////////////////////////////////
                    if (help.checkWinner(aiScore, maxPoints)) {
                        roundEnded = true;
                        winner = "AI";
                }
                 ///////////////////////////////////////////////////////
                
            }
            help.actualizeGamePanel(playerScore, aiScore);
            if (roundEnded) help.EndGame(this);
        }
        ///koniec button clicka
        //////koniec klasy
        }
    }
