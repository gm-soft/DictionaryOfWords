﻿using System;
using System.Collections.Generic;
using System.Text;
using DictionaryOfWords.Core.DataBase;

namespace DictionaryOfWords.Core.Repositories
{
    public interface IWordRepository : IRepository<Word>
    {
        bool IsNameReplay(string name, int languageId);

        List<Word> GetWordsForLanguage(int languageId);
        List<Word> GetWordsForTwoLanguage(List<string> words, int firstLanguageId, int secondLanguageId);

        List<Word> GetWordsOfList(List<string> words, int languageId);
    }
}
