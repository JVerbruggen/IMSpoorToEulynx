using Models.TopoModels.Eulynx;
using Services.Managers.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Managers.Assets
{
    public class TrackCrossingManager : ItemManager<TrackCrossing>
    {

        public TrackCrossing[] GetTrackCrossings()
        {
            return GetAll();
        }

    }
}
