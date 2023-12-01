namespace MyUtilities {

    public static class StringUtils {


        public static string ToUpper(string input) {
            string outputString = "";
            int i = 0;
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
                i++;
            }
            
            return outputString;
        }
        
    }
}