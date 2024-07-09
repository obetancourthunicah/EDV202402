using ClinicaMedicaLib.Controladores;
using ClinicaMedicaLib.Pokemon;
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
        public WebApi()
        {
            InitializeComponent();
        }

        private async void btnGetList_Click(object sender, EventArgs e)
        {
            pokemonListResponse =  await PokemonController.GetPokemonList();

            lblResult.Text = "Next: " + pokemonListResponse.next + "\n";
            lblResult.Text += "Previous: " + pokemonListResponse.previous + "\n";
            lblResult.Text += "Count: " + pokemonListResponse.count + "\n";
            lblResult.Text += "Results: \n";
            if (pokemonListResponse.results == null)
            {
                lblResult.Text += "No results\n";
                return;
            }
            foreach( PokemonListItem item in pokemonListResponse.results)
            {
                lblResult.Text += item.name + "\n";
            }
        }
    }
}
