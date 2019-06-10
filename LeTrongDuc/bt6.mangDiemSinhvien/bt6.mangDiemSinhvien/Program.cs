using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bt6.mangDiemSinhvien
{
    class StudentsMarks
    {
        string _name;
        string[] _ObjName = new string[2]{"Toan","Van"};
        int[] _marks = new int[2];
       
        static void Main(string[] args)
        {
            Console.WriteLine("So Sinh vien");
            int SvNum = Convert.ToInt32(Console.ReadLine());
            StudentsMarks[] stdMark = new StudentsMarks[SvNum];
            for (int i = 0; i < SvNum ; i++ )
            {
                stdMark[i] = new StudentsMarks();
                stdMark[i].Input();
            }
            Console.WriteLine("TenSV\t\tMonHoc\t\tDiemSV");
            for (int j = 0; j < SvNum; j++)
            {
                stdMark[j].Display();
            }
            Console.ReadLine();
        }
        void Input()
        {
            Console.WriteLine("Nhap ten SV :");
            _name = Convert.ToString(Console.ReadLine());
            for (int i = 0; i < 2; i++ ) 
            {
                _ObjName[i] = _ObjName[i];
                _marks[i] = i + 7;
            }
            Console.WriteLine("Nhap diem thanh cong :");
        }
        void Display()
        {
            Console.WriteLine();
            Console.Write(_name);
            for (int j = 0; j < _marks.Length; j++)
            {
                Console.Write("\t\t" + _ObjName[j]);
                Console.WriteLine("\t\t" + _marks[j]);
            }       
        }
    }
}
