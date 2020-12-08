using Models.Mapping.Topology;
using Models.TopoModels.Eulynx.Common;
using Models.TopoModels.IMSpoor.V1_2_3;
using Services.DependencyInjection;
using Services.Extensions;
using Services.Managers.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Services.Managers.Topology
{
    public class PositionedRelationManager : UUIDObjectManager<PositionedRelation>
    {
        public IList<PositionedRelation> AddRangeDistinct(IList<PositionedRelation> sourceList, PositionedRelation[] addingList)
        {
            foreach (PositionedRelation addition in addingList)
            {
                bool duplicate = false;
                foreach (PositionedRelation checking in sourceList)
                {
                    if (addition.IsDuplicate(checking))
                    {
                        duplicate = true;
                        break;
                    }
                }

                if (!duplicate)
                {
                    sourceList.Add(addition);
                }
            }
            return sourceList;
        }

        public PositionedRelation GetRelation(PositioningNetElement a, PositioningNetElement b, PositionedRelation[] allRelations)
        {
            PositionedRelation foundRelation = null;

            foreach (var relationId in a.relation)
            {
                var rel = b.relation.Where(r => r.Equals(relationId)).FirstOrDefault();
                if (rel != default)
                {
                    var found = this.Find(allRelations, rel);
                    if (found != null)
                    {
                        foundRelation = found;
                        break;
                    }
                }
            }

            return foundRelation;
        }

        public PositionedRelation[] GetPositionedRelations(RailTopology railTopology)
        {
            IList<PositionedRelation> positionedRelations = new List<PositionedRelation>();

            foreach (MicroLink currentTrack in railTopology.MicroLinks)
            {
                var depends = new PositionedRelationMappingDepends(railTopology, currentTrack);
                var mapping = InstanceManager.GetMappingSelector<PositionedRelationMappingDepends, PositionedRelationMappingResult>().Select(depends);
                PositionedRelation[] relations = mapping.Map(depends).PositionedRelations;

                positionedRelations = AddRangeDistinct(positionedRelations, relations);
            }

            return positionedRelations.ToArray();
        }
    }

}
