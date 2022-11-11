// See https://aka.ms/new-console-template for more information
internal class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public Student(int id, string name, string description)
    {
        this.Id = id;
        this.Name = name;
        this.Description = description;
    }
    public override string ToString()
    {
        return $"Студент {this.Name} ,Возраст  {this.Id}";
    }
    public override int GetHashCode()
    {
        return this.ToString().GetHashCode();
    }
}