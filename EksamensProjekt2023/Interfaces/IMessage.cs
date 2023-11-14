using EksamensProjekt2023.Models;

namespace EksamensProjekt2023.Interfaces;
/// <summary>
/// Date Created: 2023-11-14 <br />
/// Author: Gabriel H. Kierkegaard
/// </summary>
public interface IMessage
{
    public void SendMessage(Message message) { }
    public void RecievedMessage(Message message) { }
}
