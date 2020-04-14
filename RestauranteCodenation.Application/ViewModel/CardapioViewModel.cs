using System;
using System.Collections.Generic;
using System.Text;

namespace RestauranteCodenation.Application.ViewModel
{
    public class CardapioViewModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public List<AgendaCardapioViewModel> AgendaCardapio { get; set; }
        public List<PratoViewModel> Prato { get; set; }
    }
}
