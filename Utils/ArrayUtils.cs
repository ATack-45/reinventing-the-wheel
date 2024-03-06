namespace MyUtilities {

    public static class ArrayUtils {
        /// <summary>
        /// Averages the numbers in a given integer array
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static int Average(int[] arr) {
            int sum = 0;
            int length = 0;
            int avg;
            foreach (int num in arr)  {
                sum += num;
                length++;
            }
            avg = sum/length;
            return avg;
        }


        /// <summary>
        /// Averages numbers in a given double array
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static double Average(double[] arr) {
            double sum = 0;
            double length = 0;
            double avg;
            foreach (double num in arr)  {
                sum += num;
                length++;
            }
            avg = sum/length;
            return avg;
        }

        /// <summary>
        /// Finds the largest number in a given integer array
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static int Max(int[] arr) {
            int max = arr[0];
            foreach (int num in arr)  {
                if (num > max ) {
                    max = num;
                }
            }
            return max;
        }

        /// <summary>
        /// finds the largest number in a given double array
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static double Max(double[] arr) {
            double max = arr[0];
            foreach (double num in arr)  {
                if (num > max ) {
                    max = num;
                }
            }
            return max;
        }

        /// <summary>
        /// finds the smallest number in a given integer array
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static int Min(int[] arr) {
            int min = arr[0];
            foreach (int num in arr)  {
                if (num < min ) {
                    min = num;
                }
            }
            return min;
        }

        /// <summary>
        /// finds the smallest number in a given double array
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static double Min(double[] arr) {
            double min = arr[0];
            foreach (double num in arr)  {
                if (num < min ) {
                    min = num;
                }
            }
            return min;
        }

        /// <summary>
        /// Sorts a given integer array from smallest to largest using the selection sort method
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static int[] SortAscending(int[] arr) { // using selection sort    
            int minIndex;
            int minValue; 
            for (int i = 0; i <arr.Length -1; i++) {
                    minIndex = i; 
                    minValue = arr[i]; 
                    for (int j = i + 1; j < arr.Length; j++){
                        if (arr[j] < minValue){ 
                            minValue = arr[j]; 
                            minIndex = j; 
                        } 
                    }
                    int temp = arr[minIndex]; 
                    arr[minIndex] = arr[i]; 
                    arr[i] = temp; 
            }
            return arr; 
        }

         /// <summary>
        /// Sorts a given double array from smallest to largest using the selection sort method
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static double[] SortAscending(double[] arr) { // using selection sort
            int minIndex;
            double minValue; 
            for (int i = 0; i < Length(arr) -1; i++) {
                    minIndex = i; 
                    minValue = arr[i]; 
                    for (int j = i + 1; j < arr.Length; j++){
                        if (arr[j] < minValue){ 
                            minValue = arr[j]; 
                            minIndex = j; 
                        } 
                    }
                    double temp = arr[minIndex]; 
                    arr[minIndex] = arr[i]; 
                    arr[i] = temp; 
            }
            return arr; 
        }

         /// <summary>
        /// Sorts a given integer array from largest to smallest using the selection sort method
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static int[] SortDecending(int[] arr) { // using selection sort    
            int minIndex;
            int minValue; 
            for (int i = 0; i < Length(arr)  -1; i++) {
                    minIndex = i; 
                    minValue = arr[i]; 
                    for (int j = i + 1; j < arr.Length; j++){
                        if (arr[j] > minValue){ 
                            minValue = arr[j]; 
                            minIndex = j; 
                        } 
                    }
                    int temp = arr[minIndex]; 
                    arr[minIndex] = arr[i]; 
                    arr[i] = temp; 
            }
            return arr; 
        }

         /// <summary>
        /// Sorts a given double array from largest to smallest using the selection sort method
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static double[] SortDecending(double[] arr) { // using selection sort
            int minIndex;
            double minValue; 
            for (int i = 0; i <arr.Length -1; i++) {
                    minIndex = i; 
                    minValue = arr[i]; 
                    for (int j = i + 1; j < arr.Length; j++){
                        if (arr[j] > minValue){ 
                            minValue = arr[j]; 
                            minIndex = j; 
                        } 
                    }
                    double temp = arr[minIndex]; 
                    arr[minIndex] = arr[i]; 
                    arr[i] = temp; 
            }
            return arr; 
        }

         /// <summary>
        /// adds together all integers in a given array and returns the sum
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static int Sum(int[] arr) {
            int sum = 0;
            foreach (int num in arr)  {
            sum += num;
        }
            return sum;
        }

        /// <summary>
        /// adds together all the numbers in a double array and returns the sum
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static double Sum(double[] arr) {
            double sum = 0;
            foreach (double num in arr)  {
            sum += num;
        }
            return sum;
        }

        /// <summary>
        /// multiplies together all the numbers in a int array and returns the product
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static int Product(int[] arr) {
            int product = 1;
            foreach(int num in arr){
                product = product * num;
            }
            return product;
        }

         /// <summary>
        /// multiplies together all the numbers in a int array and returns the product
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static double Product(double[] arr) {
            double product = 1;
            foreach(double num in arr){
                product = product * num;
            }
            return product;
        }
       
       /// <summary>
       /// finds the length of a given integer array
       /// </summary>
       /// <param name="arr"></param>
       /// <returns></returns>
        public static int Length(int[] arr) {
            int length = 0;
            foreach (int num in arr)  {
                length++;
            }
            return length;
        }

        /// <summary>
        ///  finds the length of a given double array
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static int Length(double[] arr) {
            int length = 0;
            foreach (int num in arr)  {
                length++;
            }
            return length;
        }

        /// <summary>
        /// reverses a given integer array
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static int[] Reverse(int[] arr) {
            int[] outputArray = new int[Length(arr)];
            for (int i = 0; i < Length(arr); i++) {
                outputArray[Length(arr) -1 - i] = arr[i]; 
            }
            return outputArray;
        }

        /// <summary>
        /// reverses a given double array
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static double[] Reverse(double[] arr) {
            double[] outputArray = new double[Length(arr)];
            for (int i = 0; i < Length(arr); i++) {
                outputArray[Length(arr) - 1 - i] = arr[i]; 
            }
            return outputArray;
        }

        /// <summary>
        /// Clears and set all values in a int array to 0
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static int[] Clear(int[] arr) {
            for(int i = 0; i < Length(arr) - 1; i++) {
                arr[i] = 0;
            }
            return arr;
        }


        /// <summary>
        /// Clears a range of the given double array and sets all values to 0
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static double[] Clear(double[] arr, int start, int end) {
            for(int i = start; i <= end; i++) {
                arr[i] = 0;
            }
            return arr;
        }

        /// <summary>
        /// finds the index of a given number in the given array 
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="num"></param>
        /// <returns></returns>
        public static int IndexOf(int[] arr, int num) {
            int left = 0;
            int right = Length(arr) -1;

            while (left <= right){
                int mid = (left + right) / 2;
                
                if (num > arr[mid]) {
                    left = mid +1;
                }
                else if (num < arr[mid]) {
                    right = mid - 1;
                }
                else {
                    return mid;
                }
                
            }
            return -1;
        }

        /// <summary>
        /// finds the index of a given number in the given double array 
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="num"></param>
        /// <returns></returns>
        public static int IndexOf(double[] arr, double num) {
            int left = 0;
            int right = Length(arr) -1 ;

            while (left <= right){
                int mid = (left + right) / 2;
                if (num == arr[mid] ) {
                    return mid;
                }
                else if (arr[mid] < num) {
                    left = mid + 1;
                }
                else {
                    right = mid - 1;
                }
            }
            return -1;
            
        }
    }
}