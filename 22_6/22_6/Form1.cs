using _22_6.BaseballPlayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _22_6
{
    public partial class Form1 : Form
    {
        private IPlayerRepository repository;
        public Form1()
        {
            InitializeComponent();
            repository = new PlayerRepository();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadAndBindPlayers();
        }

        private void LoadAndBindPlayers(string lastName = null)
        {
            IList<Player> players = null;

            if (lastName != null)
                players = repository.GetPlayersByLastName(lastName);
            else
                players = repository.GetAllPlayers();

            var bindingSource = new BindingSource();
            foreach (var player in players)
                bindingSource.Add(player);

            dgvPlayers.DataSource = bindingSource;
            dgvPlayers.AutoGenerateColumns = true;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadAndBindPlayers(txtPlayerName.Text);
        }
    }
}
