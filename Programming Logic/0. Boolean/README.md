## General Comparator
// Greater and Less
Console.WriteLine((1<2)); // Returns True 
Console.WriteLine((1>5)); // Returns False 

//Equal
Console.WriteLine((3==2)); // Returns False
Console.WriteLine((1==1)); // Returns True 

// Not Equal 
Console.WriteLine((1!=2)); // Returns True 



# Logical And 
### BOTH statemenst must be true to return true
Console.WriteLine((1>2) && (2>3)); // Returns False
Console.WriteLine((1>2) && (5>3)); // Returns False 
Console.WriteLine((2 > 1) && (5 > 3)); // Returns True 


# Logical OR
### Atlease one statemenst must be true to return true

     Console.WriteLine((1 > 2) || (2 > 3)); // False
     Console.WriteLine((1 > 2) || (5 > 3)); // True
     Console.WriteLine((2 > 1) || (5 > 3)); // True
