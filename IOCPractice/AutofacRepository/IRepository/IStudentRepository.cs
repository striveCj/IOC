using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutofacRepository.IRepository
{
   public interface IStudentRepository
   {
       string GetName(long id);
   }
}
