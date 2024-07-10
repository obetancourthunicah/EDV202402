using ClinicaMedicaLib.Pokemon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClinicasMedicasDao.Web;

namespace ClinicaMedicaLib.Controladores
{
    public class PokemonController
    {
        private static string baseUrl = "https://pokeapi.co/api/v2/pokemon";

        public static async Task<PokemonListResponse> GetPokemonList()
        {
            return await GetPokemonList(0, 20);
        }
        public static async Task<PokemonListResponse> GetPokemonList(int offset, int limit)
        {
            JSONAdapter<PokemonListResponse> _JSONAdapter = new JSONAdapter<PokemonListResponse>();
            string url = baseUrl + "?offset=" + offset + "&limit=" + limit;
            string response = await WebContext.get(url);
            if (response != "error")
            {
                return _JSONAdapter.FromString(response);
            }
            throw new Exception("Error al conectar al API");
        }

        public static async Task<PokemonDetail> GetPokemon( string url)
        {
            JSONAdapter<PokemonDetail> _JSONAdapter = new JSONAdapter<PokemonDetail>();
            string response = await WebContext.get(url);
            if (response != "error")
            {
                return _JSONAdapter.FromString(response);
            }
            throw new Exception("Error al conectar al API");
        }
    }
}
