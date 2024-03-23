namespace Instrukcije.models;

public class ProfessorRegistration
{
    public int ProfessorId { get; set; }
    public string Email_professor { get; set; }

    public string Name_professor { get; set; }

    public string Surname_professor { get; set; }

    public string Password_professor { get; set; }

    public string ProfilePictureUrl_professor { get; set; }

    public int InstructionsCount { get; set; } 
    public List<string> Subjects { get; set; } 
}