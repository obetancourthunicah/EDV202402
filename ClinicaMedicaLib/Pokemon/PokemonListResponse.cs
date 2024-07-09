using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaMedicaLib.Pokemon
{
    public class PokemonListResponse
    {
        public string next;
        public string previous;
        public int count;
        public List<PokemonListItem> results;
    }

    public class PokemonListItem {
        public string name;
        public string url;
    }
}
