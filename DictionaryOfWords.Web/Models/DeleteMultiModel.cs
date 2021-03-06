﻿using DictionaryOfWords.Web.Models.Language;
using DictionaryOfWords.Web.Models.Word;
using DictionaryOfWords.Web.Models.WordTranslation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DictionaryOfWords.Web.Models
{
    public class DeleteMultiModel : PageInfoModel
    {
        public DeleteMultiModel()
        {
            WordTranslationModels = new List<WordTranslationModel>();
            LanguageModels = new List<LanguageModel>();
            WordModels = new List<WordDeleteModel>();
        }

        public List<LanguageModel> LanguageModels { get; set; }

        public List<WordTranslationModel> WordTranslationModels { get; set; }

        public List<WordDeleteModel> WordModels { get; set; }


    }
}
