namespace ToDoList.DTO
{
    public class TodoTask
    {
        public long Id { get; set; }
        public string? Name { get; set; }
        public bool IsComplete { get; set; }

        //Simplifica la sobreescritura del ToString() con un null coalesce
        public override string ToString() => Name ?? string.Empty;

        /*
                public override string ToString()
                {
                    return Text ?? string.Empty;

                    if(string.IsNullOrEmpty(Text)) return string.Empty;

                    if(Text == null){
                        return Text;
                    }
                    return string.Empty;

                    return Text == null ? string.Empty : Text;
                }   
        */
    }
}