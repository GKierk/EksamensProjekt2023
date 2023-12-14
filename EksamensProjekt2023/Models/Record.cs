using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EksamensProjekt2023.Models;

/// <summary>
/// Date Created: 2023-12-11 <br />
/// Author: Gabriel H. Kierkegaard <br />
/// <br />
/// 
/// </summary>
public class Record
{
    public Record()
    {
        RecordID = Guid.NewGuid().ToString();
        Date = DateTime.Now;
        AmountGiven = 0;
        AmountSold = 0;
        MobilePayAmount = 0;
    }

    [Key]
    public string RecordID { get; set; }
    public DateTime Date { get; set; }
    [ForeignKey("Id")]
    public virtual UserProfile UserProfile { get; set; }
    public int AmountGiven { get; set; }
    public int AmountSold { get; set; }
    public int MobilePayAmount { get; set; }
}
