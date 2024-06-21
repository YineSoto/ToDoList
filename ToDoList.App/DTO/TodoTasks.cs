namespace ToDoList.App.DTO
{
    public class TodoTask
    {
        public string? Text { get; init; }

        public bool Completed { get; set; } = false;

        //Simplifica la sobreescritura del ToString() con un null coalesce
        public override string ToString() => Text ?? string.Empty;

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