namespace Instrukcije.models;

public class Instructions_Date
{
    public int Instruction_id { get; set; }

    public int Student_id { get; set; }

    public int ProfessorId { get; set; }

    public DateTime Subject_datetime { get; set; }

    public string Instructions_status { get; set; }
}