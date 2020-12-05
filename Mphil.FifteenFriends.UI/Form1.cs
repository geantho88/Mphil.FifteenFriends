using Mphil.Fifteenfriends.Domain.Models;
using Mphil.Fifteenfriends.Services.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mphil.FifteenFriends.UI
{
    public partial class Form1 : Form
    {
        private List<Person> _players;
        private readonly IDeckersMeeting _gameService;
        private readonly Dictionary<int, double> _rollResultChances;
        public Form1(IDeckersMeeting gameService)
        {
            InitializeComponent();
            _rollResultChances = new Dictionary<int, double>();
            _gameService = gameService;
        }

        private void GameStartButton_Click(object sender, EventArgs e)
        {
            StartGame();

            _rollResultChances.Clear();

            _rollResultChances.Add(1, 0.0);
            _rollResultChances.Add(2, 0.2);
            _rollResultChances.Add(3, 0.3);
            _rollResultChances.Add(4, 0.5);
            _rollResultChances.Add(5, 0.0);
            _rollResultChances.Add(6, 0.2);
        }

        private void StartGame()
        {
            _gameService.ClearPlayers();

            _gameService.CreateCardPlayers((int)CardPlayersInput.Value);
            _gameService.CreateDicePlayers((int)DicePlayersInput.Value, _rollResultChances);
            _gameService.CreateCardDicePlayers((int)CardDicePlayersInput.Value, _rollResultChances);

            if (_gameService.CanStartGame())
            {
                _players = _gameService.GetPlayers();
                var counter = 0;

                var x = 196;
                var y = 60;

                foreach (var player in _players)
                {
                    counter++;

                    PictureBox picture = new PictureBox
                    {
                        Name = player.FullName,
                        Size = new Size(100, 150),
                        SizeMode = PictureBoxSizeMode.StretchImage,
                        Location = new Point(x, y),
                        Visible = true,
                    };

                    picture.MouseClick += new MouseEventHandler(player_Click);

                    Label lbl = new Label
                    {
                        Text = player.FullName,
                        ForeColor = Color.Black,
                        Location = new Point(x, picture.Height + y),
                        Height = 50,
                        Width = 100,
                        TextAlign = ContentAlignment.MiddleCenter
                    };

                    picture.ImageLocation = @"Content\Images\player.jpg";
                    Controls.Add(picture);
                    Controls.Add(lbl);

                    if (counter % 5 == 0)
                    {
                        x = 196;
                        y += 210;
                    }
                    else
                    {
                        x += 108;
                    }
                }
            }
            else
            {
                MessageBox.Show("Ανώτατο όριο 15 παικτών. Παρακαλώ μειώστε το σύνολο των παικτών.");
            }
        }

        private void player_Click(object sender, EventArgs e)
        {
            PictureBox clickedPictureBox = sender as PictureBox;
            var selectedPlayer = _players.FirstOrDefault(a => a.FullName == clickedPictureBox.Name);
            
            Form2 form2 = new Form2(selectedPlayer, _gameService);
            form2.Show();            
        }
    }
}
