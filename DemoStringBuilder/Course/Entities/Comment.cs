namespace Course.Entities
{
  public class Comment
    {
        public string Text { get; set; } = null!;

        public Comment()
        {
        }

        public Comment(string text)
        {
            Text = text;
        }
    }
}

    