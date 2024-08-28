namespace Quiz_02;

public abstract class Question : ICloneable, IComparable<Question>
{
    public string Header { get; set; }
    public string Body { get; set; }
    public int Mark { get; set; }
    public Answer[] AnswerList { get; set; }
    public Answer RightAnswer { get; set; }

    public Question(string header, string body, int mark, Answer[] answerList, Answer rightAnswer)
    {
        Header = header;
        Body = body;
        Mark = mark;
        AnswerList = answerList;
        RightAnswer = rightAnswer;
    }

    public abstract void DisplayQuestion();

    public object Clone()
    {
        return this.MemberwiseClone();
    }

    public int CompareTo(Question other)
    {
        return this.Mark.CompareTo(other.Mark);
    }

    public override string ToString()
    {
        return $"{Header} - {Body} ({Mark} Marks)";
    }
}