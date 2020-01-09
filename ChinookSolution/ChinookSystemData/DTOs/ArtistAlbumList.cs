using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Additional Namespaces
using ChinookSystemData.POCOs;
#endregion

namespace ChinookSystemData.DTOs
{
    public class ArtistAlbumList
    {
        public int ArtistId { get; set; }
        public string ArtisrName { get; set; }
        List<ListDDL> AlbumList { get; set; }
    }
}
