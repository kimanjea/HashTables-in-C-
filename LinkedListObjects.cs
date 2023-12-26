using System.Runtime.CompilerServices;

namespace HashTables_in_C_;
class Node {
        public string? data { get; set; } // this is how we get out values 
        public Node? Next {get; set;} // this is how we are able to use the reference property

        public string? playerdescription {get; set;} // add all these to function
        public int? playerposition {get; set;} // add all these to functions
        public void Display(){ // we use this to print the data in our nodes
            Console.WriteLine(data);
        }

    }
class LinkedListOps{ // carries out linkedlist operations

        public Node? head; //we use this to access the head of the list

        public void InsertAtTop(string data){ // inserting from the top
            Node? current = head; //we use current so that we dont update the head
            Node newNode = new Node(); //we cretae a new node to hold host our new data
            newNode.data=data; 

            if(current!=null) {
                newNode.Next = head;// this means that new node references head, then head can be assigned to new node
                head = newNode;//
            } else {
                newNode.Next = head; 
                head = newNode;    
            }
        }

        public void DeleteAtTop() {//deleting at the top
           Node? current = head;
           Node? temp = new Node(); //we create temp to hold our data when deleting from head

           temp = head?.Next;
           head= temp;
                    
        }

        public void InsertAtMiddle(string data, string newdata){ //inserting frm the middle of linkedlist
            Node? current = head;
            Node? prev = new Node();//prev helps us access previous node 
            Node? newNode = new Node();
            newNode.data = newdata;

            if(current?.data != data) {
                prev = current; //we are able to access previous node by assigning prev to current
                current = current?.Next;
            }

            newNode.Next = current;
            #pragma warning disable CS8602
            prev.Next = newNode;
            

        }

        public void DeleteFromMiddle(string data){ // deleting from the middle of linkedList
            Node? current = head;
            Node prev = new Node();

            while(current?.data != data){
                #pragma warning disable CS8600
                prev =  current;
                current = current?.Next;
            }

#pragma warning disable CS8602 // Dereference of a possibly null reference.
        prev.Next = current?.Next;
#pragma warning restore CS8602 // Dereference of a possibly null reference.

    }

        public void InsertATBottom(string data) { //inserting from the bottom linkedlist 
            Node? current = head;
            Node newNode = new Node();
            newNode.data = data;
            Node prev = new Node();


            while (current!= null){
                prev = current;
                current = current.Next;
            }

            prev.Next = newNode; 
        }

        public void DeleteAtBottom (){ //this method deletes from the bottom of the list
            Node? current = head;
            Node prev = new Node();
            
            while(current?.Next!= null){
                prev = current;
                current= current.Next;
            }
            prev.Next = null;
        }

        public void Delete(string data){ // delete from anywhere 
            Node? current = head;
            Node? prev = new Node();

            if(current?.data==data){
                Node? temp = new Node(); //we create temp to hold our data when deleting from head
                temp = head?.Next;
                head= temp;

            } else {
                while(current?.data != data){
                #pragma warning disable CS8600
                prev =  current;
                current = current?.Next;
                 }
                #pragma warning disable CS8602 
                prev.Next = current?.Next;
            }
        }

        public void GetObject(string name){
            Node? current = head;
            if(current!=null){
                while(current?.data!= name){
                    current = current?.Next;
                }
                Console.Write(current.data);
            } else {
                Console.WriteLine($"{name} is not in the linkedlist in hashtable");
            }
            
        }
        
        public void PrintLinkedList(){// we use this method to print out our new list whenever we perform on it
            Node? current = head;

            while(current!= null) {
                current.Display();
                current = current.Next;
            }
            
        }
}