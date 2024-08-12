using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaraokeNeeNee.DAO
{
    public class RoomDAO
    {
        private static RoomDAO instance;

        public static RoomDAO Instance
        {
            get { if (instance == null) instance = new RoomDAO(); return RoomDAO.instance;}
            private set { RoomDAO.instance = value; }
        }
        private RoomDAO()
        { }

        public void LoadRoomList()
        {

        }
    }
  

    
}
