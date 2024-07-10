using ClinicaMedicaLib.Controladores;
using ClinicaMedicaLib.Pokemon;
using DocumentFormat.OpenXml.Drawing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaMedica
{
    public partial class WebApi : Form
    {
        private PokemonListResponse pokemonListResponse;
        private int offset;
        private int limit;
        public WebApi()
        {
            InitializeComponent();
            offset = 0;
            limit = 20;
        }

        private void btnGetList_Click(object sender, EventArgs e)
        {
            loadPokemons();
        }

        private async void loadPokemons()
        {
            pokemonListResponse = await PokemonController.GetPokemonList(offset, limit);

            lblResult.Text = "Results: \n";
            if (pokemonListResponse.results == null)
            {
                lblResult.Text += "No results\n";
                return;
            }
            foreach (PokemonListItem item in pokemonListResponse.results)
            {
                lblResult.Text += item.name + "\n";
            }

            btnPrevious.Visible = pokemonListResponse.previous != null;
            btnNext.Visible = pokemonListResponse.next != null;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            offset += limit;
            loadPokemons();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            offset -= limit;
            loadPokemons();
        }

        private async void btnGetOnePokemon_Click(object sender, EventArgs e)
        {
            string tmpUrl = "https://pokeapi.co/api/v2/pokemon/1/";
            PokemonDetail pokemon = await PokemonController.GetPokemon(tmpUrl);

            if (pokemon != null)
            {
                string tmpMessage = "";
                tmpMessage += "Name: " + pokemon.name + "\n";
                tmpMessage += "Height: " + pokemon.height + "\n";
                tmpMessage += "Weight: " + pokemon.weight + "\n";
                tmpMessage += "Base Experience: " + pokemon.base_experience + "\n";

                MessageBox.Show(tmpMessage);
            }
        }
    }
}
