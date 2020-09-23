using Models.DependencyInjection.Manager;
using Models.Location;
using Models.Positioning;
using Models.TopoModels.IMSpoor;
using System;
using System.Collections.Generic;
using System.Text;

namespace Models.TopoModels.Eulynx
{
    public partial class RtmEntities : ITranslatableSingle<RtmEntities, tSituation>
    {
        public RtmEntities TranslateSingle(tSituation situation)
        {
            //this.ownsBufferstop = VehicleStop.GetVehicleStops();
            //this.ownsPoint = Turnout.GetTurnouts();
            //this.ownsRouteBody = RouteBody.GetRouteBodies();
            this.ownsSignal = new Signal().TranslateMultiple(situation.RailInfrastructure.TrackAssets.Signals);
            //this.usesCablingTopology = CablingTopology.GetCablingTopology();
            //this.usesLinearLocation = LinearLocation.GetLinearLocations();
            this.usesTrackTopology = new TrackTopology().TranslateSingle(situation.RailInfrastructure.RailTopology);
            this.usesSpotLocation = InstanceManager.GetOrNewInstanceSupplier<SpotLocationManager>().GetInstance().GetAll();
            this.usesPositioningSystem = InstanceManager.GetOrNewInstanceSupplier<PositioningSystemManager>().GetInstance().GetAll();
            this.usesPositioningSystemCoordinate = InstanceManager.GetOrNewInstanceSupplier<PositioningSystemCoordinateManager>().GetInstance().GetAll();
            this.uuid = "";

            return this;
        }
    }
}
