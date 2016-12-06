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
        private bool _showGif;
        
        /// <summary>
        /// Indicates what list of presidents will be shown.
        /// </summary>
        public Boolean ShowGif
        {
            get { return _showGif; }
            set { _showGif = value; }
        }

        public PresidentManager()
        {
            _showGif = false;
        }

        /// <summary>
        /// Returns a collection of presidents with a GIF-image.
        /// </summary>
        /// <returns>A collection of presidents.</returns>
        private ObservableCollection<President> GetLocalPresidentsWithGif()
        {
            return new ObservableCollection<President> {
                new President ("George Washington", 1, "https://www.google.be/url?sa=i&rct=j&q=&esrc=s&source=images&cd=&cad=rja&uact=8&ved=0ahUKEwjllcneyt_QAhXFtBoKHb3ACQAQjRwIBw&url=http%3A%2F%2Fphotobucket.com%2Fimages%2Fdancing%2520banana&psig=AFQjCNFUHb-0IGJ3xhxl5SdE8HCxWF0ePQ&ust=1481114264592662"),
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
        /// Returns a collection of presidents with a JPEG-image.
        /// </summary>
        /// <returns>A collection of presidents.</returns>
        private ObservableCollection<President> GetLocalPresidentsWithJpeg()
        {
            return new ObservableCollection<President> {
                new President ("George Washington", 1, "http://ecx.images-amazon.com/images/I/51cphR%2B3ZnL._AA160_.jpg"),
                new President ("John Adams", 2, "http://ecx.images-amazon.com/images/I/51kbcKJS8XL._AA160_.jpg"),
                new President ("Thomas  Jefferson", 3, "http://ecx.images-amazon.com/images/I/41pqrZz8DcL._AA160_.jpg"),
                new President ("James Madison", 4, "http://ecx.images-amazon.com/images/I/51wJedBh-ML._AA160_.jpg"),
                new President ("James Monroe", 5, "http://ecx.images-amazon.com/images/I/51LivMVFh1L._AA160_.jpg"),
                new President ("John Quincy Adams", 6, "http://ecx.images-amazon.com/images/I/41p9jbunvQL._AA160_.jpg"),
                new President ("Andrew Jackson", 7, "http://ecx.images-amazon.com/images/I/51SDmndXMiL._SL500_SS160_.jpg"),
                new President ("Martin Van Buren", 8, "http://ecx.images-amazon.com/images/I/51JpNQixP0L._SL500_SS160_.jpg"),
                new President ("William Henry Harrison", 9, "http://ecx.images-amazon.com/images/I/41ecoa5CI6L._AA160_.jpg"),
                new President ("John Tyler", 10, "http://ecx.images-amazon.com/images/I/41QLaX4lL4L._AA160_.jpg"),
                new President ("George Washington", 1, "http://ecx.images-amazon.com/images/I/51cphR%2B3ZnL._AA160_.jpg"),
                new President ("John Adams", 2, "http://ecx.images-amazon.com/images/I/51kbcKJS8XL._AA160_.jpg"),
                new President ("Thomas  Jefferson", 3, "http://ecx.images-amazon.com/images/I/41pqrZz8DcL._AA160_.jpg"),
                new President ("James Madison", 4, "http://ecx.images-amazon.com/images/I/51wJedBh-ML._AA160_.jpg"),
                new President ("James Monroe", 5, "http://ecx.images-amazon.com/images/I/51LivMVFh1L._AA160_.jpg"),
                new President ("John Quincy Adams", 6, "http://ecx.images-amazon.com/images/I/41p9jbunvQL._AA160_.jpg"),
                new President ("Andrew Jackson", 7, "http://ecx.images-amazon.com/images/I/51SDmndXMiL._SL500_SS160_.jpg"),
                new President ("Martin Van Buren", 8, "http://ecx.images-amazon.com/images/I/51JpNQixP0L._SL500_SS160_.jpg"),
                new President ("William Henry Harrison", 9, "http://ecx.images-amazon.com/images/I/41ecoa5CI6L._AA160_.jpg"),
                new President ("John Tyler", 10, "http://ecx.images-amazon.com/images/I/41QLaX4lL4L._AA160_.jpg"),
                new President ("George Washington", 1, "http://ecx.images-amazon.com/images/I/51cphR%2B3ZnL._AA160_.jpg"),
                new President ("John Adams", 2, "http://ecx.images-amazon.com/images/I/51kbcKJS8XL._AA160_.jpg"),
                new President ("Thomas  Jefferson", 3, "http://ecx.images-amazon.com/images/I/41pqrZz8DcL._AA160_.jpg"),
                new President ("James Madison", 4, "http://ecx.images-amazon.com/images/I/51wJedBh-ML._AA160_.jpg"),
                new President ("James Monroe", 5, "http://ecx.images-amazon.com/images/I/51LivMVFh1L._AA160_.jpg"),
                new President ("John Quincy Adams", 6, "http://ecx.images-amazon.com/images/I/41p9jbunvQL._AA160_.jpg"),
                new President ("Andrew Jackson", 7, "http://ecx.images-amazon.com/images/I/51SDmndXMiL._SL500_SS160_.jpg"),
                new President ("Martin Van Buren", 8, "http://ecx.images-amazon.com/images/I/51JpNQixP0L._SL500_SS160_.jpg"),
                new President ("William Henry Harrison", 9, "http://ecx.images-amazon.com/images/I/41ecoa5CI6L._AA160_.jpg"),
                new President ("John Tyler", 10, "http://ecx.images-amazon.com/images/I/41QLaX4lL4L._AA160_.jpg"),
                new President ("George Washington", 1, "http://ecx.images-amazon.com/images/I/51cphR%2B3ZnL._AA160_.jpg"),
                new President ("John Adams", 2, "http://ecx.images-amazon.com/images/I/51kbcKJS8XL._AA160_.jpg"),
                new President ("Thomas  Jefferson", 3, "http://ecx.images-amazon.com/images/I/41pqrZz8DcL._AA160_.jpg"),
                new President ("James Madison", 4, "http://ecx.images-amazon.com/images/I/51wJedBh-ML._AA160_.jpg"),
                new President ("James Monroe", 5, "http://ecx.images-amazon.com/images/I/51LivMVFh1L._AA160_.jpg"),
                new President ("John Quincy Adams", 6, "http://ecx.images-amazon.com/images/I/41p9jbunvQL._AA160_.jpg"),
                new President ("Andrew Jackson", 7, "http://ecx.images-amazon.com/images/I/51SDmndXMiL._SL500_SS160_.jpg"),
                new President ("Martin Van Buren", 8, "http://ecx.images-amazon.com/images/I/51JpNQixP0L._SL500_SS160_.jpg"),
                new President ("William Henry Harrison", 9, "http://ecx.images-amazon.com/images/I/41ecoa5CI6L._AA160_.jpg"),
                new President ("John Tyler", 10, "http://ecx.images-amazon.com/images/I/41QLaX4lL4L._AA160_.jpg"),
                new President ("George Washington", 1, "http://ecx.images-amazon.com/images/I/51cphR%2B3ZnL._AA160_.jpg"),
                new President ("John Adams", 2, "http://ecx.images-amazon.com/images/I/51kbcKJS8XL._AA160_.jpg"),
                new President ("Thomas  Jefferson", 3, "http://ecx.images-amazon.com/images/I/41pqrZz8DcL._AA160_.jpg"),
                new President ("James Madison", 4, "http://ecx.images-amazon.com/images/I/51wJedBh-ML._AA160_.jpg"),
                new President ("James Monroe", 5, "http://ecx.images-amazon.com/images/I/51LivMVFh1L._AA160_.jpg"),
                new President ("John Quincy Adams", 6, "http://ecx.images-amazon.com/images/I/41p9jbunvQL._AA160_.jpg"),
                new President ("Andrew Jackson", 7, "http://ecx.images-amazon.com/images/I/51SDmndXMiL._SL500_SS160_.jpg"),
                new President ("Martin Van Buren", 8, "http://ecx.images-amazon.com/images/I/51JpNQixP0L._SL500_SS160_.jpg"),
                new President ("William Henry Harrison", 9, "http://ecx.images-amazon.com/images/I/41ecoa5CI6L._AA160_.jpg"),
                new President ("John Tyler", 10, "http://ecx.images-amazon.com/images/I/41QLaX4lL4L._AA160_.jpg"),
                new President ("George Washington", 1, "http://ecx.images-amazon.com/images/I/51cphR%2B3ZnL._AA160_.jpg"),
                new President ("John Adams", 2, "http://ecx.images-amazon.com/images/I/51kbcKJS8XL._AA160_.jpg"),
                new President ("Thomas  Jefferson", 3, "http://ecx.images-amazon.com/images/I/41pqrZz8DcL._AA160_.jpg"),
                new President ("James Madison", 4, "http://ecx.images-amazon.com/images/I/51wJedBh-ML._AA160_.jpg"),
                new President ("James Monroe", 5, "http://ecx.images-amazon.com/images/I/51LivMVFh1L._AA160_.jpg"),
                new President ("John Quincy Adams", 6, "http://ecx.images-amazon.com/images/I/41p9jbunvQL._AA160_.jpg"),
                new President ("Andrew Jackson", 7, "http://ecx.images-amazon.com/images/I/51SDmndXMiL._SL500_SS160_.jpg"),
                new President ("Martin Van Buren", 8, "http://ecx.images-amazon.com/images/I/51JpNQixP0L._SL500_SS160_.jpg"),
                new President ("William Henry Harrison", 9, "http://ecx.images-amazon.com/images/I/41ecoa5CI6L._AA160_.jpg"),
                new President ("John Tyler", 10, "http://ecx.images-amazon.com/images/I/41QLaX4lL4L._AA160_.jpg"),
                new President ("George Washington", 1, "http://ecx.images-amazon.com/images/I/51cphR%2B3ZnL._AA160_.jpg"),
                new President ("John Adams", 2, "http://ecx.images-amazon.com/images/I/51kbcKJS8XL._AA160_.jpg"),
                new President ("Thomas  Jefferson", 3, "http://ecx.images-amazon.com/images/I/41pqrZz8DcL._AA160_.jpg"),
                new President ("James Madison", 4, "http://ecx.images-amazon.com/images/I/51wJedBh-ML._AA160_.jpg"),
                new President ("James Monroe", 5, "http://ecx.images-amazon.com/images/I/51LivMVFh1L._AA160_.jpg"),
                new President ("John Quincy Adams", 6, "http://ecx.images-amazon.com/images/I/41p9jbunvQL._AA160_.jpg"),
                new President ("Andrew Jackson", 7, "http://ecx.images-amazon.com/images/I/51SDmndXMiL._SL500_SS160_.jpg"),
                new President ("Martin Van Buren", 8, "http://ecx.images-amazon.com/images/I/51JpNQixP0L._SL500_SS160_.jpg"),
                new President ("William Henry Harrison", 9, "http://ecx.images-amazon.com/images/I/41ecoa5CI6L._AA160_.jpg"),
                new President ("John Tyler", 10, "http://ecx.images-amazon.com/images/I/41QLaX4lL4L._AA160_.jpg"),
                new President ("George Washington", 1, "http://ecx.images-amazon.com/images/I/51cphR%2B3ZnL._AA160_.jpg"),
                new President ("John Adams", 2, "http://ecx.images-amazon.com/images/I/51kbcKJS8XL._AA160_.jpg"),
                new President ("Thomas  Jefferson", 3, "http://ecx.images-amazon.com/images/I/41pqrZz8DcL._AA160_.jpg"),
                new President ("James Madison", 4, "http://ecx.images-amazon.com/images/I/51wJedBh-ML._AA160_.jpg"),
                new President ("James Monroe", 5, "http://ecx.images-amazon.com/images/I/51LivMVFh1L._AA160_.jpg"),
                new President ("John Quincy Adams", 6, "http://ecx.images-amazon.com/images/I/41p9jbunvQL._AA160_.jpg"),
                new President ("Andrew Jackson", 7, "http://ecx.images-amazon.com/images/I/51SDmndXMiL._SL500_SS160_.jpg"),
                new President ("Martin Van Buren", 8, "http://ecx.images-amazon.com/images/I/51JpNQixP0L._SL500_SS160_.jpg"),
                new President ("William Henry Harrison", 9, "http://ecx.images-amazon.com/images/I/41ecoa5CI6L._AA160_.jpg"),
                new President ("John Tyler", 10, "http://ecx.images-amazon.com/images/I/41QLaX4lL4L._AA160_.jpg"),
                new President ("George Washington", 1, "http://ecx.images-amazon.com/images/I/51cphR%2B3ZnL._AA160_.jpg"),
                new President ("John Adams", 2, "http://ecx.images-amazon.com/images/I/51kbcKJS8XL._AA160_.jpg"),
                new President ("Thomas  Jefferson", 3, "http://ecx.images-amazon.com/images/I/41pqrZz8DcL._AA160_.jpg"),
                new President ("James Madison", 4, "http://ecx.images-amazon.com/images/I/51wJedBh-ML._AA160_.jpg"),
                new President ("James Monroe", 5, "http://ecx.images-amazon.com/images/I/51LivMVFh1L._AA160_.jpg"),
                new President ("John Quincy Adams", 6, "http://ecx.images-amazon.com/images/I/41p9jbunvQL._AA160_.jpg"),
                new President ("Andrew Jackson", 7, "http://ecx.images-amazon.com/images/I/51SDmndXMiL._SL500_SS160_.jpg"),
                new President ("Martin Van Buren", 8, "http://ecx.images-amazon.com/images/I/51JpNQixP0L._SL500_SS160_.jpg"),
                new President ("William Henry Harrison", 9, "http://ecx.images-amazon.com/images/I/41ecoa5CI6L._AA160_.jpg"),
                new President ("John Tyler", 10, "http://ecx.images-amazon.com/images/I/41QLaX4lL4L._AA160_.jpg"),
                new President ("George Washington", 1, "http://ecx.images-amazon.com/images/I/51cphR%2B3ZnL._AA160_.jpg"),
                new President ("John Adams", 2, "http://ecx.images-amazon.com/images/I/51kbcKJS8XL._AA160_.jpg"),
                new President ("Thomas  Jefferson", 3, "http://ecx.images-amazon.com/images/I/41pqrZz8DcL._AA160_.jpg"),
                new President ("James Madison", 4, "http://ecx.images-amazon.com/images/I/51wJedBh-ML._AA160_.jpg"),
                new President ("James Monroe", 5, "http://ecx.images-amazon.com/images/I/51LivMVFh1L._AA160_.jpg"),
                new President ("John Quincy Adams", 6, "http://ecx.images-amazon.com/images/I/41p9jbunvQL._AA160_.jpg"),
                new President ("Andrew Jackson", 7, "http://ecx.images-amazon.com/images/I/51SDmndXMiL._SL500_SS160_.jpg"),
                new President ("Martin Van Buren", 8, "http://ecx.images-amazon.com/images/I/51JpNQixP0L._SL500_SS160_.jpg"),
                new President ("William Henry Harrison", 9, "http://ecx.images-amazon.com/images/I/41ecoa5CI6L._AA160_.jpg"),
                new President ("John Tyler", 10, "http://ecx.images-amazon.com/images/I/41QLaX4lL4L._AA160_.jpg"),
                new President ("George Washington", 1, "http://ecx.images-amazon.com/images/I/51cphR%2B3ZnL._AA160_.jpg"),
                new President ("John Adams", 2, "http://ecx.images-amazon.com/images/I/51kbcKJS8XL._AA160_.jpg"),
                new President ("Thomas  Jefferson", 3, "http://ecx.images-amazon.com/images/I/41pqrZz8DcL._AA160_.jpg"),
                new President ("James Madison", 4, "http://ecx.images-amazon.com/images/I/51wJedBh-ML._AA160_.jpg"),
                new President ("James Monroe", 5, "http://ecx.images-amazon.com/images/I/51LivMVFh1L._AA160_.jpg"),
                new President ("John Quincy Adams", 6, "http://ecx.images-amazon.com/images/I/41p9jbunvQL._AA160_.jpg"),
                new President ("Andrew Jackson", 7, "http://ecx.images-amazon.com/images/I/51SDmndXMiL._SL500_SS160_.jpg"),
                new President ("Martin Van Buren", 8, "http://ecx.images-amazon.com/images/I/51JpNQixP0L._SL500_SS160_.jpg"),
                new President ("William Henry Harrison", 9, "http://ecx.images-amazon.com/images/I/41ecoa5CI6L._AA160_.jpg"),
                new President ("John Tyler", 10, "http://ecx.images-amazon.com/images/I/41QLaX4lL4L._AA160_.jpg"),
                new President ("George Washington", 1, "http://ecx.images-amazon.com/images/I/51cphR%2B3ZnL._AA160_.jpg"),
                new President ("John Adams", 2, "http://ecx.images-amazon.com/images/I/51kbcKJS8XL._AA160_.jpg"),
                new President ("Thomas  Jefferson", 3, "http://ecx.images-amazon.com/images/I/41pqrZz8DcL._AA160_.jpg"),
                new President ("James Madison", 4, "http://ecx.images-amazon.com/images/I/51wJedBh-ML._AA160_.jpg"),
                new President ("James Monroe", 5, "http://ecx.images-amazon.com/images/I/51LivMVFh1L._AA160_.jpg"),
                new President ("John Quincy Adams", 6, "http://ecx.images-amazon.com/images/I/41p9jbunvQL._AA160_.jpg"),
                new President ("Andrew Jackson", 7, "http://ecx.images-amazon.com/images/I/51SDmndXMiL._SL500_SS160_.jpg"),
                new President ("Martin Van Buren", 8, "http://ecx.images-amazon.com/images/I/51JpNQixP0L._SL500_SS160_.jpg"),
                new President ("William Henry Harrison", 9, "http://ecx.images-amazon.com/images/I/41ecoa5CI6L._AA160_.jpg"),
                new President ("John Tyler", 10, "http://ecx.images-amazon.com/images/I/41QLaX4lL4L._AA160_.jpg"),
            };
        }

        /// <summary>
        /// Get all presidents.
        /// </summary>
        /// <returns>A collection of all presidents.</returns>
        public ObservableCollection<President> GetAllPresidents()
        {
            ObservableCollection<President> presidents;
            if (ShowGif)
            {
                presidents = GetLocalPresidentsWithGif();
            }
            else
            {
                presidents = GetLocalPresidentsWithJpeg();
            }

            return presidents;
        }

        /// <summary>
        /// Search for a specific president.
        /// </summary>
        /// <param name="searchText">The search text to find a president.</param>
        /// <returns>A collection of found presidents.</returns>
        public ObservableCollection<President> SearchPresidentBySearchText(string searchText)
        {
            var presidents = GetAllPresidents();

            if (String.IsNullOrWhiteSpace(searchText)) return presidents;

            string lowerSearchText = searchText.ToLower();

            var collection = new ObservableCollection<President>();
            foreach (var president in presidents)
            {
                if (president.Name.ToLower().Contains(lowerSearchText)) collection.Add(president);
            }

            return collection;
        }
    }
}
