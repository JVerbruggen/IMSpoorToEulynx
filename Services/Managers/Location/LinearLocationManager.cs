using Models.TopoModels.EULYNX.rtmCommon;
using Models.TopoModels.IMSpoor.V1_2_3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Services.Managers.Location
{
    public class LinearLocationManager
    {
        public LinearLocation GetLinearLocation(MicroLink microLink, RailConnection[] railConnections, Track[] tracks, PositioningNetElement netElement, PositionedRelation[] positionedRelations)
        {
            var ll = new LinearLocation();

            string railConnectionRef = microLink.railConnectionRef;
            RailConnection railConnection = railConnections.Where(rc => rc.puic == railConnectionRef).First();
            string trackRef = railConnection.trackRef;
            Track track = tracks.Where(t => t.puic == trackRef).First();

            var assElement = new AssociatedNetElementCoordinate(netElement);

            var associatedElements = new AssociatedNetElement[]{ assElement };
            ll.associatedElements = associatedElements;

            return ll;
        }

        public IEnumerable<LinearLocation> GetLinearLocations(PositioningNetElement[] positioningNetElements, PositionedRelation[] positionedRelations)
        {
            throw new NotImplementedException();
        }
    }
}
