public class Node
{
    public int value;
    public Node _next;

    public Node(int v)
    {
        value = v;
        _next = null;
    }
}

public class MyLinkedList
{
    private Node head;

    public int GetCount()
    {
        int count = 0;
        Node current = head;
        while(current != null)
        {
            count++;
            current = current._next;
        }
        return count;
    }

    public int GetSum()
    {
        int sum = 0;
        Node current = head;
        while(current != null)
        {
            sum += current.value;
            current = current._next;
        }
        return sum;
    }

    public void Prepend(int v)
    {
        Node newNode = new Node(v);

        newNode._next = head;
        head = newNode;
    }

    public void Append(int v)
    {
        Node newNode = new Node(v);

        if(head == null) //if the list is empty just add newNode
        {
            head = newNode;
            return;
        }

        Node tail = head;

        while(tail._next != null)
        {
            tail = tail._next;
        }
        tail._next = newNode;
    }

    public bool Delete(int v)
    {
        if(head == null) return false;

        if(head.value == v) // when first one is desired value
        {
            head = head._next;
            return true;
        }

        Node current = head;

        while(current._next != null)
        {
            if(current._next.value == v)
            {
                current._next = current._next._next;
                return true;
            }
            current = current._next;
        }
        return false;
    }

    public void Insert(int v, int i)
    {
        int count = 1;
        Node current = head;
        Node newNode = new Node(v);

        while(count < i)
        {
            current = current._next;
            count++;
        }

        current._next = newNode;
        
    }
}