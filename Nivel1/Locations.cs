using System;
using System.Collections.Generic;
using System.Device.Location;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nivel1
{
    public class Locations
    {
        //Radio de la tierra en GPS
        public const double Radius = 6371;
        public Locations() { }

        public double GetLocation(BO.Distances emisor, BO.Distances receptor)
        {
            double distance = 0;


            double Latitud = (receptor.DistanciaX - emisor.DistanciaX) * (Math.PI / 180);
            double Longitud = (receptor.DistanciaY - emisor.DistanciaY) * (Math.PI / 180);
            double senal = Math.Sin(Latitud / 2) * Math.Sin(Latitud / 2) + Math.Cos(emisor.DistanciaX * (Math.PI / 180)) * Math.Sin(Longitud / 2) * Math.Sin(Longitud / 2);
            //Devuelve el angulo entre los ejes
            double canal = 2 * Math.Atan2(Math.Sqrt(senal), Math.Sqrt(1 - senal));
            distance = Radius * canal;

            return distance;
        }

        public BO.Positions GetLocations(BO.Distances emisor, BO.Distances receptor)
        {
            BO.Positions positions = new BO.Positions();
            
            double Latitud = (receptor.DistanciaX - emisor.DistanciaX) * (Math.PI / 180);
            double Longitud = (receptor.DistanciaY - emisor.DistanciaY) * (Math.PI / 180);
            
            positions.X = Latitud;
            positions.Y = Longitud;

            return positions;
        }
    }
}
