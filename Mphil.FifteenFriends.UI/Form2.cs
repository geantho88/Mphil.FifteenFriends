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
    public partial class Form2 : Form
    {
        private readonly IDeckersMeeting _gameService;
        private readonly Person _player;
        public Form2()
        {
            InitializeComponent();
        }

        public Form2(Person player, IDeckersMeeting gameService)
        {
            InitializeComponent();
            _player = player;
            _gameService = gameService;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            DeckCards.Text = _gameService.GetRemainingCards().ToString();

            if (_player is CardDicePlayer)
            {
                RollBtn.Visible = true;
                PickCardBtn.Visible = true;
                OpenCards.Visible = true;
            }
            if (_player is CardPlayer)
            {
                PickCardBtn.Visible = true;
                OpenCards.Visible = true;
            }
            if (_player is DicePlayer)
            {
                RollBtn.Visible = true;
            }

            player_fullname_lbl.Text = _player.FullName;
        }

        private void PickCardBtn_Click(object sender, EventArgs e)
        {
            if (_player is CardDicePlayer)
            {
                var pl = _player as CardDicePlayer;
            }
            if (_player is CardPlayer)
            {
                var pl = _player as CardPlayer;
                _gameService.PickCard(pl);
            }
            if (_player is DicePlayer)
            {

            }

            DeckCards.Text = _gameService.GetRemainingCards().ToString();
        }

        private void OpenCards_Click(object sender, EventArgs e)
        {
            if (_player is CardPlayer)
            {
                var pl = _player as CardPlayer;
                var cards = pl.OpenCards();
                foreach (var card in cards)
                {
                    CardCollection.Items.Add(card);
                }
            }
        }

        private void RollBtn_Click(object sender, EventArgs e)
        {
            if (_player is DicePlayer)
            {
                 var pl = _player as DicePlayer;               
                Roll_Result.Text = _gameService.Roll(pl).ToString();
            }
        }
    }
}
