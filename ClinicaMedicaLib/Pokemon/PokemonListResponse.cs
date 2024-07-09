using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaMedicaLib.Pokemon
{

    public class PokemonListResponse
    {
        public int count { get; set; }
        public string next { get; set; }
        public object previous { get; set; }
        public PokemonListItem[] results { get; set; }
    }

    public class PokemonListItem
    {
        public string name { get; set; }
        public string url { get; set; }
    }

}
