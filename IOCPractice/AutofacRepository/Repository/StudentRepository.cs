using AutofacRepository.IRepository;

namespace AutofacRepository.Repository
{
    public class StudentRepository: IStudentRepository
    {
        public string GetName(long id)
        {
            return "张三";
        }
    }
}
