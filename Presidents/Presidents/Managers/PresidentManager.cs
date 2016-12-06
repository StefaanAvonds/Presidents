using Presidents.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presidents.Managers
{
    public class PresidentManager
    {
        private ObservableCollection<President> _presidents;

        public PresidentManager()
        {
            _presidents = GetLocalPresidents();
        }

        /// <summary>
        /// Returns a list of presidents.
        /// </summary>
        /// <returns>A list of presidents.</returns>
        private ObservableCollection<President> GetLocalPresidents()
        {
            return new ObservableCollection<President> {
                new President ("George Washington", 1, "http://www.americanpresidents.org/images/01_150.gif"),
                new President ("John Adams", 2, "http://www.americanpresidents.org/images/02_150.gif"),
                new President ("Thomas  Jefferson", 3, "http://www.americanpresidents.org/images/03_150.gif"),
                new President ("James Madison", 4, "http://www.americanpresidents.org/images/04_150.gif"),
                new President ("James Monroe", 5, "http://www.americanpresidents.org/images/05_150.gif"),
                new President ("John Quincy Adams", 6, "http://www.americanpresidents.org/images/06_150.gif"),
                new President ("Andrew Jackson", 7, "http://www.americanpresidents.org/images/07_150.gif"),
                new President ("Martin Van Buren", 8, "http://www.americanpresidents.org/images/08_150.gif"),
                new President ("William Henry Harrison", 9, "http://www.americanpresidents.org/images/09_150.gif"),
                new President ("John Tyler", 10, "http://www.americanpresidents.org/images/10_150.gif"),
                new President ("James K. Polk", 11, "http://www.americanpresidents.org/images/11_150.gif"),
                new President ("Zachary Taylor", 12, "http://www.americanpresidents.org/images/12_150.gif"),
                new President ("Millard Fillmore", 13, "http://www.americanpresidents.org/images/13_150.gif"),
                new President ("Franklin Pierce", 14, "http://www.americanpresidents.org/images/14_150.gif"),
                new President ("James Buchanan", 15, "http://www.americanpresidents.org/images/15_150.gif"),

                new President ("George Washington", 1, "http://www.americanpresidents.org/images/01_150.gif"),
                new President ("John Adams", 2, "http://www.americanpresidents.org/images/02_150.gif"),
                new President ("Thomas  Jefferson", 3, "http://www.americanpresidents.org/images/03_150.gif"),
                new President ("James Madison", 4, "http://www.americanpresidents.org/images/04_150.gif"),
                new President ("James Monroe", 5, "http://www.americanpresidents.org/images/05_150.gif"),
                new President ("John Quincy Adams", 6, "http://www.americanpresidents.org/images/06_150.gif"),
                new President ("Andrew Jackson", 7, "http://www.americanpresidents.org/images/07_150.gif"),
                new President ("Martin Van Buren", 8, "http://www.americanpresidents.org/images/08_150.gif"),
                new President ("William Henry Harrison", 9, "http://www.americanpresidents.org/images/09_150.gif"),
                new President ("John Tyler", 10, "http://www.americanpresidents.org/images/10_150.gif"),
                new President ("James K. Polk", 11, "http://www.americanpresidents.org/images/11_150.gif"),
                new President ("Zachary Taylor", 12, "http://www.americanpresidents.org/images/12_150.gif"),
                new President ("Millard Fillmore", 13, "http://www.americanpresidents.org/images/13_150.gif"),
                new President ("Franklin Pierce", 14, "http://www.americanpresidents.org/images/14_150.gif"),
                new President ("James Buchanan", 15, "http://www.americanpresidents.org/images/15_150.gif"),

                new President ("George Washington", 1, "http://www.americanpresidents.org/images/01_150.gif"),
                new President ("John Adams", 2, "http://www.americanpresidents.org/images/02_150.gif"),
                new President ("Thomas  Jefferson", 3, "http://www.americanpresidents.org/images/03_150.gif"),
                new President ("James Madison", 4, "http://www.americanpresidents.org/images/04_150.gif"),
                new President ("James Monroe", 5, "http://www.americanpresidents.org/images/05_150.gif"),
                new President ("John Quincy Adams", 6, "http://www.americanpresidents.org/images/06_150.gif"),
                new President ("Andrew Jackson", 7, "http://www.americanpresidents.org/images/07_150.gif"),
                new President ("Martin Van Buren", 8, "http://www.americanpresidents.org/images/08_150.gif"),
                new President ("William Henry Harrison", 9, "http://www.americanpresidents.org/images/09_150.gif"),
                new President ("John Tyler", 10, "http://www.americanpresidents.org/images/10_150.gif"),
                new President ("James K. Polk", 11, "http://www.americanpresidents.org/images/11_150.gif"),
                new President ("Zachary Taylor", 12, "http://www.americanpresidents.org/images/12_150.gif"),
                new President ("Millard Fillmore", 13, "http://www.americanpresidents.org/images/13_150.gif"),
                new President ("Franklin Pierce", 14, "http://www.americanpresidents.org/images/14_150.gif"),
                new President ("James Buchanan", 15, "http://www.americanpresidents.org/images/15_150.gif"),

                new President ("George Washington", 1, "http://www.americanpresidents.org/images/01_150.gif"),
                new President ("John Adams", 2, "http://www.americanpresidents.org/images/02_150.gif"),
                new President ("Thomas  Jefferson", 3, "http://www.americanpresidents.org/images/03_150.gif"),
                new President ("James Madison", 4, "http://www.americanpresidents.org/images/04_150.gif"),
                new President ("James Monroe", 5, "http://www.americanpresidents.org/images/05_150.gif"),
                new President ("John Quincy Adams", 6, "http://www.americanpresidents.org/images/06_150.gif"),
                new President ("Andrew Jackson", 7, "http://www.americanpresidents.org/images/07_150.gif"),
                new President ("Martin Van Buren", 8, "http://www.americanpresidents.org/images/08_150.gif"),
                new President ("William Henry Harrison", 9, "http://www.americanpresidents.org/images/09_150.gif"),
                new President ("John Tyler", 10, "http://www.americanpresidents.org/images/10_150.gif"),
                new President ("James K. Polk", 11, "http://www.americanpresidents.org/images/11_150.gif"),
                new President ("Zachary Taylor", 12, "http://www.americanpresidents.org/images/12_150.gif"),
                new President ("Millard Fillmore", 13, "http://www.americanpresidents.org/images/13_150.gif"),
                new President ("Franklin Pierce", 14, "http://www.americanpresidents.org/images/14_150.gif"),
                new President ("James Buchanan", 15, "http://www.americanpresidents.org/images/15_150.gif"),

                new President ("George Washington", 1, "http://www.americanpresidents.org/images/01_150.gif"),
                new President ("John Adams", 2, "http://www.americanpresidents.org/images/02_150.gif"),
                new President ("Thomas  Jefferson", 3, "http://www.americanpresidents.org/images/03_150.gif"),
                new President ("James Madison", 4, "http://www.americanpresidents.org/images/04_150.gif"),
                new President ("James Monroe", 5, "http://www.americanpresidents.org/images/05_150.gif"),
                new President ("John Quincy Adams", 6, "http://www.americanpresidents.org/images/06_150.gif"),
                new President ("Andrew Jackson", 7, "http://www.americanpresidents.org/images/07_150.gif"),
                new President ("Martin Van Buren", 8, "http://www.americanpresidents.org/images/08_150.gif"),
                new President ("William Henry Harrison", 9, "http://www.americanpresidents.org/images/09_150.gif"),
                new President ("John Tyler", 10, "http://www.americanpresidents.org/images/10_150.gif"),
                new President ("James K. Polk", 11, "http://www.americanpresidents.org/images/11_150.gif"),
                new President ("Zachary Taylor", 12, "http://www.americanpresidents.org/images/12_150.gif"),
                new President ("Millard Fillmore", 13, "http://www.americanpresidents.org/images/13_150.gif"),
                new President ("Franklin Pierce", 14, "http://www.americanpresidents.org/images/14_150.gif"),
                new President ("James Buchanan", 15, "http://www.americanpresidents.org/images/15_150.gif"),
            };

        }

        /// <summary>
        /// Get all presidents.
        /// </summary>
        /// <returns>A collection of all presidents.</returns>
        public ObservableCollection<President> GetAllPresidents()
        {
            return _presidents;
        }

        /// <summary>
        /// Search for a specific president.
        /// </summary>
        /// <param name="searchText">The search text to find a president.</param>
        /// <returns>A collection of found presidents.</returns>
        public ObservableCollection<President> SearchPresidentBySearchText(string searchText)
        {
            if (String.IsNullOrWhiteSpace(searchText)) return GetAllPresidents();

            string lowerSearchText = searchText.ToLower();

            var collection = new ObservableCollection<President>();
            foreach (var president in _presidents)
            {
                if (president.Name.ToLower().Contains(lowerSearchText)) collection.Add(president);
            }

            return collection;
        }
    }
}
