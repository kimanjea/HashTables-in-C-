using System;
using System.Net.Http.Headers;
using System.Reflection.Metadata;
using System.Threading.Tasks.Dataflow;
using HashTables_in_C_;

namespace hashes {
    class Program{
        static void Main(string [] args) { //hashtables are great for Constant time complexity key value look ups in large data sets

        // we initialize a hashtable name student that we will use as our dictionary to store names  
            Hashingtable StudentList = new Hashingtable("list");
            StudentList.Insert("azhar", 36081978); // we use the Insert function to add items to our hashtable
            StudentList.Insert("Ruth", 469943);
            StudentList.Insert("Tai", 737347);
            StudentList.Insert("najibs", 83849);
            StudentList.Insert("najib", 7938443);
            StudentList.Insert("Azhar", 483035);
            StudentList.Insert(")=",7359348);
            StudentList.Insert("letsd go", 73430);
            StudentList.Insert("Jerrohe hrfieir",034938);
            StudentList.Insert("h",8384309);
            StudentList.Insert("Kimanje!st", 7349739);
            
            Console.WriteLine();Console.WriteLine();Console.WriteLine();

            Console.WriteLine("We test out our Get function here to find name najibs");
            StudentList.get("najibs"); // we use the get to look for items in our hashtable
           
            Console.WriteLine();Console.WriteLine();Console.WriteLine();
         
            StudentList.PrintHashtable();  //we use the printhashtable to print our dictionary of items
        
            Console.WriteLine();Console.WriteLine();Console.WriteLine();
            Console.WriteLine("We test out our Remove function here to find name Azhar");
            StudentList.remove("azhar"); // we use the remove function to remove items 
            Console.WriteLine();
            Console.WriteLine("Final hashtable");
            StudentList.PrintHashtable(); // we print out our new hashtable her;.


            Console.WriteLine();Console.WriteLine();Console.WriteLine();
            Console.WriteLine("We test out our Remove function here to find name Jerrohe hrfieir");
            StudentList.remove("Jerrohe hrfieir");
            Console.WriteLine();
            Console.WriteLine("Final hashtable");
            StudentList.PrintHashtable();



        
        }


        class Hashingtable{ // we define our class hashingtable
           public LinkedListOps [] people = new LinkedListOps[10]; // we make an array that holds linkedlist objects
           public string? Name {get; set;} // we use this to get the name of our linkedlist
           public Hashingtable(string name){ // we set up a contructor but that is not necessary in this context, I did it just for formality
                Name= name;     
           }

           public int hashingfunction(string name){ // a good hashfunction is vital and it helps with creating indexes that fit our array size and returns an index for insertion
                int hashCode= name.Length % people.Length; // this algorithm calculates our index using modula to keep it within the array size
            return hashCode;
           }

           public bool Insert(string name , int phonenumber){ // Takes in a name to be added in the dictionary
           //we use this function to insert values into our hashingtable 

                int hashtableIndex= hashingfunction(name); //first we get our index using the hashfunction
                LinkedListOps newObject = new LinkedListOps(); // we create a new linked list object to use to place in our array

                if(people[hashtableIndex]==null){ // check for emptiness of index
                     people[hashtableIndex]=newObject; //assign the index with our object
                      people[hashtableIndex].InsertAtTop(name, phonenumber); // we insert name into our object
                     return true; //we return true after success

                }  else if (people[hashtableIndex]!=null) { //if not empty
                    //people[hashtableIndex]=newObject;
                     people[hashtableIndex].InsertAtTop(name, phonenumber); // we automatically add to the top of our linklist object at that index
                    return true; //we return true for success

                } else {
                    Console.WriteLine("failed to add linkedlist object");
                    return false; // we ever fail but i highly doubt
                }
               
           }

           public bool remove(string name){ // we use the remove function to remove from hashtabe
                int hastableIndex = hashingfunction(name); //again we start by calling our hashfunction

                if(people[hastableIndex]==null){ //if the location is null then it is automatically not in our dictionary
                    Console.WriteLine("Name is not in list");
                    return false; //we return false immediately
                } else { // if not then
                    Console.Write("Removed the name {");
                    people[hastableIndex].Delete(name);
                    Console.WriteLine( "} from hashtable");
                    return true;
                }
           }
           
           public bool get(string name){ // we use the get function to do a key value look up of O(1)
                int hastableIndex = hashingfunction(name); //again we start by calling our hashfunction

                if(people[hastableIndex]==null){ //if the location is null then it is automatically not in our dictionary
                    Console.WriteLine("Name is not in list");
                    return false; //we return false immediately
                } else { // if not then
                    Console.Write("Found the name {");
                    people[hastableIndex].GetObject(name);
                    Console.WriteLine( "} in hashtable");
                    return true;
                }
           }

           public void PrintHashtable(){ //we use this function to print out our entire hashtable
            Console.WriteLine("***  Our hashtable indexes to value  ****");
                for(int i =0; i<people.Length; i++){
                    
                    if(people[i]!=null){
                        Console.Write($"{i} =>  "); people[i].PrintLinkedList();
                    } else {
                        Console.WriteLine($"{i} => Null");
                    }
                  
                }
           }

        }
    }
}