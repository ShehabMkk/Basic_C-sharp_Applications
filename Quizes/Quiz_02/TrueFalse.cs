namespace Quiz_02;

public class TrueFalse : Question
{
    public TrueFalse(string header, string body, int mark, Answer[] answerList, Answer rightAnswer)
        : base(header, body, mark, answerList, rightAnswer) { }

    public override void DisplayQuestion()
    {
        Console.WriteLine($"{Header}\n{Body}\n1. True\n2. False");
    }
}