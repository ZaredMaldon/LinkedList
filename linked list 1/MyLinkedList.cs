using linked_list_1;
public class MyLinkedList
{
    private ListNode? head;

    //1. Add a node at the beginning
    public void AddFirst(int val)
    {
        ListNode newNode = new ListNode(val,head);
        head = newNode;
    }

    //2. Add a node at the end
    public void AddLast(int val)
    {
        ListNode newNode = new ListNode(val);

        //if the list is empty, the new node is the head
        if(head == null)
        {
            AddFirst(val);
        }

        ListNode? current = head;
        //go through the last node
        while(current?.next != null)
        {
            current = current.next;
        }
        //when the last Node is null we add the node at the last 
        current?.next = newNode;
    }

    //3. Add a node at a specific position
    public void AddAtPosition(int val, int position)
    {
        //Whereas is the first position we only use the method we prepared before
        if(position == 0)
        {
            AddFirst(val);
            return;
        }

        //Initialize the current node as the head
        ListNode? current = head;

        //Traverse the list to find the node before the desired position
        for(int i = 0; i < position - 1 && current != null; i++)
        {
            current = current.next;
        }

        //If the current node is null, the position is out of range
        if(current == null)
        {
            throw new ArgumentOutOfRangeException(nameof(position), "Position is out of range");
        }
        //Create the new node and insert it after the current node
        ListNode newNode = new ListNode(val, current.next);
        current.next = newNode;
    }

    //3. Delete the first time a val is showed
    public void Remove(int val)
    {
        //If the list is empty there are nothing to delete
        if(head == null)
        return;

        //Special case: If the node is the head
        if(head.val == val)
        {
            head = head.next;
            return;
        }

        ListNode current = head;
        //Looking up the previous node to the current one
        while(current.next != null && current.next.val != val)
        {
            current = current.next;
        }

        //If is found it (current.next is not null)
        if(current.next != null)
        {
            //The next node is skipped linking it with the next one
            current.next = current.next.next;
        }
    }

    //Edit a node
    public void Edit(int newVal, int val)
    {
        if(head == null)
        {
            AddFirst(newVal);
            return;
        }

        if(head.val == val)
        {
            head.val = newVal;
            return;
        }

        ListNode? current = head;

        while(current.val != val && current.next != null)
        {
            current = current.next;
        }

        if(current.val == val)
        {
            current.val = newVal;
        }
    }

    //4.Print and visualize
    public void PrintList()
    {
        ListNode? current = head;
        while (current != null)
        {
            Console.Write(current.val + "->");
            //it's used to go to the next node
            current = current.next;
        }
        Console.WriteLine();
        Console.WriteLine("Please press Enter to continue...");
        Console.ReadLine();
        Console.Clear();
    }

}