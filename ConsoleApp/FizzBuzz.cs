using System;
using System.Collections.Generic;
using System.Collections;


namespace FizzBuzz {
    public class FizzBuzzer {
        
        public string[] doTheFizzBuzz(string[] nums, Func<int, string>[] moreMaths = null) {
            List<string> result = new List<string>();
            var str = "";
            foreach (var num in nums) {
                var input = int.Parse(num);
                var match = false;

                if (input%3 == 0) {
                    str += "Fizz";
                    match = true;
                } 
                
                if (input%5 == 0) {
                    str += "Buzz";
                    match = true;
                } 

                if(moreMaths is not null){
                    foreach (var fxn in moreMaths){
                        if(fxn(Int32.Parse(num)) != num){
                            str += fxn(Int32.Parse(num));
                            match = true;
                        }
                    }
                    
                } 
                
                if(!match){
                    str += input.ToString();
                }
                
                result.Add(str);
                str = "";
            }
            
            Console.WriteLine("Messages processed: " + nums.Length);
            return result.ToArray();
        }
    }
}