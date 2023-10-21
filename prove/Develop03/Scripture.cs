using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

public class Scripture {
    private Reference _reference;
    private List<Word> _words;
    private int _hiddenWordCount  = 0;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();
        
        List<string> phrase = text.Split(' ').ToList();
        foreach (string word in phrase)
        {
            _words.Add(new Word(word));
        }
    }

        public void DisplayScripture()
    {
         Console.Clear();
        _reference.Display();

        foreach (Word word in _words)
        {
            string displayedWord = word.isHidden() ? Regex.Replace(word.Show(), "[a-zA-Z]", "_") : word.Show();
            Console.Write(displayedWord + " ");
        }
        Console.WriteLine();
    }

    public void HideRandomWord()
    {
        Random random = new Random();
        int remainingWords = _words.Count(w => !w.isHidden());

        if (remainingWords > 0)
        {
            int randomIndex;
            do
            {
                randomIndex = random.Next(_words.Count);
            }
            while (_words[randomIndex].isHidden());

            _words[randomIndex].Hide();
        }
    }

    public bool CompletelyHidden()
    {
        return _words.All(w => w.isHidden());
    }
}