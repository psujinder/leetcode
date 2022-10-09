
public class LinkedListNode {

    private int value;
    private LinkedListNode next;

    public LinkedListNode(int value, LinkedListNode next){
        this.value = value;
        this.next = next;
    }

    public LinkedListNode Next(){
        return next;
    }

    public void SetNext(LinkedListNode node){
        this.next = node;
    }
}

public class LinkedList{

    private LinkedListNode head;

    public LinkedList(LinkedListNode head){
        this.head = head;
    }

    public void Add(LinkedList node){
        LinkedListNode curr = head;

        while(curr.Next!= null){
            curr = node.Next;
        }

        curr.Next = node;
    }

    
}