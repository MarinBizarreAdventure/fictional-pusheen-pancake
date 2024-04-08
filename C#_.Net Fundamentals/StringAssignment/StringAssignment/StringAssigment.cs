using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace StringAssignment
{
    internal class StringAssigment
    {
        private StringBuilder _originalText;
        private int _wordCount;
        private int _sentenceCount;
        private StringBuilder _reverseText;

        public StringAssigment(string originalText) 
        {
            _originalText = new StringBuilder(originalText);
            Counter(); // word and sentence count
            _reverseText = new StringBuilder(originalText);
            ReverseText(); // reverse text
        }

        public StringBuilder OriginalText 
        { 
            get { return _originalText; } 
            set 
            { 
                _originalText.Clear();
                _originalText.Append(value);        
            } 
        }

        public int WordCount { get { return _wordCount; } }
        public int SentenceCount { get { return _sentenceCount; } }

        public StringBuilder Reverse { get { return _reverseText; } }




        private void Counter()
        {
            bool isSeparatorFlag = true;
            bool isSeparator;
            bool isPunctuation = false;

            for (int i=0;i < _originalText.Length;i++)
            {
                char c = _originalText[i];
                isSeparator = char.IsSeparator(c);
                isPunctuation = IsPunctuation(c);

                if ((isSeparator || isPunctuation) && isSeparatorFlag)
                {
                    //- Word count of this string
                    _wordCount++;
                }
                if (isPunctuation)
                {
                    //- Sentence count of this string
                    _sentenceCount++;
                }
                isSeparatorFlag = !(isSeparator || isPunctuation);

            }
        }

        //- Display this string in reverse, without using any C# language feature. (Create your own algorith)
        private StringBuilder ReverseText()
        {
            for(int i= _originalText.Length-1, j = 0; i>=0; i--,j++)
            {
                _reverseText[j] = _originalText[i];
            }
            return _reverseText;
        }


        static bool IsPunctuation(char c)
        {
            return c == '?' || c == '.' || c == '!';
        }

        //- Display how often the word "encapsulation" appears in this string
        
        public int FindSubstingOccurencies(string subString)
        {
            int index = 0;
            int occurencies = 0;

            while((index = _originalText.ToString().IndexOf(subString, index)) != -1)
            {
                index++;
                occurencies++;
            }
            return occurencies;
        }


        //- In the given string, replace all occurances of "object-oriented programming" with "OOP" and display the new string

        public StringBuilder ReplaceSubsting(string oldString, string newString)
        {
            return _originalText.Replace(oldString, newString);
        }
    }
}
