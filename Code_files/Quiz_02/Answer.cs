namespace Quiz_02;

public class Answer
{
    public int AnswerId { get; set; }
    public string AnswerText { get; set; }

    public Answer(int Id, string Text)
    {
        AnswerId = Id;
        AnswerText = Text;
    }
}