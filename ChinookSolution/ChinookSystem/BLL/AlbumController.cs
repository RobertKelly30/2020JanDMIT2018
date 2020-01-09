using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Additional Namespaces
using System.Collections.Generic;
using ChinookSystem.DAL;
using ChinookSystemData.Entities;
#endregion

namespace ChinookSystem.BLL
{
    public class AlbumController
    {
        public List<Album> Album_List()
        {
            using (var context = new ChinookContext())
            {
                return context.Albums.ToList();
            }
        }

        public Album Artist_FindByID(int albumid)
        {
            using (var context = new ChinookContext())
            {
                return context.Albums.Find(albumid);
            }
        }
    }
}
