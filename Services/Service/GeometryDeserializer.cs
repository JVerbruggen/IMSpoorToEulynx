using Models.TopoModels.IMSpoor.V1_2_3;
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
            float[] xy = new float[3];

            xy[0] = float.Parse(csplit[0]);
            xy[1] = float.Parse(csplit[1]);

            if(csplit.Length == 3)
            {
                xy[2] = float.Parse(csplit[2]);
            }
            else
            {
                xy[2] = 0f;
            }

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
        [Obsolete("Use Get3Coordinates")]
        public float[,] GetCoordinates(Point point)
        {
            string coords = point.coordinates;
            return GetCoordinates(coords);
        }

        [Obsolete("Use Get3Coordinates")]
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

        /// <summary>
        /// Get one or more coordinate sets out of point object
        /// Each row will be set of coordinates
        /// Col 0 = x, col 1 = y
        /// </summary>
        /// <returns>int[coordinateLength, 2]</returns>
        public float[,] Get3Coordinates(Point point)
        {
            string coords = point.coordinates;
            return Get3Coordinates(coords);
        }


        public float[,] Get3Coordinates(string coordinates)
        {
            var coords = coordinates.Split(' ');

            float[,] xy = new float[coords.Length, 3];

            int i = 0;
            foreach (string c in coords)
            {
                var csplit = c.Split(',');
                float[] thiscoords = GetCoordinate(csplit);

                xy[i, 0] = thiscoords[0];
                xy[i, 1] = thiscoords[1];
                xy[i, 2] = thiscoords[2];

                i++;
            }

            return xy;
        }

    }
}
