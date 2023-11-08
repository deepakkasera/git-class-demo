using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.GoogleMaps;

namespace wizzscrap
{
    public partial class pinMaps : ContentPage
    {
        public pinMaps(double mylat,double mylng)
        {
            InitializeComponent();

            List<pins> pinslist = new List<pins>();
            pinslist.Add(new pins {  id=1, lat=14.610436, lng=75.631098, name="Wizz 1",address= "Gouri Shankar Nagar Ranebennur,Karnataka 581115"});
            pinslist.Add(new pins { id = 2, lat = 14.613702, lng = 75.627437, name = "Wizz 2", address = " Shankar Nagar Ranebennur,Karnataka 581115" });
            pinslist.Add(new pins { id = 3, lat = 14.613361, lng = 75.635982, name = "Wizz 3", address = "Sri Ram Nagar Ranebennur,Karnataka 581115" });
            pinslist.Add(new pins { id = 4, lat = 14.607156, lng = 75.623939, name = "Wizz 4", address = "Honnalli-Ranebennur Rd Ranebennur,Karnataka 581115" });

            foreach (var a in pinslist)
            {
                Pin p = new Pin() {
                    Label = a.name,
                    Position = new Position(a.lat, a.lng),
                    Type=PinType.Generic
                };
                map.Pins.Add(p);
            }
            //map.Pins.Add(pinTokyo);
            map.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(mylat,mylng), Distance.FromMeters(500)));


        }

        public int compressBits(List<int> A)
        {

            int N = A.Count;
            int ans = 0;

            for (int i = 0; i < N-1; i++)
            {
                int Ai = A[i];
                int Aj = A[i + 1];

                A[i] = Ai & Aj;
                A[i + 1] = Ai | Aj;
            }

            for (int i = 0; i < N; i++)
            {
                ans = ans ^ A[i];
            }

            return ans;
        }

    }

    public class pins
    {
        public int id { get; set; }
        public string name { get; set; }
        public double lat { get; set; }
        public double lng { get; set; }
        public string address { get; set; }

    }
}

