namespace MyUtilities {

    public static class StringUtils {


       public static string ToUpper(string input) {
            string outputString = "";
            foreach (char character in input)
            {
                // Convert lowercase letters ('a' to 'z') to uppercase using ASCII shift
                char outputChar = (character >= 'a' && character <= 'z') ? (char)(character - 32) : character;
                outputString += outputChar;
            }
            return outputString;
        }
        
        public static string ToLower(string input) {
            string outputString = "";
            foreach (char character in input)
            {
                // Convert uppercase letters ('A' to 'Z') to lowercase using ASCII shift
                char outputChar = (character >= 'A' && character <= 'Z') ? (char)(character + 32) : character;
                outputString += outputChar;
            }
            return outputString;
        }
         public static int length(string input) {
            int i = 0;
            foreach (char charecter in input) {
                i++;
            }
            return i;
         }

         public static string Reverse(string input) {
            int i = MyUtilities.StringUtils.length(input) - 1;
            string output = "";
            foreach(char charecter in input) {
                output= output + input[i];
                i--;
            }
            return output;
         }
         
        public static int CountVowels(string input) {
            int i = 0;
            foreach (char charecter in input) {
                switch (charecter) {
                    case 'A':
                        i++;
                        break;
                    case 'a':
                        i++;
                        break;
                    case 'E':
                        i++;
                        break;
                    case 'e':
                        i++;
                        break;
                    case 'I':
                        i++;
                        break;
                    case 'i':
                        i++;
                        break;
                    case 'O':
                        i++;
                        break;
                    case 'o':
                        i++;
                        break;
                    case 'U':
                        i++;
                        break;
                    case 'u':
                        i++;
                        break;
                }
            }
            return i;
         }

         public static int CountConsonants(string input) {
            int i = 0;
            foreach (char charecter in input) {
                switch (charecter) {
                    case 'A':
                        break;
                    case 'a':
                        break;
                    case 'E':
                        break;
                    case 'e':
                        break;
                    case 'I':
                        break;
                    case 'i':
                        break;
                    case 'O':
                        break;
                    case 'o':
                        break;
                    case 'U':
                        break;
                    case 'u':
                        break;
                    default:
                        i++;
                        break;
                }
            }
            return i;
         }

        public static bool HasLetter(string input, char letter) {
            bool isLetter = false;
            foreach (char charecter in input) {
                if (charecter == letter) {
                    isLetter = true;
                }
            }
            return isLetter;
         }
         public static char[] ToCharArray(string input) {
            int i = 0;
            char[] outputArray = new char[MyUtilities.StringUtils.length(input)];
            foreach (char charecter in input) {
                outputArray[i] = charecter;
                i++;
            }
            return outputArray;
         }
         public static string Trim(string input) {
            string outputString = "";
            foreach (char charecter in input) {
                if (charecter == ' ') {

                }
                else {
                    outputString = outputString + charecter;
                }
            }
            return outputString;
         }


        public static string append (string str1, string str2) {
            string output = str1+ str2;
            return output;
        }
        
        public static int GetCharNum(char letter){
            switch (letter) {
                    case 'a':
                        return 1;
                    case 'b':
                       return 2;
                    case 'c':
                        return 3;
                    case 'd':
                       return 4;
                    case 'e':
                        return 5;
                    case 'f':
                        return 6;
                    case 'g':
                        return 7;
                    case 'h':
                        return 8;
                    case 'i':
                        return 9;
                    case 'j':
                        return 10;
                    case 'k':
                        return 11;
                    case 'l':
                        return 12;
                    case 'm':
                        return 13;
                    case 'n':
                       return 14;
                    case 'o':
                        return 15;
                    case 'p':
                        return 16;
                    case 'q':
                       return 17;
                    case 'r':
                        return 18;
                    case 's':
                        return 19;
                    case 't':
                        return 20;
                    case 'u':
                        return 21;
                    case 'v':
                        return 22;
                    case 'w':
                        return 23;
                    case 'x':
                        return 24;
                    case 'y':
                        return 25;
                    case 'z':
                        return 26;
                    default:
                        return -1;
                }
        }
        
        public static char GetNumChar(int num){
            switch (num) {
                    case 1:
                        return 'a';
                    case 2:
                       return 'b';
                    case 3:
                        return 'c';
                    case 4:
                       return 'd';
                    case 5:
                        return 'e';
                    case 6:
                        return 'f';
                    case 7:
                        return 'g';
                    case 8:
                        return 'h';
                    case 9:
                        return 'i';
                    case 10:
                        return 'j';
                    case 11:
                        return 'k';
                    case 12:
                        return 'l';
                    case 13:
                        return 'm';
                    case 14:
                       return 'n';
                    case 15:
                        return 'o';
                    case 16:
                        return 'p';
                    case 17:
                       return 'q';
                    case 18:
                        return 'r';
                    case 19:
                        return 's';
                    case 20:
                        return 't';
                    case 21:
                        return 'u';
                    case 22:
                        return 'v';
                    case 23:
                        return 'w';
                    case 24:
                        return 'x';
                    case 25:
                        return 'y';
                    case 26:
                        return 'z';
                    default:
                        return ' ';
                }
        }
        
        
        public static int[] Encode(string str) {
            string lowerString = ToLower(str);
            int[] stringInNums = new int[length(str)];
            for (int i = 0; i < length(str); i++) {
                stringInNums[i] = GetCharNum(str[i]);
            }
            int[] encodedString = new int[length(str)];
            for (int i = 0; i < length(str); i++) {
                encodedString[i] = stringInNums[i] + 15;
            }
            return encodedString;
        }

        public static string Decode(int[] encoded) {
            string outputString = "";
            int length = 0;
            foreach(int num in encoded) {length++;}
            for (int i = 0; i < length; i++) {
                outputString = outputString + GetNumChar(encoded[i]-15);
            }
            return outputString;
        }
        
    }
}
