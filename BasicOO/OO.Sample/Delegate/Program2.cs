using System;

namespace OO.Sample
{
    //Exemplo Delegate
    class Program2
    {
        static void RealizarPagamento(double valor)
        {
            Console.WriteLine("pagao valor de " + valor);
        }
        static void Main2(string[] args)
        {
            //var pagar = new Pagamento3.Pagar(RealizarPagamento);
            //pagar(25);

            var room = new Room(10);
            room.RoomSoldOut += OnRoomSoldOut;
            room.ReserveSeat();
            room.ReserveSeat();
            room.ReserveSeat();
            room.ReserveSeat();
            room.ReserveSeat();
        }

        static void OnRoomSoldOut(object sender, EventArgs e)
        {
            Console.WriteLine("Sala lotada");
        }
    }

    public class Pagamento3
    {
        public delegate void Pagar(double valor);
    }

}
