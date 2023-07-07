namespace FirstAspMvcApplication.Models
{
    public class StudentBusinessLayer
    {
        public Student GetStudentDetails(int StudentId)
        {
            Student student = new Student()
            {
                Id = StudentId,
                Name = "Jane",
                Gender = "Female",
                Address = "NYC",
                City = "NYC"
            };

            return student;
        }
    }
}
