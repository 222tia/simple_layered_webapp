﻿namespace factorialService;

public class Factorial {

    public static int getFactorial(int n) {
        if(n == 0) {
            return 1;
        }
        else {
            return n * getFactorial(n-1); 
        }
    }

}
