using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Additional Namespaces
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
#endregion

namespace ChinookSystemData.Entities
{
    //identify the sql entity (table) this class maps
    [Table("Artists")]
    public class Artist
    {
        // fully impemented properties will be used for nullable strings.
        private string _Name;
        [Key]
        public int ArtistId { get; set; }

        [StringLength(120, ErrorMessage ="Artist nme is limited to 120 characters")]
        public string Name
        {
            get
            {
                return _Name;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    _Name = null;
                }
                else
                {
                    _Name = value;
                }
            }
        }

        //virtual navigation properties
        //these properties do not contain data
        // these properties form a virtual relationship between the entity classes
        // create the appropriate virtual properties such as you are mapping the ERD relationship that exists in your database

        public virtual ICollection<Album> Albums { get; set; }
    }
}
