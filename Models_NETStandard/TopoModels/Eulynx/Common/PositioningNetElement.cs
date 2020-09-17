using Models.TopoModels.IMSpoor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models.TopoModels.Eulynx
{
    public interface IPositioningNetElement
    {
        AssociatedPositioningSystem[] associatedPositioningSystems
        {
            get; set;
        }
    }


    public partial class PositioningNetElement : IPositioningNetElement, ITranslatableMultiple<PositioningNetElement, MicroLink>
    {

        public PositioningNetElement[] TranslateMultiple(MicroLink[] microLinks)
        {
            IList<PositioningNetElement> positioningNetElements = new List<PositioningNetElement>();

            foreach(MicroLink microLink in microLinks)
            {
                LinearElement linearElement = new LinearElement();
                linearElement.uuid = microLink.trackFunctionalViewRef;
                linearElement.name = "-";

                positioningNetElements.Add(linearElement);
            }

            return positioningNetElements.ToArray();
        }


        //public PositioningNetElement[] TranslateMultiple(MicroNode[] microNodes)
        //{
        //    IList<PositioningNetElement> positioningNetElements = new List<PositioningNetElement>();

        //    foreach (MicroNode microNode in microNodes)
        //    {
        //        IList<tElementWithIDref> relations = new List<tElementWithIDref>();
        //        foreach(Jumper jumper in microNode.Jumpers)
        //        {
                    
        //        }


        //        LinearElement linearElement = new LinearElement();
        //        linearElement.uuid = microNode.junctionRef;
        //        linearElement.name = "-";
        //        linearElement.relations = relations.ToArray();

        //        positioningNetElements.Add(linearElement);
        //    }

        //    return positioningNetElements.ToArray();
        //}
    }
}
