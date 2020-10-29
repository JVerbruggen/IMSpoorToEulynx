using Models.TopoModels.IMSpoor.V1_3_0;
using Models.Translation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Service
{
    public class GeometryDeserializer : IService
    {

        private float[] GetCoordinate(string[] csplit)
        {
            float[] xy = new float[2];

            xy[0] = float.Parse(csplit[0]);
            xy[1] = float.Parse(csplit[1]);

            return xy;
        }

        /// <summary>
        /// Get one coordinate set out of point object
        /// Col 0 = x, col 1 = y
        /// </summary>
        /// <returns></returns>
        public float[] GetCoordinate(Point point)
        {
            return GetCoordinate(point.coordinates.Split(','));
        }

        /// <summary>
        /// Get one or more coordinate sets out of point object
        /// Each row will be set of coordinates
        /// Col 0 = x, col 1 = y
        /// </summary>
        /// <returns>int[coordinateLength, 2]</returns>
        public float[,] GetCoordinates(Point point)
        {
            string coords = point.coordinates;
            return GetCoordinates(coords);
        }


        public float[,] GetCoordinates(string coordinates)
        {
            var coords = coordinates.Split(' ');

            float[,] xy = new float[coords.Length, 2];

            int i = 0;
            foreach (string c in coords)
            {
                var csplit = c.Split(',');
                float[] thisxy = GetCoordinate(csplit);

                xy[i, 0] = thisxy[0];
                xy[i, 1] = thisxy[1];

                i++;
            }

            return xy;
        }

    }
}
