using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutofacRepository.IRepository;

namespace AutofacService.Service
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _studentRepository;

        public StudentService(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }
        public string GetStuName(long id)
        {
            var stu = _studentRepository.GetName(id);
            return stu;
        }
    }
}
