# CustomList
As a developer, I want to write documentation in a .txt file that describes the details and functionality of my – operator overload. 
I want to include details such as “syntax”, “parameters”, “return type”, and an example of it being used, with the output.
      
 public static CustomList<T> operator -(CustomList<T> list1, CustomList<T> list2)
        {
            CustomList<T> placeholder = list1;
            for (int i = 0; i < list2.Count; i++)
            {
                placeholder.Remove(list2[i]);
            }
            return placeholder;
        }


The Parameters for this method is:
CustomList<T> list1
CustomList<T> list2
The return Type of this method is:
CustomList<T>

In order for the function to be used you must pass in two lists. The two list are used as parameters.
CustomList<T>placeHolder is used as a temporary list that holds list1 and all its values.
The for loop using i as a temporary variable (i) is used to loop over the indexes of list2 while i is less than the given Count of list2.
The.Remove method is then used with a parameter of list2 index(index being given from the for loop variable i) to remove the value if it is also a value that exists in list1(aka placeHolder).
If the vaule of list2's index does not exsits as a value in list1 as well, the .Remove method is not use since there is no value to remove.
The temporary list named placeHolder is then returned out of the method to be used after the method is called.

Example:
CustomList<int> list1= new CustomList<int>(){1,2,3,4,5,6};
CustomList<int> list2= new CustomList<int>(){6,4,2,9,7,8};
CustomList<int> subtractedLists;

subtractedList=list1-list2;

Since list1 has values of 1,2,3,4,5,6 and list2 shares values of 2,4,6.
Values 2,4,6, will be removed and the new list named subtractedList with now hold values of 1,3,5


