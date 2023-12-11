namespace MyUtilities {

    public static class ArrayUtils {
        
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
        public static int Max(int[] arr) {
            int max = arr[0];
            foreach (int num in arr)  {
                if (num > max ) {
                    max = num;
                }
            }
            return max;
        }
        public static double Max(double[] arr) {
            double max = arr[0];
            foreach (double num in arr)  {
                if (num > max ) {
                    max = num;
                }
            }
            return max;
        }
        public static int Min(int[] arr) {
            int min = arr[0];
            foreach (int num in arr)  {
                if (num < min ) {
                    min = num;
                }
            }
            return min;
        }
        public static double Min(double[] arr) {
            double min = arr[0];
            foreach (double num in arr)  {
                if (num < min ) {
                    min = num;
                }
            }
            return min;
        }
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
        public static int Sum(int[] arr) {
            int sum = 0;
            foreach (int num in arr)  {
            sum += num;
        }
            return sum;
        }
        public static double Sum(double[] arr) {
            double sum = 0;
            foreach (double num in arr)  {
            sum += num;
        }
            return sum;
        }
        public static int Product(int[] arr) {
            int product = 1;
            foreach(int num in arr){
                product = product * num;
            }
            return product;
        }
        public static double Product(double[] arr) {
            double product = 1;
            foreach(double num in arr){
                product = product * num;
            }
            return product;
        }
        public static int Length(int[] arr) {
            int length = 0;
            foreach (int num in arr)  {
                length++;
            }
            return length;
        }
        public static int Length(double[] arr) {
            int length = 0;
            foreach (int num in arr)  {
                length++;
            }
            return length;
        }
        public static int[] Reverse(int[] arr) {
            int[] outputArray = new int[Length(arr)];
            for (int i = 0; i < Length(arr); i++) {
                outputArray[Length(arr) -1 - i] = arr[i]; 
            }
            return outputArray;
        }
        public static double[] Reverse(double[] arr) {
            double[] outputArray = new double[Length(arr)];
            for (int i = 0; i < Length(arr); i++) {
                outputArray[Length(arr) - 1 - i] = arr[i]; 
            }
            return outputArray;
        }
        public static int[] Clear(int[] arr) {
            for(int i = 0; i < Length(arr) - 1; i++) {
                arr[i] = 0;
            }
            return arr;
        }
        public static double[] Clear(double[] arr, int start, int end) {
            for(int i = start; i <= end; i++) {
                arr[i] = 0;
            }
            return arr;
        }
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