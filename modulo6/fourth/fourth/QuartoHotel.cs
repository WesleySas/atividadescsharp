using System;
using System.Collections.Generic;
using System.Text;

namespace fourth
{
    class QuartoHotel
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public int Aluguel { get; set; }

        public int Quarto { get; set; }
        
        public QuartoHotel()
        {

        }
        public QuartoHotel(string name, string email, int aluguel, int quarto)
        {
            Name = name;
            Email = email;
            Aluguel = aluguel;
            Quarto = quarto;
        }


    }
}
