using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Lab8_2_
{
    public class ResourseDepartment
    {
        private ReaderWriter readerWriter;
        public ResourseDepartment()
        {
            readerWriter = new ReaderWriter();
        }   
        public Employee parseInfo(string strInfo)
        {
            string[] words = new string[6];
            words = strInfo.Split(',');
            Employee employee = new Employee(int.Parse(words[0]), words[1], words[2], float.Parse(words[3]), DateTime.Parse(words[4]));
            return employee;
        }
        public List<Employee> createList()
        {
            List<Employee> e = new List<Employee>();
            List<string> strs = readerWriter.readDataFromFile();
            int strCount = 0;
            foreach (string s in strs)
            {
                e.Add(parseInfo(s));
                strCount++;
            }
            return e;
        }
    }
}
