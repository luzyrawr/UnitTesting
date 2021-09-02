using System;
using System.Collections.Generic;
using System.Text;

namespace Business
{
    public class RomanNumeral
    {
        /*
        I
        II
        III
        IV
        V
        VI
        VII
        VIII
        IX

        X
        XIV
        XX
        XXX
        XL
        L
        LX
        C

        C
        CC
        CCC
        CD
        D
        DC
        CM
        M
         */
        public static int Parse(string roman)
        {
            var result = 0;
            var romanCharArray = roman.ToCharArray();

            char? previousCharacter = null;
            foreach(var character in romanCharArray)
            {
                if(!previousCharacter.HasValue)
                {
                    result += characterValue(character);
                }
                else if (characterValue(previousCharacter.Value) >= characterValue(character))
                {
                    result += characterValue(character);
                }
                else if (characterValue(previousCharacter.Value) < characterValue(character))
                {
                    result = result + characterValue(character) - 2*characterValue(previousCharacter.Value);
                }
                previousCharacter = character;
            }

            return result;
        }

        private static int characterValue(char letter)
        {
            switch (letter)
            {
                case 'I': return 1;//4,9
                case 'V': return 5;
                case 'X': return 10;//40,90
                case 'L': return 50;
                case 'C': return 100;//400,900
                case 'D': return 500;
                case 'M': return 1000;
                default: return 0;
            }
        }
    }
}
