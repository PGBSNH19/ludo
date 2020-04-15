using GameEngine;
using GameEngine.PlayerType;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ludo
{
    public partial class GameSessionWindow : Form
    {
        GameSession gameSession = new GameSession();
        public GameSessionWindow()
        {
            InitializeComponent();
            gameSession.AddPlayer(new Player(new GreenPlayer()));
        }

        private void panelGameBoard_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = panelGameBoard.CreateGraphics();

        }

        private Brush GetBrushForPlayerType(IPlayerType playerType)
        {
            if (playerType.GetType() == typeof(BluePlayer))
            {
                return new SolidBrush(Color.Blue);
            }
            else if (playerType.GetType() == typeof(GreenPlayer))
            {
                return new SolidBrush(Color.Green);
            }
            else if (playerType.GetType() == typeof(RedPlayer))
            {
                return new SolidBrush(Color.Red);
            }
            else if (playerType.GetType() == typeof(YellowPlayer))
            {
                return new SolidBrush(Color.Yellow);
            }

            return new SolidBrush(Color.Gray);
        }
    }
}
