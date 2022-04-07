using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Models
{
    internal class Store
    {
        public int Id { get; set; }
        public string Name { get; set; }
        private List<Game> _games;
        public void AddGame(Game game)
        {
            _games.Add(game);
        }
        public void GetGameById(int? id)
        {
            
        }
        public void RemoveGameById()
        {

        }
        public void FilterGamesByPrice()
        {

        }
        public void FilterGamesByDiscountedPrice()
        {

        }
    }
}
