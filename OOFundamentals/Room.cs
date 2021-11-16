using System;

namespace OOFundamentals
{
    public class Room
    {
        public Room(int seats)
        {
            Seats = seats;
           
        }
        public int Seats { get; set; }

        private int seatsInUse = 0;

        public event EventHandler RoomSoldOut;

        protected virtual void OnRoomSoldOut(EventArgs e)
        {
            EventHandler handler = RoomSoldOut;
            handler?.Invoke(this,e);
        }

        public void ReserveSeat()
        {
            seatsInUse++;

            if(seatsInUse >= Seats)
            {
                OnRoomSoldOut(EventArgs.Empty);
            }
            else
            {
                Console.WriteLine("Assento Reservado.");
            }
        }
    }
}
