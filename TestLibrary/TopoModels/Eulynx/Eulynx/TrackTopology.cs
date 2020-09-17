using Models.TopoModels.IMSpoor;
using System;
using System.Collections.Generic;
using System.Text;

namespace Models.TopoModels.Eulynx
{
    public partial class TrackTopology : ITranslatableSingle<TrackTopology, RailTopology>
    {

        public static TrackTopology GetTrackTopology()
        {
            TrackTopology trackTopology = new TrackTopology();

            return trackTopology;
        }

        public TrackTopology TranslateSingle(RailTopology railTopology)
        {
            this.usesPositionedRelation = new PositionedRelation().TranslateMultiple(railTopology);
            this.usesPositioningNetElement = new PositioningNetElement().TranslateMultiple(railTopology.MicroLinks);

            return this;
        }
    }
}
