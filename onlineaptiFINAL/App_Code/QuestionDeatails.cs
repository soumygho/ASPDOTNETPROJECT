using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for QuestionDeatails
/// </summary>
public class QuestionDeatails
{
    private string _questionText = null;
    private int _id = -1;
    private string _option1 = null;
    private string _option2 = null;
    private string _option3 = null;
    private string _option4 = null;
    private string _rightanswer = null;
    private string _ansgiven = null;
	public QuestionDeatails()
	{
        

	}
    public string QuestionText
    {
        get { return _questionText; }
        set { _questionText = value; }
    }
    public int Id
    {
        get { return _id; }
        set { _id = value; }
    }
    public string Option1
    {
        get { return _option1; }
        set { _option1 = value; }
    }
    public string Option2
    {
        get { return _option2; }
        set { _option2 = value; }
    }
    public string Option3
    {
        get { return _option3; }
        set { _option3 = value; }
    }
    public string Option4
    {
        get { return _option4; }
        set { _option4 = value; }
    }
    public string RightAnswer
    {
        get { return _rightanswer; }
        set { _rightanswer = value; }
    }
    public string GivenAnswer
    {
        get { return _ansgiven; }
        set { _ansgiven = value; }
    }
}
