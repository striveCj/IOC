using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoFacModel
{
    public class StudentEntity
    {
        /// <summary>
        /// 唯一标识
        /// </summary>
        public long Id { get; set; }
        /// <summary>
        /// 姓名
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 成绩
        /// </summary>
        public int Grade { get; set; }
    }
}
