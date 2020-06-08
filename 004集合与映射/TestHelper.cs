using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace _004集合与映射
{
    public class TestHelper
    {
        public static List<string> ReadFile(string filename)
        {
            // 打开文件
            FileStream fs = new FileStream(filename, FileMode.Open);

            // 读取文件信息
            StreamReader sr = new StreamReader(fs);

            // 读取数据放入动态数组
            List<string> words = new List<string>();

            while(!sr.EndOfStream)// 如果没有读取到文件末尾，就继续while读取
            {
                string contents = sr.ReadLine().Trim();

                // 寻找contents第一个字母的位置
                int start = FirstCharacterIndex(contents, 0);

                // 开始分词逻辑
                for (int i = start + 1; i <= contents.Length;)
                {
                    if (i == contents.Length || !Char.IsLetter(contents[i]))
                    {
                        string word = contents.Substring(start, i - start).ToLower();
                        words.Add(word);
                        start = FirstCharacterIndex(contents, i);
                        i = start + 1;
                    }
                    else
                    {
                        i++;
                    }
                }
            }
            fs.Close();
            sr.Close();

            return words;
        }

        // 寻找字符串s，从Satrt的位置开始的第一个字母的位置
        private static int FirstCharacterIndex(string s, int start)
        {
            for (int i = start; i < s.Length; i++)
            {
                if (char.IsLetter(s[i]))
                {
                    return i;
                }
            }
            return s.Length;
        }
    }
}
