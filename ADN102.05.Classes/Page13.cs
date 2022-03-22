using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page13Part1
{

    public class Room
    {
        public string Name { get; init; }
        public decimal Price { get; init; }
        public bool Smoking { get; init; }
        public int Sleeps { get; init; }
    }

    public class Hotel
    {
        private Room[] _rooms;
        public Hotel(int TotalRooms)
        {
            _rooms = new Room[TotalRooms];
        }

    }

    class Program
    {
        static void Main()
        {
            Hotel h1 = new Hotel(4);
            Hotel h2 = new Hotel(20);

        }
    }

}

namespace Page13Part2
{

    public class Room
    {
        public string Name { get; init; }
        public decimal Price { get; init; }
        public bool Smoking { get; init; }
        public int Sleeps { get; init; }
    }
    public class Hotel
    {
        private Room[] _rooms;
        public Hotel(int TotalRooms)
        {
            _rooms = new Room[TotalRooms];
        }

        // an indexer is like a property by the name of **this** which has a set of typed parameters 
        // (in this case the type is an int and the name is index)
        public Room this[int index]         // search for a room by NUMBER (index)
        {
            get { return _rooms[index]; }
            set { _rooms[index] = value; }
        }

        // an indexer is like a property by the name of **this** which has a set of typed parameters 
        // (in this case the type is a string and the name is key)   
        public Room this[string key]        // search for a room by NAME
        {
            get
            {
                foreach (Room r in _rooms)   // do not need access to the SLOT, 
                                             // only the value in the SLOT for a get. 
                                             // no index is needed, so foreach is easier
                {
                    if (r.Name == key)
                    {
                        return r;
                    }
                }
                return null;
            }
            set
            {
                for (int i = 0; i < _rooms.Length; i++)
                // need access to the actual SLOT in order to save the value.  
                // an index is required, so for instead of foreach is appropriate
                {
                    if (_rooms[i].Name == key)
                    {
                        _rooms[i] = value;
                    }
                }

            }
        }

    }

    class Program
    {
        static void Main()
        {
            Hotel h1 = new Hotel(4);
            Hotel h2 = new Hotel(20);

            h1[2] = new Room();          // uses set to store a room by integer index
            h2[5] = new Room() { Name = "Golden Room" };  // set by integer index in h2
            Room r1 = h2["Golden Room"]; // uses get to retrieve a room by string index  
                                         //(r1 is the same room that was placed into slot 5)
        }
    }
}


namespace Page13Part3
{

    public class Room
    {
        public string Name { get; init; }
        public decimal Price { get; init; }
        public bool Smoking { get; init; }
        public int Sleeps { get; init; }
    }
    public class Hotel
    {
        private Room[] _rooms;
        private int _numberFloors;
        private int _roomsPerFloor;

        public Hotel(int RoomsPerFloor, int Floors)
        {
            _roomsPerFloor = RoomsPerFloor;
            _numberFloors = Floors;
            _rooms = new Room[RoomsPerFloor * Floors];
        }

        // an indexer is like a property by the name of **this** 
        // which has a set of typed parameters 
        // (in this case the type is an int and the name is index)
        public Room this[int floor, int index]
        // search for a room by NUMBER and Floor (2 parameters)
        {
            get { return _rooms[floor * _roomsPerFloor + index]; }
            set { _rooms[floor * _roomsPerFloor + index] = value; }
        }

        // an indexer is like a property by the name of **this** 
        // which has a set of typed parameters 
        // (in this case the type is a string and the name is key)   
        public Room this[string key]
        // search for a room by NAME
        {
            get
            {
                foreach (Room r in _rooms)   // do not need access to the SLOT, 
                                             //only the value in the SLOT for a get. 
                                             //no index is needed, so foreach is easier
                {
                    if (r.Name == key)
                    {
                        return r;
                    }
                }
                return null;
            }
            set
            {
                for (int i = 0; i < _rooms.Length; i++)  // need access to the actual SLOT 
                                                         //in order to save the value.  
                                                         //an index is required, so for is appropriate
                {
                    if (_rooms[i].Name == key)
                    {
                        _rooms[i] = value;
                    }
                }

            }
        }

    }

    class Program
    {
        static void Main()
        {
            Hotel h1 = new Hotel(4, 4);  // 4 floors with 4 rooms each (16 rooms)
            Hotel h2 = new Hotel(2, 10); // 2 floors with 10 rooms each (20 rooms)

            h1[2, 2] = new Room();          // uses set to store a room by integer floor
                                            // and integer index (Floor index is 0,1,2,3)
            h2[0, 5] = new Room() { Name = "Golden Room" };  // set by integer indexes in h2 
                                                             // (Floor is 0, room is 5, Name = "Golden Room")
            Room r1 = h2["Golden Room"]; // uses get to retrieve a room by string index
        }
    }
}

