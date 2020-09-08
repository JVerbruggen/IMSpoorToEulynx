using Models.Translation;
using Services.TopoModels;
using System;

namespace Logic.Managers
{
    public class TranslationService : ITranslationService<IMSpoor, RailTopoModel>
    {

        public RailTopoModel Translate(IMSpoor imSpoor)
        {
            throw new NotImplementedException();
        }

    }
}
