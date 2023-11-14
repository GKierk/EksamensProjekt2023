namespace EksamensProjekt2023.Models;
/// <summary>
/// Date Created: 2023-11-14 <br />
/// Author: Gabriel H. Kierkegaard
/// </summary>
public class Message
{
    private DateTime date;
    private string sender;
    private string reciever;
    private readonly int messageSize;
    private bool isRead;

    public Message(string sender, string reciever)
    {
        date = DateTime.Now;
        this.sender = sender;
        this.reciever = reciever;
        messageSize = 255;
        isRead = false;
    }

    public DateTime Date => date;

    public string Sender
    {
        get { return sender; }
        set { sender = value; }
    }

    public string Reciever
    {
        get { return reciever; }
        set { reciever = value; }
    }

    public int MessageSize => messageSize;

    public bool IsRead
    {
        get { return isRead; }
        set { isRead = value; }
    }
}
