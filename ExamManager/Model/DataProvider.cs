using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ExamManager.Model
{
    public class DataProvider
    {
        
        public ExamManagerEntities DB { get; set; }

        private static DataProvider _ins;
        public static DataProvider Ins
        {
            get
            {
                if (_ins == null)
                {
                    _ins = new DataProvider();
                }
                return _ins;
            }
            set
            {
                _ins = value;
            }

        }

        private DataProvider(){
            DB = new ExamManagerEntities();
        }
    }
}
