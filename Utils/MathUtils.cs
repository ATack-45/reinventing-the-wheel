namespace MyUtilities {

    public static class MathUtils { 
        public static int Power(int num, int exponent) {
            int product = num;
            for (int i = exponent - 1; i > 0; i--){
                product = product * num;
            }
            return product;
        }
        
        public static int Abs(int num) {
            if(num >= 0) {
                return num;
            }
            else {
                return num * -1;
            }
        }
        public static double Abs(double num) {
            if(num >= 0) {
                return num;
            }
            else {
               return num * -1;
            }
        }
        public static float Abs(float num) {
            if(num >= 0) {
                return num;
            }
            else {
                return num * -1;
            }
        }
        public static int Min(int num1, int num2) {
            if ( num1 < num2) {
                return num1;
            }
            else if (num2 < num1) {
                return num2;
            }
            else {
                return 1;
            }
        }
        public static double Min(double num1, double num2) {
            if ( num1 < num2) {
                return num1;
            }
            else if (num2 < num1) {
                return num2;
            }
            else {
                return 1;
            }
        }
        public static float Min(float num1, float num2) {
            if ( num1 < num2) {
                return num1;
            }
            else if (num2 < num1) {
                return num2;
            }
            else {
                return 1;
            }
        }
        public static int Max(int num1, int num2) {
            if ( num1 > num2) {
                return num1;
            }
            else if (num2 > num1) {
                return num2;
            }
            else {
                return 1;
            }
        }
        public static double Max(double num1, double num2) {
            if ( num1 > num2) {
                return num1;
            }
            else if (num2 > num1) {
                return num2;
            }
            else {
                return 1;
            }
        }
        public static float Max(float num1, float num2) {
            if ( num1 > num2) {
                return num1;
            }
            else if (num2 > num1) {
                return num2;
            }
            else {
                return 1;
            }
        }

        public static int Add(int num1, int num2) {
            return num1 + num2;
        }
        public static double Add(double num1, double num2) {
            return num1 + num2;
        }
        public static float Add(float num1, float num2) {
            return num1 + num2;
        }
        public static int Subtract(int num1, int num2) {
            return num1 - num2;
        }
        public static double Subtract(double num1, double num2) {
            return num1 - num2;
        }
        public static float Subtract(float num1, float num2) {
            return num1 - num2;
        }
        public static int Divide(int num1, int num2) {
            return num1 / num2;
        }
        public static double Divide(double num1, double num2) {
            return num1 / num2;
        }
        public static float Divide(float num1, float num2) {
            return num1 / num2;
        }

        public static int Multiply(int num1, int num2) {
            return num1 * num2;
        }
        public static double Multiply(double num1, double num2) {
            return num1 * num2;
        }
        public static float Multiply(float num1, float num2) {
            return num1 * num2;
        }
        public static int Factorial(int num){
            int product = 1;
            for(int i = 1; i <= num; i++) {
                product = product * i;
            }
            return product;
        }
    }
}