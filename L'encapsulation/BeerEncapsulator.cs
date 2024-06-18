using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L_encapsulation
{
    internal class BeerEncapsulator
    {
        private int BOTTLE_VOLUME = 33;
        private double _avalaibleBeerVolume { get; set; }
        private int _avalaibleBottles { get; set; }
        private int _avalaibleCapsules { get; set; }

        /// <summary>
        /// Declaration of class
        /// </summary>
        /// <param name="avalaibleCapsules"></param>
        /// <param name="avalaibleBottles"></param>
        public BeerEncapsulator(int avalaibleCapsules, int avalaibleBottles)
        {
            SetQuantityOfCapsules(avalaibleCapsules);
            SetQuantityOfBottles (avalaibleBottles);
            _avalaibleBeerVolume = 0;
        }

        /// <summary>
        /// Setting a new number of bottles
        /// </summary>
        /// <param name="numberOfBottles"></param>
        public void SetQuantityOfBottles(int numberOfBottles)
        {
            _avalaibleBottles = numberOfBottles;
        }

        /// <summary>
        /// Setting a new number of capsules
        /// </summary>
        /// <param name="numberOfCapsules"></param>
        public void SetQuantityOfCapsules(int numberOfCapsules)
        {
            _avalaibleCapsules = numberOfCapsules;
        }

        /// <summary>
        /// Add beer to _avalaibleBeerVolume
        /// </summary>
        /// <param name="quantityOfBeer"></param>
        public void AddBeer(double quantityOfBeer)
        {
            _avalaibleBeerVolume = _avalaibleBeerVolume + quantityOfBeer;
        }

        /// <summary>
        /// Produce encapsulated beer bottles if the quantity of the ingredients is sufficient.
        /// Returns the quantity of produced bottles.
        /// </summary>
        /// <param name="nombreBotteles"></param>
        /// <returns></returns>
        public int ProduceEncapsulatedBeerBottles(int nombreBotteles)
        {
            int result = 0;
            if (_avalaibleBottles >= nombreBotteles && _avalaibleCapsules >= nombreBotteles && _avalaibleBeerVolume >= nombreBotteles * BOTTLE_VOLUME)
            {
                _avalaibleBottles = _avalaibleBottles - nombreBotteles;
                _avalaibleCapsules = _avalaibleCapsules - nombreBotteles;
                _avalaibleBeerVolume = _avalaibleBeerVolume - nombreBotteles * BOTTLE_VOLUME;
                result = nombreBotteles;
            }
            return result;
        }

    }
}
