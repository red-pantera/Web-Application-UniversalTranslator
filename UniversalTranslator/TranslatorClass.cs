using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UniversalTranslator
{

    internal class TranslatorClass
    {
        
        string mstrText, mstrOriginal;
        // Controls access to class-level variables.
        public string Text
        {
            get
            {
                return mstrText;
            }
            set
            {
                mstrText = value;
                // Keep a copy of the original for Restore.
                mstrOriginal = value;
            }
        }
        // Restores translated text back to the original.
        public void Restore()
        {
            mstrText = mstrOriginal;
        }
        // Translates the value in the Text property.
        public void Translate()
        {
            string strWord;
            string[] arrWords;
            bool bCaps = false;
            // Convert the string into an array using System.String.
            arrWords = mstrText.Split(' ');
            for (int intCount = 0; intCount <= arrWords.GetUpperBound(0); intCount++)
            {
                // Change to lowercase.
                strWord = arrWords[intCount].ToLower();
                // Check if word is capitalized.
                if (!arrWords[intCount].Equals(strWord))
                    bCaps = true;
                // Do translation.
                if (strWord != "")
                {
                    strWord = strWord.Substring(1, strWord.Length - 1) + strWord.Substring(0, 1) + "ay";
                    // Recapitalize if necessary.

                    if (bCaps)

                        strWord = strWord.Substring(0, 1).ToUpper() + strWord.Substring(1, strWord.Length - 1);
                }
                // Store the word back in the array.
                arrWords[intCount] = strWord;
                // Reset the caps flag.
                bCaps = false;
            }
            // Rebuild the string from the array.

            mstrText = String.Join(" ", arrWords);
        }
    }
}