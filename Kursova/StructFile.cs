using System;
using System.IO;
using System.Runtime.InteropServices;

namespace ReadWriteBinaryFile
{
    public class StructFile
    {
        public static Test qq;
        public static int Qselected = 0;
        public static bool QisSelected = false;
        public static int Tselected = 0;
        public static bool TisSelected = false;
        public static int goS = 0;
        public static int curTest = 0;
        public static bool Tnew = true;
        public static gt T;
        public static ans[] Answers;
        public struct ans
        {
            public int AllM;
            public int Mark;
            public int selected;
        }
        public struct gt
        {
            public int Size;
            public Test[] allT;
        }
        public struct Test
        {
            public string Name;
            public int Size;
            public Question[] questions;
        }
        void Main()
        {
            qq.Size = 0;
            T.Size = 0;
            qq.questions = Array.Empty<Question>();
            T.allT = Array.Empty<Test>();
            Answers = Array.Empty<ans>();
        }
        public struct Question
        {
            public string qx;
            public int type;
            public bool Image;
            public string imgurl;
            public string q1;
            public string q2;
            public string q3;
            public string q4;
            public string r1;
            public string r2;
            public string r3;
            public string r4;
        }
        
    }
}
