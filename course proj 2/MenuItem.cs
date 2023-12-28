namespace course_proj_2;

internal class MenuItem
{
    public string Name { get; protected set; }
    public Action Action { get; protected set; }
    public List<MenuItem> Children { get; protected set; }

    public MenuItem(string name, Action action, IEnumerable<MenuItem> children = null)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            throw new ArgumentNullException(nameof(name));
        }

        Name = name;
        Action = action;
        Children = children != null ? children.ToList() : new List<MenuItem>();
        Children.ForEach(child => child.Name = "    " + child.Name);
    }
}
