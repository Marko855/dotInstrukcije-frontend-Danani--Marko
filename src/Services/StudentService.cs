
namespace Instrukcije.Services
{
    public interface IStudentService
    {
        bool RegisterStudent(StudentRegistration model);
        LoginResult LoginStudent(string email, string password);
        ServiceResult<Student> GetStudentByEmail(string email);
        ServiceResult<List<Student>> GetAllStudents();
    }

    public class StudentService : IStudentService
    {
        private List<StudentRegistration> _students;

        public StudentService()
        {
            _students = new List<StudentRegistration>();
        }

        public bool RegisterStudent(StudentRegistration model)
        {
            try
            {
                if (_students.Any(s => s.Email_student == model.Email_student))
                {
                    return false; 
                }

                var student = new StudentRegistration
                {
                    Student_id = model.Student_id,
                    Email_student = model.Email_student,
                    Name_student = model.Name_student,
                    Surname_student = model.Surname_student,
                    Password_student = model.Password_student,
                    ProfilePictureUrl_student = model.ProfilePictureUrl_student
                };

                _students.Add(student);

                return true; 
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while registering student: {ex.Message}");
                return false;
            }
        }
    }
}
