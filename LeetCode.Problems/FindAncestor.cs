namespace LeetCode.Problems;

public class Person
{
    public string Name { get; set; }
    public List<Person> Children { get; set; }
    public Person Parent { get; set; }

    // constructor
    public Person(string name)
    {
        Name = name;
        Children = new List<Person>();
        Parent = null;
    }
}

public static class FindRelation{
    public static Person FindAncestorBFS(Person root, string name) {
    Queue<Person> queue = new Queue<Person>();
    queue.Enqueue(root);
    while (queue.Count > 0) {
        Person current = queue.Dequeue();
        if (current.Name == name) {
            return current;
        }
        foreach (Person child in current.Children) {
            queue.Enqueue(child);
        }
    }
    return null;
}

}