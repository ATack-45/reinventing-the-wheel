namespace MyUtilities {

    public static class StringUtils {


        public static string ToUpper(string input) {
            string outputString = "";
            foreach(char charecter in input) {
                char outputChar;
                switch (charecter) {
                    case 'a':
                        outputChar = 'A';
                        break;
                    case 'b':
                        outputChar = 'B';
                        break;
                    case 'c':
                        outputChar = 'C';
                        break;
                    case 'd':
                        outputChar = 'D';
                        break;
                    case 'e':
                        outputChar = 'E';
                        break;
                    case 'f':
                        outputChar = 'F';
                        break;
                    case 'g':
                        outputChar = 'G';
                        break;
                    case 'h':
                        outputChar = 'H';
                        break;
                    case 'i':
                        outputChar = 'I';
                        break;
                    case 'j':
                        outputChar = 'J';
                        break;
                    case 'k':
                        outputChar = 'K';
                        break;
                    case 'l':
                        outputChar = 'L';
                        break;
                    case 'm':
                        outputChar = 'M';
                        break;
                    case 'n':
                        outputChar = 'N';
                        break;
                    case 'o':
                        outputChar = 'O';
                        break;
                    case 'p':
                        outputChar = 'P';
                        break;
                    case 'q':
                        outputChar = 'Q';
                        break;
                    case 'r':
                        outputChar = 'R';
                        break;
                    case 's':
                        outputChar = 'S';
                        break;
                    case 't':
                        outputChar = 'T';
                        break;
                    case 'u':
                        outputChar = 'U';
                        break;
                    case 'v':
                        outputChar = 'V';
                        break;
                    case 'w':
                        outputChar = 'W';
                        break;
                    case 'x':
                        outputChar = 'X';
                        break;
                    case 'y':
                        outputChar = 'Y';
                        break;
                    case 'z':
                        outputChar = 'Z';
                        break;
                    default:
                        outputChar = charecter;
                        break;
                }
                outputString = outputString + outputChar;
            }
            return outputString;
        }

        public static string ToLower(string input) {
            string outputString = "";
            foreach(char charecter in input) {
                char outputChar;
                switch (charecter) {
                    case 'A':
                        outputChar = 'a';
                        break;
                    case 'B':
                        outputChar = 'b';
                        break;
                    case 'C':
                        outputChar = 'c';
                        break;
                    case 'D':
                        outputChar = 'd';
                        break;
                    case 'E':
                        outputChar = 'e';
                        break;
                    case 'F':
                        outputChar = 'f';
                        break;
                    case 'G':
                        outputChar = 'g';
                        break;
                    case 'H':
                        outputChar = 'h';
                        break;
                    case 'I':
                        outputChar = 'i';
                        break;
                    case 'J':
                        outputChar = 'j';
                        break;
                    case 'K':
                        outputChar = 'k';
                        break;
                    case 'L':
                        outputChar = 'l';
                        break;
                    case 'M':
                        outputChar = 'm';
                        break;
                    case 'N':
                        outputChar = 'n';
                        break;
                    case 'O':
                        outputChar = 'o';
                        break;
                    case 'P':
                        outputChar = 'p';
                        break;
                    case 'Q':
                        outputChar = 'q';
                        break;
                    case 'R':
                        outputChar = 'r';
                        break;
                    case 'S':
                        outputChar = 's';
                        break;
                    case 'T':
                        outputChar = 't';
                        break;
                    case 'U':
                        outputChar = 'u';
                        break;
                    case 'V':
                        outputChar = 'v';
                        break;
                    case 'W':
                        outputChar = 'w';
                        break;
                    case 'X':
                        outputChar = 'x';
                        break;
                    case 'Y':
                        outputChar = 'y';
                        break;
                    case 'Z':
                        outputChar = 'z';
                        break;
                    default:
                        outputChar = charecter;
                        break;
                }
                outputString = outputString + outputChar;
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

        
    }
}